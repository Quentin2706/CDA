-- MySQL dump 10.13  Distrib 5.7.31, for Win64 (x86_64)
--
-- Host: localhost    Database: employedeux
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
-- Current Database: `employedeux`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `employedeux` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `employedeux`;

--
-- Table structure for table `departement`
--

DROP TABLE IF EXISTS `departement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departement` (
  `nodep` int(11) NOT NULL,
  `nomdep` varchar(150) DEFAULT NULL,
  `ville` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`nodep`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departement`
--

LOCK TABLES `departement` WRITE;
/*!40000 ALTER TABLE `departement` DISABLE KEYS */;
INSERT INTO `departement` VALUES (10,'Formation','Aix'),(20,'Ingénierie','Paris'),(30,'Industrie','Bordeaux'),(40,'Direction générale','Paris');
/*!40000 ALTER TABLE `departement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `employe` (
  `noemp` int(11) NOT NULL AUTO_INCREMENT,
  `nomemp` varchar(100) DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL,
  `noresp` int(11) DEFAULT NULL,
  `datemb` date DEFAULT NULL,
  `sala` decimal(19,4) DEFAULT NULL,
  `comm` decimal(19,4) DEFAULT NULL,
  `nodep` int(11) NOT NULL,
  PRIMARY KEY (`noemp`),
  KEY `FK_Employe_Departement` (`nodep`),
  KEY `FK_Employe_Employe` (`noresp`),
  CONSTRAINT `FK_Employe_Departement` FOREIGN KEY (`nodep`) REFERENCES `departement` (`nodep`),
  CONSTRAINT `FK_Employe_Employe` FOREIGN KEY (`noresp`) REFERENCES `employe` (`noemp`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employe`
--

LOCK TABLES `employe` WRITE;
/*!40000 ALTER TABLE `employe` DISABLE KEYS */;
INSERT INTO `employe` VALUES (1,'Costanza','psychologue',8,'1994-10-19',1715.0000,200.0000,30),(2,'Mioche','Directeur',6,'1990-03-15',2200.0000,1000.0000,20),(3,'Durand','Responsable',2,'1996-04-18',3250.0000,0.0000,10),(4,'Xiong','vendeur',5,'1994-12-15',1150.0000,200.0000,30),(5,'Manoukian','vendeur',11,'1993-08-15',2530.0000,500.0000,30),(6,'Bourdais','directeur',15,'2002-07-12',3550.0000,850.0000,40),(7,'Moreno','ouvrier',3,'1999-05-05',1075.0000,50.0000,10),(8,'Perou','directeur',2,'1995-07-05',2450.0000,800.0000,10),(9,'Bibaut','chef de service',8,'1993-06-07',2200.0000,NULL,20),(10,'Manian','assistant',9,'1996-10-18',1000.0000,250.0000,10),(11,'Colin','analyste',2,'1992-07-05',2702.0000,625.0000,30),(12,'Coulon','ouvrier',8,'2002-09-18',858.0000,125.0000,20),(13,'Roméo','assistant',8,'2001-08-16',1025.0000,1150.0000,10),(14,'Solal','secrétaire',3,'1992-02-15',1225.0000,NULL,20),(15,'Bailly','Président',NULL,'1985-01-05',4275.0000,2000.0000,40),(16,'Jazarin','Ouvrier',2,'2001-07-05',875.0000,NULL,10),(17,'Font','Ouvrier',2,'1990-08-04',1200.0000,250.0000,10),(18,'Servel','ouvrier',3,'1998-12-02',1025.0000,55.0000,30);
/*!40000 ALTER TABLE `employe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `grade`
--

DROP TABLE IF EXISTS `grade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `grade` (
  `nograde` int(11) NOT NULL AUTO_INCREMENT,
  `salmin` decimal(19,4) DEFAULT NULL,
  `salmax` decimal(19,4) DEFAULT NULL,
  PRIMARY KEY (`nograde`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `grade`
--

LOCK TABLES `grade` WRITE;
/*!40000 ALTER TABLE `grade` DISABLE KEYS */;
INSERT INTO `grade` VALUES (1,0.0000,1000.0000),(2,1000.0100,2000.0000),(3,2000.0100,3000.0000),(4,3000.0100,4000.0000),(5,4000.0100,5000.0000),(6,5000.0100,6000.0000);
/*!40000 ALTER TABLE `grade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `histofonction`
--

DROP TABLE IF EXISTS `histofonction`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `histofonction` (
  `noemp` int(11) DEFAULT NULL,
  `date_nom` date DEFAULT NULL,
  `fonction` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `histofonction`
--

LOCK TABLES `histofonction` WRITE;
/*!40000 ALTER TABLE `histofonction` DISABLE KEYS */;
INSERT INTO `histofonction` VALUES (1,'1994-10-19','vendeur'),(1,'1996-12-18','psychologue'),(2,'1990-03-15','responsable'),(2,'1994-10-18','directeur'),(3,'1996-04-18','vendeur'),(3,'1998-06-18','responsable'),(4,'1994-12-15','vendeur'),(5,'1993-08-15','vendeur'),(6,'2002-07-12','directeur'),(7,'1999-05-05','ouvrier'),(8,'1995-07-05','vendeur'),(8,'1997-04-15','responsable'),(8,'1999-10-18','directeur'),(10,'1996-10-18','assistant'),(11,'1992-07-05','vendeur'),(11,'1995-07-15','responsable'),(11,'1999-05-19','analyste'),(12,'2002-09-18','ouvrier'),(13,'2001-08-16','ouvrier'),(13,'2003-07-17','assistant'),(14,'1992-01-02','secrétaire'),(15,'1985-01-05','directeur'),(15,'1995-10-05','président'),(16,'2001-07-05','ouvrier'),(17,'1990-08-04','ouvrier'),(18,'1998-12-02','ouvrier');
/*!40000 ALTER TABLE `histofonction` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-21 17:20:42
