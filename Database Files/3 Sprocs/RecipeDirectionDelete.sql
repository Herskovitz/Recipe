create or alter proc RecipeDirectionDelete(
	@RecipeDirectionId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeDirectionId = isnull(@RecipeDirectionId,0)

	delete RecipeDirection
	where RecipeDirectionId = @RecipeDirectionId

	return @return
end
go