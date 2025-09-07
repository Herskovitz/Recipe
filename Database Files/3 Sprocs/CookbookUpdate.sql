create or alter proc CookbookUpdate(
	@CookbookId int = 0 output,
	@CookbookName varchar(100) = '' output,
	@Price decimal (5,2) = 0 output,
	@DateCreated date output,
	@Active bit = 0 output,
	@UserId int = 0 output
)
as
begin	
	declare @return bit = 0
	select @CookbookId = isnull(@CookbookId,0)
	select @Active = isnull(@Active,0)

	if @CookbookId = 0
		begin
			
			select @DateCreated = getdate()

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
