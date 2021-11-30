DROP DATABASE IF EXISTS GestionCommande;
CREATE DATABASE GestionCommande DEFAULT CHARACTER SET utf8;
USE GestionCommande;

CREATE TABLE Produits(
   IdProduit INT(11) AUTO_INCREMENT PRIMARY KEY,
   LibelleProduit VARCHAR(50) NOT NULL,
   PrixProduit DECIMAL(15,2) NOT NULL,
   QuantiteProduit INT NOT NULL
)ENGINE=InnoDB;

CREATE TABLE Commandes(
   IdCommande INT(11) AUTO_INCREMENT PRIMARY KEY,
   DateCommande DATE NOT NULL,
   NumeroCommande INT
)ENGINE=InnoDB;

CREATE TABLE Preparations(
   IdPreparation INT(11) AUTO_INCREMENT PRIMARY KEY,
   IdProduit INT(11) NOT NULL ,
   IdCommande INT NOT NULL ,
   DatePreparation DATE NOT NULL
)ENGINE=InnoDB;

ALTER TABLE Preparations ADD CONSTRAINT FK_Produits_Preparation FOREIGN KEY (IdProduit) REFERENCES Produits(idProduit);
ALTER TABLE Preparations ADD CONSTRAINT FK_Commandes_Preparation FOREIGN KEY (IdCommande) REFERENCES Commandes(idCommande);