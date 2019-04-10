CREATE DATABASE  IF NOT EXISTS `pizzeria` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pizzeria`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pizzeria
-- ------------------------------------------------------
-- Server version	8.0.13

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `categorydrink`
--

DROP TABLE IF EXISTS `categorydrink`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categorydrink` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(20) NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `categoryeat`
--

DROP TABLE IF EXISTS `categoryeat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categoryeat` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(20) NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `checks`
--

DROP TABLE IF EXISTS `checks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `checks` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Customer` varchar(45) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `Table` int(11) DEFAULT NULL,
  `Employeer` int(11) NOT NULL,
  `DateOrder` datetime NOT NULL,
  `DateGive` datetime NOT NULL,
  `Adres` varchar(150) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `Status` enum('Принят','Готовится','Доставляется','Выдан','Оплачен','Отменен') CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `CardKey` int(11) DEFAULT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  KEY `Table_idx` (`Table`),
  KEY `Employeer_idx` (`Employeer`),
  KEY `CardKey_idx` (`CardKey`),
  CONSTRAINT `CardKey` FOREIGN KEY (`CardKey`) REFERENCES `customers` (`id`),
  CONSTRAINT `Employeer` FOREIGN KEY (`Employeer`) REFERENCES `employeers` (`id`),
  CONSTRAINT `Table` FOREIGN KEY (`Table`) REFERENCES `tables` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Lname` varchar(20) NOT NULL,
  `Fname` varchar(20) NOT NULL,
  `Adres` varchar(150) NOT NULL,
  `Procent` int(11) NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `drink`
--

DROP TABLE IF EXISTS `drink`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `drink` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(30) NOT NULL,
  `Volume` int(10) unsigned NOT NULL,
  `Cost` int(10) unsigned NOT NULL,
  `Category` int(11) NOT NULL,
  `CanShop` int(11) NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  KEY `Category_idx` (`Category`),
  CONSTRAINT `CategoryDrink` FOREIGN KEY (`Category`) REFERENCES `categorydrink` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `eat`
--

DROP TABLE IF EXISTS `eat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `eat` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(30) NOT NULL,
  `Portion` enum('Маленькая','Стандарт','Большая') NOT NULL,
  `Cost` int(10) unsigned NOT NULL,
  `Mass` int(10) unsigned NOT NULL,
  `Kaloryes` int(10) unsigned NOT NULL,
  `Category` int(11) NOT NULL,
  `CanShop` int(11) NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  KEY `Category_idx` (`Category`),
  CONSTRAINT `CategoryEat` FOREIGN KEY (`Category`) REFERENCES `categoryeat` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `employeers`
--

DROP TABLE IF EXISTS `employeers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `employeers` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Lname` varchar(20) NOT NULL,
  `Fname` varchar(20) NOT NULL,
  `Sname` varchar(20) NOT NULL,
  `Born` date NOT NULL,
  `Number` varchar(15) NOT NULL,
  `Adres` varchar(150) NOT NULL,
  `Job` int(11) NOT NULL,
  `Days` enum('Четные','Нечетные') NOT NULL,
  `Password` varchar(10) DEFAULT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Password_UNIQUE` (`Password`),
  KEY `Job_idx` (`Job`),
  CONSTRAINT `Job` FOREIGN KEY (`Job`) REFERENCES `job` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `ingredients`
--

DROP TABLE IF EXISTS `ingredients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `ingredients` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Dish` int(11) DEFAULT NULL,
  `Brew` int(11) DEFAULT NULL,
  `Product` int(11) NOT NULL,
  `Count` int(10) unsigned NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `Brew_idx` (`Brew`),
  KEY `Dish_idx` (`Dish`),
  KEY `Product_idx` (`Product`),
  CONSTRAINT `Brews` FOREIGN KEY (`Brew`) REFERENCES `drink` (`id`),
  CONSTRAINT `Dish` FOREIGN KEY (`Dish`) REFERENCES `eat` (`id`),
  CONSTRAINT `Product` FOREIGN KEY (`Product`) REFERENCES `products` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `job`
--

DROP TABLE IF EXISTS `job`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `job` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(30) NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orders` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Dish` int(11) DEFAULT NULL,
  `Brew` int(11) DEFAULT NULL,
  `Count` int(10) unsigned NOT NULL,
  `Check` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `DishOrder_idx` (`Dish`),
  KEY `DrinkOrder_idx` (`Brew`),
  KEY `Check_idx` (`Check`),
  CONSTRAINT `Check` FOREIGN KEY (`Check`) REFERENCES `checks` (`id`),
  CONSTRAINT `DishOrder` FOREIGN KEY (`Dish`) REFERENCES `eat` (`id`),
  CONSTRAINT `DrinkOrder` FOREIGN KEY (`Brew`) REFERENCES `drink` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=67 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `products` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(45) NOT NULL,
  `Count` int(10) unsigned NOT NULL,
  `Ones` enum('шт','кг','л') NOT NULL,
  `MinCount` int(10) unsigned NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Names_UNIQUE` (`Names`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `tables`
--

DROP TABLE IF EXISTS `tables`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tables` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(45) NOT NULL,
  `CanTake` int(11) NOT NULL DEFAULT '1',
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping events for database 'pizzeria'
--

--
-- Dumping routines for database 'pizzeria'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-03-10 17:12:15
