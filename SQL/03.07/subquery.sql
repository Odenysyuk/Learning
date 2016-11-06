
SELECT
	*
FROM Books
WHERE ID_BOOK in (
				Select
				ID_BOOK
				FROM Sales
				GROUP BY ID_BOOK
				HAVING COUNT(ID_SHOP)> 1);
SELECT
	*
FROM
	Authors
WHERE ID_AUTHOR IN (SELECT ID_AUTHOR FROM Books)
;

SELECT
	*
FROM 
	Authors
WHERE 
	ID_COUNTRY IN(SELECT ID_COUNTRY FROM Shops)
;

SELECT
	A.FirstName + ' ' + A.LastName as Name
FROM 
	Authors as A LEFT OUTER JOIN Books as B
	ON A.ID_AUTHOR = B.ID_AUTHOR
	AND B.ID_THEME IN (Select ID_THEME FROM Themes WHERE NameTheme = 'C & C++')

UNION ALL

SELECT
	A.FirstName + ' ' + A.LastName as Name
FROM 
	Authors as A LEFT OUTER JOIN Books as B
	ON A.ID_AUTHOR = B.ID_AUTHOR
	AND YEAR(B.DateOfPublish) = 2000

UNION ALL

SELECT
	A.FirstName + ' ' + A.LastName as Name
FROM 
	Authors as A LEFT OUTER JOIN Books as B
	ON A.ID_AUTHOR = B.ID_AUTHOR
	AND B.Price > 1500

ORDER BY 1 DESC

;

SELECT
	'MIn sales:', Sh.NameShop
FROM 
	Shops as Sh
LEFT OUTER JOIN Sales as S
ON Sh.ID_SHOP = S.ID_SHOP
AND S.Quantity = (SELECT MIN(Quantity) FROM Sales)

UNION 
SELECT
	'Max sales:', Sh.NameShop
FROM 
	Shops as Sh
LEFT OUTER JOIN Sales as S
ON Sh.ID_SHOP = S.ID_SHOP
AND S.Quantity = (SELECT MAX(Quantity) FROM Sales)
;

SELECT
	*
FROM 
	Authors
WHERE 
	NOT EXISTS (SELECT ID_AUTHOR FROM Books as B WHERE B.ID_AUTHOR = ID_AUTHOR)
;

SELECT
	ID_AUTHOR
FROM 
	Authors

EXCEPT

SELECT 
	ID_AUTHOR 
FROM 
	Books 
;

CREATE TABLE ShopAuthors
(
ID_ShopAuthors INT NOT NULL PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(10),
LastName VARCHAR(20),
NameShop VARCHAR(25),
NameCountry VARCHAR(30)
)

GO
;
INSERT INTO ShopAuthors(FirstName, LastName, NameShop, NameCountry)
SELECT 

	A.FirstName,
	A.LastName,
	Sh.NameShop,
	C.ID_COUNTRY
FROM Authors as A
LEFT OUTER JOIN Books as B
ON A.ID_AUTHOR = B.ID_AUTHOR

INNER JOIN Sales as S
ON B.ID_BOOK = S.ID_BOOK
AND S.ID_SALE IN (SELECT ID_SALE FROM Sales GROUP BY ID_SALE HAVING COUNT(ID_SHOP) > 1)

LEFT OUTER JOIN Shops as Sh
ON S.ID_SHOP = Sh.ID_SHOP

INNER JOIN Country as C
ON A.ID_COUNTRY = C.ID_COUNTRY

;

DELETE FROM Books
WHERE Pages > (SELECT AVG(Pages) FROM Books)
;
 
 DELETE FROM Books
WHERE ID_AUTHOR IS NULL
;
DELETE FROM Shops 
WHERE ID_COUNTRY IN (SELECT ID_COUNTRY FROM Country WHERE NameCountry = 'England')
;
UPDATE Sales
SET Price = Price *1.1, Quantity = Quantity + 10
WHERE (ID_SHOP = (Select ID_SHOP FROM Shops WHERE ID_COUNTRY = 1))
