CREATE TABLE [dbo].[Movies_Genres] (
    [id]       INT NOT NULL,
    [movie_id] INT NOT NULL,
    [genre_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Genres_Genres] FOREIGN KEY ([genre_id]) REFERENCES [dbo].[Genres] ([genre_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Genres_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE
);

