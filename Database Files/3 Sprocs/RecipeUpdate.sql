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
	@RecipeStatus varchar(9) output,
	@DateDraftedAsDateOnly varchar(10) output
	)
as
begin
	declare @return int = 0

	select @RecipeId = isnull(@RecipeId,0), @CuisineId = nullif(@CuisineId,0), 
														@UserId = nullif(@UserId,0)

if @RecipeId = 0
begin
	select @DateDrafted = getdate()

	insert Recipe(CuisineId, UserId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
	values (@CuisineId, @UserId, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived)

	select @RecipeId = scope_identity()
	select @RecipeStatus = r.RecipeStatus from Recipe r where r.RecipeId = @RecipeId
	select @DateDraftedAsDateOnly = convert(varchar(10),@DateDrafted,101)
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

