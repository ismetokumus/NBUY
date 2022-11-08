-- 12 ) HANGÝ BÖLGEDE HANGÝ ÜRÜNDEN KAÇ ADET SATIÞ YAPILMIÞTIR.
USE Northwind
SELECT R.RegionDescription, P.ProductName, SUM(OD.Quantity) AS TOTAL 
FROM Region R 
INNER JOIN Territories T ON R.RegionID = T.RegionID
INNER JOIN EmployeeTerritories ET ON T.TerritoryID = ET.TerritoryID
INNER JOIN Employees E ON ET.EmployeeID = E.EmployeeID
INNER JOIN Orders O ON E.EmployeeID = O.EmployeeID
INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
INNER JOIN Products P ON OD.ProductID = P.ProductID
GROUP BY R.RegionDescription , P.ProductName
ORDER BY TOTAL DESC 
