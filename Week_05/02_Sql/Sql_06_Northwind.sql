USE Northwind

--SELECT *
--FROM Customers C INNER JOIN Orders O
--ON C.CustomerID = O.CustomerID

--SELECT *
--FROM Customers C LEFT JOIN Orders O
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--SELECT C.CompanyName
--FROM Orders O  RIGHT JOIN Customers C
--ON C.CustomerID = O.CustomerID
--WHERE O.OrderID IS NULL

--Hiç satýþý yapýlmamýþ ürünler.

--SELECT P.ProductName
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--Henüz satýþ yapamamýþ çalýþanlarý listeleyin

SELECT E.FirstName + ''+ E.LastName AS 'Ad Soyad'
FROM Employees E LEFT JOIN  Orders O 
ON O.EmployeeID= E.EmployeeID
WHERE O.EmployeeID IS NULL