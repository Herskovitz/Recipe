using CPUFramework;
using RecipeSystem;
using System.Configuration;
using System.Data;

namespace RecipeTest
{
    public class Tests
    {
        string connstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;
        //string unittestconnstring = ConfigurationManager.ConnectionStrings["unittestconn"].ConnectionString;

        [SetUp]
        public void Setup()
        {
            
            DBManager.SetConnectionString(connstring, true);
        }

        private DataTable GetDataTable(string sql)
        {
            DataTable dt = new();
            //DBManager.SetConnectionString(unittestconnstring, true);
            dt = SQLUtility.GetDataTable(sql);
            DBManager.SetConnectionString(connstring, true);
            return dt;
        }
        private int GetFirstColumnFirstRowValue(string sql)
        {
            int n = 0;
            //DBManager.SetConnectionString(unittestconnstring, true);
            n = SQLUtility.GetFirstColumnFirstRowValue(sql);
            DBManager.SetConnectionString(connstring, true);
            return n;
        }


        [Test]
        [TestCase(111, "01/01/2025")]
        [TestCase(1111, "01/01/1800")]
        public void InsertRecipe(int calories, DateTime datedrafted)
        //
        {
            DataTable dt = GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int userid = GetFirstColumnFirstRowValue("select top 1 userid from users order by userid");
            int cuisineid = GetFirstColumnFirstRowValue("select top 1 cuisineid from cuisine");
            Assume.That(userid > 0, "No Users in DB, cant run test");
            Assume.That(cuisineid > 0, "No Cuisines in DB, cant run test");

            string recipename = "Test" + " - " + DateTime.Now.Ticks;

            TestContext.WriteLine("Insert recipe with recipename = " + recipename);

            r["CuisineId"] = cuisineid;
            r["UserId"] = userid;
            r["RecipeName"] = recipename;
            r["Calories"] = 111;
            r["DateDrafted"] = "01/01/2025";
            r["DatePublished"] = "01/01/2035";


            DataHandling.SaveDataTables(dt, "Recipe");


            int newid = GetFirstColumnFirstRowValue("Select recipeid from recipe where recipename = '" + recipename + "'");

            Assert.IsTrue(newid > 0, "Recipe with name  = " + recipename + "is not found in DB");
            TestContext.WriteLine("Recipe with " + recipename + " was found in DB with pk value = " + newid);

        }
        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = GetDataTable("select top 1 RecipeId from recipe r  where RecipeName like '%test%'");
            int recipeid = 0;

            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["RecipeId"];
            }
            Assume.That(recipeid > 0, "No Test-Recipe in DB, cant run test");

            TestContext.WriteLine("Existing test recipe, with id = " + recipeid);
            TestContext.WriteLine("Ensure app can delete recipe with id " + recipeid);

            DataHandling.Delete("Recipe", recipeid);
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
            DataTable dt = DataHandling.Load("Recipe", recipeid);
            int loadedrecipeid = (int)dt.Rows[0]["RecipeId"];
            Assert.IsTrue(loadedrecipeid == recipeid, (int)dt.Rows[0]["RecipeId"] + " <>" + recipeid);
            TestContext.WriteLine("Loaded recipe (" + loadedrecipeid + ") " + recipeid);
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

            DataTable dt = DataHandling.Load("Recipe",recipeid);
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

            DataTable dt = DataHandling.Load("Recipe",recipeid);
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