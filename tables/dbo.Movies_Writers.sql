CREATE TABLE [dbo].[Movies_Writers] (
    [id]        INT NOT NULL,
    [movie_id]  INT NOT NULL,
    [writer_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Writers_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Writers_Persons] FOREIGN KEY ([writer_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);

