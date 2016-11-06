create function NumbersUnSales()
returns INT
AS
BEGIN

DECLARE @returnvalue INT;
Select
@returnvalue = COUNT(Sh.ID_SHOP)
FROM Shops as Sh
LEFT JOIN Sales as S
ON Sh.ID_SHOP = S.ID_SHOP
WHERE S.ID_SALE IS NULL

return @returnvalue
END

GO

----
create function MaxNumber(@a INT, @b INT, @c INT)
returns INT
AS
BEGIN

return 
CASE
	When @a > @b AND @b> @c THEN @a
	When @b > @a  AND @a > @c THEN @a
	ELSE
		@c
END
END

GO

--

create function FilterBooks(@FirstName CHAR(50), @LastName CHAR(50), @NameTheme CHAR(50), @sort INT)
returns @tableofbooks table (NameBook varchar(50))
AS

BEGIN 

if(@sort = 1)
BEGIN
	INSERT @tableofbooks
	SELECT
		b.NameBook
	FROM
	Books as b
	INNER JOIN Authors as a
	ON b.ID_AUTHOR = a.ID_AUTHOR
	AND a.FirstName = @FirstName
	AND a.LastName = @LastName

	INNER JOIN Themes as th
	ON b.ID_THEME = th.ID_THEME
	AND th.NameTheme = @NameTheme

	Order by  a.LastName ASC
END
ELSE
BEGIN
	INSERT @tableofbooks
	SELECT
		b.NameBook
	FROM
	Books as b
	INNER JOIN Authors as a
	ON b.ID_AUTHOR = a.ID_AUTHOR
	AND a.FirstName = @FirstName
	AND a.LastName = @LastName

	INNER JOIN Themes as th
	ON b.ID_THEME = th.ID_THEME
	AND th.NameTheme = @NameTheme

	Order by  a.LastName DESC
END

RETURN;
END

GO

--
create function AVGSales(@Date datetime)
returns INT
AS
BEGIN

DECLARE @returnvalue INT;
Select
@returnvalue = AVG(S.Price)
FROM Sales as S

WHERE S.DateOfSales > @Date

return @returnvalue
END

GO

---

create function MaxSales(@Theme varchar(50))
returns INT
AS
BEGIN

DECLARE @returnvalue INT;
Select
@returnvalue = MAX(Sales.Price)
FROM
Sales 
INNER JOIN Books 
ON Sales.ID_BOOK = Books.ID_BOOK

INNER JOIN Themes
ON Books.ID_THEME = Themes.ID_THEME
AND Themes.NameTheme = @Theme

return @returnvalue
END

GO
--

create function ShowShop(@ID_Shop INT)
returns table 
AS
RETURN (Select * FROM Shops WHERE ID_SHOP = @ID_Shop);

GO
--
DECLARE curs CURSOR SCROLL
FOR SELECT * FROM Books;

OPEN curs;

FETCH NEXT FROM curs;

FETCH NEXT FROM curs;

FETCH PRIOR FROM curs;

FETCH ABSOLUTE 3 FROM curs;

FETCH RELATIVE 1 FROM curs;

FETCH RELATIVE -2 FROM curs;

CLOSE curs;
DEALLOCATE curs