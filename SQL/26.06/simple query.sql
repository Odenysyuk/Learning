SELECT *
FROM Books
WHERE ID_AUTHOR IN  (1, 2, 3)
GO 

SELECT *
FROM Books
WHERE Pages BETWEEN 600 and 630

GO

SELECT *
FROM Books
WHERE NameBook LIKE '%A%' OR NameBook LIKE '%3%'

GO

SELECT *
FROM Books
WHERE NameBook LIKE 'A%'

GO

SELECT *
FROM Books
WHERE NameBook LIKE 'A%'

GO

SELECT *
FROM Books
WHERE ID_THEME <> 1
AND Pages > 3000

GO

SELECT *
FROM Books
WHERE NameBook = '%Microsoft%'
AND  NameBook  <> '%Windows%';

GO

SELECT B.NameBook, T.NameTheme, A.FirstName +' ' + A.LastName as Author
FROM Books as B
LEFT JOIN Themes as T
ON  B.ID_THEME = T.ID_THEME

LEFT JOIN Authors as A
ON  B.ID_AUTHOR = A.ID_AUTHOR

WHERE B.Price < 10

GO

SELECT NameBook
FROM Books
WHERE NameBook LIKE '[%][%][%][%]';
GO

SELECT
	B.NameBook,
	T.NameTheme,
	A.FirstName +' ' + A.LastName as Author,
	B.Price,
	S.Quantity,
	Sh.NameShop

INTO #tempTable

FROM Books as B

LEFT JOIN Themes as T
ON  B.ID_THEME = T.ID_THEME
AND  T.NameTheme = 'Програмування'

LEFT JOIN Authors as A
ON  B.ID_AUTHOR = A.ID_AUTHOR

LEFT JOIN Sales as S
ON  B.ID_BOOK = S.ID_BOOK

LEFT JOIN Shops as Sh
ON  S.ID_SHOP = Sh.ID_SHOP
AND  Sh.ID_COUNTRY <> 1
AND  Sh.ID_COUNTRY <> 2;
SELECT
*
FROM
	#tempTable


