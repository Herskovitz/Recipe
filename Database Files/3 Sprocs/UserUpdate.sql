create or alter proc UserUpdate(
	@UserId int = 0,
	@UserFirstName varchar(20) = '',
	@UserLastName varchar(30) = '',
	@Username varchar(20) = ''
)
as
begin

	select @UserId = isnull(@UserId, 0)

	if @UserId = 0
		begin
			insert Users (UserFirstName,UserLastName,Username)
			values (@UserFirstName,@UserLastName,@Username)

			select @UserId = scope_identity()
		end
	else
		begin
			update Users
			set
			UserFirstName = @UserFirstName,
			UserLastName = @UserLastName,
			Username = @Username
			where UserId = @UserId
		end
end
go
