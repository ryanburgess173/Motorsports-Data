/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [SeriesID]
      ,[SeriesName]
      ,[CarTypeID]
      ,[SeriesYear]
  FROM [racingStatistics].[dbo].[Series]


  SELECT * FROM CarTypes;