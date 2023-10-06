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

INSERT Account(idUser,Displayname,Username,Password,Type,email) VALUES('son',N'hoangson','nhson','password','gold','sonten@gmail.com')
SELECT * FROM Account
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

CREATE TABLE Staff
(
	

)
GO