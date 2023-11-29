CREATE TABLE [dbo].[Products] (
    [Id]                INT             IDENTITY (1, 1) NOT NULL,
    [Category]          NVARCHAR (MAX)  NOT NULL,
    [Size]              NVARCHAR (MAX)  NOT NULL,
    [Price]             DECIMAL (18, 2) NOT NULL,
    [Title]             NVARCHAR (MAX)  NOT NULL,
    [ArtDescription]    NVARCHAR (MAX)  NULL,
    [ArtDating]         NVARCHAR (MAX)  NOT NULL,
    [ArtId]             NVARCHAR (MAX)  NOT NULL,
    [Artist]            NVARCHAR (MAX)  NOT NULL,
    [ArtistBirthDate]   DATETIME2 (7)   NOT NULL,
    [ArtistDeathDate]   DATETIME2 (7)   NOT NULL,
    [ArtistNationality] NVARCHAR (MAX)  NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC)
);

