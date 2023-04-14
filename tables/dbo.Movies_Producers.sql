CREATE TABLE [dbo].[Movies_Producers] (
    [id]          INT NOT NULL,
    [movie_id]    INT NULL,
    [producer_id] INT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Producers_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Producers_Persons] FOREIGN KEY ([producer_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);

