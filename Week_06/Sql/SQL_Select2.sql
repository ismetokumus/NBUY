--USE HastaneDb
--SELECT * FROM Bolumler

--USE HastaneDb
--SELECT * FROM Doktorlar

--USE HastaneDb
--SELECT adSoyad AS'AD SOYAD',adres AS 'ADRES' FROM Doktorlar

--FÝLTERELEME--


--SELECT * FROM Doktorlar WHERE id=5
--SELECT * FROM Doktorlar WHERE adSoyad='TUNA SEFER'
--SELECT * FROM Doktorlar WHERE adSoyad !='TUNA SEFER'
--SELECT * FROM Doktorlar WHERE id=3 OR id=6
--SELECT * FROM Doktorlar WHERE NOT adSoyad='TUNA SEFER'
--SELECT * FROM Doktorlar WHERE  bolumId=5 AND adres='ÝZMÝR'
--SELECT * FROM Doktorlar WHERE  id>=6

--SELECT * FROM Doktorlar WHERE adres IN ('ANKARA','ÝSTANBUL')

--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'T%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'TUT%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%Evgar'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE '%s%'

--SELECT * FROM Doktorlar WHERE adSoyad LIKE '_e%'
--SELECT * FROM Doktorlar WHERE adSoyad LIKE 'd_m%'

--SIRALAMA---

--SELECT * FROM Doktorlar ORDER BY adSoyad
--SELECT * FROM Doktorlar ORDER BY adSoyad DESC
--SELECT * FROM Doktorlar ORDER BY adres
--SELECT * FROM Doktorlar ORDER BY adres, adSoyad DESC

--HESAPLAMA

--USE KUTUPHANEDB
--SELECT * FROM KÝTAPLAR

--SELECT MIN(sayfaSayisi) as 'En Az Sayfa Sayýsý' FROM Kitaplar
--SELECT Max(sayfaSayisi) as 'En Yüksek Sayfa Sayýsý' FROM Kitaplar
--SELECT COUNT(*) FROM Kitaplar

--USE HastaneDb
--SELECT COUNT(*) FROM Doktorlar
--SELECT COUNT(bolumId) FROM Doktorlar

--USE KutuphaneDb

--SELECT AVG(sayfaSayisi) FROM Kitaplar
--SELECT SUM(stok) FROM Kitaplar
--SELECT SUM(stok * sayfaSayisi) FROM Kitaplar

--STRING 

--USE HastaneDb
--SELECT LEN('Ýsmet Okumuþ')
--SELECT adSoyad, LEN(adSoyad) as 'Uzunluk' FROM Doktorlar
--SELECT 
--	adSoyad,
--	LEFT(adSoyad,3) as 'Ýlk Üç Karakter', 
--	LEN(adSoyad) as 'Uzunluk' 
--FROM Doktorlar

--SELECT
--	adSoyad,
--	UPPER(adSoyad) as 'Büyük',
--	LOWER(adSoyad) as 'Küçük'
--FROM Doktorlar
--SELECT
--	REPLACE('Ýsmet Okumuþ','u','Merhaba')

--SELECT
--	LOWER( REPLACE('Ýsmet Okumuþ',' ','')) + '@benimfirmam.com'

--SELECT 
--	adSoyad,
--	REPLACE( LOWER(adSoyad),' ','') + '@firma.com' as 'Mail Adresi'
--FROM Doktorlar

--sercan furkan adýnda amasyada yaþýyan bölümü 3 olan doktoru kaydedecek sorguyu
--yazýnýz.

--USE HastaneDb
--INSERT INTO Doktorlar VALUES
--('Sercan Furkan','Amasya',3)

--GÜNCELLEME
--USE HastaneDb
--UPDATE Doktorlar SET adSoyad = 'Sercan Ahmet Furkan'
--WHERE id=12

--USE HastaneDb
--UPDATE Doktorlar SET adSoyad = 'Al Sana Yeni Ýsim'

--USE KutuphaneDb
--UPDATE Kitaplar SET sayfaSayisi= sayfaSayisi * 1.2


--SÝLME

--USE HastaneDb
--DELETE FROM Doktorlar
--WHERE id=6

USE HastaneDb
DELETE FROM Doktorlar
WHERE bolumId IS NULL



