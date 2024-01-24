/*
INSERT INTO Series
(
	SeriesName,
	CarTypeID,
	SeriesYear
)
VALUES
(
	'NASCAR Cup Series',
	1,

),
(
	'Formula 1',
	2,
	2022
);
*/
SELECT * FROM Series;

EXEC sp_help Series;

DECLARE @smalldatetime smalldatetime = '01-01-22 00:01';  
DECLARE @datetime datetime = @smalldatetime;  

UPDATE Series
SET SeriesYear = @datetime
WHERE SeriesID = 1;