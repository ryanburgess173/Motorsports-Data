CREATE PROCEDURE InsertANewSeries @SeriesName nvarchar(80), @CarTypeID int, @Year int
AS
	DECLARE @date date = CAST(@Year AS nvarchar(4)) + '-12-21';
	DECLARE @datetime datetime = @date;

	INSERT INTO Series
	(
		SeriesName,
		CarTypeID,
		SeriesYear
	)
	VALUES(
		@SeriesName,
		@CarTypeID,
		@datetime
	)
GO