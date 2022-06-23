SELECT dbo.USUARIO.Nome, dbo.CONTA.ID_Conta, dbo.CONTA.NIF_Usuario
FROM     dbo.CONTA INNER JOIN
                  dbo.USUARIO ON dbo.CONTA.NIF_Usuario = dbo.USUARIO.NIF