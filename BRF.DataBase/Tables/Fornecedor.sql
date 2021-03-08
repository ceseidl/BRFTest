CREATE TABLE [dbo].[Fornecedor]
(
	[Id]        UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [NOME]    VARCHAR (200)    NOT NULL,
    [CreatedAt] DATETIME         NULL,
    [UpdatedAt] DATETIME         NULL,
    [Deleted]   BIT              CONSTRAINT [DF_Fornecedor_Deleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Fornecedor] PRIMARY KEY CLUSTERED ([Id] ASC),
    
)
