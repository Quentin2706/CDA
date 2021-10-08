DROP DATABASE IF EXISTS temp;
CREATE DATABASE temp DEFAULT CHARACTER SET utf8;
USE temp;

#========================================
# Table : Categories
#========================================


CREATE TABLE Categories(
   IdCategorie INT AUTO_INCREMENT PRIMARY KEY,
   NomCategorie VARCHAR(50) ,
   DescriptionCategorie TEXT , 
   IdCategorie_1 INT NOT NULL
)ENGINE = InnoDB;



#========================================
# Table : Modeles
#========================================

DROP TABLE IF EXISTS Modeles;
CREATE TABLE Modeles(
   IdModele VARCHAR(8) PRIMARY KEY,
   NomModele VARCHAR(50) ,
   DateModele DATE
)ENGINE = InnoDB;


#========================================
# Table : Produits
#========================================

DROP TABLE IF EXISTS Produits;
CREATE TABLE Produits(
   IdProduit INT AUTO_INCREMENT PRIMARY KEY,
   NumSerie VARCHAR(6) ,
   NumProduit VARCHAR(4) ,
   IdModele VARCHAR(8)  NOT NULL
)ENGINE = InnoDB;


#========================================
# Table : Fautes
#========================================

DROP TABLE IF EXISTS Fautes;
CREATE TABLE Fautes(
   IdFaute INT AUTO_INCREMENT PRIMARY KEY,
   TitreFaute VARCHAR(100) ,
   DateDetection DATE,
   Commentaire TEXT,
   DateReparation DATE,
   IdProduit INT NOT NULL,
   IdCategorie INT NOT NULL
)ENGINE = InnoDB;

ALTER TABLE Categories ADD CONSTRAINT FK_Categories_Categories FOREIGN KEY(IdCategorie_1) REFERENCES Categories(IdCategorie);
ALTER TABLE Produits ADD CONSTRAINT FK_Produits_Modeles FOREIGN KEY(IdModele) REFERENCES Modeles(IdModele);
ALTER TABLE Fautes ADD CONSTRAINT FK_Fautes_Produits FOREIGN KEY(IdProduit) REFERENCES Produits(IdProduit),
 ADD CONSTRAINT FK_Fautes_Categories FOREIGN KEY(IdCategorie) REFERENCES Categories(IdCategorie);