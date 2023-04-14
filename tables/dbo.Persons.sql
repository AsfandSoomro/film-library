CREATE TABLE [dbo].[Persons] (
    [person_id] INT NOT NULL,
    [imdb_id]   VARCHAR (50)  NOT NULL,
    [name]      VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([person_id] ASC)
);

