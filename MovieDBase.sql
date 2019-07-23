-- Movie class
CREATE DATABASE MVCMovies

GO

USE MVCMovies
GO

CREATE TABLE Movies
(
	MovieID			int						PRIMARY KEY IDENTITY
	, Title			varchar(80)	NOT NULL
	, Director		varchar(60) NOT NULL
	, YearReleased	smallint		
	, Genre			varchar(30)	
	, IMDBRating	decimal
)