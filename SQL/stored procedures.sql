CREATE PROCEDURE SelectBrand @Marca nvarchar(10)
AS
SELECT * FROM VEICULO WHERE NOME = @Marca
GO;

CREATE PROCEDURE MecaWork @NIF_meca varchar(9)
as 
SELECT * FROM MECANICO INNER JOIN INTERVENCOES ON(NIF = MECA_NIF)
WHERE NIF = @NIF_meca
GO;

CREATE PROCEDURE BrandPrice @marca NVARCHAR(10)
as
SELECT * FROM VEICULO INNER JOIN SUBSCRICOES ON( MATRICULA_VEICULO = Matricula)
JOIN PLANO ON(ID = ID_PLANO) WHERE NOME = @marca