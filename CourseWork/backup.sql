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
-- Dumping data for table `categorydrink`
--

LOCK TABLES `categorydrink` WRITE;
/*!40000 ALTER TABLE `categorydrink` DISABLE KEYS */;
INSERT INTO `categorydrink` VALUES (13,'Кофе  ',1),(14,'Коктейль',1),(15,'Соки  ',1),(16,'Напитки',1);
/*!40000 ALTER TABLE `categorydrink` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `categoryeat`
--

LOCK TABLES `categoryeat` WRITE;
/*!40000 ALTER TABLE `categoryeat` DISABLE KEYS */;
INSERT INTO `categoryeat` VALUES (4,'Закуски',1),(5,'Десерт',1),(6,'Пицца',1);
/*!40000 ALTER TABLE `categoryeat` ENABLE KEYS */;
UNLOCK TABLES;

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
  `Status` enum('Принят','Готовится','Доставляется','Выдан','Оплачен') CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `CardKey` int(11) DEFAULT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  KEY `Table_idx` (`Table`),
  KEY `Employeer_idx` (`Employeer`),
  KEY `CardKey_idx` (`CardKey`),
  CONSTRAINT `CardKey` FOREIGN KEY (`CardKey`) REFERENCES `customers` (`id`),
  CONSTRAINT `Employeer` FOREIGN KEY (`Employeer`) REFERENCES `employeers` (`id`),
  CONSTRAINT `Table` FOREIGN KEY (`Table`) REFERENCES `tables` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checks`
--

LOCK TABLES `checks` WRITE;
/*!40000 ALTER TABLE `checks` DISABLE KEYS */;
/*!40000 ALTER TABLE `checks` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (6,'Виталий','Слива','Харьков',70,1),(7,'Славик','Лиман','Салтовка',30,1),(8,'Егор','Демченко','м. Герои труда',20,1);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

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
  CONSTRAINT `CategoryDrink` FOREIGN KEY (`Category`) REFERENCES `categorydrink` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drink`
--

LOCK TABLES `drink` WRITE;
/*!40000 ALTER TABLE `drink` DISABLE KEYS */;
INSERT INTO `drink` VALUES (8,'Эспрессо',50,10,13,1,1),(9,'Маохито без алк.',500,50,14,1,1),(10,'Яблочный сок',300,20,15,1,1),(11,'Минеральная вода',100,5,16,1,1),(12,'Кокла со льдем',150,30,16,1,1),(14,'Сок фруктовый',100,30,15,1,1),(15,'Сок клубничный',200,40,15,1,1);
/*!40000 ALTER TABLE `drink` ENABLE KEYS */;
UNLOCK TABLES;

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
  CONSTRAINT `CategoryEat` FOREIGN KEY (`Category`) REFERENCES `categoryeat` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `eat`
--

LOCK TABLES `eat` WRITE;
/*!40000 ALTER TABLE `eat` DISABLE KEYS */;
INSERT INTO `eat` VALUES (5,'Жюльен','Стандарт',30,300,300,4,1,1),(6,'Лаваш','Стандарт',40,300,150,4,1,1),(7,'Морьков по-коррейски','Стандарт',20,200,300,4,1,1),(8,'Мороженное','Большая',50,300,10,5,1,1),(9,'Кекс','Стандарт',10,100,10,5,1,1),(10,'4 сыра','Стандарт',50,1000,500,6,1,1),(11,'Фирменная','Большая',100,2000,5000,6,1,1),(12,'Баварская','Стандарт',66,100,100,6,1,1),(13,'Мясная','Стандарт',33,80,300,6,1,1),(14,'Фитнес','Стандарт',100,600,200,6,1,1),(15,'По-домашнему','Большая',150,1500,1000,6,1,1),(16,'Пирок','Стандарт',50,400,1,5,1,1);
/*!40000 ALTER TABLE `eat` ENABLE KEYS */;
UNLOCK TABLES;

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
  `Money` int(10) unsigned NOT NULL,
  `Job` int(11) NOT NULL,
  `Days` enum('Четные','Нечетные') NOT NULL,
  `Password` varchar(10) DEFAULT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Password_UNIQUE` (`Password`),
  KEY `Job_idx` (`Job`),
  CONSTRAINT `Job` FOREIGN KEY (`Job`) REFERENCES `job` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employeers`
--

LOCK TABLES `employeers` WRITE;
/*!40000 ALTER TABLE `employeers` DISABLE KEYS */;
INSERT INTO `employeers` VALUES (10,'Слива','Виталий','Витальевич','2000-12-09','0999689962','Краснодарская 177б',8000,1,'Четные','1111',1),(11,'Слива','Виталий','Витальевич','2000-12-09','0999689962','Краснодарская 177б',8000,1,'Нечетные','11111',1),(12,'Егор','Демченко','Андреевич','2000-11-02','9999222333','Салтовка на героши',3000,14,'Нечетные','0786421',1),(13,'Славик','Лиман','Витальевич','2001-02-18','1111123387','Салтовка возле Каравана',3555,15,'Четные','6323065',1),(14,'Макс','Иванов','Иванович','1999-05-19','3336561231','Под Харьковом',5555,14,'Нечетные','7048653',1),(15,'Дима','Кулешов','Дмитреевич','2001-01-06','7373247833','602 м-н',3333,14,'Четные','2541668',1),(16,'Довготько','Вадим','Сергеевич','2001-02-18','5553433634','Харьков',2241,14,'Четные','1703320',1),(17,'Сергей','Петров','Иванович','1999-09-10','4352677225','Киев ',3333,14,'Четные','0408475',1),(18,'Илья','Церковный','Сергеевич','2000-02-11','3335412423','улица Амосова',3333,14,'Нечетные','2031457',1),(19,'Влад','Марченко','Сергеевич','2000-10-07','3135432354','Харьков Салтовка',5555,15,'Четные','6181772',1),(20,'Беленко','Даня','Романович','2001-02-18','2222244112','Харьков',2214,15,'Нечетные','6382503',1),(21,'Саня','Жерновников','Саневич','2000-06-23','8765445775','Дергачи',3333,15,'Нечетные','7046578',1),(22,'Романович','Игорь','Игоревич','2000-08-30','4444325254','Пролет',4553,16,'Нечетные',NULL,1),(23,'Рубан','Миша','Сергеевич','2001-02-09','3332343234','Под Харьковом',3333,16,'Четные',NULL,1);
/*!40000 ALTER TABLE `employeers` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `ingredients`
--

LOCK TABLES `ingredients` WRITE;
/*!40000 ALTER TABLE `ingredients` DISABLE KEYS */;
INSERT INTO `ingredients` VALUES (24,5,NULL,14,1),(25,5,NULL,10,1),(26,5,NULL,21,1),(27,6,NULL,21,1),(28,6,NULL,17,1),(29,6,NULL,16,1),(30,7,NULL,15,1),(31,7,NULL,11,1),(32,8,NULL,16,1),(33,8,NULL,17,1),(34,9,NULL,20,1),(35,10,NULL,15,1),(36,10,NULL,17,1),(37,10,NULL,16,1),(38,10,NULL,21,1),(40,11,NULL,14,1),(41,11,NULL,22,1),(42,11,NULL,21,1),(43,11,NULL,11,1),(44,12,NULL,21,1),(45,12,NULL,16,2),(46,13,NULL,22,3),(47,13,NULL,21,3),(48,14,NULL,14,1),(49,14,NULL,17,1),(50,14,NULL,19,1),(52,15,NULL,17,1),(53,15,NULL,21,1),(54,15,NULL,22,1),(55,15,NULL,10,1),(56,15,NULL,12,1),(61,NULL,8,18,1),(63,NULL,9,19,1),(64,NULL,9,24,1),(66,NULL,10,20,7),(68,16,NULL,20,3),(69,NULL,11,24,1),(72,NULL,12,23,1),(73,NULL,15,25,1),(74,NULL,15,26,1),(75,NULL,14,25,1),(76,NULL,14,26,1);
/*!40000 ALTER TABLE `ingredients` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `job`
--

LOCK TABLES `job` WRITE;
/*!40000 ALTER TABLE `job` DISABLE KEYS */;
INSERT INTO `job` VALUES (1,'Admin',1),(14,'Официант',1),(15,'Повар',1),(16,'Охранник',1);
/*!40000 ALTER TABLE `job` ENABLE KEYS */;
UNLOCK TABLES;

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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

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
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (10,'Грибы',100,'кг',1,1),(11,'Картошка',100,'кг',1,1),(12,'Помидоры',100,'кг',1,1),(13,'Огурцы',100,'кг',1,1),(14,'Оливки',50,'кг',1,1),(15,'Мазик',40,'л',1,1),(16,'Сыр',60,'кг',1,1),(17,'Кетчуп',70,'л',1,1),(18,'Кофе в зернах',50,'кг',1,1),(19,'Лайм',30,'кг',1,1),(20,'Яблоки',100,'кг',1,1),(21,'Курица',100,'кг',1,1),(22,'Ветчина',40,'кг',1,1),(23,'Кола',100,'л',1,1),(24,'Мята',50,'кг',1,1),(25,'Клубника',7,'кг',1,1),(26,'Лед',8,'кг',1,1);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tables`
--

DROP TABLE IF EXISTS `tables`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `tables` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Names` varchar(45) NOT NULL,
  `Enable` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tables`
--

LOCK TABLES `tables` WRITE;
/*!40000 ALTER TABLE `tables` DISABLE KEYS */;
INSERT INTO `tables` VALUES (5,'Номер 1',1),(6,'Номер 2',1),(7,'Номер 3',1),(8,'Номер 4',1),(9,'Номер 5',1),(10,'Номер 6',1),(11,'Номер 7',1),(12,'Номер 8',1),(13,'Номер 9',1),(14,'Номер 10',1);
/*!40000 ALTER TABLE `tables` ENABLE KEYS */;
UNLOCK TABLES;

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

-- Dump completed on 2019-02-19 16:37:43
