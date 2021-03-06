--CREATE DATABASE MYTRANSPORT;
--GO


CREATE TABLE USUARIO(
NIF		VARCHAR(9),
SEXO	VARCHAR(1),
Nome	VARCHAR(15),
Data_Nasc	DATE,

PRIMARY KEY(NIF),

);
GO


CREATE TABLE CONTA(
ID_Conta  INT,
DATA	DATE,
NIF_Usuario VARCHAR(9)

PRIMARY KEY(ID_Conta),
FOREIGN KEY(NIF_Usuario) REFERENCES USUARIO(NIF) ON DELETE CASCADE
);
GO


CREATE TABLE MEIO_DE_PAGAMENTO(
NUMERO INT,
TIPO VARCHAR(10),
NIF	VARCHAR(9),

PRIMARY KEY(NUMERO),
FOREIGN KEY(NIF) REFERENCES USUARIO(NIF) ON DELETE CASCADE
);
GO


CREATE TABLE VEICULO(
NOME	VARCHAR(15),
KM		REAL,
Matricula  INT,

PRIMARY KEY(Matricula)
);
GO


CREATE TABLE SCOOTER(
NOME	VARCHAR(15),
KM		REAL,
Matricula_Veiculo  INT,
CC INT,
Cor VARCHAR(20)

PRIMARY KEY(Matricula_Veiculo)
FOREIGN KEY(Matricula_Veiculo) REFERENCES VEICULO(Matricula) ON DELETE CASCADE
);
GO


CREATE TABLE BIKE(
NOME	VARCHAR(15),
KM		REAL,
Matricula_Veiculo  INT,
Modelo INT,
Tipo INT

PRIMARY KEY(Matricula_Veiculo)
FOREIGN KEY(Matricula_Veiculo) REFERENCES VEICULO(Matricula) ON DELETE CASCADE
);
GO


CREATE TABLE PATINETE(
NOME	VARCHAR(15),
KM		REAL,
Matricula_Veiculo  INT,
Fabricante VARCHAR(15),
Carga INT

PRIMARY KEY(Matricula_Veiculo)
FOREIGN KEY(Matricula_Veiculo) REFERENCES VEICULO(Matricula) ON DELETE CASCADE
);
GO


CREATE TABLE PEDIDO(
ID		INT,
DESCRICAO	VARCHAR(50),
DATA_P	DATE,
ID_CONTA	INT,
MATRICULA	INT,

PRIMARY KEY(ID),
FOREIGN KEY(ID_CONTA) REFERENCES CONTA(ID_Conta) ON DELETE CASCADE,
FOREIGN KEY(MATRICULA) REFERENCES VEICULO(Matricula) ON DELETE CASCADE
);
GO


CREATE TABLE MECANICO (
NIF		VARCHAR(9),
NOME	VARCHAR(15),
Data_Nasc	DATE,
SEXO	VARCHAR(1)
PRIMARY KEY(NIF)
);
GO


CREATE TABLE INTERVENCOES (
ID		INT,
MATRI_VEICULO	INT,
MECA_NIF	VARCHAR(9),
PRECO	DECIMAL(5,2),
DESCRICAO	VARCHAR(50),
DATA_INTERVENCAO	DATE,

PRIMARY KEY(ID),
FOREIGN KEY(MATRI_VEICULO) REFERENCES VEICULO(Matricula) ON DELETE CASCADE,
FOREIGN KEY(MECA_NIF) REFERENCES MECANICO(NIF) ON DELETE CASCADE
);
GO


CREATE TABLE FAZ (
NIF_Mecanico VARCHAR(9),
ID_Intervenc	INT,
Matri_Veiculo	INT,

PRIMARY KEY(NIF_Mecanico, ID_Intervenc),
FOREIGN KEY(NIF_Mecanico) REFERENCES MECANICO(NIF) ON DELETE CASCADE,
FOREIGN KEY(ID_Intervenc) REFERENCES INTERVENCOES(ID),
FOREIGN KEY(Matri_Veiculo) REFERENCES VEICULO(Matricula) ON DELETE CASCADE
);
GO


CREATE TABLE PLANO(
ID		INT,
VALOR	DECIMAL(4,2),
TIPO	VARCHAR(1),

PRIMARY KEY(ID),
);
GO


CREATE TABLE SUBSCRICOES(
ID_PLANO	INT,
ID_CONTA	INT,
MATRICULA_VEICULO	INT,
DATA_INICIO		DATE,
DATA_FIM		DATE,

PRIMARY KEY(ID_PLANO, ID_CONTA, MATRICULA_VEICULO),
FOREIGN KEY(ID_PLANO) REFERENCES PLANO(ID) ON DELETE CASCADE,
FOREIGN KEY(ID_CONTA) REFERENCES CONTA(ID_Conta) ON DELETE CASCADE,
FOREIGN KEY(MATRICULA_VEICULO) REFERENCES VEICULO(Matricula) ON DELETE CASCADE
);
GO


CREATE TABLE POSSUI(
ID_CONTA	INT,
ID_PLANO	INT,
MATRICULA_VEICULO	INT,

PRIMARY KEY(ID_CONTA,ID_PLANO,MATRICULA_VEICULO),
FOREIGN KEY(ID_CONTA) REFERENCES CONTA(ID_Conta) ON DELETE CASCADE,
FOREIGN KEY(ID_PLANO) REFERENCES PLANO(ID) ON DELETE CASCADE,
FOREIGN KEY(MATRICULA_VEICULO) REFERENCES VEICULO(Matricula) ON DELETE CASCADE
);
GO
