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

--Hi� sat��� yap�lmam�� �r�nler.

--SELECT P.ProductName
--FROM Products P LEFT JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE OD.ProductID IS NULL

--Hen�z sat�� yapamam�� �al��anlar� listeleyin

SELECT E.FirstName + ''+ E.LastName AS 'Ad Soyad'
FROM Employees E LEFT JOIN  Orders O 
ON O.EmployeeID= E.EmployeeID
WHERE O.EmployeeID IS NULL