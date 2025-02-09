create or alter proc dbo.RecipeUpdate
(
	@RecipeId int output,
	@RecipeName varchar (100),
	@CuisineId int ,
	@UserId int ,
	@Calories int ,
	@DateDrafted datetime ,
	@DatePublished datetime ,
	@DateArchived datetime
)
as
begin
	declare @return int = 0

	select @CuisineId = nullif(@CuisineId,0), @UserId = nullif(@UserId,0)	
if @RecipeId = 0
begin
	insert Recipe(CuisineId, UserId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
	values (@CuisineId, @UserId, @RecipeName, @Calories, getdate(), @DatePublished, @DateArchived)

	select @RecipeId = scope_identity()
end
else
begin
	update Recipe
	set
	CuisineId = @CuisineId, 
	UserId = @UserId, 
	RecipeName = @RecipeName, 
	Calories = @Calories, 
	DateDrafted = @DateDrafted, 
	DatePublished = @DatePublished, 
	DateArchived = @DateArchived
	where RecipeId = @RecipeId
end
return @return
end

