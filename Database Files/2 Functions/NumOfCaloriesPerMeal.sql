create or alter function dbo.NumOfCaloriesPerMeal(@MealId int)
returns int
as 
begin
	declare @value int

	select @value = sum(r.calories)
	from meal m
	join mealcourse mc
	on m.mealid = mc.mealid 
	join mealcourserecipe mcr
	on mc.mealcourseid = mcr.mealcourseid
	join recipe r
	on mcr.recipeid = r.recipeid
	where m.MealId = @MealId
	group by m.MealId

	return @value
end
go



select m.MealName, NumOfCalories = dbo.NumOfCaloriesPerMeal(m.MealId)
from meal m


