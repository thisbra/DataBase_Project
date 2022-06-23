--DROP PROCEDURE addVeiculo;
--GO

CREATE PROCEDURE addInterven
    @ID INT,
    @MATRI_VEI INT,
    @MECA_NIF int,
	@DESCRI varchar(50),
	@PRECO DECIMAL(5,2),
	@DATE_IN DATE,
	@responseMessage varchar(10)
AS
BEGIN
    SET NOCOUNT ON
    BEGIN TRY
		SET @DATE_IN = GETDATE();
		IF NOT EXISTS(SELECT TOP 1 ID FROM INTERVENCOES ORDER BY ID DESC)
		SET @ID = 1
		ELSE
		SET @ID = (SELECT TOP 1 ID FROM INTERVENCOES ORDER BY ID DESC) +1 
		INSERT INTO INTERVENCOES
		(ID,MATRI_VEICULO,MECA_NIF,PRECO,DESCRICAO,DATA_INTERVENCAO)
		VALUES(@ID,@MATRI_VEI,@MECA_NIF,@PRECO,@DESCRI,@DATE_IN) 
		SET @responseMessage='Success'
                
    END TRY
    BEGIN CATCH
        SET @responseMessage='Failed'
    END CATCH

END
GO