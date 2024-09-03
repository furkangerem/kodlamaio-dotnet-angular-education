-- ANSII
-- SQL is Case Insensitive

-- SELECT
SELECT * FROM Customers
SELECT ContactName,	CompanyName, City FROM Customers
SELECT ContactName Adi,	CompanyName SirketAdi, City Sehir FROM Customers

SELECT * FROM Customers WHERE City = 'London'
SELECT * FROM Customers WHERE City = 'Berlin'

SELECT * FROM Products WHERE categoryId = 1 OR categoryId = 3
SELECT * FROM Products WHERE categoryId = 1 OR UnitPrice >= 3

-- ORDER BY
SELECT * FROM Products ORDER BY ProductName
SELECT * FROM Products ORDER BY CategoryID, ProductName
SELECT * FROM Products ORDER BY UnitPrice ASC -- In default, Ascending (Lowest -> Highest)
SELECT * FROM Products ORDER BY UnitPrice DESC -- Descending (Highest -> Lowest)
SELECT * FROM Products WHERE CategoryID = 1 ORDER BY UnitPrice DESC

SELECT COUNT(*) FROM Products -- Total Row Count
SELECT COUNT(*) FROM Products WHERE CategoryID = 2

-- GROUP BY
SELECT CategoryID, COUNT(*) FROM Products GROUP BY CategoryID

-- HAVING
SELECT CategoryID, COUNT(*) FROM Products WHERE UnitPrice > 20 GROUP BY CategoryID HAVING COUNT(*) < 10

-- JOINS
-- INNER JOIN (Brings result only matched in the two table. If there is mismatched data, it will not fetch it.)
SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
FROM Products INNER JOIN Categories ON Products.CategoryID = Categories.CategoryID
WHERE Products.UnitPrice > 10

-- LEFT JOIN
SELECT * FROM Products PRD INNER JOIN [Order Details] ORD ON PRD.ProductID = ORD.ProductID
SELECT * FROM Products PRD LEFT JOIN [Order Details] ORD ON PRD.ProductID = ORD.ProductID
SELECT * FROM Customers CTM LEFT JOIN Orders ORD ON CTM.CustomerID = ORD.CustomerID WHERE ORD.CustomerID IS NULL