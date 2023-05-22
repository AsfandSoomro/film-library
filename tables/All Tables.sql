CREATE TABLE [dbo].[Users] (
    [user_id]       INT          IDENTITY (1, 1) NOT NULL,
    [username]      VARCHAR (32) NOT NULL,
    [password]      VARCHAR (50) NOT NULL,
    [email]         VARCHAR (50) NULL,
    [first_name]    VARCHAR (32) NULL,
    [last_name]     VARCHAR (32) NULL,
    [dob]           DATE         NOT NULL,
    [register_date] DATE         NOT NULL,
    [status]        VARCHAR (32) DEFAULT ('user') NOT NULL,
    [profile_photo] VARBINARY(MAX) NULL, 
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);


CREATE TABLE [dbo].[Watchlists] (
    [watchlist_id] INT           IDENTITY (1, 1) NOT NULL,
    [title]        VARCHAR (100) DEFAULT ('Your Watchlist') NOT NULL,
	[cover] VARBINARY(MAX) NULL, 
	[visibility]   VARCHAR (32)  DEFAULT ('private') NOT NULL,
    [owner_id]     INT           NOT NULL,
    [creation_date] DATE NOT NULL,
    PRIMARY KEY CLUSTERED ([watchlist_id] ASC),
    CONSTRAINT [FK_Watchlists_Users] FOREIGN KEY ([owner_id]) REFERENCES [dbo].[Users] ([user_id])
);


CREATE TABLE [dbo].[Movies] (
    [movie_id]                   INT    IDENTITY(1, 1)         NOT NULL,
    [imdb_id]                    VARCHAR (50)    NULL,
    [title]                      VARCHAR (100)   NOT NULL,
    [plot_outline]               VARCHAR (4000)  NULL,
    [release_year]               INT             NOT NULL,
    [rating]                     DECIMAL (18, 2) DEFAULT (0.0) NULL,
    [votes]                      BIGINT          DEFAULT (0) NULL,
    [cover]                      VARBINARY (MAX) NULL,
    [budget]                     BIGINT          NULL,
    [cumulative_worldwide_gross] BIGINT          NULL,
    PRIMARY KEY CLUSTERED ([movie_id] ASC),
    UNIQUE NONCLUSTERED ([imdb_id] ASC)
);


CREATE TABLE [dbo].[Genres] (
    [genre_id] INT          NOT NULL,
    [name]     VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([genre_id] ASC)
);


CREATE TABLE [dbo].[Countries] (
    [country_id]   INT           NOT NULL,
    [country_code] VARCHAR (50)  NOT NULL,
    [name]         VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([country_id] ASC),
    UNIQUE NONCLUSTERED ([country_code] ASC)
);


CREATE TABLE [dbo].[Languages] (
    [language_id] INT          NOT NULL,
	[language_code] VARCHAR(50) NOT NULL, 
    [name]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([language_id] ASC)
);


CREATE TABLE [dbo].[Persons] (
    [person_id] INT NOT NULL,
    [imdb_id]   VARCHAR (50)  NOT NULL,
    [name]      VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([person_id] ASC)
);

CREATE TABLE [dbo].[Companies] (
    [company_id] INT           NOT NULL,
    [imdb_id]    VARCHAR (50)  NOT NULL,
    [name]       VARCHAR (300) NOT NULL,
    PRIMARY KEY CLUSTERED ([company_id] ASC)
);

CREATE TABLE [dbo].[Watchlists_Movies]
(
	[id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [watchlist_id] INT NOT NULL, 
    [movie_id] INT NOT NULL, 
    [add_date] DATE NOT NULL, 
    CONSTRAINT [FK_WatchlistsMovies_Watchlists] FOREIGN KEY ([watchlist_id]) REFERENCES [dbo].[Watchlists]([watchlist_id]), 
    CONSTRAINT [FK_WatchlistsMovies_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies]([movie_id])
)


CREATE TABLE [dbo].[Movies_Cast] (
    [id]       INT NOT NULL,
    [movie_id] INT NOT NULL,
    [cast_id]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Cast_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Cast_Persons] FOREIGN KEY ([cast_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Directors] (
    [id]          INT NOT NULL,
    [movie_id]    INT NOT NULL,
    [director_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Directors_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id])  ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Directors_Persons] FOREIGN KEY ([director_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Companies] (
    [id]         INT NOT NULL,
    [movie_id]   INT NOT NULL,
    [company_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Companies_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id])  ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Companies_Companies] FOREIGN KEY ([company_id]) REFERENCES [dbo].[Companies] ([company_id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Countries] (
    [id]         INT NOT NULL,
    [movie_id]   INT NOT NULL,
    [country_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Countries_Countries] FOREIGN KEY ([country_id]) REFERENCES [dbo].[Countries] ([country_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Countries_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Distributors] (
    [id]             INT NOT NULL,
    [movie_id]       INT NOT NULL,
    [distributor_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Distributors_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Distributors_Companies] FOREIGN KEY ([distributor_id]) REFERENCES [dbo].[Companies] ([company_id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Genres] (
    [id]       INT NOT NULL,
    [movie_id] INT NOT NULL,
    [genre_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Genres_Genres] FOREIGN KEY ([genre_id]) REFERENCES [dbo].[Genres] ([genre_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Genres_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Languages] (
    [id]          INT NOT NULL,
    [movie_id]    INT NOT NULL,
    [language_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Languages_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id])  ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Languages_Languages] FOREIGN KEY ([language_id]) REFERENCES [dbo].[Languages] ([language_id])  ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Producers] (
    [id]          INT NOT NULL,
    [movie_id]    INT NULL,
    [producer_id] INT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Producers_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Producers_Persons] FOREIGN KEY ([producer_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Movies_Writers] (
    [id]        INT NOT NULL,
    [movie_id]  INT NOT NULL,
    [writer_id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Movies_Writers_Movies] FOREIGN KEY ([movie_id]) REFERENCES [dbo].[Movies] ([movie_id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Movies_Writers_Persons] FOREIGN KEY ([writer_id]) REFERENCES [dbo].[Persons] ([person_id]) ON DELETE CASCADE
);






