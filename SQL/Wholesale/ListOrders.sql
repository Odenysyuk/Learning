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
INTO #ListOrders

FROM Stock as st

LEFT OUTER JOIN Product as prod
ON st.ID_Product = prod.ID_Product

LEFT OUTER JOIN Client as cl
ON st.ID_Client = cl.ID_Client

LEFT OUTER JOIN Provider as prov
ON st.ID_Provider = prov.ID_Provider

LEFT OUTER JOIN Worker as wk
ON st.ID_Worker = wk.ID_Worker


 Select
 *
 FROM #ListOrders

 ---Filters
 DECLARE @Provider AS varchar(100)
SET @Provider = 'Asus'

 DECLARE @Client AS varchar(100)
SET @Client = 'Samsung'

 DECLARE @Delivery AS varchar(100)
SET @Delivery = 'self                '

 Select
 *
 FROM #ListOrders
 WHERE 
 Provider = @Provider 

 Select
 *
 FROM #ListOrders
 WHERE 
 Client = @Client 

 Select
 *
 FROM #ListOrders
 WHERE 
[Delivery method] = @Delivery 

