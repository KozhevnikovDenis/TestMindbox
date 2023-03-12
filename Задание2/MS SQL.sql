CREATE TABLE Category
(
  CategoryId INT PRIMARY KEY IDENTITY,
  CategoryName NVARCHAR(50) NOT NULL,
);

CREATE TABLE Product
(
  ProductId INT PRIMARY KEY IDENTITY,
  ProductName NVARCHAR(50) NOT NULL,
);

CREATE TABLE ProductsCategories
(
  ProductId INT FOREIGN KEY REFERENCES Product(ProductId),
  CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId),
  PRIMARY KEY(ProductId, CategoryId),
);

INSERT INTO Category VALUES ('Tableware'), ('Fruit'), ('Gardening');

INSERT INTO Product VALUES ('Fork'), ('Spoon'), ('Apple'), ('Shirt');

INSERT INTO ProductsCategories VALUES 
(
  (SELECT ProductId from Product WHERE ProductName='Fork'), 
  (SELECT CategoryId from Category WHERE CategoryName='Tableware')
), 
(
  (SELECT ProductId from Product WHERE ProductName='Spoon'), 
  (SELECT CategoryId from Category WHERE CategoryName='Tableware')
), 
(
  (SELECT ProductId from Product WHERE ProductName='Apple'),
  (SELECT CategoryId from Category WHERE CategoryName='Fruit')
),
(
  (SELECT ProductId from Product WHERE ProductName='Apple'), 
  (SELECT CategoryId from Category WHERE CategoryName='Gardening')
);

SELECT Product.ProductName, Category.CategoryName FROM Product LEFT JOIN ProductsCategories ON Product.ProductId = ProductsCategories.ProductId LEFT JOIN Category ON ProductsCategories.CategoryId = Category.CategoryId;