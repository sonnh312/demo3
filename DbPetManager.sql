CREATE DATABASE	PetManager
GO


USE PetManager
GO

---khach hang(loai,uu dai khach hang pet), pet(gom nhung loai nao,ten gi,thong tin ra sao),dich vu pet(dich vu gi,gia ca), admin quan li(them, xoa, sua) , nhan vien, bill(gio hang,cach thanh toan,billinfo,table

CREATE TABLE Pet
(
	idPet INT IDENTITY PRIMARY KEY,
	idPetCategory INT NOT NULL,
	NamePet NVARCHAR(100)NOT NULL,
	Status NVARCHAR(100)NOT NULL,
	FOREIGN KEY(idPetCategory) REFERENCES PetCategory(PetCategory)
)
GO

SELECT * FROM Pet


CREATE TABLE PetCategory
(
	PetCategory INT IDENTITY PRIMARY KEY,
	Petkind NVARCHAR(100)NOT NULL,
)
GO
DROP TABLE PetCategory
SELECT * FROM dbo.PetCategory

INSERT dbo.PetCategory(Petkind) VALUES (N'Kind1')
INSERT dbo.PetCategory(Petkind) VALUES (N'Kind2')
INSERT dbo.PetCategory(Petkind) VALUES (N'Kind3')

CREATE TABLE Account
(
	idUser INT IDENTITY PRIMARY KEY,
	Displayname NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL,
	password NVARCHAR(100) NOT NULL,
	role NVARCHAR(100) NOT NULL,
	
)
GO

INSERT dbo.Account(Displayname,Username,password,role) VALUES(N'hoangson',N'hs',N'1',N'admin')
INSERT dbo.Account(Displayname,Username,password,role) VALUES(N'hoangson',N'nhs',N'1',N'user')
SELECT * FROM dbo.Account

SELECT * FROM dbo.Account WHERE Username='hs' AND password='1'

CREATE TABLE PetService
(
	idPet INT,
	idPetService INT IDENTITY PRIMARY KEY,
	Shower INT ,
	Food INT ,
	FOREIGN KEY(idPetService) REFERENCES Pet(idPet)
)
GO
SELECT * FROM dbo.PetService

CREATE TABLE TablePet
(
	idPet INT IDENTITY PRIMARY KEY,
	NamePet NVARCHAR(100),
	status INT,
	
)
GO

SELECT * FROM dbo.TablePet

DECLARE @i	INT = 0
WHILE @i <=10
BEGIN
	INSERT dbo.TablePet(NamePet,status) VALUES (N'Dog'+ CAST (@i AS NVARCHAR(100)),0) 
SET @i = @i + 1
END 
UPDATE dbo.TablePet SET status = 1 WHERE NamePet=N'Dog4'
SELECT * FROM TablePet



CREATE TABLE Bill
(
	idBill INT IDENTITY PRIMARY KEY,
	idTable INT,
	dataCheckIn NVARCHAR(100) ,
	dataCheckOut NVARCHAR(100) ,
	status INT,
)
GO


INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (5,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (7,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (6,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (2,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (1,null,null,0)

SELECT * FROM dbo.Bill WHERE idTable=1 AND status = 0

CREATE TABLE BillInfo
(
	idBillInfo INT IDENTITY PRIMARY KEY,
	idFood CHAR(10),
	count INT,
)
GO

INSERT dbo.BillInfo(idFood,count) VALUES ('2',5)
INSERT dbo.BillInfo(idFood,count) VALUES ('3',10)

SELECT * FROM dbo.BillInfo WHERE idBillInfo=2



CREATE PROCEDURE USP_GetAccountByUserName
@username nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE Username = N'hs'
END
GO
exec USP_GetAccountByUserName



SELECT * FROM  GetAccountFromUserName

EXECUTE getAccountByUserName @username = N'hoangson' 

SELECT * FROM dbo.Account WHERE Username=N'hs' AND PassWord='1'


CREATE PROCEDURE USP_GetPetList
AS

GO
exec USP_GetPetList
