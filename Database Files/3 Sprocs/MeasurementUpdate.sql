create or alter proc MeasurementUpdate(
	@MeasurementId int = 0,
	@MeasurementType varchar(30) = '',
	@All int = 0,
	@IncludeBlank int = 0
)
as
begin

	select @MeasurementId = isnull(@MeasurementId, 0)

	if @MeasurementId = 0
		begin
			insert Measurement(MeasurementType)
			values (@MeasurementType)

			select @MeasurementId = scope_identity()
		end
	else
		begin
			update Measurement 
			set
			MeasurementType = @MeasurementType
			where MeasurementId = @MeasurementId
		end
end
go
