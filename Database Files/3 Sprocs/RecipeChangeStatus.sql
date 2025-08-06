--AS Why are you using all these hardcoded dates? Whenever a button is clicked update that date to current date, what are all these dates about? (*)
create or alter proc RecipeChangeStatus(
	@RecipeId int = 0,
	@DateDrafted datetime = null  output,
	@DatePublished datetime null output,
	@DateArchived datetime null output,
	@RecipeStatus varchar(9) = '' output
)
as
begin

declare @return int = 0

select nullif(@DateDrafted,''), nullif(@DatePublished,''), nullif(@DateArchived,'')

if @DateArchived is not null
	begin
		update Recipe
		set DateArchived = getdate()
		where RecipeId = @RecipeId
	end
if @DatePublished is not null
	begin
		update Recipe
		set 
		DatePublished = getdate(),
		DateArchived = null
		where RecipeId = @RecipeId
	end
if @DateDrafted is not null
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
