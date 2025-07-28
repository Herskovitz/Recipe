create or alter proc CourseUpdate(
	@CourseId int = 0,
	@CourseType varchar(30) = '',
	@CourseSequence int = 0,
	@All int = 0,
	@IncludeBlank int = 0
)
as
begin

	select @CourseId = isnull(@CourseId, 0)

	if @CourseId = 0
		begin
			insert Course(CourseType, CourseSequence)
			values (@CourseType, @CourseSequence)

			select @CourseId = scope_identity()
		end
	else
		begin
			update Course 
			set
			CourseType = @CourseType,
			CourseSequence = @CourseSequence
			where CourseId = @CourseId
		end
end
go
