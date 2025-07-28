create or alter function dbo.NumOfIngredientsInRecipe(@RecipeId int)
returns int
as 
begin
	declare @value int

	select @value = count(ri.IngredientId)
	from Recipe r
	join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	where @RecipeId = r.RecipeId
	group by r.RecipeId

	return @value
end
go
