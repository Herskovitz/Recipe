declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r
left join CookbookRecipe cr
on r.RecipeId = cr.RecipeId
left join MealCourseRecipe mcr
on mcr.RecipeId = r.RecipeId
where mcr.RecipeId is null
and cr.RecipeId is null	
and (r.RecipeStatus like 'Draft' or datediff(day,r.DateArchived,getdate()) > 30)

select r.RecipeName from Recipe r where r.RecipeId = @recipeid


declare @return int, @message varchar(500)

exec @return = RecipeDelete @RecipeId = recipeid

--select 'Return' = @return, 'Message' = @message

select r.RecipeName from Recipe r where r.RecipeId = @recipeid

