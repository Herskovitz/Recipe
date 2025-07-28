create or alter proc MealGet(
	@MealId int = 0,
	@All bit = 0,
	@Message varchar(500) = ' ' output 
)
as
begin
	select m.MealId, m.MealName, u.Username, NumOfCalories = dbo.NumOfCaloriesPerMeal(m.MealId), NumOfRecipes = count(r.RecipeId),
			NumOfCourses = count(distinct mc.MealCourseId)
	from Meal m
	join Users u
	on m.UserId = u.UserId
	join MealCourse mc
	on m.MealId = mc.MealId
	left join MealCourseRecipe mcr
	on mc.MealCourseId = mcr.MealCourseId
	left join Recipe r
	on mcr.RecipeId = r.RecipeId
	where m.MealId = @MealId
	or @All = 1
	group by m.MealId, m.MealName, u.Username
	order by m.MealName
end
go

--exec MealGet @All = 1