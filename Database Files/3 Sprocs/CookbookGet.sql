create or alter proc CookbookGet(
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = ' ' output
)
as
begin
	select c.CookbookId, c.CookbookName, u.Username, NumOfRecipes = count(cr.RecipeId), c.Price, u.UserId,c.DateCreated, c.Active
	from Cookbook c
	join Users u
	on u.UserId = c.UserId
	left join CookbookRecipe cr
	on c.CookbookId = cr.CookbookId
	left join Recipe r
	on cr.RecipeId = r.RecipeId
	where c.CookbookId = @CookbookId
	or @All = 1
	group by c.CookbookId, c.CookbookName, u.Username, u.UserId,c.Price, c.DateCreated, c.Active
	
end
go

--exec CookbookGet @All = 1

