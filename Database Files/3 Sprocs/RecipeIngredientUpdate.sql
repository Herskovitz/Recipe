create or alter proc RecipeIngredientUpdate(
	@RecipeIngredientId int output,
	@RecipeId int = 0,
	@IngredientId int = 0,
	@MeasurementId int = 0,
	@IngredientSequence int = 0,
	@Quantity decimal(4,2) = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeIngredientId = isnull(@RecipeIngredientId,0)
	
	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId,IngredientId,MeasurementId,IngredientSequence,Quantity)
		values (@RecipeId,@IngredientId,@MeasurementId,@IngredientSequence,@Quantity)

		select @RecipeIngredientId = scope_identity()
	end
	else
	begin
		update RecipeIngredient
		set
		RecipeId = @RecipeId,
		IngredientId = @IngredientId,
		MeasurementId = @MeasurementId,
		IngredientSequence = @IngredientSequence,
		Quantity = @Quantity
		where RecipeIngredientId = @RecipeIngredientId
	end
	return @return
end
go

