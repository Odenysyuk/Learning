
CREATE VIEW ShopsInfo(NameShop, NameCountry)
AS
SELECT
	Sh.NameShop,
	case
		when c.NameCountry = 'Ukraine' Then    c.NameCountry + ' UA'
		when c.NameCountry = 'Ukraine' Then    c.NameCountry + ' UA'
		else
			c.NameCountry
	End as 'NameCountry'

from  Shops AS Sh
INNER JOIN Country as c
ON Sh.ID_COUNTRY = c.ID_COUNTRY

ORDER BY Sh.NameShop ASC, c.NameCountry DESC
go

SELECT 
	*
FROM ShopsInfo
go

--
UPDATE Books SET Price = Case when year(DateOfPublish) < 2008 then Price + 1000  else Price + 1000 end

--
WITH Statictic(Quantity, DateOfSales, NameShop)
AS
(Select 
	SUM(Quantity),
	Min(DateOfSales), 
	Shops.NameShop 
FROM Sales 
INNER JOIN Shops 
ON Sales.ID_SHOP = Shops.ID_SHOP 
GROUP BY Shops.NameShop)

--
Create proc Show 
as
Select
*
FROM Sales as S
INNER JOIN Shops as Sh
On S.ID_SHOP = S.ID_SHOP
INNER JOINodenysuyk@kt Country as C
ON Sh.ID_COUNTRY = C.ID_COUNTRY

--
CREATE PROCEDURE sp_max_munber
@number1 int,
@number2 int
as
IF(@number1 > @number2)  
	RETURN @number1; 
ELSE
	return @number2
--
Create procedure factorial_ @number int
AS
Begin
DECLARE @res int 
set  @res = 1
IF(@number < 1)
Begin
	return @res;
END
ELSE
Begin
	while(@number > 1)
	bEGIN
		set @res = @res * @number;
		set @number = @number - 1;		
	end
END
return @res;

END