create or alter procedure dbo.UserGet(@UserId int = 0, @Username varchar(20) = '', @All bit = 0)
as
begin
	select @Username = nullif(@Username, '')
	select u.UserId,u.Username,u.UserFirstName, u.UserLastName
	from Users u
	where u.UserId = @UserId
	or u.Username like '%' + @Username + '%'
	or @All = 1
end
go

exec UserGet

declare @UId int
select top 1 @UId = u.UserId from Users u
exec UserGet @UserId = @UId

exec UserGet @Username = 'n'
exec userGet @Username = 'r'

exec UserGet @All = 1

