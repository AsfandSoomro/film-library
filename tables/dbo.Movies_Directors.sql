CREATE TABLE [dbo].[Movies_Directors] (
    [id]          INT NOT NULL,
    [movie_id]    INT NOT NULL,
    [director_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Directors_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id])  ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Directors_Persons] FOREIGN KEY ([director_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);

