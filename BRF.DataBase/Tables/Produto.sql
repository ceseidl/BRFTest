CREATE TABLE [dbo].[Produto]
(
	[Id]        UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [FornecedorId]        UNIQUEIDENTIFIER  NOT NULL,
    [NOME]    VARCHAR (200)    NOT NULL,
    [CreatedAt] DATETIME         NULL,
    [UpdatedAt] DATETIME         NULL,
    [Deleted]   BIT              CONSTRAINT [DF_Produto_Deleted] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Fornecedor_Produto] FOREIGN KEY ([FornecedorId]) REFERENCES [dbo].[Fornecedor] ([Id])
)
