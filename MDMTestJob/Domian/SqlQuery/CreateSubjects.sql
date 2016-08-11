CREATE TABLE Customers
					(
						CustomerId INT NOT NULL identity (1, 1) PRIMARY KEY ,
						Name VARCHAR(50),
						Address VARCHAR(50),
						PhoneNum VARCHAR(50)
					)
CREATE TABLE Orders
(
						OrderId INT NOT NULL identity (1, 1) PRIMARY KEY,
						CustomerId INT,
						Number VARCHAR(50),
						Amount INT,
						DueTime DATETIME,
						Description VARCHAR(1000)
) 
					 