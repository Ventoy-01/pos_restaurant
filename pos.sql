-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 30, 2025 at 02:32 PM
-- Server version: 8.0.37
-- PHP Version: 8.2.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos`
--

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nom` varchar(50) NOT NULL,
  `Prenom` varchar(50) DEFAULT NULL,
  `Sexe` enum('Masculin','Féminin') DEFAULT NULL,
  `Telephone` varchar(20) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `MontantDette` decimal(10,2) DEFAULT '0.00',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`ID`, `Nom`, `Prenom`, `Sexe`, `Telephone`, `Email`, `MontantDette`) VALUES
(1, 'CLOCIN', 'Jonas', 'Masculin', '+509 42080136', 'jonas.clocin@student.ueh.edu.ht', 0.00),
(7, 'CHERENFANT', 'Vinchy', 'Masculin', '3456474', 'jjjf.@gmail.com', 100.00);

-- --------------------------------------------------------

--
-- Table structure for table `commandes`
--

DROP TABLE IF EXISTS `commandes`;
CREATE TABLE IF NOT EXISTS `commandes` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `IdMenu` int DEFAULT NULL,
  `IdClient` int DEFAULT NULL,
  `quantite` int DEFAULT NULL,
  `DateCommande` datetime DEFAULT CURRENT_TIMESTAMP,
  `prixTotal` decimal(10,2) DEFAULT NULL,
  `description` text,
  PRIMARY KEY (`ID`),
  KEY `IdClient` (`IdClient`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `commandes`
--

INSERT INTO `commandes` (`ID`, `IdMenu`, `IdClient`, `quantite`, `DateCommande`, `prixTotal`, `description`) VALUES
(9, 8, 1, 1, '2025-12-30 08:40:53', 350.00, ''),
(10, 7, 7, 1, '2025-12-30 08:41:35', 2000.00, '');

-- --------------------------------------------------------

--
-- Table structure for table `menus`
--

DROP TABLE IF EXISTS `menus`;
CREATE TABLE IF NOT EXISTS `menus` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Nom` varchar(100) NOT NULL,
  `Type` enum('Plat','Boisson','Dessert') NOT NULL,
  `Quantite` int DEFAULT '0',
  `PrixUnitaire` decimal(10,2) NOT NULL,
  `Description` text,
  `Actif` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `menus`
--

INSERT INTO `menus` (`ID`, `Nom`, `Type`, `Quantite`, `PrixUnitaire`, `Description`, `Actif`) VALUES
(1, 'Poulet Grillée', 'Plat', 43, 450.00, 'Un  Plat delicieux', 1),
(2, 'Test 2', 'Plat', 0, 240.00, 'le monde', 0),
(3, 'test3', 'Boisson', 2, 30.00, 'boisson al', 0),
(4, 'Vinchy', 'Plat', 80, 900.00, 'le plat unique', 0),
(5, 'Mais', 'Plat', 1, 23.00, 'vgh', 0),
(6, 'the', 'Boisson', 1, 12.00, 'The gingembre', 0),
(7, 'Wisky & Barbancourt', 'Boisson', 28, 2000.00, 'Le melange parfait', 1),
(8, 'Spaguetti au lait', 'Dessert', 99, 350.00, 'le dessert en un clin d\'oeil', 1);

-- --------------------------------------------------------

--
-- Table structure for table `paiements`
--

DROP TABLE IF EXISTS `paiements`;
CREATE TABLE IF NOT EXISTS `paiements` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `IdCommande` int NOT NULL,
  `Montant` double NOT NULL,
  `DatePaiement` datetime DEFAULT CURRENT_TIMESTAMP,
  `ModePaiement` enum('Cash','Carte Debit','Carte Credit','Cheque') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `IdCommande` (`IdCommande`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `paiements`
--

INSERT INTO `paiements` (`ID`, `IdCommande`, `Montant`, `DatePaiement`, `ModePaiement`) VALUES
(2, 9, 350, '2025-12-30 09:24:23', 'Carte Credit');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
CREATE TABLE IF NOT EXISTS `users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Password` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `Role` enum('admin','user') CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `uq_username` (`Username`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `Username`, `Password`, `Role`) VALUES
(1, 'ventoy01', 'jonas', 'admin'),
(2, 'vinchy19', 'vinchygit@1', 'admin');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `commandes`
--
ALTER TABLE `commandes`
  ADD CONSTRAINT `commandes_ibfk_1` FOREIGN KEY (`IdClient`) REFERENCES `clients` (`ID`) ON DELETE SET NULL;

--
-- Constraints for table `paiements`
--
ALTER TABLE `paiements`
  ADD CONSTRAINT `paiements_ibfk_1` FOREIGN KEY (`IdCommande`) REFERENCES `commandes` (`ID`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
