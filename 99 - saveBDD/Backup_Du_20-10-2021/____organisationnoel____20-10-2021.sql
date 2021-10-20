-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: organisationnoel
-- ------------------------------------------------------
-- Server version	5.7.31

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `organisationnoel`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `organisationnoel` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `organisationnoel`;

--
-- Table structure for table `cadeaux`
--

DROP TABLE IF EXISTS `cadeaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cadeaux` (
  `idCadeau` int(11) NOT NULL AUTO_INCREMENT,
  `libelleCadeau` varchar(200) NOT NULL,
  PRIMARY KEY (`idCadeau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadeaux`
--

LOCK TABLES `cadeaux` WRITE;
/*!40000 ALTER TABLE `cadeaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `cadeaux` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfants`
--

DROP TABLE IF EXISTS `enfants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `enfants` (
  `idEnfant` int(11) NOT NULL AUTO_INCREMENT,
  `nomEnfant` varchar(100) NOT NULL,
  `prenomEnfant` varchar(50) NOT NULL,
  `adresse` varchar(200) NOT NULL,
  `genre` varchar(1) DEFAULT NULL,
  `pourcentageSagesse` int(11) DEFAULT NULL,
  `idCadeau` int(11) NOT NULL,
  PRIMARY KEY (`idEnfant`),
  KEY `FK_Enfant_Cadeau` (`idCadeau`),
  CONSTRAINT `FK_Enfant_Cadeau` FOREIGN KEY (`idCadeau`) REFERENCES `cadeaux` (`idCadeau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfants`
--

LOCK TABLES `enfants` WRITE;
/*!40000 ALTER TABLE `enfants` DISABLE KEYS */;
/*!40000 ALTER TABLE `enfants` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipes`
--

DROP TABLE IF EXISTS `equipes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipes` (
  `idEquipe` int(11) NOT NULL AUTO_INCREMENT,
  `idTournee` int(11) NOT NULL,
  `idRenne` int(11) NOT NULL,
  PRIMARY KEY (`idEquipe`),
  KEY `FK_Equipe_Tournee` (`idTournee`),
  KEY `FK_Equipe_Renne` (`idRenne`),
  CONSTRAINT `FK_Equipe_Renne` FOREIGN KEY (`idRenne`) REFERENCES `rennes` (`idRenne`),
  CONSTRAINT `FK_Equipe_Tournee` FOREIGN KEY (`idTournee`) REFERENCES `tournees` (`idTournee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipes`
--

LOCK TABLES `equipes` WRITE;
/*!40000 ALTER TABLE `equipes` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historiquesresponsabilites`
--

DROP TABLE IF EXISTS `historiquesresponsabilites`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historiquesresponsabilites` (
  `idHistoriqueResponsabilite` int(11) NOT NULL AUTO_INCREMENT,
  `idLutin` int(11) NOT NULL,
  `idTraineau` int(11) NOT NULL,
  `dateAcquisition` varchar(50) NOT NULL,
  PRIMARY KEY (`idHistoriqueResponsabilite`),
  KEY `FK_HistoriqueResponsabilite_Lutin` (`idLutin`),
  KEY `FK_HistoriqueResponsabilite_Traineau` (`idTraineau`),
  CONSTRAINT `FK_HistoriqueResponsabilite_Lutin` FOREIGN KEY (`idLutin`) REFERENCES `lutins` (`idLutin`),
  CONSTRAINT `FK_HistoriqueResponsabilite_Traineau` FOREIGN KEY (`idTraineau`) REFERENCES `traineaux` (`idTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historiquesresponsabilites`
--

LOCK TABLES `historiquesresponsabilites` WRITE;
/*!40000 ALTER TABLE `historiquesresponsabilites` DISABLE KEYS */;
/*!40000 ALTER TABLE `historiquesresponsabilites` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `livraisons`
--

DROP TABLE IF EXISTS `livraisons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `livraisons` (
  `idLivraison` int(11) NOT NULL AUTO_INCREMENT,
  `idEnfant` int(11) NOT NULL,
  `idTournee` int(11) NOT NULL,
  PRIMARY KEY (`idLivraison`),
  KEY `FK_Livraison_Enfant` (`idEnfant`),
  KEY `FK_Livraison_Tournee` (`idTournee`),
  CONSTRAINT `FK_Livraison_Enfant` FOREIGN KEY (`idEnfant`) REFERENCES `enfants` (`idEnfant`),
  CONSTRAINT `FK_Livraison_Tournee` FOREIGN KEY (`idTournee`) REFERENCES `tournees` (`idTournee`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `livraisons`
--

LOCK TABLES `livraisons` WRITE;
/*!40000 ALTER TABLE `livraisons` DISABLE KEYS */;
/*!40000 ALTER TABLE `livraisons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lutins`
--

DROP TABLE IF EXISTS `lutins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lutins` (
  `idLutin` int(11) NOT NULL AUTO_INCREMENT,
  `nomLutin` varchar(100) NOT NULL,
  `prenomLutin` varchar(50) NOT NULL,
  PRIMARY KEY (`idLutin`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lutins`
--

LOCK TABLES `lutins` WRITE;
/*!40000 ALTER TABLE `lutins` DISABLE KEYS */;
/*!40000 ALTER TABLE `lutins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rennes`
--

DROP TABLE IF EXISTS `rennes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `rennes` (
  `idRenne` int(11) NOT NULL AUTO_INCREMENT,
  `nomRenne` varchar(50) NOT NULL,
  `sexe` varchar(1) NOT NULL,
  `dateNaissance` date NOT NULL,
  PRIMARY KEY (`idRenne`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rennes`
--

LOCK TABLES `rennes` WRITE;
/*!40000 ALTER TABLE `rennes` DISABLE KEYS */;
/*!40000 ALTER TABLE `rennes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tournees`
--

DROP TABLE IF EXISTS `tournees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tournees` (
  `idTournee` int(11) NOT NULL AUTO_INCREMENT,
  `heureDepart` datetime NOT NULL,
  `idLutin` int(11) NOT NULL,
  `idTraineau` int(11) NOT NULL,
  PRIMARY KEY (`idTournee`),
  KEY `FK_Tournee_Lutin` (`idLutin`),
  KEY `FK_Tournee_Traineau` (`idTraineau`),
  CONSTRAINT `FK_Tournee_Lutin` FOREIGN KEY (`idLutin`) REFERENCES `lutins` (`idLutin`),
  CONSTRAINT `FK_Tournee_Traineau` FOREIGN KEY (`idTraineau`) REFERENCES `traineaux` (`idTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tournees`
--

LOCK TABLES `tournees` WRITE;
/*!40000 ALTER TABLE `tournees` DISABLE KEYS */;
/*!40000 ALTER TABLE `tournees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `traineaux`
--

DROP TABLE IF EXISTS `traineaux`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `traineaux` (
  `idTraineau` int(11) NOT NULL AUTO_INCREMENT,
  `taille` int(11) NOT NULL,
  `dateMiseService` date NOT NULL,
  `dateRevision` date DEFAULT NULL,
  PRIMARY KEY (`idTraineau`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `traineaux`
--

LOCK TABLES `traineaux` WRITE;
/*!40000 ALTER TABLE `traineaux` DISABLE KEYS */;
/*!40000 ALTER TABLE `traineaux` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-20 17:20:42
