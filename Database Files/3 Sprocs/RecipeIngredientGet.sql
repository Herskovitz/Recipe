create or alter proc dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @All = isnull(@All,0), @RecipeId = isnull(@RecipeId,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @IncludeBlank = isnull(@IncludeBlank,0)

	select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, ri.MeasurementId, ri.Quantity, ri.IngredientSequence
	from RecipeIngredient ri
	where ri.RecipeId = @RecipeId
	or @All = 1
	union select 0,0,0,0,0,0
	where @IncludeBlank = 1
	order by ri.IngredientSequence

	return @return
end
go

--exec RecipeIngredientGet @All = 1