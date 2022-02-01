CREATE TABLE [dbo].[users] (
    [Id]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NOT NULL,
    [LastName]  NVARCHAR (MAX) NOT NULL,
    [Age]       INT            NOT NULL,
    CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED ([Id] ASC)
);

