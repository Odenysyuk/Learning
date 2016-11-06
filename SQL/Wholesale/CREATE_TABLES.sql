CREATE TABLE Position
(
ID_Position INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(100),
Salary smallmoney,
Obligation VARCHAR(100),
Requirements VARCHAR(100)
);

CREATE TABLE Worker
(
ID_Worker INT NOT NULL PRIMARY KEY IDENTITY(1,1),
FullName VARCHAR(150),
Age INT,
stat Sex,
AddressWorker VARCHAR(100),
Phone VARCHAR(10),
Passport VARCHAR(50),
ID_Position INT NOT NULL REFERENCES Position(ID_Position)
);

CREATE TABLE TypeProduct
(
ID_TypeProduct INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(50),
DescriptionTypeProduct VARCHAR(100),
Characteristic VARCHAR(100)
);

CREATE TABLE Product
(
ID_Product INT NOT NULL PRIMARY KEY IDENTITY(1,1),
ID_TypeProduct INT NOT NULL REFERENCES TypeProduct(ID_TypeProduct),
Producer VARCHAR(50),
Name VARCHAR(50),
StorageConditions VARCHAR(50),
stat Packaging,
ExpirationDate date
);

CREATE TABLE Provider
(
ID_Provider INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(50),
AddressProvider VARCHAR(150),
Phone VARCHAR(10),
ID_Product1 INT NOT NULL REFERENCES Product(ID_Product),
ID_Product2 INT NOT NULL REFERENCES Product(ID_Product),
ID_Product3 INT NOT NULL REFERENCES Product(ID_Product)
);

CREATE TABLE Client(
ID_Client INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(50),
AddressClient VARCHAR(150),
Phone VARCHAR(10),
ID_Product1 INT NOT NULL REFERENCES Product(ID_Product),
ID_Product2 INT NOT NULL REFERENCES Product(ID_Product),
ID_Product3 INT NOT NULL REFERENCES Product(ID_Product)
)

CREATE TABLE Stock(
DateAdded smalldatetime,
OrderDate smalldatetime,
DateOfTransmission smalldatetime,
ID_Product INT NOT NULL REFERENCES Product(ID_Product),
ID_Provider INT NOT NULL REFERENCES Provider(ID_Provider),
ID_Client INT NOT NULL REFERENCES Client(ID_Client),
stat DeliveryMethod,
size Float,
Price smallmoney,
ID_Worker INT NOT NULL REFERENCES Worker(ID_Worker)
)