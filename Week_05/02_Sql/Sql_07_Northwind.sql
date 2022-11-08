USE Northwind

--SELECT DISTINCT CategoryId FROM Products

-- 1) Bu g�ne kadar hangi �lkelere kargo g�ndermi�iz?

--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

-- 2) Hangi �lkeye ne kadar sat�� yapm���z?

--SELECT  O.ShipCountry, SUM( OD.Quantity * OD.UnitPrice) AS 'Toplam Tutar'
--FROM Orders O INNER JOIN [Order Details]  OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

-- 3 ) En �ok sat�� yap�lan 3 �lke

--SELECT TOP(3)  O.ShipCountry, SUM( OD.Quantity * OD.UnitPrice) AS 'Toplam Tutar'
--FROM Orders O INNER JOIN [Order Details]  OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

-- 4 ) Elimizde en �ok suto�u bulunan ilk 3 �r�n.

--SELECT TOP(3) P.ProductName ,P.UnitsInStock FROM Products P
--ORDER BY P.UnitsInStock DESC

-- 5 ) Hangi kategoriden ka� adet �r�n�m�z var

--SELECT C.CategoryName , COUNT(*) AS Adet
--FROM Categories C INNER JOIN Products P
--ON C.CategoryID = P.CategoryID
--GROUP BY C.CategoryName
--HAVING COUNT(*)>=10
--ORDER BY Adet DESC

-- 6 ) Hangi �r�nden ka� adet sat�lm��t�r.

--SELECT P.ProductName, COUNT(*)
--FROM Products P INNER JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID 
--GROUP BY P.ProductName


-- 7 ) En �ok kazand�ran ilk 3 �r�n hangsidir.

--SELECT TOP(3) P.ProductName, SUM( OD.Quantity*OD.UnitPrice) AS 'Total'
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Total DESC

-- 8 ) Hangi kargo �irketine ne kadar �deme yap�lm��t�r?(Freight)

--SELECT S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL DESC

-- 9 ) En az �deme yap�lm�� kargo �irketi ?

--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL ASC

-- 10 ) Hangi m��teriye ne kadar sat�� yap�lm��.

--SELECT C.CompanyName , SUM( OD.Quantity*OD.UnitPrice) AS TOTAL
--FROM Customers C 
--INNER JOIN Orders O ON C.CustomerID = O.CustomerID 
--INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC

-- 11 ) B�lgelere g�re sat�� tutarlar�

--SELECT R.RegionDescription , SUM (OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
--INNER JOIN Territories T ON ET.TerritoryID = T.TerritoryID
--INNER JOIN Region R ON T.RegionID = R.RegionID
--INNER JOIN Orders O ON E.EmployeeID = O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC

-- 12 ) HANG� B�LGEDE HANG� �R�NDEN KA� PARALIK SATI� YAPILMI�TIR.

SELECT R.RegionDescription , P.ProductName, SUM (OD.Quantity * OD.UnitPrice) AS TOTAL
FROM Employees E 
INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
INNER JOIN Territories T ON ET.TerritoryID = T.TerritoryID
INNER JOIN Region R ON T.RegionID = R.RegionID
INNER JOIN Orders O ON E.EmployeeID = O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
INNER JOIN Products P ON OD.ProductID = P.ProductID
GROUP BY R.RegionDescription , P.ProductName
ORDER BY R.RegionDescription, P.ProductName, TOTAL DESC