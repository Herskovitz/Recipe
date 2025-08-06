create or alter proc CookbookAutoCreate(
	@UserId int = 0,
	@CookbookId int = 0 output,
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin	
	declare @return int = 0

	if not exists(select * from Recipe r join users u on u.UserId = r.userid where u.UserId = @UserId)
	begin
	select @return = 1, @Message = 'Cannot create a cookbook for this user because they have no recipes.'
	goto finished
	end

	begin try
	begin tran

	insert Cookbook(UserId,CookbookName,Price,Active)
	select u.UserId, concat('Recipes by ',u.UserFirstName,' ',u.UserLastName),(count(r.RecipeId) * 1.33),1
	from Recipe r
	join Users u
	on r.UserId = u.UserId
	where u.UserId = @UserId
	group by u.UserId, u.UserFirstName, u.UserLastName
	
	select @CookbookId = scope_identity();

	;
	with x as (
		select r.RecipeId, row_number() over (order by r.RecipeName) as RecipeSequence 
		from Recipe r 
		where r.UserId = @UserId
	)
	insert CookbookRecipe(CookbookId,RecipeId,RecipeSequence)
	select @CookbookId, x.RecipeId, x.RecipeSequence
	from x
	
	commit
	end try
	begin catch
	rollback;
	throw
	end catch

	finished:
	return @return
end
go


--declare
--@i int,
--@RecipeId int,
--@CookbookId int,
--@UserId int,
--@m varchar(500)

--select @UserId = (select top 1 UserId from Users)

--exec
--@i = CookbookAutoCreate
--@RecipeId = @RecipeId,
--@UserId = @UserId,
--@CookbookId = @CookbookId,
--@Message = @m output

--select @i, @m



