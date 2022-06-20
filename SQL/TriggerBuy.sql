--DROP TRIGGER buyTrigger
--GO

CREATE TRIGGER buyTrigger ON VEICULO
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @veiID AS INT;
    DECLARE @stock as INT;
    SELECT @veiID = Matricula FROM inserted;
    SELECT @stock =  COUNT('@veiID') FROM VEICULO LEFT JOIN PEDIDO ON(PEDIDO.MATRICULA IS NULL)
    IF (@stock < 0)
    BEGIN
        RAISERROR('Pedido não processado. Não existem veiculos disponiveis.', 16, 1);
        ROLLBACK TRAN;
    END
END
GO;