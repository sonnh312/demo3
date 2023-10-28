CREATE DATABASE PetApplication
GO

USE PetApplication
GO

CREATE TABLE Pet
(
	IdPet INT NOT NULL,
	IdPetCategory INT NOT NULL,
	CategoryPet NVARCHAR(100),
	NamePet NVARCHAR(100),
	Price INT ,
	Count INT
	PRIMARY KEY (IdPet,IdPetCategory)
)
GO



INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price,Count) VALUES (1,101, N'Dog', N'Husky',2000,5)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price,Count) VALUES (3,101, N'Dog', N'Alaska',2000,10)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price,Count) VALUES (5,101, N'Dog', N'Pitbull',2000,15)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price,Count) VALUES (7,101, N'Dog', N'Corgi',2000,20)
INSERT INTO Pet (IdPet, IdPetCategory, CategoryPet, NamePet, Price,Count) VALUES (9,102, N'Cat', N'Ragdoll',2000,25)

CREATE TABLE PetCategory
(
	IdPet INT NOT NULL,
	IdPetCategory INT NOT NULL,
	CategoryPet NVARCHAR(100)NOT NULL,
	PRIMARY KEY (IdPet,IdPetCategory)
)
--101 DOG, 102 CAT

INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (1,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (3,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (5,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (7,101, N'Dog')
INSERT INTO PetCategory (IdPet, IdPetCategory, CategoryPet) VALUES (9,102, N'Cat')

SELECT * FROM PetCategory

CREATE TABLE Staff
(
	IdUser INT PRIMARY KEY,
	Displayname NVARCHAR(100) NOT NULL,
	Username NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Type INT NOT NULL,
	Role NVARCHAR(100) NOT NULL,
	Address NVARCHAR(100) ,
	Birthday DATETIME,
	Phone INT,
)
GO

SELECT * FROM Staff

INSERT INTO Staff (IdUser, Displayname, Username, Password, Type, Role,Address,Birthday,Phone) VALUES (2, N'Hoang Son', N'hs', N'1',1, N'admin',N'HCM',6/9/2000,012345678)
INSERT INTO Staff (IdUser, Displayname, Username, Password, Type, Role,Address,Birthday,Phone) VALUES (4, N'Gia Han', N'gh', N'1',0, N'staff',N'HN',6/9/2000,012345678)
INSERT INTO Staff (IdUser, Displayname, Username, Password, Type, Role,Address,Birthday,Phone) VALUES (6, N'Thanh Ngan', N'tn', N'1',0, N'staff',N'DN',6/9/2000,012345678)

CREATE TABLE PetService
(
	IdService INT NOT NULL,
	NameService NVARCHAR(100) NOT NULL,
	Price INT,
	PRIMARY KEY (IdService)
)
GO

INSERT dbo.PetService(IdService,NameService,Price) VALUES (1001,N'Shower',50)
INSERT dbo.PetService(IdService,NameService,Price) VALUES (1002,N'Take Care',150)
INSERT dbo.PetService(IdService,NameService,Price) VALUES (1003,N'Food',250)

CREATE TABLE Customer
(
	IdCus INT NOT NULL,
	FullName NVARCHAR(100) NOT NULL,
	Address NVARCHAR(100) NOT NULL,
	Phone INT NOT NULL,
	PRIMARY KEY (IdCus)
)
SELECT * FROM dbo.Customer

INSERT dbo.Customer(IdCus,FullName,Address,Phone) VALUES (1,N'Nguyen Van A',N'141 dbp',09323231)
INSERT dbo.Customer(IdCus,FullName,Address,Phone) VALUES (3,N'Tran Van B',N'255 dbl',09323231)
INSERT dbo.Customer(IdCus,FullName,Address,Phone) VALUES (4,N'Dinh Van C',N'410 ahz',09323231)

CREATE TABLE Bill
(
	IdBill INT IDENTITY NOT NULL,
	IdPet INT NOT NULL,
	NamePet NVARCHAR(100),
	DateCheckIn DATETIME,
	Price INT,
	count INT,
	Status NVARCHAR(100),
	PRIMARY KEY (IdBill,IdPet)
)
GO

INSERT INTO Bill ( IdPet , NamePet, DateCheckIn,Price, Count ,Status) VALUES (1,N'Husky',GETDATE(),2000,2, N'Unpaid')
INSERT INTO Bill ( IdPet , NamePet, DateCheckIn,Price, Count ,Status) VALUES (3,N'Alaska',GETDATE(),2000,3, N'Unpaid')
INSERT INTO Bill ( IdPet , NamePet, DateCheckIn,Price, Count ,Status) VALUES (5,N'Pitbull',GETDATE(),2000,4, N'Unpaid')
INSERT INTO Bill ( IdPet , NamePet, DateCheckIn,Price, Count ,Status) VALUES (7,N'Corgi',GETDATE(),2000,5, N'Unpaid')
INSERT INTO Bill ( IdPet , NamePet, DateCheckIn,Price, Count ,Status) VALUES (9,N'Ragdoll',GETDATE(),2000,6, N'Paid')

SELECT * FROM Bill






SELECT * FROM Pet
SELECT * FROM PetCategory
SELECT * FROM Staff
SELECT * FROM Bill

SELECT * FROM PetService 
SELECT * FROM dbo.Customer

SELECT COUNT(*) AS SoLuong, CategoryPet
FROM PetCategory

GROUP BY CategoryPet


SELECT b.IdBill, p.NamePet, bi.count, p.Price, p.Price*bi.count AS totalPrice
FROM  Bill AS b ON bi.IdBill = b.IdBill
JOIN Pet AS p ON bi.IdPet = p.IdPet
WHERE b.Status = N'Unpaid' AND b.IdBill=3

SELECT b.IdBill, p.NamePet, b.count, p.Price, p.Price*b.count AS totalPrice FROM dbo.Bill AS b,dbo.Pet AS p WHERE b.IdPet = p.IdPet AND b.Status = N'Unpaid' AND b.IdBill=1




----
---


---Storeproc
----
----
exec USP_GetCusById

CREATE PROCEDURE USP_GetCusById
AS	SELECT (IdCus) FROM dbo.Customer
GO

---

SELECT IdCus,FullName FROM dbo.Customer
CREATE PROCEDURE USP_GetNameById
@idcus INT
AS
BEGIN 
	SELECT IdCus,FullName FROM dbo.Customer WHERE IdCus = @idcus 
END
GO
DROP proc USP_GetNameById
---
exec USP_GetNameById @idcus = 1


CREATE PROCEDURE USP_GetAccountByUserName
@username nvarchar(100)
AS
BEGIN 
	SELECT * FROM dbo.Staff WHERE Username = N'hs'
END
GO
EXEC USP_GetAccountByUserName @username = N'hs' 
---
----

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
---up bill history
CREATE PROCEDURE USP_AddToBill
@idcus INT,@idpet INT,@namepet NVARCHAR(100), @price INT , @count INT
AS
	SELECT (IdCus) FROM dbo.Customer WHERE IdCus = @idcus
	BEGIN
		INSERT INTO Bill ( IdPet , NamePet, DateCheckIn ,Price, Count ,Status) VALUES (@idpet ,'@namepet',GETDATE(),@price,@count, N'Unpaid')
		
	END
exec proc USP_AddToBill @idcus ,@idpet,@namepet NVARCHAR(100), @price INT , @count INT

--
CREATE PROC USP_InserNewBill
@idcus INT,@namepet NVARCHAR(100), @price INT , @count INT 
AS 
BEGIN 
	DECLARE @idbill INT = 0
	SET @idbill += @idbill
	INSERT INTO Bill (IdBill, IdPet , NamePet, DateCheckIn ,Price, Count ,Status) VALUES (@idbill,@idcus ,N'@namepet',GETDATE(),@price,@count, N'Unpaid')
END

DROP proc USP_InserNewBill
--
----
---- luu bill co check
CREATE PROCEDURE USP_InsertBill
@idpet INT, @count INT, @namepet NVARCHAR(100), @price INT ,@totalprice
AS
BEGIN
	DECLARE	@idbill INT = 0;
	SET @idbill = @idbill + 1;
	DECLARE @isExitsBillInfo INT;
	DECLARE @petCount INT = 1;

	SELECT @isExitsBillInfo = IdPet FROM Bill WHERE IdBill = @idbill AND IdPet = @idpet;

	IF @isExitsBillInfo IS NOT NULL
	BEGIN
		
		UPDATE Bill SET Count = Count + @count WHERE IdBill = @idbill AND IdPet = @idpet;
	END 
	ELSE 
	BEGIN
		
		INSERT INTO Bill (IdBill, IdPet , NamePet, DateCheckIn ,Price, Count ,Status) VALUES (@idbill,@idpet ,N'@namepet',GETDATE(),@price,@count, N'Unpaid')
	END
END
 
exec USP_InsertBill @idbill, @idpet , @count , @namepet , @price 



----
-- delete bill
CREATE TRIGGER UTG_DeleteBill
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idbillinfo INT
	DECLARE @idbill INT
	SELECT @idbillinfo = IdBill,@idbill =deleted.IdBill FROM deleted

	declare @idpetliste

	SELECT @idbill = id FROM 
END
----




--- update account staff
CREATE PROC USP_UpdateAccount
@username NVARCHAR(100),@displayname NVARCHAR(100),@password NVARCHAR(100),@newpassword NVARCHAR(100)
AS 
BEGIN 
	DECLARE @isRightPass INT =0
	SELECT @isRightPass = COUNT(*) FROM Staff WHERE Username = @username AND Password = @password

	IF(@isRightPass =1)
	BEGIN
		IF(@newpassword = null OR @newpassword ='')
		BEGIN
			UPDATE Staff SET Displayname= @displayname,Password=@newpassword  WHERE Username=@username
		END

	END
END

--
---- update account staff

CREATE PROC USP_UpdateInfo
@phone INT, @address NVARCHAR(100), @birthday DATETIME
AS 
BEGIN 
	UPDATE Staff SET Phone= @phone,Address=@address  WHERE Birthday=@birthday
END



--check login
--- 
CREATE PROCEDURE USP_LoginAccount
@username NVARCHAR(100),@password NVARCHAR(100)
AS
BEGIN
	SELECT * FROM dbo.Staff WHERE Username=@username AND Password=@password
END

exec USP_LoginAccount @username , @password 
---
---
CREATE PROCEDURE USP_LoadToBill
@idbill INT, @idpet INT, @count INT, @namepet NVARCHAR(100), @price INT
AS
BEGIN
	SELECT * FROM dbo.Staff WHERE Username=@username AND Password=@password
END

exec USP_LoginAccount @username , @password 