CREATE DATABASE SirketDb2
 GO

 USE SirketDb2

 CREATE TABLE Departmanlar(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
 )

 INSERT INTO Departmanlar(ad) VALUES 
	('Muhasebe'),
	('Teknik'),
	('Satýþ'),
	('ÝK'),
	('Yönetim')

/*
	-ÝÞÇÝ,MUHASEBE UZMANI, SATIÞCI, IK UZMANI, IK STAJYERÝ, YÖNETÝCÝ, YÖNETÝCÝ YARDIMCISI
*/

CREATE TABLE Unvanlar(
	id INT  NOT NULL PRIMARY KEY IDENTITY(1,1),
	unvan NVARCHAR(MAX) NOT NULL,
)

INSERT INTO Unvanlar(unvan) VALUES
	('Ýþçi'),
	('Muhasebe Uzmaný'),
	('Satýþcý'),
	('IK Uzmaný'),
	('IK Stajyer'),
	('Yönetici'),
	('Yönetici Yardýmcýsý')

USE SirketDb2
CREATE TABLE Iller(
	id CHAR(2) NOT NULL PRIMARY KEY,
	il NVARCHAR(MAX) NOT NULL,
)

INSERT INTO Iller(id,il) VALUES
	('34','Ýstanbul'),
	('06','Ankara'),
	('35','Ýzmir'),
	('58','Sivas'),
	('41','Ýzmit')

USE SirketDb2
CREATE TABLE Ilceler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
	ilId CHAR(2) NOT NULL,
	FOREIGN KEY(ilId) REFERENCES Iller(id),
)

INSERT INTO Ilceler (ad,ilId) VALUES
	('Kadýköy','34'),
	('Beþiktaþ','34'),
	('Avcýlar','34'),
	('Konak','35'),
	('Yeni Mahalle','06'),
	('Çankaya','06'),
	('Suþehri','58')

USE SirketDb2
CREATE TABLE Personeller(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
	soyad NVARCHAR(MAX) NOT NULL,
	cinsiyet BIT NOT NULL,
	dogumTarihi date not null,
	ikametgahIlceId int not null,
	isebaslamaTarihi date not null,
	departmanId int not null,
	unvanId int not null,
	maas money not null,
	FOREIGN KEY(ikametgahIlceId) REFERENCES Ilceler(id),
	FOREIGN KEY(departmanId) REFERENCES Departmanlar(id),
	FOREIGN KEY(unvanId) REFERENCES Unvanlar(id)
)

INSERT INTO Personeller(ad,soyad,cinsiyet,dogumTarihi,ikametgahIlceId,isebaslamaTarihi,departmanId,unvanId,maas) VALUES
('Alican','Kabak',0,'1999-05-15',1,'2021-11-10',1,4,12500),
('Sude','Canöz',1,'1999-05-15',2,'2021-11-10',2,3,112500),
('Kerem','Ay',0,'1999-05-15',3,'2021-11-10',3,2,212500),
('Hatice','Ak',1,'1999-05-15',4,'2021-11-10',4,1,12500),
('Tuðçe','Eyiz',1,'1999-05-15',5,'2021-11-10',5,7,33500),
('Burak','Kabak',0,'1999-05-15',6,'2021-11-10',1,6,12500),
('Kemal','Cin',0,'1999-05-15',7,'2021-11-10',2,5,12500),
('Fatih','Fil',0,'1999-05-15',1,'2021-11-10',3,4,12500),
('Ayþe','Gül',1,'1999-05-15',2,'2021-11-10',4,3,12500),
('Selçuk','Tepe',0,'1999-05-15',3,'2021-11-10',5,2,12500),
('Arda','Güler',0,'1999-05-15',4,'2021-11-10',1,1,12500)

USE SirketDb2
CREATE TABLE Projeler(
	id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	ad NVARCHAR(MAX) NOT NULL,
	baslamaTarihi DATE NOT NULL,
	planlananBitisTarihi DATE NOT NULL
)

INSERT INTO Projeler VALUES
('Mutlu Çucuklar','1999-12-15','2002-12-18'),
('Mutlu Çucuklar','1999-12-15','2002-12-18'),
('Mutlu Çucuklar','1999-12-15','2002-12-18'),
('Mutlu Çucuklar','1999-12-15','2002-12-18')

