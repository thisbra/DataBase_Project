CREATE TRIGGER createUser ON usuario
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @NIF AS VARCHAR(9);
	DECLARE @DATA AS DATE;
	DECLARE @ID AS VARCHAR(9);
	SET @DATA = GETDATE();
	SET  @ID =  (SELECT TOP 1 ID_Conta FROM CONTA ORDER BY ID_CONTA DESC);
	SET @ID = @ID + 1;
    --DECLARE @Nome AS VARCHAR(40); 
    SELECT @NIF = NIF FROM inserted;
    BEGIN
    BEGIN TRY
		INSERT INTO CONTA
		(ID_Conta, DATA, NIF_Usuario)
		VALUES(@ID,@DATA,@NIF) 
    END TRY
    BEGIN CATCH
        raiserror ('N?o foi poss?vel inserir o usuario', 16, 1);
        ROLLBACK TRAN
    END CATCH
	END
END
GO