DROP TRIGGER createUser
GO

CREATE TRIGGER createUser ON usuario
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @NIF AS VARCHAR(9);
    --DECLARE @Nome AS VARCHAR(40); 
    SELECT @NIF = NIF FROM inserted;
    IF EXISTS(SELECT 1 FROM CONTA WHERE NIF_Usuario IS NULL)
    BEGIN
    BEGIN TRY
		UPDATE CONTA
		SET  NIF_Usuario=@NIF, DATA = GETDATE(), ID_CONTA = (SELECT TOP 1 * FROM CONTA ORDER BY ID_Conta DESC) + 1  
    END TRY
    BEGIN CATCH
        raiserror ('N�o foi poss�vel inserir o usuario', 16, 1);
        ROLLBACK TRAN
    END CATCH
	END
END
GO