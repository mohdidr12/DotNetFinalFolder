

Create table Category1(CategoryId int NOT NULL primary key , CategoryName varchar(50))

Create table Product1(ProductId int NOT NULL primary key , ProductName varchar(50),Price decimal(18,2),CategoryId int  NOT NULL , FOREIGN KEY (CategoryId) REFERENCES Category1(CategoryId))


