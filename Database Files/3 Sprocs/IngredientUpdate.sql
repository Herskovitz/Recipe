create or alter proc IngredientUpdate(
	@IngredientId int = 0,
	@IngredientName varchar(30) = '',
	@All int = 0,
	@IncludeBlank int = 0
)
as
begin

	select @IngredientId = isnull(@IngredientId, 0)

	if @IngredientId = 0
		begin
			insert Ingredient(IngredientName)
			values (@IngredientName)

			select @IngredientId = scope_identity()
		end
	else
		begin
			update Ingredient 
			set
			IngredientName = @IngredientName
			where IngredientId = @IngredientId
		end
end
go
