--Clientes ordenados alfabéticamente por el nombre de la compañía
SELECT CompanyName
FROM Customers
ORDER BY CompanyName ASC;

--Clientes cuyo nombre empieza con “S”
SELECT *
FROM Customers
WHERE CompanyName LIKE 'S%';

--Productos cuyo precio unitario > 50
SELECT *
FROM Products
WHERE UnitPrice > 50;

--Cantidad de productos “Discontinued”
SELECT COUNT(*) AS CantidadDiscontinued
FROM Products
WHERE Discontinued = 1;

--Producto de mayor valor unitario
SELECT TOP 1 *
FROM Products
ORDER BY UnitPrice DESC;

--Producto de mayor valor unitario (con subconsulta)
SELECT ProductName, UnitPrice
FROM Products
WHERE UnitPrice = (
    SELECT MAX(UnitPrice)
    FROM Products
);

--Lista de productos con su categoría (INNER JOIN)
SELECT p.ProductName, c.CategoryName
FROM Products p
INNER JOIN Categories c
    ON p.CategoryID = c.CategoryID;

--Clientes y detalles de pedidos (LEFT JOIN)
SELECT cu.CustomerID, cu.CompanyName, o.OrderID, o.OrderDate
FROM Customers cu
LEFT JOIN Orders o
    ON cu.CustomerID = o.CustomerID;

--Número total de órdenes por cliente
SELECT CustomerID, COUNT(*) AS TotalOrders
FROM Orders
GROUP BY CustomerID;

--Proveedores con más de 3 productos
SELECT s.SupplierID, s.CompanyName, COUNT(*) AS TotalProductos
FROM Suppliers s
INNER JOIN Products p
    ON s.SupplierID = p.SupplierID
GROUP BY s.SupplierID, s.CompanyName
HAVING COUNT(*) > 3;


--Procedimiento almacenado para devolver clientes por país
CREATE PROCEDURE GetCustomersByCountry
    @Country NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Customers
    WHERE Country = @Country;
END;
GO


-- Ejemplo de uso:
EXEC GetCustomersByCountry @Country = 'Germany';