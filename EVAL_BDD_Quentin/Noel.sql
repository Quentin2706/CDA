DROP DATABASE IF EXISTS organisationNoel; 
CREATE DATABASE organisationNoel DEFAULT CHARACTER SET utf8;
USE organisationNoel;

#========================================
# Table : Cadeaux
#========================================

CREATE TABLE Cadeaux(
   idCadeau INT AUTO_INCREMENT PRIMARY KEY,
   libelleCadeau VARCHAR(200)  NOT NULL
)ENGINE = InnoDB;



#========================================
# Table : Lutins
#========================================

CREATE TABLE Lutins(
   idLutin INT AUTO_INCREMENT PRIMARY KEY,
   nomLutin VARCHAR(100)  NOT NULL,
   prenomLutin VARCHAR(50)  NOT NULL
)ENGINE = InnoDB;



#========================================
# Table : Traineaux
#========================================

CREATE TABLE Traineaux(
   idTraineau INT AUTO_INCREMENT PRIMARY KEY,
   taille INT NOT NULL,
   dateMiseService DATE NOT NULL,
   dateRevision DATE
)ENGINE = InnoDB;



#========================================
# Table : Tournees
#========================================

CREATE TABLE Tournees(
   idTournee INT AUTO_INCREMENT PRIMARY KEY,
   heureDepart DATETIME NOT NULL,
   idLutin INT NOT NULL,
   idTraineau INT NOT NULL
)ENGINE = InnoDB;



#========================================
# Table : Rennes
#========================================

CREATE TABLE Rennes(
   idRenne INT AUTO_INCREMENT PRIMARY KEY,
   nomRenne VARCHAR(50)  NOT NULL,
   sexe VARCHAR(1)  NOT NULL,
   dateNaissance DATE NOT NULL
)ENGINE = InnoDB;



#========================================
# Table : Enfants
#========================================

CREATE TABLE Enfants(
   idEnfant INT AUTO_INCREMENT PRIMARY KEY,
   nomEnfant VARCHAR(100)  NOT NULL,
   prenomEnfant VARCHAR(50)  NOT NULL,
   adresse VARCHAR(200)  NOT NULL,
   genre VARCHAR(1) ,
   pourcentageSagesse INT,
   idCadeau INT NOT NULL
)ENGINE = InnoDB;



#========================================
# Table : Equipes
#========================================

CREATE TABLE Equipes(
   idEquipe INT AUTO_INCREMENT PRIMARY KEY,
   idTournee INT NOT NULL,
   idRenne INT NOT NULL
)ENGINE = InnoDB;



#========================================
# Table : HistoriquesResponsabilites
#========================================

CREATE TABLE HistoriquesResponsabilites(
   idHistoriqueResponsabilite INT AUTO_INCREMENT PRIMARY KEY,
   idLutin INT NOT NULL,
   idTraineau INT NOT NULL,
   dateAcquisition VARCHAR(50)  NOT NULL
)ENGINE = InnoDB;


#========================================
# Table : Livraisons
#========================================

CREATE TABLE Livraisons(
   idLivraison INT AUTO_INCREMENT PRIMARY KEY,
   idEnfant INT NOT NULL,
   idTournee INT NOT NULL
)ENGINE = InnoDB;


ALTER TABLE Tournees ADD CONSTRAINT FK_Tournee_Lutin FOREIGN KEY(idLutin) REFERENCES Lutins(idLutin),
                     ADD CONSTRAINT FK_Tournee_Traineau FOREIGN KEY(idTraineau) REFERENCES Traineaux(idTraineau);

ALTER TABLE Enfants ADD CONSTRAINT FK_Enfant_Cadeau FOREIGN KEY(idCadeau) REFERENCES Cadeaux(idCadeau);

ALTER TABLE Equipes ADD CONSTRAINT FK_Equipe_Tournee FOREIGN KEY(idTournee) REFERENCES Tournees(idTournee),
                    ADD CONSTRAINT FK_Equipe_Renne FOREIGN KEY(idRenne) REFERENCES Rennes(idRenne);

ALTER TABLE HistoriquesResponsabilites ADD CONSTRAINT FK_HistoriqueResponsabilite_Lutin FOREIGN KEY(idLutin) REFERENCES Lutins(idLutin),
                                       ADD CONSTRAINT FK_HistoriqueResponsabilite_Traineau FOREIGN KEY(idTraineau) REFERENCES Traineaux(idTraineau);

ALTER TABLE Livraisons ADD CONSTRAINT FK_Livraison_Enfant FOREIGN KEY(idEnfant) REFERENCES Enfants(idEnfant),
                       ADD CONSTRAINT FK_Livraison_Tournee FOREIGN KEY(idTournee) REFERENCES Tournees(idTournee);

