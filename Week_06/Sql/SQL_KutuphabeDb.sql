/*
1) KütüphaneDb Adýnda bir veri tabaný oluþturunuz.
2) Veri tabanýnda aþaðýdaki tablolar bulunsun:
	Turler (ýd,ad)
	Yazarlar(yas)
	Yayinevleri(ad,adres)
	Uyeler
	Kitaplar(yazar,yayýnevi,tur,)
	OduncIslemleri(uyeadSoyad,
*/

USE MASTER 
GO

DROP DATABASE IF EXISTS KutuphaneDb
GO

CREATE DATABASE KutuphaneDb
GO

USE KutuphaneDb
GO

CREATE TABLE Turler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	turAd NVARCHAR(30) NOT NULL
	)
GO

INSERT INTO Turler VALUES
	('Roman'),('Hikaye'),('Masal'),('Þiir'),('Polisiye')
GO

CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	yas INT NOT NULL,

)
GO

INSERT INTO Yazarlar VALUES
	('Yaþar Kemal',65),
	('Kemal Zývalý',45),
	('Fatih Parapan',38),
	('Emin Bener',48)
GO

CREATE TABLE YayinEvleri(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(50) NOT NULL
)
GO

INSERT INTO YayinEvleri VALUES
	('Elma','Ýstanbul'),
	('Fener','Ankara'),
	('Çay','Rize')
GO

CREATE TABLE Uyeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(20) NOT NULL,
	yas INT NOT NULL
)
GO

INSERT INTO Uyeler VALUES
	('Kerem Ayyýldýz','Ýstanbul',28),
	('Bahar Kaplan','Ýstanbul',26),
	('Furkan Gür','Sivas',35),
	('Bahadýr Sayýn','Rize',55),
	('Ahmetcan Yýlmaz','Konya',45)
GO

CREATE TABLE Kitaplar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	kitapAd NVARCHAR(50) UNIQUE,
	YayinEvleriID INT NOT NULL,
	YazarlarId INT NOT NULL UNIQUE,
	tulerId INT FOREIGN KEY 
	FOREIGN KEY (YayinEvleriID) REFERENCES YayinEvleri(id),
	FOREIGN KEY (YazarlarId) REFERENCES Yazarlar(id)

)
GO

INSERT INTO Kitaplar VALUES
	('ESKÝLER',2,2),
	('ESKÝLER',1,1)
GO