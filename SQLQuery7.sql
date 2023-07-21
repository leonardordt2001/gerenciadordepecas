USE [C:\USERS\LEONARDO.SARAUJO8\SOURCE\REPOS\GERENCIADORDEPECAS\GERENCIADORDEPECAS\MODEL\PECASBD.MDF]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[pDeletarPecas]
		@idPecas = 1

SELECT	@return_value as 'Return Value'

GO
