create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0, 
	@RecipeName varchar(100) = '', 
	@IncludeBlank bit = 0,
	@All bit = 0
)
as 
begin
	select @RecipeName = nullif(@RecipeName,'')
	select r.RecipeId, c.CuisineId, u.UserId, r.RecipeName, r.RecipeStatus, u.Username,
	r.Calories, NumOfIngredients = dbo.NumOfIngredientsInRecipe(r.RecipeId),
					r.DateDrafted, r.DatePublished, r.DateArchived, ListOrder = 0
					,DateDraftedAsDateOnly = convert(varchar, r.DateDrafted, 101)
					,DatePublishedAsDateOnly = convert(varchar, r.DatePublished, 101)
					,DateArchivedAsDateOnly = convert(varchar, r.DateArchived, 101),r.RecipePicture
	from Recipe r
	join Users u
	on r.UserId = u.UserId
	join Cuisine c
	on r.CuisineId = c.CuisineId
	where r.RecipeId = @RecipeId
	or @All = 1
	or r.RecipeName like '%' + @RecipeName + '%'
	union select 0,0,0,'','','',0,0,0,0,0,0,'','','',''
	where @IncludeBlank = 1
	order by ListOrder, r.RecipeStatus desc
end
go

--exec RecipeGet

--exec RecipeGet @All = 1

--declare @RId int
--select top 1 @RId = r.RecipeId from Recipe r
--exec RecipeGet @RecipeId = @RId

--exec RecipeGet @RecipeName = 'Yossi'

