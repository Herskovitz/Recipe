create or alter proc DashboardGet(
	@All bit = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select Type = 'Recipes', Number = count(r.RecipeId) from recipe r
	union select 'Meals', count(m.MealId) from Meal m
	union select 'Cookbooks', count(c.CookbookId) from Cookbook c
	order by Number desc

	return @return
end
go 

--exec DashboardGet @All = 1
