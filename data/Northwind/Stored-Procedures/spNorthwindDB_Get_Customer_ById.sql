
Use NorthwindDB
Go

-- EXEC dbo.spNorthwindDB_Get_Customer_ById @CustomerId = 'COMMI'

CREATE OR ALTER PROCEDURE dbo.spNorthwindDB_Get_Customer_ById
	@CustomerId varchar(5)
As

-- DECLARE @CustomerId int = 2
Select CustomerId	
	,CompanyName	
	,ContactName	
	,ContactTitle	
	,[Address]
	,City	
	,Region	
	,PostalCode	
	,Country
From dbo.Customers
Where CustomerId = @CustomerId

Go