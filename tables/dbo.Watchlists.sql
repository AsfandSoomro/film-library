CREATE TABLE [dbo].[Watchlists]
(
	[watchlist_id] INT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [title] VARCHAR(100) DEFAULT 'Your Watchlist' NOT NULL, 
    [owner_id] INT NOT NULL, 
    [visibility] VARCHAR(32) DEFAULT 'private' NOT NULL, 
    CONSTRAINT [FK_Watchlists_Users] FOREIGN KEY ([owner_id]) REFERENCES [Users]([user_id]), 
    CONSTRAINT [CK_Watchlists_visibility] CHECK (visibility IN('private', 'public'))
)
