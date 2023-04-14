CREATE TABLE [dbo].[Countries] (
    [country_id]   INT           NOT NULL,
    [country_code] VARCHAR (50)  NOT NULL,
    [name]         VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([country_id] ASC),
    UNIQUE NONCLUSTERED ([country_code] ASC)
);

