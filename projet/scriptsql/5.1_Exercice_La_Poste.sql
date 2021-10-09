#========================================
#             SCRIPT MYSQL
#========================================

DROP DATABASE IF EXISTS 5.1_Exercice_La_Poste;
CREATE DATABASE 5.1_Exercice_La_Poste;
USE 5.1_Exercice_La_Poste;

#========================================
# Table : Bureaux
#========================================
CREATE TABLE Bureaux(
	idBureau INT AUTO_INCREMENT PRIMARY KEY ,
	codePostal VARCHAR(6) 
)ENGINE = InnoDB;

#========================================
# Table : Types
#========================================
CREATE TABLE Types(
	idType INT AUTO_INCREMENT PRIMARY KEY ,
	libelleType VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Courriers
#========================================
CREATE TABLE Courriers(
	idCourrier INT AUTO_INCREMENT PRIMARY KEY ,
	rueDestinataire VARCHAR(150) NOT NULL ,
	numDestintaire VARCHAR(5) NOT NULL ,
	rueEmetteur VARCHAR(150)  ,
	numEmetteur VARCHAR(50)  ,
	idType INT NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : Transports
#========================================
CREATE TABLE Transports(
	idTransport INT AUTO_INCREMENT PRIMARY KEY ,
	libelleTransport VARCHAR(50)  ,
	taxeCarbonne INT
)ENGINE = InnoDB;

#========================================
# Table : Centres_de_tri
#========================================
CREATE TABLE Centres_de_tri(
	idCentresDeTri INT AUTO_INCREMENT PRIMARY KEY ,
	nomCentreDeTri VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Achemine
#========================================
CREATE TABLE Achemine(
	idAchemine INT AUTO_INCREMENT PRIMARY KEY ,
	idBureau INT  ,
	idTransport INT  ,
	idCentresDeTri INT 
)ENGINE = InnoDB;

#========================================
# Table : Gere
#========================================
CREATE TABLE Gere(
	idGere INT AUTO_INCREMENT PRIMARY KEY ,
	idBureau INT  ,
	idCourrier INT  ,
	dateEnvoi DATE ,
	dateReception DATE
)ENGINE = InnoDB;

ALTER TABLE Courriers ADD CONSTRAINT FK_Courriers_Types FOREIGN KEY(idType) REFERENCES Types(idType);
ALTER TABLE Achemine ADD CONSTRAINT FK_Achemine_Bureaux FOREIGN KEY(idBureau) REFERENCES Bureaux(idBureau);
ALTER TABLE Achemine ADD CONSTRAINT FK_Achemine_Transports FOREIGN KEY(idTransport) REFERENCES Transports(idTransport);
ALTER TABLE Achemine ADD CONSTRAINT FK_Achemine_Centres_de_tri FOREIGN KEY(idCentresDeTri) REFERENCES Centres_de_tri(idCentresDeTri);
ALTER TABLE Gere ADD CONSTRAINT FK_Gere_Bureaux FOREIGN KEY(idBureau) REFERENCES Bureaux(idBureau);
ALTER TABLE Gere ADD CONSTRAINT FK_Gere_Courriers FOREIGN KEY(idCourrier) REFERENCES Courriers(idCourrier);