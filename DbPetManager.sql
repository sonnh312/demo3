CREATE DATABASE	PetManager
GO

USE PetManager
GO

---khach hang(loai,uu dai khach hang pet), pet(gom nhung loai nao,ten gi,thong tin ra sao),dich vu pet(dich vu gi,gia ca), admin quan li(them, xoa, sua) , nhan vien, bill(gio hang,cach thanh toan,billinfo,table

CREATE TABLE Pet
(
	idPet INT IDENTITY PRIMARY KEY,
	idPetCategory INT,
	name NVARCHAR(100)NOT NULL,
	status NVARCHAR(100)NOT NULL,
	
)
GO
INSERT dbo.Pet(idPet,idPetCategory,name,status) VALUES (1,1,N'Ngu',N'ready')

ALTER TABLE Pet ADD CONSTRAINT N_1 FOREIGN KEY(idPetCategory) REFERENCES PetCategory(PetCategory)

CREATE TABLE PetCategory
(
	
	PetCategory INT IDENTITY PRIMARY KEY,
	Petkind NVARCHAR(100)NOT NULL,

)
GO

DROP TABLE dbo.PetCategory
INSERT dbo.PetCategory(Petkind) VALUES (N'Kind1')
INSERT dbo.PetCategory(Petkind) VALUES (N'Kind2')
INSERT dbo.PetCategory(Petkind) VALUES (N'Kind3')

CREATE TABLE Account
(
	idUser INT IDENTITY PRIMARY KEY,
	Displayname NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL,
	password NVARCHAR(100) NOT NULL,
	
)
GO
DROP TABLE Account
INSERT dbo.Account(Displayname,Username,password) VALUES(N'hoangson',N'hs',N'1')
INSERT dbo.Account(Displayname,Username,password) VALUES(N'hoangson',N'nhs',N'1')
SELECT * FROM dbo.Account

SELECT * FROM dbo.Account WHERE Username='hs' AND password='1'

CREATE TABLE PetService
(
	idPet INT,
	idPetService INT IDENTITY PRIMARY KEY,
	Shower INT ,
	Food INT ,
)
GO
ALTER TABLE PetService ADD CONSTRAINT N_1 FOREIGN KEY(idPetService) REFERENCES Pet(idPet)

CREATE TABLE TablePet
(
	name NVARCHAR(100),
	status INT,
)
GO
DROP TABLE dbo.TablePet


DECLARE @i	INT = 0
WHILE @i <=10
BEGIN
	INSERT dbo.TablePet(name,status) VALUES (N'Ban'+ CAST (@i AS NVARCHAR(100)),0) 
SET @i = @i + 1
END 
UPDATE dbo.TablePet SET status = 1 WHERE name=N'Ban4'
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
DROP TABLE Bill
SELECT * FROM dbo.Bill WHERE idTable=1 AND status = 0
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (5,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (7,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (6,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (2,null,null,0)
INSERT dbo.Bill(idTable,dataCheckIn,dataCheckOut,status) VALUES (1,null,null,0)


CREATE TABLE BillInfo
(
	
	idBillInfo INT IDENTITY PRIMARY KEY,
	idFood CHAR(10),
	count INT,
	
)
GO

SELECT * FROM dbo.BillInfo WHERE idBillInfo=2


INSERT dbo.BillInfo(idFood,count) VALUES ('2',5)
INSERT dbo.BillInfo(idFood,count) VALUES ('3',10)
CREATE PROCEDURE getAccountByUserName
@username nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE Username = @username
END
GO


SELECT * FROM  getAccountFromUserName

EXECUTE getAccountByUserName @username = N'hoangson' 
DELETE dbo.Account
SELECT * FROM dbo.Account WHERE Username=N'hoangson' AND PassWord='nhson'
GO

CREATE PROCEDURE USP_GetTableList
AS
SELECT * FROM dbo.TablePet
EXECUTE USP_GetTableList
GO
DROP PROCEDURE USP_GetTableList