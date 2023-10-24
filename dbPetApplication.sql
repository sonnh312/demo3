CREATE DATABASE PetApplication
GO

USE PetApplication
GO

CREATE TABLE Pet
(
	IdPet INT NOT NULL,
	IdPetCategory INT NOT NULL,
	CategoryPet NVARCHAR(100)NOT NULL,
	NamePet NVARCHAR(100)NOT NULL,
	Price INT ,
	PRIMARY KEY (IdPet,IdPetCategory)
)
GO



INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price) VALUES (1,101, N'Dog', N'Husky',2000)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price) VALUES (2,101, N'Dog', N'Alaska',2000)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price) VALUES (3,101, N'Dog', N'Pitbull',2000)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price) VALUES (4,101, N'Dog', N'Corgi',2000)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price) VALUES (5,102, N'Cat', N'Ragdoll',2000)

UPDATE dbo.Pet SET IdPetCategory= IdPetCategory, NamePet,PRICE  WHERE IdPet= 1

UPDATE Pet SET NamePet = N'{0}', IdPetCategory = {1} , PRICE '{2}' WHERE Id = {3})

CREATE TABLE PetCategory
(
	IdPet INT NOT NULL,
	IdPetCategory INT NOT NULL,
	CategoryPet NVARCHAR(100)NOT NULL,
	PRIMARY KEY (IdPet,IdPetCategory)
)



INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (1,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (2,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (3,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (4,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (5,102, N'Cat')


SELECT * FROM PetCategory

CREATE TABLE Account
(
	IdUser CHAR(10)NOT NULL,
	Displayname NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Type INT NOT NULL,
	Role NVARCHAR(100) NOT NULL,
	PRIMARY KEY (IdUser)
)
GO

SELECT * FROM Account
INSERT INTO Account (IdUser, Displayname, Username, Password, Type, Role) VALUES (1, N'Hoang Son', N'hs', N'1',1, N'admin')
INSERT INTO Account (IdUser, Displayname, Username, Password, Type, Role) VALUES (2, N'Gia Han', N'gh', N'1',0, N'user')
INSERT INTO Account (IdUser, Displayname, Username, Password, Type, Role) VALUES (3, N'Thanh Ngan', N'tn', N'1',0, N'user')

UPDATE dbo.Account SET Type='0'  WHERE IdUser='3'	

SELECT * FROM dbo.Account WHERE Username='hs' AND password=1

CREATE TABLE PetService
(
	IdService INT NOT NULL,
	NameService CHAR(10),
	Price INT,
	PRIMARY KEY (IdService)
)
GO
INSERT dbo.PetService(IdService,NameService,Price) VALUES (1001,N'Shower',50)
INSERT dbo.PetService(IdService,NameService,Price) VALUES (1002,N'Take Care',150)
INSERT dbo.PetService(IdService,NameService,Price) VALUES (1003,N'Food',250)



CREATE TABLE PetList
(
	IdPet INT NOT NULL,
	NamePet NVARCHAR(100),
	Status NVARCHAR(100),
	PRIMARY KEY (IdPet)
)
GO

INSERT dbo.PetList(IdPet,NamePet,Status) VALUES (1,N'Husky',N'Ready')
INSERT dbo.PetList(IdPet,NamePet,Status) VALUES (2,N'Alaska',N'Ready')
INSERT dbo.PetList(IdPet,NamePet,Status) VALUES (3,N'Pitbull',N'Ready')
INSERT dbo.PetList(IdPet,NamePet,Status) VALUES (4,N'Corgi',N'Ready')
INSERT dbo.PetList(IdPet,NamePet,Status) VALUES (5,N'Ragdoll',N'Ready')


UPDATE dbo.PetList SET Status = 'Not Ready' WHERE NamePet = N'Husky'



UPDATE dbo.PetList SET Status = 1 WHERE NamePet=N'Ragdoll'

CREATE TABLE Bill
(
	IdBill INT NOT NULL,
	IdPet INT NOT NULL,
	DateCheckIn DATETIME,
	DateCheckOut DATETIME,
	Status NVARCHAR(100),
	PRIMARY KEY (IdBill,IdPet)
)
GO

INSERT INTO Bill (IdBill, IdPet, DateCheckIn, DateCheckOut, Status) VALUES (10001,1,GETDATE(), null, N'Unpaid')
INSERT INTO Bill (IdBill, IdPet, DateCheckIn, DateCheckOut, Status) VALUES (10002,2,GETDATE(), null, N'Unpaid')
INSERT INTO Bill (IdBill, IdPet, DateCheckIn, DateCheckOut, Status) VALUES (10003,3,GETDATE(), null, N'Unpaid')
INSERT INTO Bill (IdBill, IdPet, DateCheckIn, DateCheckOut, Status) VALUES (10004,4,GETDATE(), null, N'Paid')
INSERT INTO Bill (IdBill, IdPet, DateCheckIn, DateCheckOut, Status) VALUES (10005,5,GETDATE(), null, N'Paid')


CREATE TABLE BillInfo
(
	IdBill INT NOT NULL,
	IdPet INT NOT NULL,
	count INT,
	PRIMARY KEY (IdBill,IdPet)
)
GO



INSERT dbo.BillInfo(IdBill,IdPet,count) VALUES (10001,1,1)
INSERT dbo.BillInfo(IdBill,IdPet,count) VALUES (10002,2,1)
INSERT dbo.BillInfo(IdBill,IdPet,count) VALUES (10003,3,1)
INSERT dbo.BillInfo(IdBill,IdPet,count) VALUES (10004,4,1)
INSERT dbo.BillInfo(IdBill,IdPet,count) VALUES (10005,5,1)

SELECT p.NamePet, bi.count,p.PRICE AS totalPrice FROM BillInfo AS bi, Bill AS b,Pet AS p 
WHERE bi.IdBill = b.IdBill AND bi.IdPet= p.IdPet AND b.Status='UnPaid' AND b.IdPet = 1

	
SELECT * FROM PetCategory
SELECT * FROM PetList
SELECT * FROM Bill
SELECT * FROM BillInfo
SELECT * FROM PetService , Account

SELECT * FROM dbo.Account WHERE Username=N'hs' AND PassWord='1'
----
---
DECLARE @i	INT = 0
WHILE @i <=4
BEGIN
	INSERT dbo.PetList(IdPet,NamePet,Status) VALUES (@i,N'A0'+ CAST (@i AS NVARCHAR(100)),0) 
SET @i = @i + 1
END 

---Storeproc
----
----
CREATE PROCEDURE USP_GetAccountByUserName
@username nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.Account WHERE Username = N'hs'
END
GO
EXEC USP_GetAccountByUserName @username = N'hs' 
---
----
CREATE PROCEDURE USP_GetPetList
AS
	BEGIN
		SELECT * FROM PetList
	END

exec USP_GetPetList
----
----
CREATE PROCEDURE USP_InsertPet
@namepet NVARCHAR(100), @idpet INT, @price INT , @idpetcategory INT
AS
	BEGIN
		INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price) VALUES (@idpet+1,@idpetcategory+1, N'Dog', N'Husky',2000)
		
	END
--
--
CREATE PROCEDURE USP_UpdatePet
@namepet NVARCHAR(100), @idpet INT, @price INT , @idpetcategory INT
AS
	BEGIN
		INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price) VALUES (@idpet+1,@idpetcategory+1, N'Dog', N'Husky',2000)
		
	END

--
--
CREATE PROCEDURE USP_InsertBill
@idpet INT, @i INT = 0
AS
	BEGIN
		INSERT dbo.Bill(IdBill,IdPet,DateCheckIn,DateCheckOut,Status) VALUES ('B06',@idpet,GETDATE(),null,0)
	END
exec USP_InsertBill @idpet = ''
----
----
CREATE PROCEDURE USP_InsertBillInfo
@idbill INT, @idpet INT, @count INT
AS
BEGIN
	DECLARE @isExitsBillInfo INT;
	DECLARE @petCount INT = 1;
	SELECT @isExitsBillInfo = IdPet FROM dbo.BillInfo WHERE IdBill = @idbill AND IdPet = @idpet
	IF(@isExitsBillInfo >0)
	BEGIN
		UPDATE dbo.BillInfo SET count = @petCount + @count WHERE IdPet = IdPet
	END 
	ELSE 
	BEGIN
		INSERT dbo.BillInfo(IdBill,IdPet,count) VALUES (@idbill,@idpet,@count)
	END

END
	
exec USP_InsertBillInfo @idbill , @idpet , @count 
----
--
CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idbillinfo INT
	DECLARE @idbill INT
	SELECT @idbillinfo = IdBill,@idbill =deleted.IdBill FROM deleted

	declare @idpetliste

	SELECT @idbill = id FROM 
END




--
----
CREATE PROC USP_UpdateAccount
@username NVARCHAR(100),@displayname NVARCHAR(100),@password NVARCHAR(100),@newpassword NVARCHAR(100)
AS 
BEGIN 
	DECLARE @isRightPass INT =0
	SELECT @isRightPass = COUNT(*) FROM dbo.Account WHERE Username = @username AND Password = @password

	IF(@isRightPass =1)
	BEGIN
		IF(@newpassword = null OR @newpassword = '')
		BEGIN
			UPDATE dbo.Account SET Displayname= @displayname WHERE Username=@username
		END
		ELSE 
			UPDATE dbo.Account SET Displayname= @displayname, Password=@newpassword  WHERE Username=@username

	END
END

CREATE PROCEDURE USP_LoginAccount
@username NVARCHAR(100),@password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE Username=@username AND Password=@password
END

exec USP_LoginAccount @username , @password 

