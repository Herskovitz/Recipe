<<<<<<< HEAD

=======
--AF Amazing job! 100%
>>>>>>> a115047ce545a5fed0255b4272a4e242244bb1e3
use RecipeDB
go

drop table if exists CookBookRecipe
drop table if exists RecipeIngredientDirections
drop table if exists MealCourseRecipe
drop table if exists MealCourse
drop table if exists Cookbook
drop table if exists Meal
drop table if exists Course
drop table if exists RecipeDirection
drop table if exists RecipeIngredient
drop table if exists Recipe
drop table if exists Users
drop table if exists Cuisine
drop table if exists Measurement
drop table if exists Ingredient
go

create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(30) not null 
        constraint ck_Ingredient_IngredientName_cannot_be_blank check(IngredientName > '')
        constraint u_Ingredient_IngredientName unique(IngredientName),
    IngredientPicture as replace(concat('Ingredient-',IngredientName,'.jpg'),' ','-')
)

create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineType varchar(30) not null
        constraint ck_Cuisine_CuisineType_cannot_be_blank check(CuisineType > '')
        constraint u_Cuisine_CuisineType unique(CuisineType)
)

create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementType varchar(30) not null
        constraint ck_Measurement_MeasurementType_cannot_be_blank check(MeasurementType > '')
        constraint u_Measurement_MeasurementType unique(MeasurementType)
)

create table dbo.Users(
    UserId int not null identity primary key,
    UserFirstName varchar(20) not null
        constraint ck_Users_UserFirstName_cannot_be_blank check(UserFirstName > ''),
    UserLastName varchar(30) not null
        constraint ck_Users_UserLastName_cannot_be_blank check(UserLastName > ''),
    Username varchar(20) not null
        constraint ck_Users_Username_cannot_be_blank check(Username > '')
        constraint u_Users_Username unique(Username)
)

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    UserId int not null constraint f_Users_Recipe foreign key references Users(UserId),
    RecipeName varchar(100) not null
        constraint ck_Recipe_RecipeName_cannot_be_blank check(RecipeName > '')
        constraint u_Recipe_RecipeName unique(RecipeName),
    Calories int not null
        constraint ck_Recipe_Calories_cannot_be_negative check(Calories >= 0),
    DateDrafted datetime not null default getdate(),
    DatePublished datetime,
    DateArchived datetime,
    RecipeStatus as case
        when DateDrafted is not null and DatePublished is null and DateArchived is null then 'Draft'
        when DatePublished > DateDrafted and DateArchived is null then 'Published'
        when DateArchived >DateDrafted and DateArchived > DatePublished then 'Archived'
        end,
    RecipePicture as replace(concat('Recipe-',RecipeName,'.jpg'),' ','-'),
        constraint ck_Recipe_DatePublished_and_DateArchived_must_be_later_than_DateDrafted check(DateDrafted <= DatePublished and DateDrafted <= DateArchived),
        constraint ck_Recipe_DateArchived_must_be_later_than_DatePublished_if_recipe_is_published check(DateArchived >= DatePublished or DatePublished is null)
        )

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeIngredient foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_Ingredient_RecipeIngredient foreign key references Ingredient(IngredientId),
    MeasurementId int constraint f_Measurement_RecipeIngredient foreign key references Measurement(MeasurementId),
    IngredientSequence int not null
        constraint ck_RecipeIngredient_IngredientSequence_must_be_greater_than_zero check(IngredientSequence > 0),
    Quantity decimal(4,2) not null
        constraint ck_RecipeIngredient_Quantity_must_be_greater_than_zero check(Quantity > 0),
            constraint u_RecipeIngredient_RecipeId_IngredientId unique(RecipeId,IngredientId),
            constraint u_RecipeIngredient_RecipeId_IngredientSequence unique(RecipeId,IngredientSequence)
)

create table dbo.RecipeDirection(
    RecipeDirectionId int not null identity primary key,
    RecipeId int not null constraint f_Recipe_RecipeDirection foreign key references Recipe(RecipeId),
    StepNum int not null
        constraint ck_RecipeDirection_StepNum_must_be_greater_than_zero check(StepNum > 0),
    DirectionDescription varchar(500) not null
        constraint ck_RecipeDirection_DirectionDescription_cannot_be_blank check(DirectionDescription > ''),
            constraint u_RecipeDirection_RecipeId_StepNum unique(RecipeId,StepNum)
)

create table dbo.Course(
    CourseId int not null identity primary key,
    CourseType varchar(30) not null
        constraint ck_Course_CourseType_cannot_be_blank check(CourseType > '')
        constraint u_Course_CourseType unique(CourseType),
    CourseSequence int not null
        constraint ck_Course_CourseSequence_must_be_greater_than_zero check(CourseSequence > 0)
        constraint u_Course_CourseSequence unique(CourseSequence)
)

create table dbo.Meal(
    MealId int not null identity primary key,
    UserId int not null constraint f_Users_Meal foreign key references Users(UserId),
    MealName varchar(40) not null
        constraint ck_Meal_MealName_cannot_be_blank check(MealName > '')
        constraint u_Meal_MealName unique(MealName),
    DateCreated date not null default getdate(),
    Active bit not null,
    MealPicture as replace(concat('Meal-',MealName,'.jpg'),' ','-')
)

create table dbo.MealCourse(
    MealCourseId int not null identity primary key,
    MealId int not null constraint f_Meal_MealCourse foreign key references Meal(MealId),
    CourseId int not null constraint f_Course_MealCourse foreign key references Course(CourseId),
            constraint u_MealCourse_MealId_CourseId unique(MealId,CourseId)
)

create table dbo.MealCourseRecipe(
    MealCourseRecipeId int not null identity primary key,
    MealCourseId int not null constraint f_MealCourse_MealCourseRecipe foreign key references MealCourse(MealCourseId),
    RecipeId int not null constraint f_Recipe_MealCourseRecipe foreign key references Recipe(RecipeId),
    MainDish bit not null,
        constraint u_MealCourseRecipe_Recipe_MealCourse unique(RecipeId,MealCourseId)
)

create table dbo.Cookbook(
    CookbookId int not null identity primary key,
    UserId int not null constraint f_Users_Cookbook foreign key references Users(UserId),
    CookbookName varchar(100) not null
        constraint ck_Cookbook_CookbookName_cannot_be_blank check(CookbookName > '')
        constraint u_Cookbook_CookbookName unique(CookbookName),
    Price decimal (5,2) not null
        constraint ck_Cookbook_Price_must_be_greater_than_zero check(Price > 0),
    DateCreated date not null default getdate(),
    Active bit not null,
    CookbookPicture as replace(concat('Cookbook-',CookbookName,'.jpg'),' ','-')
)

create table dbo.CookbookRecipe(
    CookbookRecipeId int not null identity primary key,
    CookbookId int not null constraint f_Cookbook_CookbookRecipe foreign key references Cookbook(CookbookId),
    RecipeId int not null constraint f_Recipe_CookbookoRecipe foreign key references Recipe(RecipeId),
    RecipeSequence int not null
        constraint ck_CookbookRecipe_RecipeSequence_must_be_greater_than_zero check(RecipeSequence > 0),
        constraint u_Cookbook_Recipe_RecipeId_CookbookId unique(RecipeId,CookbookId),
        constraint u_CookbookRecipe_CookbookId_RecipeSequence unique(CookbookId,RecipeSequence)
)
