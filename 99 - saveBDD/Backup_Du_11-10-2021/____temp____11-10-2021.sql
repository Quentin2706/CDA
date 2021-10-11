-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: temp
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
-- Current Database: `temp`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `temp` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `temp`;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `IdCategorie` int(11) NOT NULL AUTO_INCREMENT,
  `NomCategorie` varchar(50) DEFAULT NULL,
  `DescriptionCategorie` text,
  `IdCategorie_1` int(11) NOT NULL,
  PRIMARY KEY (`IdCategorie`),
  KEY `FK_Categories_Categories` (`IdCategorie_1`),
  CONSTRAINT `FK_Categories_Categories` FOREIGN KEY (`IdCategorie_1`) REFERENCES `categories` (`IdCategorie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fautes`
--

DROP TABLE IF EXISTS `fautes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fautes` (
  `IdFaute` int(11) NOT NULL AUTO_INCREMENT,
  `TitreFaute` varchar(100) DEFAULT NULL,
  `DateDetection` date DEFAULT NULL,
  `Commentaire` text,
  `DateReparation` date DEFAULT NULL,
  `IdProduit` int(11) NOT NULL,
  `IdCategorie` int(11) NOT NULL,
  PRIMARY KEY (`IdFaute`),
  KEY `FK_Fautes_Produits` (`IdProduit`),
  KEY `FK_Fautes_Categories` (`IdCategorie`),
  CONSTRAINT `FK_Fautes_Categories` FOREIGN KEY (`IdCategorie`) REFERENCES `categories` (`IdCategorie`),
  CONSTRAINT `FK_Fautes_Produits` FOREIGN KEY (`IdProduit`) REFERENCES `produits` (`IdProduit`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fautes`
--

LOCK TABLES `fautes` WRITE;
/*!40000 ALTER TABLE `fautes` DISABLE KEYS */;
/*!40000 ALTER TABLE `fautes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `modeles`
--

DROP TABLE IF EXISTS `modeles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `modeles` (
  `IdModele` varchar(8) NOT NULL,
  `NomModele` varchar(50) DEFAULT NULL,
  `DateModele` date DEFAULT NULL,
  PRIMARY KEY (`IdModele`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modeles`
--

LOCK TABLES `modeles` WRITE;
/*!40000 ALTER TABLE `modeles` DISABLE KEYS */;
/*!40000 ALTER TABLE `modeles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produits`
--

DROP TABLE IF EXISTS `produits`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produits` (
  `IdProduit` int(11) NOT NULL AUTO_INCREMENT,
  `NumSerie` varchar(6) DEFAULT NULL,
  `NumProduit` varchar(4) DEFAULT NULL,
  `IdModele` varchar(8) NOT NULL,
  PRIMARY KEY (`IdProduit`),
  KEY `FK_Produits_Modeles` (`IdModele`),
  CONSTRAINT `FK_Produits_Modeles` FOREIGN KEY (`IdModele`) REFERENCES `modeles` (`IdModele`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produits`
--

LOCK TABLES `produits` WRITE;
/*!40000 ALTER TABLE `produits` DISABLE KEYS */;
/*!40000 ALTER TABLE `produits` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-11 17:20:42
