#========================================
#             SCRIPT MYSQL
#========================================

DROP DATABASE IF EXISTS bibliotheque;
CREATE DATABASE bibliotheque DEFAULT CHARACTER SET utf8;
USE bibliotheque;

#========================================
# Table : Auteurs
#========================================
CREATE TABLE Auteurs(
	idAuteur INT AUTO_INCREMENT PRIMARY KEY ,
	nomAuteur VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Catalogues
#========================================
CREATE TABLE Catalogues(
	idCatalogue VARCHAR(50)  ,
	codeCatalogue VARCHAR(50)  UNIQUE
)ENGINE = InnoDB;

#========================================
# Table : Editeurs
#========================================
CREATE TABLE Editeurs(
	idEditeur  PRIMARY KEY ,
	 
)ENGINE = InnoDB;

#========================================
# Table : Genres
#========================================
CREATE TABLE Genres(
	idGenre  PRIMARY KEY ,
	 
)ENGINE = InnoDB;

#========================================
# Table : Abonnés
#========================================
CREATE TABLE Abonnés(
	NumMatricule VARCHAR(50)  ,
	nom VARCHAR(50)  ,
	telephone VARCHAR(50)  ,
	adresse VARCHAR(100)  ,
	dateAdhesion DATE ,
	DDN DATE
)ENGINE = InnoDB;

#========================================
# Table : Usures
#========================================
CREATE TABLE Usures(
	idUsure INT AUTO_INCREMENT PRIMARY KEY ,
	codeUsure VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : categoriesProfessionnelles
#========================================
CREATE TABLE categoriesProfessionnelles(
	idCategorieProfessionnelle INT AUTO_INCREMENT PRIMARY KEY ,
	libelleCategorieProfessionnelle VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Mots_clés
#========================================
CREATE TABLE Mots_clés(
	idMotsClés INT AUTO_INCREMENT PRIMARY KEY ,
	libelleMotCle VARCHAR(50) 
)ENGINE = InnoDB;

#========================================
# Table : Livres
#========================================
CREATE TABLE Livres(
	idLivre INT AUTO_INCREMENT PRIMARY KEY ,
	codeRayon VARCHAR(50)  UNIQUE ,
	idUsure INT  NOT NULL ,
	idCatalogue VARCHAR(50)  NOT NULL
)ENGINE = InnoDB;

#========================================
# Table : acquisitions
#========================================
CREATE TABLE acquisitions(
	idacquisitions INT AUTO_INCREMENT PRIMARY KEY ,
	idLivre INT  ,
	NumMatricule VARCHAR(50)  ,
	dateAcquisition DATETIME
)ENGINE = InnoDB;

#========================================
# Table : Redactions
#========================================
CREATE TABLE Redactions(
	idRedactions INT AUTO_INCREMENT PRIMARY KEY ,
	idAuteur INT  ,
	idLivre INT 
)ENGINE = InnoDB;

#========================================
# Table : editions
#========================================
CREATE TABLE editions(
	ideditions INT AUTO_INCREMENT PRIMARY KEY ,
	idLivre INT  ,
	idEditeur INT 
)ENGINE = InnoDB;

#========================================
# Table : LivresGenres
#========================================
CREATE TABLE LivresGenres(
	idLivresGenres INT AUTO_INCREMENT PRIMARY KEY ,
	idLivre INT  ,
	idGenre INT 
)ENGINE = InnoDB;

#========================================
# Table : Retours
#========================================
CREATE TABLE Retours(
	idRetours INT AUTO_INCREMENT PRIMARY KEY ,
	idLivre INT  ,
	NumMatricule VARCHAR(50)  ,
	dateRetour DATETIME
)ENGINE = InnoDB;

#========================================
# Table : Asso_8
#========================================
CREATE TABLE Asso_8(
	idAsso_8 INT AUTO_INCREMENT PRIMARY KEY ,	NumMatricule VARCHAR(50)  ,
	idCategorieProfessionnelle INT 
)ENGINE = InnoDB;

#========================================
# Table : recherches
#========================================
CREATE TABLE recherches(
	idrecherches INT AUTO_INCREMENT PRIMARY KEY ,
	idLivre INT  ,
	idMotsClés INT 
)ENGINE = InnoDB;

ALTER TABLE Livres ADD CONSTRAINT FK_Livres_Usures FOREIGN KEY(idUsure) REFERENCES Usures(idUsure);
ALTER TABLE Livres ADD CONSTRAINT FK_Livres_Catalogues FOREIGN KEY(idCatalogue) REFERENCES Catalogues(idCatalogue);
ALTER TABLE acquisitions ADD CONSTRAINT FK_acquisitions_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE acquisitions ADD CONSTRAINT FK_acquisitions_Abonnés FOREIGN KEY(NumMatricule) REFERENCES Abonnés(NumMatricule);
ALTER TABLE Redactions ADD CONSTRAINT FK_Redactions_Auteurs FOREIGN KEY(idAuteur) REFERENCES Auteurs(idAuteur);
ALTER TABLE Redactions ADD CONSTRAINT FK_Redactions_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE editions ADD CONSTRAINT FK_editions_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE editions ADD CONSTRAINT FK_editions_Editeurs FOREIGN KEY(idEditeur) REFERENCES Editeurs(idEditeur);
ALTER TABLE LivresGenres ADD CONSTRAINT FK_LivresGenres_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE LivresGenres ADD CONSTRAINT FK_LivresGenres_Genres FOREIGN KEY(idGenre) REFERENCES Genres(idGenre);
ALTER TABLE Retours ADD CONSTRAINT FK_Retours_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE Retours ADD CONSTRAINT FK_Retours_Abonnés FOREIGN KEY(NumMatricule) REFERENCES Abonnés(NumMatricule);
ALTER TABLE Asso_8 ADD CONSTRAINT FK_Asso_8_Abonnés FOREIGN KEY(NumMatricule) REFERENCES Abonnés(NumMatricule);
ALTER TABLE Asso_8 ADD CONSTRAINT FK_Asso_8_categoriesProfessionnelles FOREIGN KEY(idCategorieProfessionnelle) REFERENCES categoriesProfessionnelles(idCategorieProfessionnelle);
ALTER TABLE recherches ADD CONSTRAINT FK_recherches_Livres FOREIGN KEY(idLivre) REFERENCES Livres(idLivre);
ALTER TABLE recherches ADD CONSTRAINT FK_recherches_Mots_clés FOREIGN KEY(idMotsClés) REFERENCES Mots_clés(idMotsClés);