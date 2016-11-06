--1

SELECT AVG(s.Quantity) as 'avg', sh.NameShop 
FROM 
	Sales as s
	INNER JOIN Shops as sh
ON s.[ID_SHOP] = sh.[ID_SHOP]

where  sh.[ID_COUNTRY] in (Select ID_COUNTRY FROM Country WHERE [NameCountry] IN ('English', 'Ukraine'))
AND s.DateOfSales >= '2008-01-01'
and s.DateOfSales <= '2008-09-01'

GROUP BY ROLLUP (sh.NameShop)

GO


SELECT AVG(s.Quantity) as 'avg', sh.NameShop 
FROM 
	Sales as s
	INNER JOIN Shops as sh
ON s.[ID_SHOP] = sh.[ID_SHOP]

where  sh.[ID_COUNTRY] in (Select ID_COUNTRY FROM Country WHERE [NameCountry] IN ('English', 'Ukraine'))
AND s.DateOfSales >= '2008-01-01'
and s.DateOfSales <= '2008-09-01'

GROUP BY CUBE (sh.NameShop)


--2
SELECT
	YEAR(b.DateOfPublish) as 'year of publish',
	a.FirstName +' ' + a.LastName as 'author',
	MAX(b.Price) as 'max amount'
FROM Books as b
Inner join Authors as a
ON b.ID_AUTHOR = a.ID_AUTHOR

GROUP BY GROUPING SETS(YEAR(b.DateOfPublish), a.FirstName +' ' + a.LastName)

--3
SELECT 'Minimal sales' as 'Info', [Bookva], [Plaza]
FROM 
(
	SELECT s.Quantity, sh.NameShop 
	FROM 
	Sales as s INNER JOIN Shops as sh
	ON s.[ID_SHOP] = sh.[ID_SHOP]

	where  YEAR(s.DateOfSales) = 2016 

) AS st
pivot
(
	SUM(Quantity)
	FOR NameShop
	IN ([Bookva], [Plaza])
) AS pv

GO
--4
CREATE VIEW Exspensive(NameBook)
AS
	SELECT
	Books.NameBook
FROM Books
WHERE Books.Price IN (
SELECT Max(Price) 
FROM  Books
INNER JOIN Themes 
ON Books.ID_THEME = Themes.ID_THEME
AND Themes.NameTheme = 'WEB')
go
SELECT 
	*
FROM Exspensive
go

--5

CREATE VIEW ShopsInfo(NameBook)
AS
SELECT
	Sh.NameShop,
	c.NameCountry

from  Shops AS Sh
INNER JOIN Country as c
ON Sh.ID_COUNTRY = c.ID_COUNTRY

ORDER BY Sh.NameShop ASC, c.NameCountry DESC
go

SELECT 
	*
FROM ShopsInfo
go

CREATE VIEW MorePopular(NameBook)
WITH ENCRYPTION
AS
SELECT
	Books.NameBook
FROM Books
WHERE Books.Price IN (
SELECT Max(Price) 
FROM  Books)
go

SELECT 
	*
FROM MorePopular
go