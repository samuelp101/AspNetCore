
Use NorthwindDB
Go

-- EXEC dbo.spNorthwindDB_Get_Customers @OrderBy = 'Country', @Country = 'Braz';
-- EXEC dbo.spNorthwindDB_Get_Customesr @OrderBy = 'CustomerID'
-- EXEC dbo.spNorthwindDB_Get_Customers @OrderBy = 'CompanyName'
-- EXEC dbo.spNorthwindDB_Get_Customers @OrderBy = 'ContactName', @AscDesc = 1
-- EXEC dbo.spNorthwindDB_Get_Customers @OrderBy = 'Region'
-- EXEC dbo.spNorthwindDB_Get_Customers @OrderBy = 'City'

CREATE OR ALTER PROC dbo.spNorthwindDB_Get_Customers
    @CompanyName varchar(40) = null
	,@ContactName varchar(30) = null
	,@City varchar(15) = null
	,@Region varchar(15) = null
	,@Country varchar(15) = null
	,@OrderBy varchar(25) = null
	,@AscDesc bit = 0
As

if(@CompanyName IS NOT NULL) SET @CompanyName = @CompanyName + '%';
if(@ContactName IS NOT NULL) SET @ContactName = @ContactName + '%';
if(@City IS NOT NULL) SET @City = @City + '%';
if(@Region IS NOT NULL) SET @Region = @Region + '%';
if(@Country IS NOT NULL) SET @Country = @Country + '%';


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
Where
  ((@CompanyName IS NULL) OR (CompanyName Like @CompanyName))
  AND ((@ContactName IS NULL) OR (ContactName Like @ContactName))
  AND ((@City IS NULL) OR (City Like @City))
  AND ((@Region IS NULL) OR (Region Like @Region))
  AND ((@Country IS NULL) OR (Country Like @Country))
Order By
	Case When @OrderBy = 'CustomerId' and @AscDesc = 0 Then CustomerId End Asc
	,Case When @OrderBy = 'CustomerId' and @AscDesc = 1 Then CustomerId End Desc
	,Case When @OrderBy = 'CompanyName' and @AscDesc = 0 Then CompanyName End Asc
	,Case When @OrderBy = 'CompanyName' and @AscDesc = 1 Then CompanyName End Desc
	,Case When @OrderBy = 'ContactName' and @AscDesc = 0 Then ContactName End Asc
	,Case When @OrderBy = 'ContactName' and @AscDesc = 1 Then ContactName End Desc
	,Case When @OrderBy = 'City' and @AscDesc = 0 Then City End Asc
	,Case When @OrderBy = 'City' and @AscDesc = 1 Then City End Desc
	,Case When @OrderBy = 'Region' and @AscDesc = 0 Then Region End Asc
	,Case When @OrderBy = 'Region' and @AscDesc = 1 Then Region End Desc
	,Case When @OrderBy = 'PostalCode' and @AscDesc = 0 Then PostalCode End Asc
	,Case When @OrderBy = 'PostalCode' and @AscDesc = 1 Then PostalCode End Desc
	,Case When @OrderBy = 'Country' and @AscDesc = 0 Then Country End Asc
	,Case When @OrderBy = 'Country' and @AscDesc = 1 Then Country End Desc

Go
