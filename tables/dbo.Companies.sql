CREATE TABLE [dbo].[Companies] (
    [company_id] INT           NOT NULL,
    [imdb_id]    VARCHAR (50)  NOT NULL,
    [name]       VARCHAR (300) NOT NULL,
    PRIMARY KEY CLUSTERED ([company_id] ASC)
);

