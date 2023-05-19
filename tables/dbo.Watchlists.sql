CREATE TABLE [dbo].[Watchlists] (
    [watchlist_id] INT           IDENTITY (1, 1) NOT NULL,
    [title]        VARCHAR (100) DEFAULT ('Your Watchlist') NOT NULL,
	[cover] VARBINARY(MAX) NULL, 
	[visibility]   VARCHAR (32)  DEFAULT ('private') NOT NULL,
    [owner_id]     INT           NOT NULL,
    [creation_date] DATE DEFAULT (CONVERT([date],getdate())) NOT NULL,
    PRIMARY KEY CLUSTERED ([watchlist_id] ASC),
    CONSTRAINT [FK_Watchlists_Users] FOREIGN KEY ([owner_id]) REFERENCES [dbo].[Users] ([user_id]),
    CONSTRAINT [CK_Watchlists_visibility] CHECK ([visibility]='public' OR [visibility]='private')
);

