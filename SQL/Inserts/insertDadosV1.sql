DECLARE @Var1 VARCHAR(9)
DECLARE @Var2 VARCHAR(9)
DECLARE @Var3 VARCHAR(9)
DECLARE @Var4 VARCHAR(9)
DECLARE @Var5 VARCHAR(9)
DECLARE @Var6 VARCHAR(9)
DECLARE @Var7 VARCHAR(9) = 100
DECLARE @Var8 VARCHAR(9)
DECLARE @Var9 VARCHAR(9)
DECLARE @Var10 VARCHAR(9)
DECLARE @Var11 VARCHAR(9)
DECLARE @Var12 VARCHAR(9)

DECLARE @i int = 0
DECLARE @U int = 1
DECLARE @Y INT = 0
DECLARE @X int = 0
DECLARE @P INT = 0


WHILE @i < 5
BEGIN
SET @i = @i + 1
SET @Var1 =CAST(FLOOR(RAND() * (999999999 + 1 -  100000000))AS INT)
SET @Var2 =CAST(FLOOR(RAND() * (999999999 + 1 -  100000000))AS INT)
SET @Var3 =CAST(FLOOR(RAND() * (999999999 + 1 -  100000000))AS INT)
SET @Var4 =CAST(FLOOR(RAND() * (999999999 + 1 -  100000000))AS INT)
SET @Var5 =CAST(FLOOR(RAND() * (999999999 + 1 -  100000000))AS INT)
SET @Var6 =CAST(FLOOR(RAND() * (999999999 + 1 -  100000000))AS INT)





----------INSERT USUARIOS ALEATORIOS
---------------INSERT DE PLANOS

INSERT INTO PLANO(ID,VALOR,TIPO)
VALUES(@P, 25, 1)

SET @P = @P + 1
INSERT INTO PLANO(ID,VALOR,TIPO)
VALUES(@P, 50, 2)

SET @P = @P + 1
INSERT INTO PLANO(ID,VALOR,TIPO)
VALUES(@P, 75, 3)

SET @P = @P + 1
INSERT INTO PLANO(ID,VALOR,TIPO)
VALUES(@P, 95, 4)

INSERT INTO USUARIO(NIF,Nome,Data_Nasc,SEXO)
VALUES(@Var1,'Alberto Roberto',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'M')

INSERT INTO USUARIO(NIF,Nome,Data_Nasc,SEXO)
VALUES(@Var2,'Maria Da Hora',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'F')	

INSERT INTO USUARIO(NIF,Nome,Data_Nasc,SEXO)
VALUES(@Var3,'Matheus Da Hora',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'M')

INSERT INTO USUARIO(NIF,Nome,Data_Nasc,SEXO)
VALUES(@Var4,'Thiago Brasil',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'M')	

INSERT INTO USUARIO(NIF,Nome,Data_Nasc,SEXO)
VALUES(@Var5,'Marcela Chirol',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'F')

INSERT INTO USUARIO(NIF,Nome,Data_Nasc,SEXO)
VALUES(@Var6,'Juan Lessa',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'M')	


------INSERT DE CONTAS

INSERT INTO CONTA(NIF_Usuario,DATA,ID_Conta)
SELECT NIF, DATEADD(year, 20, Data_Nasc),NIF-700000 FROM USUARIO
WHERE NIF=@Var1


INSERT INTO CONTA(NIF_Usuario,DATA,ID_Conta)
SELECT NIF, DATEADD(year, 20, Data_Nasc),NIF-700000 FROM USUARIO
WHERE NIF=@Var2


INSERT INTO CONTA(NIF_Usuario,DATA,ID_Conta)
SELECT NIF, DATEADD(year, 20, Data_Nasc),NIF-700000 FROM USUARIO
WHERE NIF=@Var3


INSERT INTO CONTA(NIF_Usuario,DATA,ID_Conta)
SELECT NIF, DATEADD(year, 20, Data_Nasc),NIF-700000 FROM USUARIO
WHERE NIF=@Var4

INSERT INTO CONTA(NIF_Usuario,DATA,ID_Conta)
SELECT NIF, DATEADD(year, 20, Data_Nasc),NIF-700000 FROM USUARIO
WHERE NIF=@Var5

INSERT INTO CONTA(NIF_Usuario,DATA,ID_Conta)
SELECT NIF, DATEADD(year, 20, Data_Nasc),NIF-700000 FROM USUARIO
WHERE NIF=@Var6

----INSERT MEIO DE PAGAMENTOS

SET @U = @U + 1
INSERT INTO MEIO_DE_PAGAMENTO(NIF, TIPO, NUMERO)
SELECT NIF, 'Visa' as TIPO, @U AS NUMERO  FROM USUARIO
WHERE NIF = @Var1

SET @U = @U + 1
INSERT INTO MEIO_DE_PAGAMENTO(NIF, TIPO, NUMERO)
SELECT NIF, 'Master Card' as TIPO, @U AS NUMERO  FROM USUARIO
WHERE NIF = @Var2


SET @U = @U + 1
INSERT INTO MEIO_DE_PAGAMENTO(NIF, TIPO, NUMERO)
SELECT NIF, 'AMEX' as TIPO, @U AS NUMERO  FROM USUARIO
WHERE NIF = @Var3

SET @U = @U + 1
INSERT INTO MEIO_DE_PAGAMENTO(NIF, TIPO, NUMERO)
SELECT NIF, 'THIZE' as TIPO, @U AS NUMERO  FROM USUARIO
WHERE NIF = @Var4

SET @U = @U + 1
INSERT INTO MEIO_DE_PAGAMENTO(NIF, TIPO, NUMERO)
SELECT NIF, 'ZETI' as TIPO, @U AS NUMERO  FROM USUARIO
WHERE NIF = @Var5

SET @U = @U + 1
INSERT INTO MEIO_DE_PAGAMENTO(NIF, TIPO, NUMERO)
SELECT NIF, 'PAYPAL' as TIPO, @U AS NUMERO  FROM USUARIO
WHERE NIF = @Var6


SET @Var7 = @Var6 + 1
SET @Var8  = @Var7 + 1 
SET @Var9 = @Var8 + 1
SET @Var10 = @Var9 +1 
SET @Var11 = @Var10 +1 

--INSERT DE VEICULOS


INSERT INTO VEICULO(NOME,KM,Matricula)
VALUES('NISSAN', 10 * RAND() + 100 * RAND(), @Var7)

INSERT INTO VEICULO(NOME,KM,Matricula)
VALUES('CITROEN', 10 * RAND() + 100 * RAND(), @Var8)

INSERT INTO VEICULO(NOME,KM,Matricula)
VALUES('FERRARI', 10 * RAND() + 100 * RAND(), @Var9)

INSERT INTO VEICULO(NOME,KM,Matricula)
VALUES('HONDA', 10 * RAND() + 100 * RAND(), @Var10)

INSERT INTO VEICULO(NOME,KM,Matricula)
VALUES('FIAT', 10 * RAND() + 100 * RAND(), @Var11)

-------CRIA??O DE SUBSCRICOES

INSERT INTO SUBSCRICOES(ID_CONTA,ID_PLANO,MATRICULA_VEICULO,DATA_INICIO,DATA_FIM)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula, DATEADD(year, 20, DATA) AS DATA_INICIO,  DATEADD(year, 21, DATA) AS DATA_FIM  FROM PLANO,CONTA, VEICULO
WHERE ID = @P-3 AND NIF_Usuario = @Var1

INSERT INTO SUBSCRICOES(ID_CONTA,ID_PLANO,MATRICULA_VEICULO,DATA_INICIO,DATA_FIM)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula, DATEADD(year, 20, DATA) AS DATA_INICIO,  DATEADD(year, 21, DATA) AS DATA_FIM  FROM PLANO,CONTA, VEICULO
WHERE ID = @P-2 AND NIF_Usuario = @Var2

INSERT INTO SUBSCRICOES(ID_CONTA,ID_PLANO,MATRICULA_VEICULO,DATA_INICIO,DATA_FIM)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula, DATEADD(year, 20, DATA) AS DATA_INICIO,  DATEADD(year, 21, DATA) AS DATA_FIM  FROM PLANO,CONTA, VEICULO
WHERE ID = @P-1 AND NIF_Usuario = @Var3

INSERT INTO SUBSCRICOES(ID_CONTA,ID_PLANO,MATRICULA_VEICULO,DATA_INICIO,DATA_FIM)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula, DATEADD(year, 20, DATA) AS DATA_INICIO,  DATEADD(year, 21, DATA) AS DATA_FIM  FROM PLANO,CONTA, VEICULO
WHERE ID = @P-2 AND NIF_Usuario = @Var4


--------------CRIA?AO DE POSSUI

INSERT INTO POSSUI(ID_CONTA,ID_PLANO,MATRICULA_VEICULO)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula AS MATRICULA_VEICULO FROM CONTA,PLANO,VEICULO
WHERE ID=@P-3 AND Matricula = @Var7

INSERT INTO POSSUI(ID_CONTA,ID_PLANO,MATRICULA_VEICULO)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula AS MATRICULA_VEICULO FROM CONTA,PLANO,VEICULO
WHERE ID=@P-2 AND Matricula = @Var8

INSERT INTO POSSUI(ID_CONTA,ID_PLANO,MATRICULA_VEICULO)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula AS MATRICULA_VEICULO FROM CONTA,PLANO,VEICULO
WHERE ID=@P-1 AND Matricula = @Var9

INSERT INTO POSSUI(ID_CONTA,ID_PLANO,MATRICULA_VEICULO)
SELECT ID_Conta AS ID_CONTA, ID AS ID_PLANO, Matricula AS MATRICULA_VEICULO FROM CONTA,PLANO,VEICULO
WHERE ID=@P AND Matricula = @Var10


-------------------CRIA?AO DE PATINETES

INSERT INTO PATINETE(NOME,KM,Matricula_Veiculo,Fabricante,Carga)
SELECT 'XPT1' AS NOME, KM, Matricula, NOME, 100 FROM VEICULO
WHERE Matricula = @Var7

INSERT INTO BIKE(NOME,KM,Matricula_Veiculo,Modelo,Tipo)
SELECT 'BMX1' AS NOME, KM, Matricula, 1, 47 FROM VEICULO
WHERE Matricula = @Var8

INSERT INTO BIKE(NOME,KM,Matricula_Veiculo,Modelo,Tipo)
SELECT 'BMK2' AS NOME, KM, Matricula + 1, 2, 15 FROM VEICULO
WHERE Matricula = @Var9

INSERT INTO SCOOTER(NOME,KM,Matricula_Veiculo,CC,Cor)
SELECT 'SC25', KM, matricula, 50, 'Azul' FROM VEICULO
WHERE Matricula = @Var10


INSERT INTO SCOOTER(NOME,KM,Matricula_Veiculo,CC,Cor)
SELECT 'SC26', KM, matricula, 25, 'Vermelha' FROM VEICULO
WHERE Matricula = @Var11

SET @X = @X +1
INSERT INTO PEDIDO(ID,DESCRICAO,ID_CONTA,MATRICULA, DATA_P)
SELECT @X AS ID, 'Quero diferent?o.' AS DESCRICAO, ID_Conta AS ID_CONTA, Matricula AS MATRICULA, DATEADD(year, 20, DATA) AS DATA_P FROM CONTA, VEICULO
WHERE NIF_Usuario = @VAR1 AND MATRICULA = @VAR7

SET @X = @X +1
INSERT INTO PEDIDO(ID,DESCRICAO,ID_CONTA,MATRICULA, DATA_P)
SELECT @X AS ID, 'Quero algo bom.' AS DESCRICAO, ID_Conta AS ID_CONTA, Matricula AS MATRICULA, DATEADD(year, 20, DATA) AS DATA_P FROM CONTA, VEICULO
WHERE NIF_Usuario = @Var2 AND MATRICULA = @VAR8

SET @X = @X +1
INSERT INTO PEDIDO(ID,DESCRICAO,ID_CONTA,MATRICULA, DATA_P)
SELECT @X AS ID, 'Hora de pilotar algo muito bom.' AS DESCRICAO, ID_Conta AS ID_CONTA, Matricula AS MATRICULA, DATEADD(year, 20, DATA) AS DATA_P FROM CONTA, VEICULO
WHERE NIF_Usuario = @Var3 AND MATRICULA = @VAR9	
	
SET @Var1 =CAST(FLOOR(RAND() * (99999999 + 1 -  10000000))AS INT)
SET @Var2 =CAST(FLOOR(RAND() * (99999999 + 1 -  10000000))AS INT)
SET @Var3 =CAST(FLOOR(RAND() * (99999999 + 1 -  10000000))AS INT)
SET @Var4 =CAST(FLOOR(RAND() * (99999999 + 1 -  10000000))AS INT)


--INSERT DE MECANICOS


INSERT INTO MECANICO(NIF, NOME, Data_Nasc, SEXO)
VALUES(@Var1,'Felipe Morais',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'M')


INSERT INTO MECANICO(NIF, NOME, Data_Nasc, SEXO)
VALUES(@Var2,'Helena Bringel',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'F')


INSERT INTO MECANICO(NIF, NOME, Data_Nasc, SEXO)
VALUES(@Var3,'Manuel da Silva',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'M')


INSERT INTO MECANICO(NIF, NOME, Data_Nasc, SEXO)
VALUES(@Var4,'Lorena dos Santos',DATEADD(day, (ABS(CHECKSUM(NEWID())) % 65530), 0),'F')


--INSERT DE INTERVENCOES

SET @Y = @Y + 1
INSERT INTO INTERVENCOES(ID,MATRI_VEICULO,MECA_NIF,PRECO,DESCRICAO,DATA_INTERVENCAO)
SELECT @Y AS ID, Matricula AS MATRI_VEICULO, @Var1 AS MECA_NIF, @Y + 30 AS PRECO,  'Complicada' AS DESCRICAO,DATEADD(year, 20, Data_Nasc) AS DATA_INTERVENCAO FROM VEICULO, MECANICO
WHERE NIF = @Var1 AND Matricula = @Var7

SET @Y = @Y + 1
INSERT INTO INTERVENCOES(ID,MATRI_VEICULO,MECA_NIF,PRECO,DESCRICAO,DATA_INTERVENCAO)
SELECT @Y AS ID, Matricula AS MATRI_VEICULO, @Var2 AS MECA_NIF, @Y + 10 AS PRECO,'Tranquila' AS DESCRICAO, DATEADD(year, 20, Data_Nasc) AS DATA_INTERVENCAO FROM VEICULO, MECANICO
WHERE NIF = @Var2 AND Matricula = @Var8

SET @Y = @Y + 1
INSERT INTO INTERVENCOES(ID,MATRI_VEICULO,MECA_NIF,PRECO,DESCRICAO,DATA_INTERVENCAO)
SELECT @Y AS ID, Matricula AS MATRI_VEICULO, @Var3 AS MECA_NIF,@Y + 100 AS PRECO, 'Impossivel' AS DESCRICAO, DATEADD(year, 20, Data_Nasc) AS DATA_INTERVENCAO FROM VEICULO, MECANICO
WHERE NIF = @Var3 AND Matricula = @Var9

--INSERT INTO FAZ

INSERT INTO FAZ(NIF_Mecanico,ID_Intervenc,Matri_Veiculo)
SELECT MECA_NIF AS NIF ,ID AS ID_Intervenc ,Matricula as Matri_Veiculo FROM MECANICO,INTERVENCOES,VEICULO
WHERE NIF = @Var1 AND ID = @Y - 2 AND MATRICULA = @Var7

INSERT INTO FAZ(NIF_Mecanico,ID_Intervenc,Matri_Veiculo)
SELECT MECA_NIF AS NIF ,ID AS ID_Intervenc ,Matricula as Matri_Veiculo FROM MECANICO,INTERVENCOES,VEICULO
WHERE NIF = @Var2 AND ID = @Y - 1 AND Matricula = @Var8

INSERT INTO FAZ(NIF_Mecanico,ID_Intervenc,Matri_Veiculo)
SELECT MECA_NIF AS NIF ,ID AS ID_Intervenc ,Matricula as Matri_Veiculo FROM MECANICO,INTERVENCOES,VEICULO
WHERE NIF = @Var3 AND ID = @Y AND Matricula = @Var9












END







----SELECT NIF,Nome,ID_Conta  FROM USUARIO INNER JOIN CONTA
----ON NIF = NIF_Usuario
----WHERE Nome='Marcela Chirol'