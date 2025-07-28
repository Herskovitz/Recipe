create or alter proc MeasurementDelete(
	@MeasurementId int = 0
)
as
begin
	delete ri
	from Measurement m
	join RecipeIngredient ri
	on m.MeasurementId = ri.MeasurementId
	where m.MeasurementId = @MeasurementId

	delete m
	from Measurement m
	where m.MeasurementId = @MeasurementId
end
go

