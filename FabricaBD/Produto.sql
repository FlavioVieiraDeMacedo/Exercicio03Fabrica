CREATE TABLE [dbo].[Produto]
(
	[ProdutoId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DataCadastro] DATETIME NOT NULL, 
    [Valor] DECIMAL NOT NULL, 
    [Descricao] NVARCHAR(255) NULL, 
    [Titulo] NVARCHAR(150) NOT NULL, 
    [Nacional] BIT NOT NULL
)


