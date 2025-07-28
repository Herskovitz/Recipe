create or alter proc CookbookRecipeGet(
	@CookbookId int = 0,
	@All int = 0,
	@IncludeBlank int = 0
)
as
begin

	declare @return int = 0

	select cr.CookbookRecipeId, c.CookbookId, r.RecipeId, cr.RecipeSequence
	from Cookbook c
	join CookbookRecipe cr
	on c.CookbookId = cr.CookbookId 
	join Recipe r
	on cr.RecipeId = r.RecipeId
	where c.CookbookId = @CookbookId
	or @All = 1
	union select 0, 0, 0, 0
	where @IncludeBlank = 1
	order by cr.RecipeSequence

	return @return
end
go

--exec CookbookRecipeGet @All = 1


