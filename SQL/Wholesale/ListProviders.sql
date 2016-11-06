 --3
 SELECT
	prov.Name as 'Provider',
	prov.Phone as 'Phone',
	prov.AddressProvider as 'Address',
	prod1.Name as 'product 1',
	prod2.Name as 'product 2',
	prod3.Name as 'product 3'
INTO #ListProviders
 FROM
	Provider as prov
	LEFT OUTER JOIN Product as prod1
	ON prov.ID_Product1 = prod1.ID_Product

	LEFT OUTER JOIN Product as prod2
	ON prov.ID_Product2 = prod2.ID_Product

	LEFT OUTER JOIN Product as prod3
	ON prov.ID_Product3 = prod3.ID_Product
	;
Select
 *
 FROM #ListProviders

 GO
  DECLARE @Provider AS varchar(100)
SET @Provider = 'Seller'


 Select
 *
 FROM #ListProviders
 WHERE 
 Provider = @Provider 
 ;
 GO
 
CREATE FUNCTION FilterOfProviders(@Provider CHAR(100))
RETURNS @result TABLE(Provider VARCHAR(100), Phone VARCHAR(10), Addresss VARCHAR(50),Prod1 VARCHAR(100),Prod2 VARCHAR(100),Prod3 VARCHAR(100))
BEGIN
 INSERT @result 
 Select
 *
 FROM #ListProviders
 WHERE 
 Provider = @Provider 
END
RETURN
GO
