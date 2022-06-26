/**************************************************
Target Database:  NorthwindDB

***************************************************/

CREATE OR ALTER PROCEDURE dbo.spGet_CustomersOrders
  @FromDate varchar(20) = '2020-07-01'
  ,@ToDate varchar(20) = '2022-06-01'
  ,@OrderID varchar(10) = null
  ,@CustomerID varchar(5) = null
  ,@CompanyName varchar(50) = null
  ,@Country varchar(15) = null
  ,@SalesRepID int = null
  ,@SalesRep varchar(50) = null
  ,@Shipper varchar(50) = null
  ,@OrderBy varchar(25) = null
  ,@AscDesc varchar(5) = null
AS

BEGIN

DECLARE @FromDate2 Datetime, @ToDate2 Datetime, @AscDesc2 Bit = 0
SET @FromDate2 = Try_Parse(@FromDate as Datetime)
SET @ToDate2 = Try_Parse(@ToDate as Datetime)

IF (@AscDesc = '1') SET @AscDesc2 = 1
IF (@CustomerID IS NOT NULL) SET @CustomerID = @CustomerID + '%';
IF (@CompanyName IS NOT NULL) SET @CompanyName = @CompanyName + '%';
IF (@SalesRep IS NOT NULL) SET @SalesRep = @SalesRep + '%';
IF (@Shipper IS NOT NULL) SET @Shipper = @Shipper + '%';
IF (@Country IS NOT NULL) SET @Country = @Country + '%';

SELECT *
FROM
(
Select A.OrderID
  ,A.CustomerID
  ,C.CompanyName
  ,A.ShipCountry AS Country  
  ,A.EmployeeID AS SalesRepID
  --,T.TerritoryDescription
  --,R.RegionDescription
  ,(E.FirstName + ' ' + E.LastName) AS SalesRep
  ,CAST(A.OrderDate AS DATE) AS OrderDate
  ,S.CompanyName AS Shipper
  ,A.Freight
  ,A.OrderTotal
From
(  
	Select A.OrderID, A.CustomerID, A.ShipCountry, A.OrderDate, A.ShipVia, A.Freight, A.EmployeeID
	  ,SUM(od.Quantity * od.UnitPrice) AS OrderTotal
	From dbo.Orders AS A
	  INNER JOIN dbo.OrderDetails AS od ON od.OrderID = A.OrderID
	Where (A.OrderDate BETWEEN @FromDate2 AND @ToDate2)
	 AND (@OrderID IS NULL or A.OrderID = @OrderID)
	 AND (@CustomerID IS NULL or A.CustomerID LIKE @CustomerID)	
	 AND (@Country IS NULL or A.ShipCountry LIKE @Country)	
	 AND (@SalesRepID IS NULL or A.EmployeeID = @SalesRepID)
	GROUP BY A.OrderID, A.CustomerID, A.OrderDate, A.ShipCountry, A.ShipVia, A.Freight, A.EmployeeID
) A
  INNER JOIN dbo.Customers C ON C.CustomerID = A.CustomerID
  LEFT OUTER JOIN dbo.Employees E ON E.EmployeeID = A.EmployeeID
  LEFT OUTER JOIN dbo.Shippers S ON S.ShipperID = A.ShipVia 
) A
WHERE (@CompanyName IS NULL or A.CompanyName LIKE @CompanyName)
  AND (@SalesRep IS NULL or A.SalesRep LIKE @SalesRep)
  AND (@Shipper IS NULL or A.Shipper LIKE @Shipper)
ORDER BY
   CASE WHEN @OrderBy = 'OrderID' AND @AscDesc2 = 0 THEN A.OrderID END ASC
  ,CASE WHEN @OrderBy = 'OrderID' AND @AscDesc2 = 1 THEN A.OrderID END DESC
  ,CASE WHEN @OrderBy = 'CustomerID' AND @AscDesc2 = 0 THEN A.CustomerID END ASC
  ,CASE WHEN @OrderBy = 'CustomerID' AND @AscDesc2 = 1 THEN A.CustomerID END DESC
  ,CASE WHEN @OrderBy = 'CompanyName' AND @AscDesc2 = 0 THEN A.CompanyName END ASC
  ,CASE WHEN @OrderBy = 'CompanyName' AND @AscDesc2 = 1 THEN A.CompanyName END DESC
  ,CASE WHEN @OrderBy = 'Country' AND @AscDesc2 = 0 THEN A.Country END ASC
  ,CASE WHEN @OrderBy = 'Country' AND @AscDesc2 = 1 THEN A.Country END DESC
  ,CASE WHEN @OrderBy = 'SalesRep' AND @AscDesc2 = 0 THEN A.SalesRep END ASC
  ,CASE WHEN @OrderBy = 'SalesRep' AND @AscDesc2 = 1 THEN A.SalesRep END DESC
  ,CASE WHEN @OrderBy = 'OrderDate' AND @AscDesc2 = 0 THEN A.OrderDate END ASC
  ,CASE WHEN @OrderBy = 'OrderDate' AND @AscDesc2 = 1 THEN A.OrderDate END DESC
  ,CASE WHEN @OrderBy = 'Shipper' AND @AscDesc2 = 0 THEN A.Shipper END ASC
  ,CASE WHEN @OrderBy = 'Shipper' AND @AscDesc2 = 1 THEN A.Shipper END DESC
  ,CASE WHEN @OrderBy = 'Freight' AND @AscDesc2 = 0 THEN A.Freight END ASC
  ,CASE WHEN @OrderBy = 'Freight' AND @AscDesc2 = 1 THEN A.Freight END DESC
  ,CASE WHEN @OrderBy = 'OrderTotal' AND @AscDesc2 = 0 THEN A.OrderTotal END ASC
  ,CASE WHEN @OrderBy = 'OrderTotal' AND @AscDesc2 = 1 THEN A.OrderTotal END DESC

END 

  
GO