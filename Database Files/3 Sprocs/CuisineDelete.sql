create or alter proc CuisineDelete(
	@CuisineId int = 0
)
as
begin
	delete mcr
	from MealCourseRecipe mcr
	join Recipe r
	on mcr.RecipeId = r.RecipeId
	join Cuisine c
	on r.CuisineId = c.CuisineId
	where c.CuisineId = @CuisineId

	delete cr
	from CookbookRecipe cr
	join Recipe r
	on cr.RecipeId = r.RecipeId
	join Cuisine c
	on r.CuisineId = c.CuisineId
	where c.CuisineId = @CuisineId
	

	delete ri
	from RecipeIngredient ri
	join Recipe r
	on ri.RecipeId = r.RecipeId
	join Cuisine c
	on r.CuisineId = c.CuisineId
	where c.CuisineId = @CuisineId
	
	delete rd
	from RecipeDirection rd
	join Recipe r
	on rd.RecipeId = r.RecipeId
	join Cuisine c
	on r.CuisineId = c.CuisineId
	where c.CuisineId = @CuisineId

	delete r
	from Cuisine c
	join Recipe r
	on c.CuisineId = r.CuisineId
	where c.CuisineId = @CuisineId

	delete c
	from Cuisine c
	where c.CuisineId = @CuisineId
end
go

