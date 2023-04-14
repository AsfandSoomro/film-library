CREATE TABLE [dbo].[Movies_Distributors] (
    [id]             INT NOT NULL,
    [movie_id]       INT NOT NULL,
    [distributor_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Distributors_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Distributors_Companies] FOREIGN KEY ([distributor_id]) REFERENCES [dbo].[Companies] ([company_id]) ON DELETE CASCADE
);

