CREATE TABLE [dbo].[Languages] (
    [language_id] INT          NOT NULL,
	[language_code] VARCHAR(50) NOT NULL, 
    [name]        VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([language_id] ASC)
);

