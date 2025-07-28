create or alter proc CourseDelete(
	@CourseId int = 0
)
as
begin
	delete mcr
	from MealCourseRecipe mcr
	join MealCourse mc
	on mcr.MealCourseId = mc.MealCourseId
	join Course c
	on mc.CourseId = c.CourseId
	where c.CourseId = @CourseId

	delete mc
	from MealCourse mc
	join Course c
	on mc.CourseId = c.CourseId
	where c.CourseId = @CourseId

	delete c
	from Course c 
	where c.CourseId = @CourseId
end
go



