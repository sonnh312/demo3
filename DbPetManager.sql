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
	Password NVARCHAR(100) NOT NULL,
	Type NVARCHAR(100) NOT NULL,
	email NVARCHAR(100) NOT NULL,
	PRIMARY KEY(idUser),
)
GO
DROP TABLE Account
INSERT Account(idUser,Displayname,Username,Password,Type,email) VALUES('01',N'hoangson','nhson','password','gold','sonten@gmail.com')
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

CREATE TABLE Sale
(
	Date DATETIME(),
	
)
GO

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
EXECUTE getAccountByUserName @username = N'nhson' 
DELETE dbo.Account
SELECT * FROM dbo.Account WHERE Username=N'nhson' AND PassWord='password'
