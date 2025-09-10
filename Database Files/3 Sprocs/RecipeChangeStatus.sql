--AS Why are you using all these hardcoded dates? Whenever a button is clicked update that date to current date, what are all these dates about? (*)
create or alter proc RecipeChangeStatus(
	@RecipeId int = 0,
	@DateDrafted datetime = null output,
	@DatePublished datetime = null output,
	@DateArchived datetime = null output,
	@RecipeStatus varchar(9) = '' output
)
as
begin

declare @return int = 0
declare @currentdate datetime = getdate()

select nullif(@DateDrafted,''), nullif(@DatePublished,''), nullif(@DateArchived,''), isnull(@RecipeStatus,'')

if @DateArchived is not null
	begin
		update Recipe
		set DateArchived = @currentdate
		where RecipeId = @RecipeId
	end
if @DatePublished is not null
	begin
		update Recipe
		set 
		DatePublished = @currentdate,
		DateArchived = null
		where RecipeId = @RecipeId
	end
if @DateDrafted is not null
	begin
		update Recipe
		set
		DateDrafted = @currentdate,
		DatePublished = null,
		DateArchived = null
		where RecipeId = @RecipeId
	end	
		select @DateDrafted = r.DateDrafted from Recipe r where r.RecipeId = @RecipeId
		select @DatePublished = r.DatePublished from Recipe r where r.RecipeId = @RecipeId
		select @DateArchived = r.DateArchived from Recipe r where r.RecipeId = @RecipeId
return @return
end
go

--exec RecipeChangeStatus
--@RecipeId = 11,
--@DateDrafted = null,
--@DatePublished = null,
--@DateArchived = '9/8/2025 9:04:48 PM',
--@RecipeStatus = null

