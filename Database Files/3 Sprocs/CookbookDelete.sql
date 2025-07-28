create or alter proc CookbookDelete(
	@CookbookId int = 0
)
as 
begin
	declare @return int = 0

	delete cr
	from CookbookRecipe cr
	join Cookbook c
	on cr.CookbookId = c.CookbookId
	where c.CookbookId = @CookbookId

	delete c
	from Cookbook c
	where c.CookbookId = @CookbookId

	return @return
end