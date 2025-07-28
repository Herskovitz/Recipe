create or alter proc CookbookRecipeDelete(
	@CookbookRecipeId int = 0
)
as 
begin
	declare @return int = 0

	delete cr
	from CookbookRecipe cr
	where cr.CookbookRecipeId = @CookbookRecipeId

	return @return
end