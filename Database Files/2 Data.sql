use RecipeDB
go

delete CookbookRecipe
delete Cookbook
delete MealCourseRecipe
delete MealCourse
delete Meal
delete Course
delete RecipeDirection
delete RecipeIngredient
delete Recipe
delete Cuisine
delete Measurement
delete Ingredient
delete Users

insert Cuisine(CuisineType)
select 'American'
union select 'French'
union select 'Italian'
union select 'Chinese'
union select 'Mediterranean'
union select 'English'

insert Users (UserFirstName,UserLastName,Username)
select 'Sam','Fried','Fried_Sam'
union select 'Nick', 'Nickerson','nicknicknick'
union select 'Mark', 'Marque', 'markmarque@gmail.com'
union select 'Sarah', 'Schwartz', 'Sarah Schwartz'
union select 'Rosemarie', 'Rosen', 'Rosen_Rosemarie'
union select 'Esther', 'Easter', 'Easter_Esther'

insert Measurement(MeasurementType)
select 'Cup(s)'
union select 'Teaspoon(s)'
union select 'Tablespoon(s)'
union select 'Ounce(s)'
union select 'Pound(s)'
union select 'Pinch'
union select 'Bag(s)'
union select 'Bar(s)'
union select 'Clove(s)'
union select 'Side'

insert Ingredient(IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Eggs'
union select 'Flour'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apples'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cubes'
union select 'Club Bread'
union select 'Butter'
union select 'Shredded Cheese'
union select 'Garlic'
union select 'Black Pepper'
union select 'Salt'
union select 'Stick Butter'
union select 'Vanilla Pudding'
union select 'Whipped Cream Cheese'
union select 'Sour Cream'
union select 'Slivered Almonds'
union select 'Caesar Dressing'
union select 'Plum Tomatoes'
union select 'Eggplant'
union select 'Hot Cherry Peppers'
union select 'Salmon'
union select 'Lemon Juice'
union select 'Lemon Pepper Spice'
union select 'Romaine Lettuce'
union select 'Red Cabbage'
union select 'Kirbies'
union select 'Chickpeas'
union select 'Craisins'
union select 'Caesar Croutons'

;
with x as(
    select Cuisine = 'American', Username = 'markmarque@gmail.com', Recipe = 'Chocolate Chip Cookies', Calories = 1000, Draft = '01-10-2020', Publish = '02-10-2020' , Archived = null
    union select 'French', 'Fried_Sam', 'Apple Yogurt Smoothie', 150, '05-15-2022', '10-10-2022', null
    union select 'English', 'nicknicknick', 'Cheese Bread', 780, '12-12-2021', '3-12-2022', null
    union select 'American', 'markmarque@gmail.com', 'Butter Muffins', 900, '06-06-2022', '10-06-2022', null
    union select 'Italian', 'Rosen_Rosemarie', 'Tomato Dip', 85, '10-12-2021', '11-12-2021', '04-25-2023'
    union select 'French', 'Rosen_Rosemarie', 'Eggplant Dip', 85, '11-20-2021', '12-10-2021', null
    union select 'Italian', 'Rosen_Rosemarie', 'Lemon Pepper Baked Fish', 450, '4-04-2020', '05-05-2020','06-06-2021'
    union select 'American', 'Easter_Esther', 'Salad 1', 360, '02-12-2019', '03-12-2019', null
)

insert Recipe(CuisineId,UserId,RecipeName,Calories,DateDrafted,DatePublished,DateArchived)
select c.CuisineId,u.UserId, x.Recipe,x.Calories,x.Draft,x.Publish,x.Archived
from x
join Cuisine c
on x.Cuisine = c.CuisineType
join Users u
on x.Username = u.Username

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', Ingredient = 'Sugar', Measurement = 'Cup(s)', Suq = 1, Qty = 1
    union select 'Chocolate Chip Cookies', 'Oil', 'Cup(s)', 2, .5
    union select 'Chocolate Chip Cookies', 'Eggs', null, 3, 3
    union select 'Chocolate Chip Cookies', 'Vanilla Sugar', 'Teaspoon(s)', 4, 1
    union select 'Chocolate Chip Cookies', 'Baking Powder', 'Teaspoon(s)', 5, 2
    union select 'Chocolate Chip Cookies', 'Baking Soda', 'Teaspoon(s)', 6, .5
    union select 'Chocolate Chip Cookies', 'Chocolate Chips', 'Cup(s)', 7, 1
    union select 'Apple Yogurt Smoothie', 'Granny Smith Apples', null, 1, 3
    union select 'Apple Yogurt Smoothie', 'Vanilla Yogurt', 'Cup(s)', 2, 2
    union select 'Apple Yogurt Smoothie', 'Sugar', 'Teaspoon(s)', 3, 2
    union select 'Apple Yogurt Smoothie', 'Orange Juice', 'Cup(s)', 4, .5
    union select 'Apple Yogurt Smoothie', 'Honey', 'Tablespoon(s)', 5, 2
    union select 'Apple Yogurt Smoothie', 'Ice Cubes', null, 6, 5
    union select 'Cheese Bread', 'Club Bread', null, 1, 1
    union select 'Cheese Bread', 'Butter', 'Ounce(s)', 2, 4
    union select 'Cheese Bread', 'Shredded Cheese', 'Ounce(s)', 3, 8
    union select 'Cheese Bread', 'Garlic', 'Clove(s)', 4, 2
    union select 'Cheese Bread', 'Black Pepper', 'Teaspoon(s)', 5, .25
    union select 'Cheese Bread', 'Salt', 'Pinch', 6, 1
    union select 'Butter Muffins', 'Stick Butter', null, 1, 1
    union select 'Butter Muffins', 'Sugar', 'Cup(s)', 2, 3
    union select 'Butter Muffins', 'Vanilla Pudding', 'Tablespoon(s)', 3, 2
    union select 'Butter Muffins', 'Eggs', null, 4, 4
    union select 'Butter Muffins', 'Whipped Cream Cheese', 'Ounce(s)', 5, 8
    union select 'Butter Muffins', 'Sour Cream', 'Ounce(s)', 6, 8
    union select 'Butter Muffins', 'Flour', 'Cup(s)', 7, 1
    union select 'Tomato Dip', 'Plum Tomatoes', null, 1, 3
    union select 'Tomato Dip', 'Garlic', 'Clove(s)', 2, 3
    union select 'Tomato Dip', 'Hot Cherry Peppers', null, 3, 1
    union select 'Tomato Dip', 'Salt', 'Teaspoon(s)', 4, 1
    union select 'Tomato Dip', 'Oil', 'Cup(s)', 5, .33
    union select 'Eggplant Dip', 'Eggplant', null, 1, 1
    union select 'Eggplant Dip', 'Oil', 'Cup(s)', 2, 1
    union select 'Eggplant Dip', 'Eggs', null, 3, 1
    union select 'Eggplant Dip', 'Garlic', 'Clove(s)', 4, 3
    union select 'Eggplant Dip', 'Salt', 'Teaspoon(s)', 5, 1
    union select 'Lemon Pepper Baked Fish', 'Salmon', 'Side(s)', 1, 1
    union select 'Lemon Pepper Baked Fish', 'Lemon Juice', 'Cup(s)', 2, .5
    union select 'Lemon Pepper Baked Fish', 'Lemon Pepper Spice', 'Tablespoon(s)', 3, 1
    union select 'Lemon Pepper Baked Fish', 'Salt', 'Teaspoon(s)', 4, 1
    union select 'Lemon Pepper Baked Fish', 'Black Pepper', 'Teaspoon(s)', 5, .25
    union select 'Salad 1', 'Romaine Lettuce', 'Bag(s)', 1, 1
    union select 'Salad 1', 'Red Cabbage', 'Bag(s)', 2, 1
    union select 'Salad 1', 'Kirbies', null, 3, 3
    union select 'Salad 1', 'Chickpeas', 'Ounce(s)', 4, 10
    union select 'Salad 1', 'Craisins', 'Ounce(s)', 5, 5
    union select 'Salad 1', 'Slivered Almonds', 'Ounces(s)', 6, 4
    union select 'Salad 1', 'Caesar Dressing', 'Cup(s)', 7, 1
    union select 'Salad 1', 'Caesar Croutons', 'Cup(s)', 8, 1
)

insert RecipeIngredient(RecipeId,IngredientId,MeasurementId,IngredientSequence,Quantity)
select r.RecipeId,i.IngredientId,m.MeasurementId,x.Suq,x.Qty
from x
join Recipe r
on x.Recipe = r.RecipeName
join Ingredient i
on x.Ingredient = i.IngredientName
left join Measurement m
on x.Measurement = m.MeasurementType

;
with x as(
    Select Recipe = 'Chocolate Chip Cookies' , Step = 1 , DD = 'Combine sugar, oil and eggs in a bowl'
    union select 'Chocolate Chip Cookies', 2, 'Mix well'
    union select 'Chocolate Chip Cookies', 3, 'Add Flour, Vanilla Sugar, Baking Powder and Baking Soda'
    union select 'Chocolate Chip Cookies', 4, 'Beat for 5 minutes'
    union select 'Chocolate Chip Cookies', 5, 'Add Chocolate Chips'
    union select 'Chocolate Chip Cookies', 6, 'Freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies', 7, 'Roll into balls and spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies', 8, 'Bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'Mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'Add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'Pour into glasses'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'Fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'Wrap bread into a foil and bake for 30 minutes'
    union select 'Butter Muffins', 1, 'Cream butter with sugars'
    union select 'Butter Muffins', 2, 'Add eggs and mix well'
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffins', 4, 'Fill muffin pans 3/4 full and bake for 30 minutes'
    union select 'Tomato Dip', 1, 'Blend all ingredients until smooth'
    union select 'Eggplant Dip', 1, 'Broil eggplant on high for twenty minutes each side'
    union select 'Eggplant Dip', 2, 'Crack Egg'
    union select 'Eggplant Dip', 3, 'Slowly pour oil over egg while blending to form mayo.'
    union select 'Eggplant Dip', 4, 'Add garlic and salt and blend'
    union select 'Eggplant Dip', 5, 'Add eggplant and blend'
    union select 'Lemon Pepper Baked Fish', 1, 'Mix lemon juice with spices'
    union select 'Lemon Pepper Baked Fish', 2, 'Pour over salmon'
    union select 'Lemon Pepper Baked Fish', 3, 'Marinade for an hour'
    union select 'Lemon Pepper Baked Fish', 4, 'Bake covered on 400 for 30 minutes'
    union select 'Lemon Pepper Baked Fish', 5, 'Uncover and bake for additional 10 minutes'
    union select 'Salad 1', 1, 'Toss all ingredients except croutons'
    union select 'Salad 1', 2, 'Top with croutons'
)

insert RecipeDirection(RecipeId,StepNum,DirectionDescription)
select r.RecipeId,x.Step,x.DD
from x
join Recipe r
on x.Recipe = r.RecipeName

insert Course(CourseType,CourseSequence)
select 'Appetizer',1
union select 'Main Course',2
union select 'Dessert',3

insert Meal(UserId,MealName,Active)
select (select u.UserId from Users u where u.Username = 'markmarque@gmail.com'), 'Breakfast Bash', 1
union select (select u.UserId from Users u where u.Username = 'Sarah Schwartz'), 'Real Food', 1
union select (select u.UserId from Users u where u.Username = 'Sarah Schwartz'), 'LunchTime', 1
union select (select u.UserId from Users u where u.Username = 'Rosen_Rosemarie'), 'Baked Meal', 1

;
with x as(
    select Meal = 'Breakfast Bash', Course = 'Main Course'
    union select 'Breakfast Bash', 'Appetizer'
    union select 'Real Food', 'Main Course'
    union select 'Real Food', 'Dessert'
    union select 'Lunchtime', 'Appetizer'
    union select 'Lunchtime', 'Main Course'
    union select 'Lunchtime', 'Dessert'
    union select 'Baked Meal', 'Appetizer'
    union select 'Baked Meal', 'Main Course'
    union select 'Baked Meal', 'Dessert'
)

insert MealCourse (MealId,CourseId)
select m.MealId, c.CourseId
from x
join Meal m
on x.Meal = m.MealName
join Course c
on x.Course = c.CourseType

;
with x as(
    select Username = 'Fried_Sam', Cookbook = 'Treats for two', Price = 30, Active = 1
    union select 'Fried_Sam', 'Best Baking Book', 18, 1
    union select 'Easter_Esther', 'Best Seller Cookbook', 50, 1
    union select 'markmarque@gmail.com', 'Good Food Book', 38, 1
)

insert Cookbook(UserId,CookbookName,Price,Active)
select u.UserId,x.Cookbook,x.Price,x.Active
from x
join Users u
on x.Username = u.Username

;
with x as(
    select Meal = 'Breakfast Bash', Course = 'Main Course', Recipe = 'Cheese Bread', Main = 1
    union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 0
    union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 1
    --union select 'Real Food', 'Main Course', 'Lemon Pepper Baked Fish', 1
    union select 'Real Food', 'Main Course', 'Salad 1', 0
    union select 'Real Food', 'Dessert', 'Apple Yogurt Smoothie', 1
    union select 'Lunchtime', 'Appetizer', 'Salad 1', 1
    union select 'Lunchtime', 'Main Course', 'Cheese Bread', 1
    union select 'Lunchtime', 'Main Course', 'Eggplant Dip', 0
    union select 'Lunchtime', 'Main Course', 'Tomato Dip', 0
    union select 'Lunchtime', 'Dessert', 'Butter Muffins', 1
    --union select 'Baked Meal', 'Appetizer', 'Chocolate Chip Cookies', 1
    union select 'Baked Meal', 'Main Course', 'Cheese Bread', 1
    union select 'Baked Meal', 'Dessert', 'Butter Muffins', 1
)

insert MealCourseRecipe(MealCourseId,RecipeId,MainDish)
select mc.MealCourseId, r.RecipeId, x.Main
from x
join Meal m
on x.Meal = m.MealName
join Course c
on x.Course = c.CourseType
join MealCourse mc
on m.MealId = mc.MealId
and c.CourseId = mc.CourseId
join Recipe r
on x.Recipe = r.RecipeName

;
with x as(
    select Cookbook = 'Treats for two' , Recipe = 'Apple Yogurt Smoothie', Seq = 1
    --union select 'Treats for two', 'Chocolate Chip Cookies', 2
    union select 'Treats for two', 'Cheese Bread', 3
    union select 'Treats for two', 'Butter Muffins', 4
    union select 'Good Food Book', 'Cheese Bread', 1
    --union select 'Good Food Book', 'Lemon Pepper Baked Fish', 2
    union select 'Good Food Book', 'Tomato Dip', 3
    union select 'Good Food Book', 'Eggplant Dip', 4
    union select 'Good Food Book', 'Salad 1', 5
    --union select 'Best Baking Book', 'Chocolate Chip Cookies', 1
    union select 'Best Baking Book', 'Butter Muffins', 2
    union select 'Best Baking Book', 'Cheese Bread', 3
    union select 'Best Seller Cookbook', 'Cheese Bread', 1
    union select 'Best Seller Cookbook', 'Tomato Dip', 2
    union select 'Best Seller Cookbook', 'Eggplant Dip', 3
    union select 'Best Seller Cookbook', 'Salad 1', 4
    --union select 'Best Seller Cookbook', 'Lemon Pepper Baked Fish', 5
    union select 'Best Seller Cookbook', 'Apple Yogurt Smoothie', 6
    union select 'Best Seller Cookbook', 'Butter Muffins', 7
    --union select 'Best Seller Cookbook', 'Chocolate Chip Cookies', 8
)

insert CookbookRecipe(CookbookId,RecipeId,RecipeSequence)
select c.CookbookId, r.RecipeId, x.Seq
from x
join Cookbook c
on x.Cookbook = c.CookbookName
join Recipe r
on x.Recipe = r.RecipeName




