create or alter proc dbo.RecipeDirectionGet(
	@RecipeDirectionId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select @RecipeDirectionId = isnull(@RecipeDirectionId,0), @RecipeId = isnull(@RecipeId,0), @All = isnull(@All,1),@IncludeBlank = isnull(@IncludeBlank,0)

	select rd.RecipeDirectionId, rd.RecipeId, rd.DirectionDescription, rd.StepNum
	from RecipeDirection rd
	where rd.RecipeId = @RecipeId
	or @All = 1
	union select 0,0,'',0
	where @IncludeBlank = 1
	order by rd.StepNum

	return @return
end
go

--exec RecipDirectionGet @All = 1, @IncludeBlank = 1