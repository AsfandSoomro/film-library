CREATE TABLE [dbo].[Movies_Countries] (
    [id]         INT NOT NULL,
    [movie_id]   INT NOT NULL,
    [country_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Countries_Countries] FOREIGN KEY ([country_id]) REFERENCES [dbo].[Countries] ([country_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Countries_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE
);

