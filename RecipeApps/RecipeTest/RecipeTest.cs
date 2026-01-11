using CPUFramework;
using RecipeSystem;
using System.Configuration;
using System.Data;

namespace RecipeTest
{
    public class Tests
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        string unittestconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;
        string liveconn = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(liveconn, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            //DBManager.SetConnectionString(unittestconnstring, true);
            dt = SQLUtility.GetDataTable(sql);
            //DBManager.SetConnectionString(connstring, true);
            return dt;
        }
        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            //DBManager.SetConnectionString(unittestconnstring, true);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            //DBManager.SetConnectionString(connstring, true);
            return n;
        }


        [Test]
        [TestCase(111)]
        [TestCase(1111)]
        public void InsertRecipe(int calories)
        {

            int userid = GetFirstColumnFirstRowValue("select top 1 userid from users order by userid");
            int cuisineid = GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(userid > 0, "No Users in DB, cant run test");
            Assume.That(cuisineid > 0, "No Cuisines in DB, cant run test");

            string recipename = "Test" + " - " + DateTime.Now.Ticks;
            DateTime date = DateTime.Now;

            TestContext.WriteLine("Insert recipe with recipename = " + recipename);

            bizRecipe recipe = new();

            recipe.CuisineId = cuisineid;
            recipe.UserId = userid;
            recipe.RecipeName = recipename;
            recipe.Calories = calories;
            recipe.DatePublished = date.AddDays(30);
            recipe.DateArchived = date.AddDays(90);

            recipe.Save();

            int newid = GetFirstColumnFirstRowValue("Select recipeid from recipe where recipename = '" + recipename + "'");
            int recipeid = recipe.RecipeId;

            Assert.IsTrue(newid > 0, "Recipe with name  = " + recipename + "is found in DB");
            TestContext.WriteLine("Recipe with " + recipename + " was found in DB with pk value = " + newid);
        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = GetDataTable("select top 1 RecipeId from recipe r  where RecipeName like '%test%' and RecipeStatus = 'Draft'");
            int recipeid = 0;

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
            }
            Assume.That(recipeid > 0, "No Test-Recipe in DB, cant run test");

            TestContext.WriteLine("Existing test recipe, with id = " + recipeid);
            TestContext.WriteLine("Ensure app can delete recipe with id " + recipeid);

            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
            DataTable dtafterdelete = GetDataTable("select * from recipe where recipeid  = " + recipeid);

            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "Record with recipeid " + recipeid + "does exist in the DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + " does exist in the DB");

        }
        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, cant test");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure app loads recipe with id " + recipeid);
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            int loadedrecipeid = recipe.RecipeId;
            string recipename = recipe.RecipeName;
            Assert.IsTrue(loadedrecipeid == recipeid && recipename != "", recipe.RecipeId + " <>" + recipeid + ", RecipeName = " + recipe.RecipeName);
            TestContext.WriteLine("Loaded recipe (" + loadedrecipeid + ") RecipeName = " + recipe.RecipeName);
        }
        [Test]
        [TestCase(false)]
        [TestCase(true)]
        public void GetListOfRecipes(bool includeblank)
        {
            int recipecount = GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            if (includeblank) { recipecount = recipecount + 1; }
            Assume.That(recipecount > 0, "No recipes in DB, cant test");
            TestContext.WriteLine("Number of recipes in DB  = " + recipecount);
            bizRecipe recipe = new();
            var lst = recipe.GetList(includeblank);
            Assert.IsTrue(lst.Count == recipecount, $"Number of rows returned by app = {lst.Count}, number of rows in the database =  {recipecount}");
            TestContext.WriteLine("Number of rows in Recipe returned by app  =" + lst.Count);
        }
        [Test]
        public void SearchRecipes()
        {
            string searchcriteria = "e";
            int recipecount = GetFirstColumnFirstRowValue($"select total = count(*) from recipe where recipename like '%{searchcriteria}%'");
            TestContext.WriteLine($"Num of recipe results in DB with search criteria '{searchcriteria}' = {recipecount}.");
            bizRecipe recipe = new();
            List<bizRecipe> lst = recipe.Search(searchcriteria);
            Assert.IsTrue(lst.Count == recipecount, $"Number of rows returned by search = {lst.Count} | Number or rows returned by search in database = {recipecount}.");
            TestContext.WriteLine($"Number of rows in search results returned by app = {lst.Count}.");
        }
        [Test]
        public void GetListOfCuisines()
        {
            int cuisinecount = GetFirstColumnFirstRowValue("select total = count(*) from cuisine");
            Assume.That(cuisinecount > 0, "No Cuisines in DB, cant test");
            TestContext.WriteLine("Number of cuisines in DB = " + cuisinecount);
            TestContext.WriteLine("Ensure that the num of rows returned by app matches " + cuisinecount);
            DataTable dt = DataHandling.GetDataList("Cuisine");
            Assert.That(dt.Rows.Count == cuisinecount, "num of rows returned by app :" + dt.Rows.Count + " <>" + cuisinecount);
            TestContext.WriteLine("Number of rows in Cuisine returned by app = " + dt.Rows.Count);
        }
        [Test]
        public void GetListOfUsers()
        {

            int usercount = GetFirstColumnFirstRowValue("select total = count(*) from users");
            Assume.That(usercount > 0, "No users in DB, cant test");
            TestContext.WriteLine("Number of users in DB  = " + usercount);
            TestContext.WriteLine("Ensure num of rows returned by app matches " + usercount);
            DataTable dt = DataHandling.GetDataList("User");
            Assert.IsTrue(dt.Rows.Count == usercount, "num of rows returned by app (" + dt.Rows.Count + ") <> " + usercount);
            TestContext.WriteLine("Number of rows in Users returned by app = " + dt.Rows.Count);
        }
        [Test]
        [TestCase (false)]
        [TestCase(true)]
        public void GetListOfIngredients(bool includeblank)
        {
            int ingredientcount = GetFirstColumnFirstRowValue("select total = count(*) from ingredient");
            if (includeblank) { ingredientcount = ingredientcount + 1; }
            Assume.That(ingredientcount > 0, "No ingredients in DB, cant test");
            TestContext.WriteLine($"Number of ingredients in DB  = {ingredientcount}");
            bizIngredient ingredient = new();
            var lst = ingredient.GetList(includeblank);
            Assert.IsTrue(lst.Count == ingredientcount, $"Number of rows returned by app = {lst.Count}, number of rows in the database =  {ingredientcount}");
            TestContext.WriteLine($"Number of rows in Ingredient returned by app  = {lst.Count}.");
        }
        [Test]
        public void SearchIngredients()
        {
            string searchcriteria = "e";
            int ingredientcount = GetFirstColumnFirstRowValue($"select total = count(*) from ingredient where ingredientname like '%{searchcriteria}%'");
            TestContext.WriteLine($"Num of ingredient results in DB with search criteria '{searchcriteria}' = {ingredientcount}.");
            bizIngredient ingredient = new();
            List<bizIngredient> lst = ingredient.Search(searchcriteria);
            Assert.IsTrue(lst.Count == ingredientcount, $"Number of rows returned by search = {lst.Count} | Number or rows returned by search in database = {ingredientcount}.");
            TestContext.WriteLine($"Number of rows in search results returned by app = {lst.Count}.");
        }
        [Test]
        public void DeleteRecipeNotInDraftStatusorArchivedLessThanThirtyDays()
        {
            string sql = @"
                    select top 1 r.RecipeId 
                    from recipe r
                    left join MealCourseRecipe mcr
                    on mcr.RecipeId = r.RecipeId
                    left join CookbookRecipe cr
                    on cr.RecipeId = r.RecipeId
                    where mcr.RecipeId is null
                    and cr.RecipeId is null
                    and ((datediff(day,r.datearchived,getdate()) is null or datediff(day,r.datearchived,getdate()) < 30) and r.RecipeStatus <> 'Draft')
                    ";
            DataTable dt = GetDataTable(sql);
            int recipeid = 0;

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
            }
            Assume.That(recipeid > 0, "No Recipe Archived over 30 days or in Draft status in DB, cant run test");

            TestContext.WriteLine("Existing test recipe, with id = " + recipeid);
            TestContext.WriteLine("Ensure app cannot delete recipe with id " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => DataHandling.Delete("Recipe", recipeid));

            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void DeleteRecipeAssociatedWithAMeal()
        {
            DataTable dt = GetDataTable("select * from Recipe r join MealCourseRecipe m on m.RecipeId = r.RecipeId");
            int recipeid = 0;

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
            }
            Assume.That(recipeid > 0, "No Recipe associate with a meal in DB, cant run test");

            TestContext.WriteLine("Existing test recipe, with id = " + recipeid);
            TestContext.WriteLine("Ensure app cannot delete recipe with id " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => DataHandling.Delete("Recipe", recipeid));

            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeToDuplicateName()
        {
            int recipeid = GetExistingRecipeId();

            Assume.That(recipeid > 0, "No recipe in DB, cant run test");

            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);
            string recipename2 = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipename <> '" + recipename + "'");

            Assume.That(recipename != null, "No other recipe record in the table, cant run test");

            TestContext.WriteLine("Change recipe name from " + recipename + " to " + recipename2 + " which belongs to a different recipe that already exists in the DB");

            bizRecipe recipe = new();
            DataTable dt = recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = recipename2;

            Exception ex = Assert.Throws<Exception>(() => DataHandling.SaveDataTables(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }
        [Test]
        public void ChangeExistingRecipeToBlankName()
        {
            int recipeid = GetExistingRecipeId();

            Assume.That(recipeid > 0, "No recipe in DB, cant run test");

            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);

            TestContext.WriteLine("Change recipe name " + recipename + " to " + " blank");

            bizRecipe recipe = new();
            DataTable dt = recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = "";

            Exception ex = Assert.Throws<Exception>(() => DataHandling.SaveDataTables(dt, "Recipe"));
            TestContext.WriteLine(ex.Message);
        }
        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";
            DataTable dt = GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            return s;
        }
        private int GetExistingRecipeId()
        {
            return GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }
    }
}