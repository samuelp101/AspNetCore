
Use NorthwindDB
Go

CREATE OR ALTER PROCEDURE dbo.spNorthwindDB_Create_Customer
        @CustomerId int = null
	,@CompanyName nvarchar(40)
	,@ContactName nvarchar(30)
	,@ContactTitle nvarchar(30)
	,@Address nvarchar(60)
	,@City nvarchar(15)
	,@Region nvarchar(15)
	,@PostalCode nvarchar(10)
	,@Country nvarchar(15)
As


Begin

	Insert Into dbo.Customers
		(CompanyName,ContactName,ContactTitle,
		[Address],City,Region,PostalCode,Country)
	Values
		(@CompanyName,@ContactName,@ContactTitle,
		@Address,@City,@Region,@PostalCode,@Country)
End

Go

/*

DECLARE @CompanyName nvarchar(40) = 'Embedded101'
	,@ContactName nvarchar(30) = 'Sam Phung'
	,@ContactTitle nvarchar(30) = 'PM'
	,@Address nvarchar(60) = '123 Any Street'
	,@City nvarchar(15) = 'Los Angeles'
	,@Region nvarchar(15) = 'CA'
	,@PostalCode nvarchar(10) = '91732'
	,@Country nvarchar(15) = 'USA'

EXEC dbo.spNorthwindDB2021_Customers_Create	
	@CompanyName
	,@ContactName
	,@ContactTitle
	,@Address
	,@City
	,@Region
	,@PostalCode
	,@Country
*/
