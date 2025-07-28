create or alter proc IngredientDelete(
	@IngredientId int = 0
)
as
begin
	delete ri
	from RecipeIngredient ri
	join Ingredient i
	on ri.IngredientId = i.IngredientId
	where i.IngredientId = @IngredientId

	delete i
	from Ingredient i
	where i. IngredientId = @IngredientId
end
go

