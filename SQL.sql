SELECT ProductName AS Product, Categories.Name AS Category
FROM Products
LEFT JOIN Categories ON Products.CategoryId = Categories.Id
