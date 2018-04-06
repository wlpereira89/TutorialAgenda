CREATE TABLE [dbo].[Contatos]
(
	[Email] VARCHAR(50) NOT NULL , 
    [TipoContato] INT NOT NULL, 
    [telefone] NCHAR(16) NULL, 
    PRIMARY KEY ([Email], [TipoContato])
)
