IF OBJECT_ID('Products', 'U') IS NOT NULL
    DROP TABLE Products;

CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);

INSERT INTO Products (ProductName, Category, Price)
VALUES
('iPhone 14', 'Electronics', 999.99),
('Samsung Galaxy', 'Electronics', 899.99),
('MacBook Pro', 'Electronics', 1999.99),
('HP Laptop', 'Electronics', 799.99),
('Dell XPS', 'Electronics', 1199.99),
('Nike Shoes', 'Footwear', 149.99),
('Adidas Sneakers', 'Footwear', 139.99),
('Puma Runners', 'Footwear', 129.99),
('Formal Shoes', 'Footwear', 119.99),
('Flip Flops', 'Footwear', 49.99);
SELECT *
FROM (
    SELECT 
        ProductName,
        Category,
        Price,
        ROW_NUMBER() OVER (PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
) AS RankedProducts
WHERE RowNum <= 3;
SELECT *
FROM (
    SELECT 
        ProductName,
        Category,
        Price,
        RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS RankNum
    FROM Products
) AS RankedProducts
WHERE RankNum <= 3;
SELECT *
FROM (
    SELECT 
        ProductName,
        Category,
        Price,
        DENSE_RANK() OVER (PARTITION BY Category ORDER BY Price DESC) AS DenseRankNum
    FROM Products
) AS RankedProducts
WHERE DenseRankNum <= 3;