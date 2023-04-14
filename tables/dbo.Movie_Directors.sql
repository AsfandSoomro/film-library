CREATE TABLE [dbo].[Movies_Directors]
(
	[id] INT NOT NULL PRIMARY KEY, 
    [movie_id] INT NOT NULL, 
    [director_id] INT NOT NULL, 
    CONSTRAINT [FK_Movies_Directors_Movies] FOREIGN KEY ([movie_id]) REFERENCES [Movies]([movie_id]), 
    CONSTRAINT [FK_Movies_Directors_Persons] FOREIGN KEY ([director_id]) REFERENCES [Persons]([person_id])
)
