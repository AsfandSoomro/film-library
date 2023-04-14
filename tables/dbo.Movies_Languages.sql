CREATE TABLE [dbo].[Movies_Languages] (
    [id]          INT NOT NULL,
    [movie_id]    INT NOT NULL,
    [language_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Languages_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id])  ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Languages_Languages] FOREIGN KEY ([language_id]) REFERENCES [dbo].[Languages] ([language_id])  ON DELETE CASCADE
);

