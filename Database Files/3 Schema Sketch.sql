-- SM Excellent sketch! See comments, I think that it's ready to start creating the DB. Just fix the minor issues and start working on DB. Good luck!
/*
RecipeDB



Users table
    UserId int not null identity primary key,
    UserFirstName varchar(20) not null, no blank constraint
    UserLastName varchar(30) not null, no blank constraint
    Username varchar(20) not null, no blank constraint, unique constraint

Ingredient table
    IngredientId int not null identity primary key
    IngredientName varchar(50) not null, no blank constraint, unique constraint
    IngredientPicture as concat table name, item name & .jpg, replace space with -

Cuisine table
    CuisineId int not null identity primary key
    CuisineType varchar(30) not null, no blank constraint, unique constraint

Measurement table
    MeasurementId int not null identity primary key
    MeasurementType varchar(30) not null, no blank constraint, unique constraint

RecipeIngredient table
    RecipeIngredientId int not null identity primary key
    RecipeId int not null fk-Recipe
    IngredientId int not null fk-Ingredient
    MeasurementId int yes null fk-Measurement
    Sequence int not null, greater than zero constraint
    Quantity int not null, greater than zero constraint
        constraint unique IngredientId and RecipeId
-- SM No need to include IngredientId in this unique constraint. (*)
        constraint unique Sequence and RecipeId

RecipeDirections table
    RecipeDirectionId int not null identity primary key
    RecipeId int not null fk-Recipe
    StepNum int not null, greater than zero constraint
-- SM Desc should not be unique. You can have multiple times "boil for 10 minutes" but they are different as they are for different recipes (*)
    Description varchar(500) not null, no blank constraint
-- SM No need to include desc in unique constraint. (*)
        constraint unique StepNum and RecipeId

Recipe table
    RecipeId int not null identity primary key
    CuisineId int not null fk-Cuisine
    UserId int not null fk-User
    RecipeName varchar(100) not null, no blank constraint, unique constraint
    Calories int not null, greater than zero constraint
    DateDrafted datetime not null default getdate()
    DatePublished datetime yes null
    DateArchived datetime yes null
-- SM Archived MUST be after published if recipe was published. See below. (*)
-- This should only check on null.
    RecipeStatus as case 
        when draft is not null and publish is null and draft is null then 'Draft'
        when published is greater than drafted and archived then 'Published'
        when archived is greater than drafted and published then 'Archived'
    RecipePicture as concat table name, item name & .jpg, replace space with -

-- SM It will go first back to drafted (resetting all data) to have some modification and then to published. See the answer again.(*)
        constraint DatePublished and DateArchived must be later than DateDrafted
        constarint DateArchived must be later than DatePublished or DatePublished is null
-- SM No need for this constraint. RecipeName is unique. (*)

--RH Should I change the CourseSequence column to the Course table instead of MealCourse?
-- SM Yes. The order of the courses is always the same, you might just skip a course in some meals. (*)

Course table
    CourseId int not null identity primary key
    CourseType varchar(30) not null, no blank constraint, unique constraint
    CourseSequence int not null, greater than zero constraint, unique constraint


Meal table
    MealId int not null identity primary key
    UserId int not null fk-User
    MealName varchar(40) not null, no blank constraint, unique constraint
    DateCreated date not null defualt getdate()
    Active bit not null
    MealPicture as concat table name, item name & .jpg, replace space with -

MealCourse table
    MealCourseId int not null identity primary key
    MealId int not null fk-Meal
    CourseId int not null fk-Course
-- SM This should be a unique column in course table. (*)
        constraint MealId and CourseId
        constraint unique MealId,CourseId

MealCourseRecipe table
    MealCourseRecipeId int not null identity primary key
    MealCourseId int not null fk-MealCourse
    RecipeId int not null fk-Recipe
    MainDish bit not null(?)
        constraint unique RecipeId and MealCourseId

Cookbook table
    CookbookId int not null identity primary key
    UserId int not null fk-User
    CookbookName varchar(100) not null, no blank constraint, unique constraint
    Price decimal (5,2) not null, greater than zero constraint
    DateCreated date not null default getdate()
    Active bit not null
    CookbookPicture as concat table name, item name & .jpg, replace space with -

CookbookRecipe table
    CookbookRecipeId int not null identity primary key
    CookbookId int not null fk-Cookbook
    RecipeId int not null fk-Recipe
    Sequence int not null, greater than zero constraint
        constraint unique CookbookId and RecipeId
-- SM This should only have columns CookbookId and Sequence. (*)
        constraint unique CookbookId and Sequence



