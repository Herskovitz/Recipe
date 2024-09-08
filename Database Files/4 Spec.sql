/*
Have a popular recipe website and as it grows get more and more problems so looking for help.
Not only Recipes, meals and cookbooks. Same recipe can be in multiple pages (meals,cookbooks) and the source of problem is that everthing is duplicated and users make changes on one place but not all.

Here is what we have on site:
>Recipes:
-Cuisine Type 
-Ingredients
-Measurement Type
-Amount
-Ingredient Sequence
-Directions
-Steps
-Status - Draft then Publish then sometimes Archived
    -Date and Time of status change to track different behaviors 
    -Archive only not delete 

>Meals
-Name
-Courses 
-Course Sequence
-Recipes
    Multiple recipes per course and multiple courses per meal
    No min or max but coursetype in meal must be unique (cannot have to desserts but can have multiple recipes in a dessert)


>Cookbook
-Name
-Price
-Recipes
-Recipe Sequence

>Pictures on Ingredients, Recipes, Meals and Cookbooks
    Format = ItemType-ItemName.jpg - all spaces replaced with dashes (Ex. Ingredient-Baby-Carrot.jpg)

--Status for meals and cookbooks - just need to show if active or inactive

>Users
-FirstName
-LastName
-Username
    -create Recipes, Meals and Cookbooks


Note: everything in the system must be unique like ingredients, cuisine, recipe, meal and cookbook, should not be duplicated