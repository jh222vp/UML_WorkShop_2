-- phpMyAdmin SQL Dump
-- version 4.1.4
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2014 at 04:27 PM
-- Server version: 5.6.15-log
-- PHP Version: 5.5.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `boatclub`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteBoat`(IN `_id` INT)
    NO SQL
DELETE FROM boat
        WHERE boatID = _id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `deleteMember`(IN `_id` INT)
    NO SQL
DELETE FROM member
        WHERE memberID = _id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `displayBoat`(IN `_id` INT)
    NO SQL
SELECT boatID,memberID, boattype, boatlength
FROM boat as b
INNER JOIN boattype as bt
ON b.boattypeID = bt.boattypeID
WHERE memberID=_id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `getBoats`(IN `_id` INT)
    NO SQL
SELECT *
FROM boat
WHERE memberID=_id$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `memberlist`()
    NO SQL
SELECT m.memberID, firstname, lastname, socialsecuritynumber,boatID, boatlength, boattype
FROM member as m
INNER JOIN boat as b
ON m.memberID=b.memberID
INNER JOIN boattype as bt
ON b.boattypeID = bt.boattypeID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `miniMemList`()
    NO SQL
SELECT member.memberID, firstname, lastname, socialsecuritynumber, count(boat.memberID)
FROM boat 
RIGHT OUTER JOIN member 
	ON boat.memberID=member.memberID 
GROUP BY member.memberID$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `boat`
--

CREATE TABLE IF NOT EXISTS `boat` (
  `boatID` int(111) NOT NULL AUTO_INCREMENT,
  `memberID` int(111) NOT NULL,
  `boattypeID` int(111) NOT NULL,
  `boatlength` varchar(30) NOT NULL,
  PRIMARY KEY (`boatID`),
  KEY `boatID` (`boatID`),
  KEY `boatID_2` (`boatID`),
  KEY `boattypeID` (`boattypeID`),
  KEY `memberID` (`memberID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=50 ;

--
-- Dumping data for table `boat`
--

INSERT INTO `boat` (`boatID`, `memberID`, `boattypeID`, `boatlength`) VALUES
(32, 40, 1, '30m'),
(33, 42, 2, '12m'),
(35, 45, 1, '89m'),
(44, 24, 1, '14'),
(49, 40, 1, '34');

-- --------------------------------------------------------

--
-- Table structure for table `boattype`
--

CREATE TABLE IF NOT EXISTS `boattype` (
  `boattypeID` int(111) NOT NULL AUTO_INCREMENT,
  `boattype` varchar(30) NOT NULL,
  PRIMARY KEY (`boattypeID`),
  KEY `boattypeID` (`boattypeID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `boattype`
--

INSERT INTO `boattype` (`boattypeID`, `boattype`) VALUES
(1, 'Segelbåt'),
(2, 'Motorseglare'),
(3, 'Motorbåt'),
(4, 'Kajak/Kanot'),
(5, 'Övrigt');

-- --------------------------------------------------------

--
-- Table structure for table `member`
--

CREATE TABLE IF NOT EXISTS `member` (
  `memberID` int(111) NOT NULL AUTO_INCREMENT,
  `firstname` varchar(30) NOT NULL,
  `lastname` varchar(30) NOT NULL,
  `socialsecuritynumber` varchar(30) NOT NULL,
  PRIMARY KEY (`memberID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=48 ;

--
-- Dumping data for table `member`
--

INSERT INTO `member` (`memberID`, `firstname`, `lastname`, `socialsecuritynumber`) VALUES
(24, 'Jonas', 'Holte', '920414'),
(40, 'Erik', 'Magnusson', '910304'),
(42, 'Rasmus', 'Eneman', '940312'),
(44, 'Tobias', 'Holst', '941022'),
(45, 'Sandraaaa', 'Hanson', '920414'),
(46, 'Sandra', 'Hanson', '939393'),
(47, 'Tom', 'Hanssson', '929292');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `boat`
--
ALTER TABLE `boat`
  ADD CONSTRAINT `boat_ibfk_1` FOREIGN KEY (`boattypeID`) REFERENCES `boattype` (`boattypeID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `boat_ibfk_2` FOREIGN KEY (`memberID`) REFERENCES `member` (`memberID`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
