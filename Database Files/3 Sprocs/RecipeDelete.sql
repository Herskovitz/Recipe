create or alter procedure dbo.RecipeDelete(
	@RecipeId int, 
	@Message varchar(500) = '' output)
as
begin
	declare @return int = 0
	if not exists (select * from Recipe r where r.RecipeId = @RecipeId and (r.RecipeStatus like 'Draft' or (datediff(day,r.DateArchived,getdate()) > 30)))
	begin
		select @return = 1, @Message = 'A recipe may only be deleted if it is archived for over 30 days or is currently in Draft status.'
	goto finish
end
begin try
	begin tran
		
		delete MealCourseRecipe where RecipeId = @RecipeId
		delete CookbookRecipe where RecipeId = @RecipeId
		delete RecipeDirection where RecipeId = @RecipeId
		delete RecipeIngredient where RecipeId = @RecipeId
		delete Recipe where RecipeId = @RecipeId
	commit
end try
begin catch
		rollback
		;
		throw
end catch
	finish:
	return @return
end
go

