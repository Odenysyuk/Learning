SELECT
	product.[Name],
	product.[Producer],	
	product.stat as Packaging,
	product.[StorageConditions],
	product.[ExpirationDate],
	typeProduct.name as [type of product],
	typeProduct.[DescriptionTypeProduct] as [DescriptionTypeProduct],
	typeProduct.[Characteristic] as [Characteristic]
INTO #ListProducts
FROM
 Product as product
 INNER JOIN TypeProduct as typeProduct
 ON product.ID_TypeProduct = typeProduct.ID_TypeProduct
 ;

 Select
 *
 FROM #ListProducts
  ;

 Select
 *
 FROM #ListProducts
 WHERE 
 [type of product] = 'Mouse'
;
  DECLARE @typeOfProduct AS varchar(100)
SET @typeOfProduct = 'Seller'


 Select
 *
 FROM #ListProducts
 WHERE 
 [type of product] = @typeOfProduct

 GO

CREATE FUNCTION FilterOfProduct(@typeOfProduct CHAR(50))
RETURNS @result TABLE(
Name VARCHAR(150),
Producer VARCHAR(100),
stat Packaging, 
StorageConditions VARCHAR(50),
ExpirationDate datetime,
[type of product] varchar(100),
[DescriptionTypeProduct] VARCHAR(100), 
[Characteristic] VARCHAR(100))
BEGIN
 INSERT @result 
 Select
 *
 FROM #ListProducts
 WHERE 
 [type of product] = @typeOfProduct
END
RETURN

 GO
