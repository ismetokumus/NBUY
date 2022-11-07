--INNER JOIN

USE Northwind
--SELECT Products.ProductName,Categories.CategoryName FROM Products INNER JOIN Categories
--	ON Products.CategoryID=Categories.CategoryID

--SELECT P.ProductName,C.CategoryName
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID

--SELECT P.ProductName,C.CategoryName,P.UnitPrice
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID
--WHERE CategoryName='Beverages' and P.UnitPrice<=40
--ORDER BY P.UnitPrice DESC

--PRODUCT NAME VE SUPPLER COMPANY NAME Ý GÖSTEREN BÝR SORGU YAZNINZ.

--SELECT P.ProductName , S.CompanyName
--FROM Products P INNER JOIN Suppliers S 
--ON P.SupplierID=S.SupplierID

--Germany'den tedarik edilen ürünlerin listesi(Product name gözükse yeter)
--SELECT P.ProductName
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID=S.SupplierID
--WHERE S.Country='Germany'

--Germany'den tedarik edilen ürünlerin toplam tutarý

--SELECT SUM( P.UnitPrice * P.UnitsInStock) AS 'TOPLAM TUTAR'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID=S.SupplierID
--WHERE S.Country='Germany'

--Chai satýþlarýnýn toplam tutarý

--SELECT SUM( OD.UnitPrice * OD.Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID=OD.ProductID
--WHERE P.ProductName='Chai'

--Germany e yapýlmýþ olan Chai satýþlarýnýn toplam tutarý

--SELECT SUM(OD.UnitPrice * OD.Quantity) 
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID=OD.OrderID INNER JOIN Products P
--ON OD.ProductID=P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'

--Ernst Handel müþterisine yapýlan satýþ tutarýnýn toplamý
SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID=O.OrderID INNER JOIN Customers C
ON O.CustomerID=C.CustomerID
WHERE C.CompanyName='Ernst Handel'