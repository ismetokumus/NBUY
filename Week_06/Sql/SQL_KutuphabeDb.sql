/*
1) K�t�phaneDb Ad�nda bir veri taban� olu�turunuz.
2) Veri taban�nda a�a��daki tablolar bulunsun:
	Turler (�d,ad)
	Yazarlar(yas)
	Yayinevleri(ad,adres)
	Uyeler
	Kitaplar(yazar,yay�nevi,tur,)
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
	('Roman'),('Hikaye'),('Masal'),('�iir'),('Polisiye')
GO

CREATE TABLE Yazarlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	yas INT NOT NULL,

)
GO

INSERT INTO Yazarlar VALUES
	('Ya�ar Kemal',65),
	('Kemal Z�val�',45),
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
	('Elma','�stanbul'),
	('Fener','Ankara'),
	('�ay','Rize')
GO

CREATE TABLE Uyeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	adSoyad NVARCHAR(50) NOT NULL,
	adres NVARCHAR(20) NOT NULL,
	yas INT NOT NULL
)
GO

INSERT INTO Uyeler VALUES
	('Kerem Ayy�ld�z','�stanbul',28),
	('Bahar Kaplan','�stanbul',26),
	('Furkan G�r','Sivas',35),
	('Bahad�r Say�n','Rize',55),
	('Ahmetcan Y�lmaz','Konya',45)
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
	('ESK�LER',2,2),
	('ESK�LER',1,1)
GO