CREATE TABLE [dbo].[Movies_Cast] (
    [id]       INT NOT NULL,
    [movie_id] INT NOT NULL,
    [cast_id]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Cast_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Cast_Persons] FOREIGN KEY ([cast_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);

