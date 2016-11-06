
CREATE TABLE Themes
(
ID_THEME INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NameTheme VARCHAR(50)
);

CREATE TABLE Country
(
ID_COUNTRY INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NameCountry VARCHAR(30)
);

CREATE TABLE Authors
(
ID_AUTHOR INT NOT NULL PRIMARY KEY IDENTITY(1,1),
FirstName VARCHAR(10),
LastName VARCHAR(20),
ID_COUNTRY INT NOT NULL REFERENCES Country(ID_COUNTRY)
);


CREATE TABLE Shops
(
ID_SHOP INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NameShop VARCHAR(25),
ID_COUNTRY INT NOT NULL REFERENCES Country(ID_COUNTRY)
);


CREATE TABLE Books
(

ID_BOOK INT NOT NULL PRIMARY KEY IDENTITY(1,1),
NameBook VARCHAR(25),
ID_THEME INT NOT NULL REFERENCES Themes(ID_THEME),
ID_AUTHOR INT NOT NULL REFERENCES Authors(ID_AUTHOR),
Price INT,
DrawingOfBook VARCHAR(25),
DateOfPublish DATE,
Pages INT
);


CREATE TABLE Sales
(
ID_SALE INT NOT NULL PRIMARY KEY IDENTITY(1,1),
ID_BOOK INT NOT NULL REFERENCES Books(ID_BOOK),
DateOfSales DATE,
Price Float,
Quantity INT,
ID_SHOP INT NOT NULL REFERENCES Shops(ID_SHOP)
);

GO

INSERT INTO Themes (NameTheme) VALUES ('History');
INSERT INTO Themes (NameTheme) VALUES ('Fantactic');

INSERT INTO Country (NameCountry) VALUES ('Ukraine');
INSERT INTO Country (NameCountry) VALUES ('USA');


INSERT INTO Authors(FirstName, LastName, ID_COUNTRY) VALUES ('Name1', 'S1', 1);
INSERT INTO Authors(FirstName, LastName, ID_COUNTRY) VALUES ('Name2', 'S2', 1);
INSERT INTO Authors(FirstName, LastName, ID_COUNTRY) VALUES ('Name3', 'S3', 2);

INSERT INTO Shops(NameShop, ID_COUNTRY) VALUES ('Bookva',  1);
INSERT INTO Shops( NameShop, ID_COUNTRY) VALUES ('Plaza',  1);
INSERT INTO Shops(NameShop, ID_COUNTRY) VALUES ('US', 2);


INSERT INTO Books(NameBook, ID_THEME, ID_AUTHOR, Price, DrawingOfBook, Pages) VALUES ('GameOfThone', 2, 2, 500, '',600);
INSERT INTO Books(NameBook, ID_THEME, ID_AUTHOR, Price, DrawingOfBook, Pages) VALUES ('Brothers Grimm', 2, 2, 150, '',400);
INSERT INTO Books(NameBook, ID_THEME, ID_AUTHOR, Price, DrawingOfBook, Pages) VALUES ('Ukraine History', 1, 1, 600, '',2000);

INSERT INTO Sales(ID_BOOK, Price, Quantity, ID_SHOP) VALUES (2, 500, 15, 1);
INSERT INTO Sales(ID_BOOK, Price, Quantity, ID_SHOP) VALUES (2, 150, 4, 2);
INSERT INTO Sales(ID_BOOK, Price, Quantity, ID_SHOP) VALUES (1, 600, 20, 3);
