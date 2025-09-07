create or alter proc dbo.RecipeUpdate
(
	@RecipeId int output,
	@RecipeName varchar (100),
	@CuisineId int ,
	@UserId int ,
	@Calories int ,
	@DateDrafted datetime output,
	@DatePublished datetime,
	@DateArchived datetime,
	@RecipeStatus varchar(9) output
	)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0), @CuisineId = nullif(@CuisineId,0), 
														@UserId = nullif(@UserId,0)

if @RecipeId = 0
begin
	select @DateDrafted = convert(varchar,getdate(),101)

	insert Recipe(CuisineId, UserId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
	values (@CuisineId, @UserId, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived)

	select @RecipeId = scope_identity()
	select @RecipeStatus = r.RecipeStatus from Recipe r where r.RecipeId = @RecipeId
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

