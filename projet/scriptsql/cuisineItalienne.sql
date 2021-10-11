#========================================
#             SCRIPT MYSQL
#========================================

DROP DATABASE IF EXISTS cuisineItalienne DEFAULT CHARACTER SET utf8 ;
CREATE DATABASE cuisineItalienne;
USE cuisineItalienne;

#========================================
# Table : Clients
#========================================
CREATE TABLE Clients(
	idClient INT AUTO_INCREMENT PRIMARY KEY ,
	nomClient VARCHAR(50)  NOT NULL ,
	prenomClient VARCHAR(50)  NOT NULL ,
	DDN DATE NOT NULL ,
	courriel VARCHAR(100)  ,
	telephone VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : TableCuisine
#========================================
CREATE TABLE TableCuisine(
	numeroTable INT ,
	nbCouvert INT NOT NULL ,
	type VARCHAR(50)  NOT NULL ,
	supplement DOUBLE
)ENGINE = InnoDB;

#========================================
# Table : Types
#========================================
CREATE TABLE Types(
	idType INT AUTO_INCREMENT PRIMARY KEY ,
	libelleType VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Met
#========================================
CREATE TABLE Met(
	idMet INT AUTO_INCREMENT PRIMARY KEY ,
	nom VARCHAR(50)  NOT NULL ,
	prix DOUBLE NOT NULL ,
	idType INT  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Tickets
#========================================
CREATE TABLE Tickets(
	idTicket INT AUTO_INCREMENT PRIMARY KEY ,
	numero BIGINT NOT NULL UNIQUE ,
	dateTicket DATETIME NOT NULL ,
	nbCouvert INT NOT NULL ,
	addition DOUBLE NOT NULL ,
	idClient INT  NOT NULL ,
	numeroTable INT NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Commandes
#========================================
CREATE TABLE Commandes(
	idCommandes INT AUTO_INCREMENT PRIMARY KEY ,
	idTicket INT  ,
	idMet INT 
)ENGINE = InnoDB;

ALTER TABLE Met ADD CONSTRAINT FK_Met_Types FOREIGN KEY(idType) REFERENCES Types(idType);
ALTER TABLE Tickets ADD CONSTRAINT FK_Tickets_Clients FOREIGN KEY(idClient) REFERENCES Clients(idClient);
ALTER TABLE Tickets ADD CONSTRAINT FK_Tickets_TableCuisine FOREIGN KEY(numeroTable) REFERENCES TableCuisine(numeroTable);
ALTER TABLE Commandes ADD CONSTRAINT FK_Commandes_Tickets FOREIGN KEY(idTicket) REFERENCES Tickets(idTicket);
ALTER TABLE Commandes ADD CONSTRAINT FK_Commandes_Met FOREIGN KEY(idMet) REFERENCES Met(idMet);