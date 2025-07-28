create or alter proc RecipeDirectionUpdate(
	@RecipeId int = 0,
	@RecipeDirectionId int = 0,
	@StepNum int = 0,
	@DirectionDescription varchar(500) = '',
	@Message varchar(500) = ''
)
as
begin
	declare @return int = 0

	select @RecipeDirectionId = isnull(@RecipeDirectionId,0)

	
	if @RecipeDirectionId = 0
	begin
		insert RecipeDirection(RecipeId,StepNum,DirectionDescription)
		values (@RecipeId,@StepNum,@DirectionDescription)

		select @RecipeDirectionId = scope_identity()
	end
	else
	begin
		update RecipeDirection
		set
		RecipeId = @RecipeId,
		StepNum = @StepNum,
		DirectionDescription = @DirectionDescription
		where RecipeDirectionId = @RecipeDirectionId
	end
	return @return
end
go