CREATE TRIGGER createTypes ON VEICULO
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @MARCA AS VARCHAR(9);
	DECLARE @matricula AS INT;
	DECLARE @KM AS REAL;
    SELECT @MARCA = NOME,@matricula = Matricula,@KM = KM FROM INSERTED;
    BEGIN
    BEGIN TRY
		IF @MARCA = 'FIAT'
		INSERT INTO SCOOTER
		(NOME, Matricula_Veiculo, KM)
		VALUES(@MARCA,@matricula,@KM) 
		ELSE IF @MARCA = 'NISSAN'
		INSERT INTO PATINETE
		(NOME, Matricula_Veiculo, KM)
		VALUES(@MARCA,@matricula,@KM) 
		ELSE IF @MARCA = 'HONDA'
		INSERT INTO BIKE
		(NOME, Matricula_Veiculo, KM)
		VALUES(@MARCA,@matricula,@KM) 
    END TRY
    BEGIN CATCH
        raiserror ('Não foi possãvel inserir o usuario', 16, 1);
        ROLLBACK TRAN
    END CATCH
	END
END
GO