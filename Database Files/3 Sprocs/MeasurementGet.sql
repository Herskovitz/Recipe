create or alter proc dbo.MeasurementGet(
	@MeasurementId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ' ' output
)
as
begin
	declare @return int = 0

	select @MeasurementId = isnull(@MeasurementId,0), @RecipeId = isnull(@RecipeId,0), @All = isnull(@All,0), 
																						@IncludeBlank = isnull(@IncludeBlank,0)

	select m.MeasurementId, m.MeasurementType
	from Measurement m
	where 
	@All = 1
	union select 0,''
	where @IncludeBlank = 1
	order by m.MeasurementType 

	return @return
end
go

--exec MeasurementGet @All = 1