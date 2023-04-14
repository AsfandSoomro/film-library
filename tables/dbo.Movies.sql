CREATE TABLE [dbo].[Movies] (
    [movie_id]                   INT             NOT NULL,
    [imdb_id]                    VARCHAR (50)    NOT NULL,
    [title]                      VARCHAR (100)   NOT NULL,
    [plot_outline]               VARCHAR (4000)  NULL,
    [release_year]               INT             NOT NULL,
    [rating]                     DECIMAL (18, 2) DEFAULT ((0.0)) NOT NULL,
    [votes]                      BIGINT          DEFAULT ((0)) NOT NULL,
    [cover]                      VARBINARY (MAX) NULL,
    [budget]                     BIGINT          NULL,
    [cumulative_worldwide_gross] BIGINT          NULL,
    PRIMARY KEY CLUSTERED ([movie_id] ASC),
    UNIQUE NONCLUSTERED ([imdb_id] ASC),
    CONSTRAINT [CK_Movies_rating] CHECK ([rating] >= (0.0)
                                             AND [rating] <= (10.0)),
    CONSTRAINT [CK_Movies_release_year] CHECK ([release_year] > (0))
);

