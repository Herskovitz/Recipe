create or alter proc dbo.RecipeClone(
	@RecipeId int = null output,
	@BaseRecipeId int,
	@Message varchar(500) = '' output	
)
as
begin
	declare @return int = 0

	insert Recipe(CuisineId,UserId,RecipeName,Calories,DateDrafted)
	select distinct r.CuisineId, r.UserId, concat(r.RecipeName,' - clone'),r.Calories, getdate()
	from Recipe r
	where @BaseRecipeId = r.RecipeId
	
		select @RecipeId = scope_identity();
		
	insert RecipeIngredient (RecipeId,IngredientId,MeasurementId,Quantity,IngredientSequence)
	select @RecipeId, ri.IngredientId, ri.MeasurementId, ri.Quantity, ri.IngredientSequence
	from Recipe r
	left join RecipeIngredient ri
	on ri.RecipeId = r.RecipeId
	where ri.RecipeId = @BaseRecipeId

	insert RecipeDirection (RecipeId, StepNum, DirectionDescription)
	select @RecipeId, rd.StepNum, rd.DirectionDescription
	from Recipe r
	join RecipeDirection rd
	on r.RecipeId = rd.RecipeId
	where rd.RecipeId = @BaseRecipeId

	return @return
end
go 

	


 