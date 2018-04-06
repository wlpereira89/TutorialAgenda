CREATE TABLE [dbo].[Pessoas]
(
	[UserID] UNIQUEIDENTIFIER NOT NULL, 
	[Email] VARCHAR(50) NOT NULL , 
    [Nome] VARCHAR(50) NULL, 
    [Idade] INT NULL,     
    PRIMARY KEY ([UserID])
)
