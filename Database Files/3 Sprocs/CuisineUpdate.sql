create or alter proc CuisineUpdate(
	@CuisineId int = 0,
	@CuisineType varchar(30) = ''
)
as
begin

select @CuisineId = isnull(@CuisineId,0)

	if @CuisineId = 0
	begin
		insert Cuisine(CuisineType)
		values (@CuisineType)

		select @CuisineId = scope_identity()
	end

	else
		begin
			update Cuisine
			set 
			CuisineType = @CuisineType
			where CuisineId = @CuisineId
		end
end
go 
