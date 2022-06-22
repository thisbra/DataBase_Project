--DROP PROCEDURE addVeiculo;
--GO

CREATE PROCEDURE addVeiculo
    @nome CHAR(10),
    @km real,
    @matricula int,
	@responseMessage varchar(20)
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
                IF EXISTS(SELECT Matricula FROM VEICULO WHERE Matricula=@matricula)
                    SET @responseMessage = 'Matricula já existe'
                ELSE
                BEGIN
                    INSERT INTO VEICULO
                    (NOME,KM,Matricula)
                    VALUES(@nome,@km,@matricula) 
                    SET @responseMessage='Success'
                END
    END TRY
    BEGIN CATCH
        SET @responseMessage='Failed'
    END CATCH

END
GO