create or alter proc RecipeChangeStatus(
	@RecipeId int = 0,
	@DateDrafted datetime = '01/01/2000' output,
	@DatePublished datetime = '01/01/2000' output,
	@DateArchived datetime = '01/01/2000' output,
	@RecipeStatus varchar(9) = '' output
)
as
begin

declare @return int = 0

if @DateArchived = '12/31/9999'
	begin
		update Recipe
		set DateArchived = getdate()
		where RecipeId = @RecipeId
	end
if @DatePublished = '12/31/9999'
	begin
		update Recipe
		set 
		DatePublished = getdate(),
		DateArchived = null
		where RecipeId = @RecipeId
	end
if @DateDrafted = '12/31/9999'
	begin
		update Recipe
		set
		DateDrafted = getdate(),
		DatePublished = null,
		DateArchived = null
		where RecipeId = @RecipeId
	end
return @return
end
go



