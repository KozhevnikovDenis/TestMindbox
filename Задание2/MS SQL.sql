CREATE TABLE Category
(
  Id INT PRIMARY KEY IDENTITY,
  CategoryName NVARCHAR(50) NOT NULL,
);

CREATE TABLE Product
(
  Id INT PRIMARY KEY IDENTITY,
  ProductName NVARCHAR(50) NOT NULL,
  CategoryID INT REFERENCES Category(Id) ON DELETE CASCADE,
);

INSERT INTO Category VALUES ('Tableware'), ('Fruit');

INSERT INTO Product (ProductName, CategoryID) VALUES 
(
  'Fork',
  (SELECT Id from Category WHERE CategoryName='Tableware')
),
(
  'Spoon',
  (SELECT Id from Category WHERE CategoryName='Tableware')
),
(
  'Apple',
  (SELECT Id from Category WHERE CategoryName='Fruit')
),
(
  'Apple',
  (SELECT Id from Category WHERE CategoryName='Gardening')
);

INSERT INTO Product (ProductName) VALUES ('Shirt');

SELECT Product.ProductName, Category.CategoryName FROM Category RIGHT JOIN Product ON Product.CategoryID = Category.Id;