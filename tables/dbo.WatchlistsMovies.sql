CREATE TABLE [dbo].[Watchlists_Movies]
(
	[id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [watchlist_id] INT NOT NULL, 
    [movie_id] INT NOT NULL, 
    [add_date] DATE DEFAULT (CONVERT([date],getdate())) NOT NULL, 
    CONSTRAINT [FK_WatchlistsMovies_Watchlists] FOREIGN KEY ([watchlist_id]) REFERENCES [Watchlists]([watchlist_id]), 
    CONSTRAINT [FK_WatchlistsMovies_Movies] FOREIGN KEY ([movie_id]) REFERENCES [Movies]([movie_id])
)
