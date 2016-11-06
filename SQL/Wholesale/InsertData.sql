INSERT INTO Position (Name, Salary, Obligation, Requirements) VALUES ('HR manager', 3000, 'Provide leadership, motivation and mentoring to the HR Specialist team', 'Oversee initiation of HR actions to workforce planning and Disney Global HR Ops for SAP input');
INSERT INTO Position (Name, Salary, Obligation, Requirements) VALUES ('Cleaner', 1500, 'Clean and supply designated facility areas ', 'All thing must be clean');
INSERT INTO Position (Name, Salary, Obligation, Requirements) VALUES ('Lawyer', 3000, 'Give advice to people about law', 'Give advice to people about law');
INSERT INTO Position (Name, Salary, Obligation, Requirements) VALUES ('Seller', 3000, 'Sell product', 'contact with client');
INSERT INTO Position (Name, Salary, Obligation, Requirements) VALUES ('Hight seller', 3000, 'Sell product', 'contact with client');

INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Ivanov Ivan Ivanovych', 30, 'm', 'Rivne, Soborna str. 45/5', '0977777777', 'PU 15689', 1);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Ivanov Cate Ivanovych', 30, 'f', 'Rivne, Soborna str. 45/5', '0977777771', 'PU 75689', 2);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Petrova Cate Ivanovych', 25, 'f', 'Rivne, Chornovola str. 15/5', '0966666661', 'AU 112233', 3);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Free Cate Ivanovych', 27, 'f', 'Rivne, Chornovola str. 63/5', '0966666651', 'EE 669385', 4);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Free Ivan Ivanovych', 30, 'm', 'Rivne, Chornovola str. 63/5', '0966666351', 'YU 123986', 5);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Cate Winick', 23, 'f', 'Rivne, Vidinska str. 36/56', '0977777777', 'PU 36689', 4);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Nom Smith', 30, 'm', 'Rivne, Kyivska str. 15/3', '0977777771', 'PU 75969', 5);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Jams Bond', 36, 'm', 'Rivne, Vidinska str. 10/4', '0966666661', 'AU 136233', 4);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Adam Adam Adamovych', 27, 'm', 'Rivne, Kyivska str. 11/3', '0966666651', 'EE 777385', 5);
INSERT INTO Worker (FullName, Age, stat, AddressWorker, Phone, Passport, ID_Position) 
VALUES ('Podkonjeva Lilia Viktorivna', 30, 'm', 'Rivne, Chornovola str. 152/8', '0966666351', 'YU 223986', 5);

INSERT INTO TypeProduct (Name, DescriptionTypeProduct, Characteristic) 
VALUES ('Mouse', 'futher for computer', 'wireless');
INSERT INTO TypeProduct (Name, DescriptionTypeProduct, Characteristic) 
VALUES ('notebook', 'futher for computer', 'reg bue yellow');
INSERT INTO TypeProduct (Name, DescriptionTypeProduct, Characteristic) 
VALUES ('monitor', 'futher for computer', '15 16 17 18');
INSERT INTO TypeProduct (Name, DescriptionTypeProduct, Characteristic) 
VALUES ('keyboard', 'futher for computer', 'black pink red');
INSERT INTO TypeProduct (Name, DescriptionTypeProduct, Characteristic) 
VALUES ('mp3', 'futher for muzic', 'black pink red grey');


INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (1, 'China', 'Mouse black', 'dry room', 'pc', '2099-07-14');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (1, 'China', 'Mouse red', 'dry room', 'pkg', '2099-07-14');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (2, 'China', 'Notebook black', 'dry room', 'pc', '2099-07-14');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (2, 'China', 'Notebook red', 'dry room', 'pc', '2020-07-14');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (3, 'China', 'Monitor 16', 'dry room', 'pc', '2016-10-14');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (3, 'China', 'Monitor 15.6', 'dry room', 'pc', '2016-08-02');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (4, 'China', 'keyboard black', 'dry room', 'pc', '2090-10-01');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (4, 'China', 'keyboard pink', 'dry room', 'pc', '2200-01-01');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (5, 'China', 'mp3 black', 'dry room', 'pc', '2100-01-01');
INSERT INTO Product (ID_TypeProduct, Producer, Name, StorageConditions, stat, ExpirationDate) 
VALUES (5, 'China', 'mp3 trasland', 'dry room', 'pc', '2100-01-01');


INSERT INTO Provider (Name, AddressProvider, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Asus', 'China Str str 1/1', '3635974281', 1, 3, 5);
INSERT INTO Provider (Name, AddressProvider, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Samsung', 'China Str str 2/1', '0235974281', 10, 4, 6);
INSERT INTO Provider (Name, AddressProvider, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Acer', 'China Str str 5/1', '9235974281', 7, 9, 1);
INSERT INTO Provider (Name, AddressProvider, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Meizu', 'China Str str 35/1', '7235974281', 6, 8, 3);
INSERT INTO Provider (Name, AddressProvider, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Lenovo', 'China Str str 55/1', '7235974281', 4, 5, 6);

INSERT INTO Client (Name, AddressClient, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Asus', 'Ukraine, Rivne Str str 1/1', '3635974281', 1, 3, 5);
INSERT INTO Client (Name, AddressClient, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Samsung', 'Ukraine, Rivne Str str 2/1', '0235974281', 10, 4, 6);
INSERT INTO Client (Name, AddressClient, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Acer', 'Ukraine, Rivne Str str 5/1', '9235974281', 7, 9, 1);
INSERT INTO Client (Name, AddressClient, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Meizu', 'Ukraine, Rivne Str str 35/1', '7235974281', 6, 8, 3);
INSERT INTO Client (Name, AddressClient, Phone, ID_Product1, ID_Product2, ID_Product3) 
VALUES ('Lenovo', 'Ukraine, Rivne Str str 55/1', '7235974281', 4, 5, 6);


INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-08 12:35:00', '2007-06-28 12:00:00', '2007-05-08 12:35:00', 1, 1, 1,'self', 150, 156.36, 5);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-10 12:45:00', '2007-06-28 12:00:00', '2007-05-08 12:35:00', 10, 6, 2,'self', 150, 185.50, 9);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-12 12:00:00', '2007-06-28 12:00:00', '2007-05-08 12:35:00', 3, 3, 3,'self', 200, 1500.00, 6);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-14 12:01:00', '2007-05-18 12:00:00', '2007-05-08 12:35:00', 4, 4, 4,'self', 200, 2000.00, 7);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-16 12:03:00', '2007-05-18 12:00:00', '2007-05-08 12:35:00', 5, 5, 5,'self', 300, 1550.00, 8);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-08 12:35:00', '2007-06-28 12:00:00', '2007-05-08 12:35:00', 6, 1, 1,'self', 150, 1700.00, 9);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-10 12:45:00', '2007-06-28 12:00:00', '2007-05-08 12:35:00', 7, 6, 2,'self', 150, 185.50, 5);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-12 12:00:00', '2007-06-28 12:00:00', '2007-05-08 12:35:00', 8, 3, 3,'self', 200, 100.00, 6);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-14 12:01:00', '2007-05-18 12:00:00', '2007-05-08 12:35:00', 9, 4, 4,'self', 200, 400.00, 7);
INSERT INTO Stock (DateAdded, OrderDate, DateOfTransmission, ID_Product, ID_Provider, ID_Client, stat, size, Price, ID_Worker) 
VALUES ('2007-07-16 12:03:00', '2007-05-18 12:00:00', '2007-05-08 12:35:00', 10, 5, 5,'self', 300, 360.00, 8);


