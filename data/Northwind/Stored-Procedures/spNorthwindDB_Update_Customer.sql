Use NorthwindDB
Go

CREATE OR ALTER PROCEDURE dbo.spNorthwindDB_Update_Customer
	@CustomerID varchar(5)
	,@CompanyName varchar(40)
	,@ContactName varchar(30)
	,@ContactTitle varchar(30)
	,@Address varchar(60)
	,@City varchar(15)
	,@Region varchar(15)
	,@PostalCode varchar(10)
	,@Country varchar(15)
As
Begin
	Update c
	Set c.CompanyName = @CompanyName
		,c.ContactName = @ContactName
		,c.ContactTitle = @ContactTitle
		,c.[Address] = @Address
		,c.City = @City
		,c.Region = @Region
		,c.PostalCode = @PostalCode
		,c.Country = @Country
	--Select *
	From dbo.Customers c
	Where c.CustomerID = @CustomerID

End

