create or alter procedure CuisineGet(@CuisineId int = 0, @CuisineType varchar(30) = '', @All bit = 0)
as
begin
	select @CuisineType = nullif(@CuisineType, '')
	select c.CuisineId, C.CuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineType like '%' + @CuisineType + '%'
end
go

exec CuisineGet

exec CuisineGet @All = 1

declare @CId int
select top 1 @CId = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @CId

exec CuisineGet @CuisineType = 'an'