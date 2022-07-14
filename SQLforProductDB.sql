DROP DATABASE PRN_ProductDB
go


CREATE DATABASE PRN_ProductDB
go

use PRN_ProductDB
go


CREATE TABLE Category (
	Id int identity primary key,
	Name nvarchar(50),
	[Status] int
)

go

CREATE TABLE Product(
	Id int identity primary key,
	Name nvarchar(50),
	Price float,
	CreatedDate DateTime,
	[Status] int,
	CategoryId int REFERENCES Category(Id)	
)

go
CREATE TABLE [Order](
	Id int identity primary key,
	CustomerName nvarchar(50),
	[Address] nvarchar(250),
	Price float,
	OrderDate DateTime,
	[Status] int
)

go
CREATE TABLE Payment(
	Id int identity primary key,
	PayTime DateTime,
	Amount float,
	PayType nvarchar(250),
	OrderId int REFERENCES [order](Id) 
)


go
CREATE TABLE OrderDetail(
	Id int identity primary key,
	ProductId int REFERENCES Product(Id),
	OrderId int REFERENCES [Order](Id),
	Quantity int,
	Price float
)


go

--------Insert -----------------------
-----Category
go
--DELETE FROM Category WHERE id between 0 and 19
--DBCC CHECKIDENT ('Category', RESEED, 0)
insert into Category values ('Fruit', 0)
insert into Category values ('Meat', 0)

select * from Category
-------Product
go
--DELETE FROM Product WHERE id between 0 and 19
--DBCC CHECKIDENT ('Product', RESEED, 0)
insert into Product values ('Apple', 10000.0, '2022-07-13', 1, 1)
insert into Product values ('Banana', 15000.0, '2022-07-13', 1, 1)

select * from Product

-------OrderDetail
--DELETE FROM OrderDetail WHERE id between 0 and 19
--DBCC CHECKIDENT ('OrderDetail', RESEED, 0)
select * from OrderDetail

------Payment
--DELETE FROM Payment WHERE id between 0 and 19
--DBCC CHECKIDENT ('Payment', RESEED, 0)
Select * from Payment

------Order
--DELETE FROM [Order] WHERE id between 0 and 19
--DBCC CHECKIDENT ('Order', RESEED, 0)
select * from [Order]



-------OrderDetail----------
go
set identity_insert OrderDetail off
set identity_insert Product off
set identity_insert [Order] off
--insert into OrderDetail(ProductId, OrderId, Quantity, Price) values (1,1,2,20000.0)


---------------------Test queries----------------------
go
SELECT ord.Id, CustomerName, Address, ord.Price, OrderDate, ord.Status, 
		orDetail.Id as orDetailID, orDetail.ProductId, orDetail.OrderId as orDetailOrderId, orDetail.Quantity, orDetail.Price as orDetailPrice, 
		pm.Id as pmId, pm.PayTime, pm.Amount, pm.PayType, pm.OrderId as pmOrderId
FROM (([Order] ord
		inner join Payment pm on (pm.OrderId = ord.Id) )
		inner join OrderDetail orDetail on (orDetail.OrderId = ord.Id) )

go
SELECT TOP 1 Id FROM [Order] ORDER BY Id DESC

Select * from [Order]

SELECT Price FROM Product WHERE Id = 1





