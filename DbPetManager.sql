CREATE DATABASE	PetManager
GO


USE PetManager
GO



CREATE TABLE Pet
(
	IdPet CHAR(10),
	IdCetCategory CHAR(10) ,
	PetKind NVARCHAR(100)NOT NULL,
	NamePet NVARCHAR(100)NOT NULL,
	Status NVARCHAR(100)NOT NULL,
	
)
GO
ALTER TABLE dbo.Pet ADD FOREIGN KEY(IdPetCategory) REFERENCES PetCategory(IdPetCategory)

CREATE TABLE PetCategory
(
	IdPet CHAR(10),
	IdPetCategory CHAR(10),
	PetKind NVARCHAR(100)NOT NULL,
)
GO
ALTER TABLE dbo.PetCategory ADD FOREIGN KEY(IdPet) REFERENCES Pet(IdPet)
SELECT * FROM dbo.PetCategory

INSERT dbo.PetCategory(Petkind) VALUES (N'Kind1')
INSERT dbo.PetCategory(Petkind) VALUES (N'Kind2')
INSERT dbo.PetCategory(Petkind) VALUES (N'Kind3')

CREATE TABLE Account
(
	IdUser CHAR(10),
	Displayname NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Role NVARCHAR(100) NOT NULL,
)
GO

INSERT dbo.Account(Displayname,Username,password,role) VALUES(N'hoangson',N'hs',N'1',N'admin')
INSERT dbo.Account(Displayname,Username,password,role) VALUES(N'hoangson',N'nhs',N'1',N'user')


SELECT * FROM dbo.Account WHERE Username='hs' AND password='1'

CREATE TABLE PetService
(
	IdPet CHAR(10),
	IdPetService CHAR(10),
	Shower NVARCHAR(100) ,
	Wax NVARCHAR(100) ,
	--FOREIGN KEY(IdPet) REFERENCES Pet(idPet)
)
GO
ALTER TABLE dbo.PetService ADD FOREIGN KEY(IdPet) REFERENCES Pet(IdPet)
SELECT * FROM dbo.PetService


CREATE TABLE TablePet
(
	IdPet CHAR(10),
	NamePet NVARCHAR(100),
	Status INT,
	--FOREIGN KEY(IdPet) REFERENCES Pet(idPet)
)
GO
ALTER TABLE dbo.TablePet ADD FOREIGN KEY(IdPet) REFERENCES Pet(IdPet)
SELECT * FROM dbo.TablePet

DECLARE @i	INT = 0
WHILE @i <=10
BEGIN
	INSERT dbo.TablePet(NamePet,Status) VALUES (N'Dog'+ CAST (@i AS NVARCHAR(100)),0) 
SET @i = @i + 1
END 

UPDATE dbo.TablePet SET status = 1 WHERE NamePet=N'Dog4'


CREATE TABLE Bill
(
	IdBill CHAR(10),
	IdPet CHAR(10),
	DateCheckIn DATETIME,
	DateCheckOut DATETIME,
	Status NVARCHAR(100),
)
GO



INSERT dbo.Bill(IdPet,dataCheckIn,dataCheckOut,status) VALUES (5,null,null,0)
INSERT dbo.Bill(IdPet,dataCheckIn,dataCheckOut,status) VALUES (7,null,null,0)
INSERT dbo.Bill(IdPet,dataCheckIn,dataCheckOut,status) VALUES (6,null,null,0)
INSERT dbo.Bill(IdPet,dataCheckIn,dataCheckOut,status) VALUES (2,null,null,0)
INSERT dbo.Bill(IdPet,dataCheckIn,dataCheckOut,status) VALUES (1,null,null,0)

SELECT * FROM dbo.Bill WHERE idTable=1 AND status = 0

CREATE TABLE BillInfo
(
	IdBillInfo CHAR(10),
	IdPet CHAR(10),
	count INT,
)
GO
ALTER TABLE dbo.BillInfo ADD FOREIGN KEY(IdPet) REFERENCES Pet(IdPet)

INSERT dbo.BillInfo(IdPet,count) VALUES (5)
INSERT dbo.BillInfo(IdPet,count) VALUES (10)

SELECT * FROM dbo.BillInfo WHERE idBillInfo=2



CREATE PROCEDURE USP_GetAccountByUserName
@username nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE Username = N'hs'
END
GO
EXEC USP_GetAccountByUserName @username = N'hs' 






SELECT * FROM dbo.Account WHERE Username=N'hs' AND PassWord='1'


CREATE PROCEDURE USP_GetPetList
AS

GO
exec USP_GetPetList

CREATE PROC USP_UpdateAccount
@username NVARCHAR(100),@displayname NVARCHAR(100),@password NVARCHAR(100),@newpassword NVARCHAR(100)
AS 
BEGIN 
	DECLARE @isRightPass INT =0
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE Username = @username AND Password = @password

	IF(@isRightPass =1)
	BEGIN
		IF(@newpassword = null OR @newpassword ='')
		BEGIN
			UPDATE dbo.Account SET Displayname= @displayname,Password=@newpassword  WHERE Username=@username
		END

	END
END
