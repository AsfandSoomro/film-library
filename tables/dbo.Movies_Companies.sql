CREATE TABLE [dbo].[Movies_Companies] (
    [id]         INT NOT NULL,
    [movie_id]   INT NOT NULL,
    [company_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Companies_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id])  ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Companies_Companies] FOREIGN KEY ([company_id]) REFERENCES [dbo].[Companies] ([company_id]) ON DELETE CASCADE
);

