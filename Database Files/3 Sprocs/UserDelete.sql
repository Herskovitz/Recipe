create or alter proc UserDelete(
	@UserId int = 0
)
as
begin
	delete mcr
	from MealCourseRecipe mcr
	left join MealCourse mc
	on mcr.MealCourseId = mc.MealCourseId 
	left join Meal m
	on mc.MealId = m.MealId
	left join Recipe r
	on mcr.RecipeId = r.RecipeId
	left join Users u
	on m.UserId = u.UserId
	or r.UserId = u.UserId
	where u.UserId = @UserId
	
	delete mc
	from MealCourse mc
	join Meal m
	on mc.MealId = m.MealId
	join Users u
	on m.UserId = u.UserId
	where u.userid = @UserId
	
	delete m
	from Meal m 
	join Users u
	on m.UserId = u.UserId
	where u.UserId = @UserId
	
	delete cr
	from CookbookRecipe cr
	left join Recipe r
	on cr.RecipeId = r.RecipeId
	join Cookbook c
	on cr.CookbookId = c.CookbookId
	join Users u
	on r.UserId = u.UserId
	or c.UserId = u.UserId
	where u.UserId = @UserId
	
	delete c
	from Cookbook c
	join Users u
	on c.UserId = u.UserId
	where u.UserId = @UserId

	delete RecipeIngredient
	from RecipeIngredient ri
	join Recipe r
	on ri.RecipeId = r.RecipeId
	join Users u
	on r.UserId = u.UserId
	where r.UserId = @UserId
	
	delete RecipeDirection 
	from RecipeDirection rd
	join Recipe r
	on rd.RecipeId = r.RecipeId
	join Users u
	on r.UserId = u.UserId
	where r.UserId = @UserId

	delete Recipe
	from Recipe r
	join Users u
	on r.UserId = u.UserId
	where r.UserId = @UserId

	delete Users
	where UserId = @UserId
end
go






