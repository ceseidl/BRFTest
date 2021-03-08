CREATE PROCEDURE [dbo].[GetFornecedoresProdutos]

AS
	SELECT FORN.NOME , PROD.NOME FROM Fornecedor AS FORN
	INNER JOIN Produto AS PROD ON FORN.Id = PROD.FornecedorId


GO




	

