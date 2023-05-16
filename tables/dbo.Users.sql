CREATE TABLE [dbo].[Users] (
    [user_id]       INT          IDENTITY (1, 1) NOT NULL,
    [username]      VARCHAR (32) NOT NULL,
    [email]         VARCHAR (50) NULL,
    [first_name]    VARCHAR (32) NULL,
    [last_name]     VARCHAR (32) NULL,
    [dob]           DATE         NOT NULL,
    [register_date] DATE         DEFAULT (CONVERT([date],getdate())) NOT NULL,
    [status] VARCHAR(32) DEFAULT 'user' CHECK(status IN ('user', 'admin', 'owner')) NOT NULL, 
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);

