create or alter proc CookbookUpdate(
	@CookbookId int = 0 output,
	@CookbookName varchar(100) = '',
	@Price decimal (5,2) = 0,
	@DateCreated date = getdate,
	@Active bit = 0,
	@UserId int = 0
)
as
begin	
	declare @return bit = 0
	select @CookbookId = isnull(@CookbookId,0)
	select @Active = isnull(@Active,0)

	if @CookbookId = 0
		begin
			insert Cookbook(UserId,CookbookName,Price,DateCreated,Active)
			values(@UserId,@CookbookName,@Price,getdate(),@Active)

			select @CookbookId = scope_identity();
		end
	else
		begin
			update Cookbook
			set
			UserId = @UserId,
			CookbookName = @CookbookName,
			Price = @Price,
			DateCreated = @DateCreated,
			Active = @Active	
			where CookbookId = @CookbookId
		end
	return @return
end
go
