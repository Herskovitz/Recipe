create or alter proc CookbookRecipeUpdate(
	@CookbookRecipeId int = 0,
	@CookbookId int = 0,
	@RecipeId int = 0,
	@RecipeSequence int = 0
)
as
begin
	
	select @CookbookRecipeId = isnull(@CookbookRecipeId,0)

	if @CookbookRecipeId = 0
		begin
			insert CookbookRecipe(CookbookId,RecipeId,RecipeSequence)
			values (@CookbookId,@RecipeId,@RecipeSequence)

			select @CookbookRecipeId = scope_identity()
		end
	else
		begin
			update CookbookRecipe
			set 
			CookbookId = @CookbookId,
			RecipeId = @RecipeId,
			RecipeSequence = @RecipeSequence
			where CookbookRecipeId = @CookbookRecipeId
		end
end
go
