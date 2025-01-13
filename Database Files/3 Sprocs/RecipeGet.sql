create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @RecipeName varchar(100) = '', @All bit = 0)
as 
begin
	select @RecipeName = nullif(@RecipeName,'')
	select r.RecipeId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
end
go

exec RecipeGet

exec RecipeGet @All = 1

declare @RId int
select top 1 @RId = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @RId

exec RecipeGet @RecipeName = 'test'

