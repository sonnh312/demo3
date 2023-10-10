CREATE DATABASE	PetGoo
GO

USE PetGoo
GO

---khach hang, pet,dich vu pet, ds quan li ,pet ds ban hang, nhan vien, bill
CREATE TABLE Admin
(
	

)
GO


CREATE TABLE Pet
(
	idPet CHAR(10),
	name NVARCHAR(100)NOT NULL,
	status NVARCHAR(100)NOT NULL,
	Petkind NVARCHAR(100)NOT NULL,
	PRIMARY KEY(idPet),
)
GO

CREATE TABLE Account
(
	idUser CHAR(10),
	Displayname NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL,
	password NVARCHAR(100) NOT NULL,
	PRIMARY KEY(idUser),
)
GO
DROP TABLE ACCOUNT
INSERT Account(idUser,Displayname,Username,password) VALUES('01',N'hs',N'hoangson',N'nhson')
INSERT Account(idUser,Displayname,Username,password) VALUES('02',N'hs',N'hoangson',N'0312')
SELECT * FROM dbo.Account


LAPTOP-ISEILDT0
CREATE TABLE PetService
(
	idPet CHAR(10),
	idPetService CHAR(10),
	Shower NVARCHAR(100) NOT NULL,
	Food NVARCHAR(100) NOT NULL,
)
GO
ALTER TABLE PetService ADD CONSTRAINT N_1 FOREIGN KEY(idPetService) REFERENCES Pet(idPet)

CREATE TABLE TableFood
(
	name NVARCHAR(100),
	status int,
)
DROP TABLE dbo.TableFood
DECLARE @i	INT = 0
WHILE @i <=10
BEGIN
	INSERT dbo.TableFood(name,status) VALUES (N'Ban'+ CAST (@i AS NVARCHAR(100)),0) 
SET @i = @i + 1
END 
UPDATE dbo.TableFood SET status = 1 WHERE name=N'Ban4'
VALUE (N'Ban 1')
SELECT * FROM TableFood



CREATE TABLE Bill
(
	idUser CHAR(10),
	idBill INT IDENTITY PRIMARY KEY,
	Username NVARCHAR(100) NOT NULL,
	dataCheckIn NVARCHAR(100) NOT NULL,
	dataCheckOut NVARCHAR(100) NOT NULL,
	
)
GO


CREATE PROCEDURE getAccountByUserName
@username nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE Username = @username
END
GO

GO
SELECT * FROM  GetAccountFromUserName
DROP PROCEDURE IF EXISTS USP_GetAccountFromUserName;
EXECUTE getAccountByUserName @username = N'hoangson' 
DELETE dbo.Account
SELECT * FROM dbo.Account WHERE Username=N'hoangson' AND PassWord='nhson'


CREATE PROCEDURE USP_GetTableList
AS
SELECT * FROM dbo.TableFood
EXECUTE USP_GetTableList