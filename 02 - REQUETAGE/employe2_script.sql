DROP DATABASE IF EXISTS employedeux; 
CREATE DATABASE employedeux DEFAULT CHARACTER SET utf8;
USE employedeux;

#========================================
# Table : departement
#========================================

CREATE TABLE departement(
   nodep INT PRIMARY KEY,
   nomdep VARCHAR(150) ,
   ville VARCHAR(100) 
)ENGINE = InnoDB;



#========================================
# Table : employe
#========================================

CREATE TABLE employe(
   noemp INT AUTO_INCREMENT PRIMARY KEY,
   nomemp VARCHAR(100) ,
   fonction VARCHAR(50) ,
   datemb DATE,
   sala DECIMAL(19,4),
   comm DECIMAL(19,4),
   nodep INT NOT NULL,
   noemp_1 INT
   
)ENGINE = InnoDB;



#========================================
# Table : grade
#========================================

CREATE TABLE grade(
   nograde INT AUTO_INCREMENT PRIMARY KEY,
   salmin DECIMAL(19,4),
   salmax DECIMAL(19,4)
)ENGINE = InnoDB;



#========================================
# Table : histofonction
#========================================

CREATE TABLE histofonction(
   noemp INT PRIMARY KEY,
   date_nom DATE,
   fonction VARCHAR(50) 
)ENGINE = InnoDB;

ALTER TABLE employe ADD CONSTRAINT FK_Employe_Departement FOREIGN KEY(nodep) REFERENCES departement(nodep),
                    ADD CONSTRAINT FK_Employe_Employe FOREIGN KEY(noemp_1) REFERENCES employe(noemp);
                    