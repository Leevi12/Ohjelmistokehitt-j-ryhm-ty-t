-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Dec 02, 2021 at 07:55 AM
-- Server version: 8.0.21
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Table structure for table `asiakkaat`
--

DROP TABLE IF EXISTS `asiakkaat`;
CREATE TABLE IF NOT EXISTS `asiakkaat` (
  `kayttajanimi` varchar(20) NOT NULL,
  `etunimi` varchar(20) NOT NULL,
  `sukunimi` varchar(30) NOT NULL,
  `lahiosoite` varchar(50) NOT NULL,
  `postinumero` varchar(10) NOT NULL,
  `postitoimipaikka` varchar(20) NOT NULL,
  `salasana` varchar(20) NOT NULL,
  PRIMARY KEY (`kayttajanimi`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `asiakkaat`
--

INSERT INTO `asiakkaat` (`kayttajanimi`, `etunimi`, `sukunimi`, `lahiosoite`, `postinumero`, `postitoimipaikka`, `salasana`) VALUES
('ErkEsim', 'Erkki', 'Esimerkki', 'Esimerkkitie 1 A', '00200', 'Helsinki', 'password');

-- --------------------------------------------------------

--
-- Table structure for table `huoneet`
--

DROP TABLE IF EXISTS `huoneet`;
CREATE TABLE IF NOT EXISTS `huoneet` (
  `huoneNro` int NOT NULL AUTO_INCREMENT,
  `huoneTyyppi` varchar(10) NOT NULL,
  `puhelin` varchar(20) NOT NULL,
  `vapaa` varchar(10) NOT NULL,
  PRIMARY KEY (`huoneNro`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `huoneet`
--

INSERT INTO `huoneet` (`huoneNro`, `huoneTyyppi`, `puhelin`, `vapaa`) VALUES
(1, '2H+K', '101', 'Ei'),
(2, '1H', '102', 'Kyllä'),
(3, '2H', '103', 'Kyllä'),
(4, '2H', '104', 'Kyllä');

-- --------------------------------------------------------

--
-- Table structure for table `varaukset`
--

DROP TABLE IF EXISTS `varaukset`;
CREATE TABLE IF NOT EXISTS `varaukset` (
  `VarausNro` int NOT NULL AUTO_INCREMENT,
  `AsiakasNro` int NOT NULL,
  `Huonetyyppi` varchar(10) NOT NULL,
  `HuoneNro` int NOT NULL,
  `Sisaan` date NOT NULL,
  `Ulos` date NOT NULL,
  PRIMARY KEY (`VarausNro`)
) ENGINE=MyISAM AUTO_INCREMENT=1256 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data for table `varaukset`
--

INSERT INTO `varaukset` (`VarausNro`, `AsiakasNro`, `Huonetyyppi`, `HuoneNro`, `Sisaan`, `Ulos`) VALUES
(1255, 1, '2H+K', 1, '1814-12-12', '2042-12-12');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
