-- 1
SELECT
	worker.FullName,
	worker.Age,
	worker.stat as sex,
	worker.AddressWorker,
	worker.Phone,
	worker.Passport,
	position.name as Position,
	position.Salary as Salary,
	position.Obligation as Obligation,
	position.Requirements as Requirements
FROM
 Worker as worker
 INNER JOIN Position as position
 ON worker.ID_Position = position.ID_Position

 --2
SELECT
	product.[Name],
	product.[Producer],	
	product.stat as Packaging,
	product.[StorageConditions],
	product.[ExpirationDate],
	typeProduct.name as [type of product],
	typeProduct.[DescriptionTypeProduct] as [DescriptionTypeProduct],
	typeProduct.[Characteristic] as [Characteristic]

FROM
 Product as product
 INNER JOIN TypeProduct as typeProduct
 ON product.ID_TypeProduct = typeProduct.ID_TypeProduct

 --3
 SELECT
	prov.Name as 'Provider',
	prov.Phone as 'Phone',
	prov.AddressProvider as 'Address',
	prod1.Name as 'product 1',
	prod2.Name as 'product 2',
	prod3.Name as 'product 3'

 FROM
	Provider as prov
	LEFT OUTER JOIN Product as prod1
	ON prov.ID_Product1 = prod1.ID_Product

	LEFT OUTER JOIN Product as prod2
	ON prov.ID_Product2 = prod2.ID_Product

	LEFT OUTER JOIN Product as prod3
	ON prov.ID_Product3 = prod3.ID_Product


--4
 SELECT
	cl.Name as 'client',
	cl.Phone as 'Phone',
	cl.AddressClient as 'Address',
	prod1.Name as 'product 1',
	prod2.Name as 'product 2',
	prod3.Name as 'product 3'

 FROM
	Client as cl
	LEFT OUTER JOIN Product as prod1
	ON cl.ID_Product1 = prod1.ID_Product

	LEFT OUTER JOIN Product as prod2
	ON cl.ID_Product2 = prod2.ID_Product

	LEFT OUTER JOIN Product as prod3
	ON cl.ID_Product3 = prod3.ID_Product

--5
SELECT 
	st.[DateAdded] as 'Date addded',
	st.[OrderDate] as 'Order date',
	st.[DateOfTransmission] as 'Date of transmission',
	st.[stat] as 'Delivery method',
	st.[size] as 'Size',
	st.[Price] as 'Price',
	prod.Name as 'Product',
	cl.Name as 'Client',
	prov.Name as 'Provider',
	wk.FullName as 'Worker'

FROM Stock as st

LEFT OUTER JOIN Product as prod
ON st.ID_Product = prod.ID_Product

LEFT OUTER JOIN Client as cl
ON st.ID_Client = cl.ID_Client

LEFT OUTER JOIN Provider as prov
ON st.ID_Provider = prov.ID_Provider

LEFT OUTER JOIN Worker as wk
ON st.ID_Worker = wk.ID_Worker
