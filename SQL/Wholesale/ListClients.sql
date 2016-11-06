--4
 SELECT
	cl.Name as 'client',
	cl.Phone as 'Phone',
	cl.AddressClient as 'Address',
	prod1.Name as 'product 1',
	prod2.Name as 'product 2',
	prod3.Name as 'product 3'
INTO #ListClients

 FROM
	Client as cl
	LEFT OUTER JOIN Product as prod1
	ON cl.ID_Product1 = prod1.ID_Product

	LEFT OUTER JOIN Product as prod2
	ON cl.ID_Product2 = prod2.ID_Product

	LEFT OUTER JOIN Product as prod3
	ON cl.ID_Product3 = prod3.ID_Product
 ;
 Select
 *
 FROM #ListClients
GO
 DECLARE @Name AS varchar(100)
SET @Name = 'Asus'

 Select
 *
 FROM #ListClients
 WHERE 
 client = @Name 

 GO

CREATE FUNCTION FilterOfClients(@Name CHAR(50))
RETURNS @result TABLE(client VARCHAR(150),P VARCHAR(50),a VARCHAR(100), n1 VARCHAR(100), n2 VARCHAR(100), n3 VARCHAR(100))
BEGIN
 INSERT @result 
  Select
 *
 FROM #ListClients
 WHERE 
 client = @Name 
RETURN

 