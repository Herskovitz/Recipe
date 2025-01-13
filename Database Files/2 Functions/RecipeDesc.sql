create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(200)
as
begin
	declare @value varchar(200) = ''

	select @value = concat( r.RecipeName,' (',c.CuisineType,') has ', 
						count(distinct ri.RecipeIngredientId),' ingredients and ',
							count(distinct rd.RecipeDirectionId),' steps.')
	from Recipe r
	join Cuisine c
	on r.CuisineId = c.CuisineId
	join RecipeIngredient ri
	on r.RecipeId = ri.RecipeId
	join RecipeDirection rd
	on r.RecipeId = rd.RecipeId
	where r.RecipeId = @RecipeId
	group by r.RecipeName,c.CuisineType

	return @value
end
go



select RecipeDesc = dbo.RecipeDesc(r.RecipeId), r.*
from Recipe r