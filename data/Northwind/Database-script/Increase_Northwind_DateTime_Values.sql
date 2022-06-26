/******************************************************
  Note:  
  The Northwind database was created in the 1990s.
  Transaction dates for the data were between July-1996 through May-1998.

  This simple script updates the datetime values for the following tables, to reflect recent data:
    - dbo.Employees (updating the BirthDate and HireDate)
	- dbo.Orders (update the OrderDate, RequiredDate and ShippedDate)

  All datetime columns are incremented by the same number of years, as specify by the @YearsToIncrease variable. 

  For example, setting @YearsToIncrease = 24, will update transaction dates for the data to:
    July-2020 through May-2022

*******************************************************/
Use NorthwindDB
Go

DECLARE @YearsToIncrease INT = 24;
DECLARE @LatestOrderDate Datetime;

Select  @LatestOrderDate = Max(OrderDate) From dbo.Orders

if(@LatestOrderDate < '1998-06-01')
	BEGIN
		UPDATE dbo.Employees
		  SET HireDate = CASE WHEN HireDate IS NOT null THEN DATEADD(year, @YearsToIncrease, HireDate) END
		  ,BirthDate = CASE WHEN BirthDate IS NOT null THEN DATEADD(year, @YearsToIncrease, BirthDate) END
		--SELECT *
		FROM dbo.Employees



		UPDATE dbo.Orders
		  SET OrderDate = CASE WHEN OrderDate IS NOT null THEN DATEADD(year, @YearsToIncrease, OrderDate) END
			 ,RequiredDate = CASE WHEN RequiredDate IS NOT null THEN DATEADD(year, @YearsToIncrease, RequiredDate) END
			 ,ShippedDate = CASE WHEN ShippedDate IS NOT null THEN DATEADD(year, @YearsToIncrease, ShippedDate) END
		-- SELECT *
		FROM dbo.Orders

		Select 'Data updated'

	END
else
	BEGIN
		Select 'Data has already been udpated'
	END

Go