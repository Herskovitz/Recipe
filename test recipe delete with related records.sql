

declare @recipeid int

select top 1 @recipeid = r.RecipeId
from Recipe r
left join MealCourseRecipe mcr
on r.RecipeId = mcr.RecipeId
left join CookbookRecipe cr
on r.RecipeId = cr.RecipeId
where cr.RecipeId is null
and mcr.RecipeId is null


exec RecipeDelete @RecipeId = @recipeid


