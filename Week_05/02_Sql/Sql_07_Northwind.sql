USE Northwind

--SELECT DISTINCT CategoryId FROM Products

-- 1) Bu güne kadar hangi ülkelere kargo göndermiþiz?

--SELECT DISTINCT ShipCountry FROM Orders
--ORDER BY ShipCountry

-- 2) Hangi ülkeye ne kadar satýþ yapmýþýz?

--SELECT  O.ShipCountry, SUM( OD.Quantity * OD.UnitPrice) AS 'Toplam Tutar'
--FROM Orders O INNER JOIN [Order Details]  OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

-- 3 ) En çok satýþ yapýlan 3 ülke

--SELECT TOP(3)  O.ShipCountry, SUM( OD.Quantity * OD.UnitPrice) AS 'Toplam Tutar'
--FROM Orders O INNER JOIN [Order Details]  OD
--ON O.OrderID = OD.OrderID
--GROUP BY O.ShipCountry
--ORDER BY 'Toplam Tutar' DESC

-- 4 ) Elimizde en çok sutoðu bulunan ilk 3 ürün.

--SELECT TOP(3) P.ProductName ,P.UnitsInStock FROM Products P
--ORDER BY P.UnitsInStock DESC

-- 5 ) Hangi kategoriden kaç adet ürünümüz var

--SELECT C.CategoryName , COUNT(*) AS Adet
--FROM Categories C INNER JOIN Products P
--ON C.CategoryID = P.CategoryID
--GROUP BY C.CategoryName
--HAVING COUNT(*)>=10
--ORDER BY Adet DESC

-- 6 ) Hangi üründen kaç adet satýlmýþtýr.

--SELECT P.ProductName, COUNT(*)
--FROM Products P INNER JOIN  [Order Details] OD
--ON P.ProductID=OD.ProductID 
--GROUP BY P.ProductName


-- 7 ) En çok kazandýran ilk 3 ürün hangsidir.

--SELECT TOP(3) P.ProductName, SUM( OD.Quantity*OD.UnitPrice) AS 'Total'
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--GROUP BY P.ProductName
--ORDER BY Total DESC

-- 8 ) Hangi kargo þirketine ne kadar ödeme yapýlmýþtýr?(Freight)

--SELECT S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL DESC

-- 9 ) En az ödeme yapýlmýþ kargo þirketi ?

--SELECT TOP(1) S.CompanyName, SUM(O.Freight) AS TOTAL
--FROM Shippers S INNER JOIN Orders O
--ON S.ShipperID = O.ShipVia
--GROUP BY S.CompanyName
--ORDER BY TOTAL ASC

-- 10 ) Hangi müþteriye ne kadar satýþ yapýlmýþ.

--SELECT C.CompanyName , SUM( OD.Quantity*OD.UnitPrice) AS TOTAL
--FROM Customers C 
--INNER JOIN Orders O ON C.CustomerID = O.CustomerID 
--INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID
--GROUP BY C.CompanyName
--ORDER BY TOTAL DESC

-- 11 ) Bölgelere göre satýþ tutarlarý

--SELECT R.RegionDescription , SUM (OD.Quantity * OD.UnitPrice) AS TOTAL
--FROM Employees E 
--INNER JOIN EmployeeTerritories ET ON E.EmployeeID = ET.EmployeeID
--INNER JOIN Territories T ON ET.TerritoryID = T.TerritoryID
--INNER JOIN Region R ON T.RegionID = R.RegionID
--INNER JOIN Orders O ON E.EmployeeID = O.EmployeeID
--INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
--GROUP BY R.RegionDescription
--ORDER BY TOTAL DESC

-- 12 ) HANGÝ BÖLGEDE HANGÝ ÜRÜNDEN KAÇ PARALIK SATIÞ YAPILMIÞTIR.

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