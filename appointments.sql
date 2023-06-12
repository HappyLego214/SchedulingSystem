-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 12, 2023 at 10:34 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `appointments`
--

-- --------------------------------------------------------

--
-- Table structure for table `householdava`
--

CREATE TABLE `householdava` (
  `memberID` int(50) NOT NULL,
  `hhmFName` varchar(50) NOT NULL,
  `hhmMName` varchar(50) DEFAULT NULL,
  `hhmLName` varchar(50) DEFAULT NULL,
  `hhmBirth` date DEFAULT NULL,
  `hhmRelation` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `householdava`
--

INSERT INTO `householdava` (`memberID`, `hhmFName`, `hhmMName`, `hhmLName`, `hhmBirth`, `hhmRelation`) VALUES
(1, 'Tyler ', 'Terra', 'Ava', '1982-12-15', 'Husband'),
(2, 'Charlotte ', 'Terra', 'Ava', '1995-06-14', 'HEAD'),
(3, 'Amber', 'Terra', 'Ava', '2017-06-08', 'Daughter');

-- --------------------------------------------------------

--
-- Table structure for table `householdfaraday`
--

CREATE TABLE `householdfaraday` (
  `memberID` int(50) NOT NULL,
  `hhmFName` varchar(50) NOT NULL,
  `hhmMName` varchar(50) DEFAULT NULL,
  `hhmLName` varchar(50) DEFAULT NULL,
  `hhmBirth` date DEFAULT NULL,
  `hhmRelation` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `householdfaraday`
--

INSERT INTO `householdfaraday` (`memberID`, `hhmFName`, `hhmMName`, `hhmLName`, `hhmBirth`, `hhmRelation`) VALUES
(1, 'Wilbert ', 'Penoski', 'Faraday', '1985-05-04', 'Husband'),
(2, 'Alyzza ', 'Penoski', 'Faraday', '1983-09-12', 'HEAD');

-- --------------------------------------------------------

--
-- Table structure for table `householdlego`
--

CREATE TABLE `householdlego` (
  `memberID` int(50) NOT NULL,
  `hhmFName` varchar(50) NOT NULL,
  `hhmMName` varchar(50) DEFAULT NULL,
  `hhmLName` varchar(50) DEFAULT NULL,
  `hhmBirth` date DEFAULT NULL,
  `hhmRelation` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `householdlego`
--

INSERT INTO `householdlego` (`memberID`, `hhmFName`, `hhmMName`, `hhmLName`, `hhmBirth`, `hhmRelation`) VALUES
(1, 'Joon', 'Tiamson', 'Lego', '2012-05-18', 'Daughter'),
(2, 'Dylan', 'Tiamson', 'Lego', '2012-05-18', 'Son'),
(3, 'Hina', 'Yeongsu', 'Lego', '1998-01-24', 'Wife'),
(4, 'Anthony Josh', 'Tiamson', 'Lego', '2002-05-21', 'HEAD');

-- --------------------------------------------------------

--
-- Table structure for table `householdlist`
--

CREATE TABLE `householdlist` (
  `householdName` varchar(50) NOT NULL,
  `hhHeadFname` varchar(50) DEFAULT NULL,
  `hhHeadMname` varchar(50) DEFAULT NULL,
  `hhHeadLname` varchar(50) DEFAULT NULL,
  `hhHeadEmployer` varchar(50) DEFAULT NULL,
  `hhHeadInsurance` varchar(50) DEFAULT NULL,
  `hhHeadWorkNumber` varchar(50) DEFAULT NULL,
  `hHHeadHomeNumber` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `householdlist`
--

INSERT INTO `householdlist` (`householdName`, `hhHeadFname`, `hhHeadMname`, `hhHeadLname`, `hhHeadEmployer`, `hhHeadInsurance`, `hhHeadWorkNumber`, `hHHeadHomeNumber`) VALUES
('Ava', 'Charlotte', 'Terra', 'Ava', 'Meta', 'Center Medical', '267-387-3330', '671-777-0324'),
('Faraday', 'Alyzza', 'Penoski', 'Faraday', 'Nestle', 'Mediwell Insurance', '615-378-3292', '315-290-7397'),
('Lego', 'Anthony Josh', 'Tiamson', 'Lego', 'Intel', 'Pacific West', '415-361-7867', '804-616-2398'),
('Marcus', 'John', 'Kittenson', 'Marcus', 'Nvidia', 'Golden Health', '718-792-3088', '302-637-4027');

-- --------------------------------------------------------

--
-- Table structure for table `householdmarcus`
--

CREATE TABLE `householdmarcus` (
  `memberID` int(50) NOT NULL,
  `hhmFName` varchar(50) NOT NULL,
  `hhmMName` varchar(50) DEFAULT NULL,
  `hhmLName` varchar(50) DEFAULT NULL,
  `hhmBirth` date DEFAULT NULL,
  `hhmRelation` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `householdmarcus`
--

INSERT INTO `householdmarcus` (`memberID`, `hhmFName`, `hhmMName`, `hhmLName`, `hhmBirth`, `hhmRelation`) VALUES
(1, 'John', 'Kittenson', 'Marcus', '1999-07-21', 'HEAD'),
(2, 'Nadine', 'Kittenson', 'Marcus', '2000-01-09', 'Wife'),
(3, 'Jacklyn', 'Kittenson', 'Marcus', '2012-07-21', 'Daughter'),
(4, 'Julian ', 'Kittenson', 'Marcus', '2015-08-29', 'Daughter');

-- --------------------------------------------------------

--
-- Table structure for table `medicalproviders`
--

CREATE TABLE `medicalproviders` (
  `ID` int(11) NOT NULL,
  `mpFirstName` varchar(50) DEFAULT NULL,
  `mpMiddleName` varchar(50) DEFAULT NULL,
  `mpLastName` varchar(50) DEFAULT NULL,
  `mpField` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `medicalproviders`
--

INSERT INTO `medicalproviders` (`ID`, `mpFirstName`, `mpMiddleName`, `mpLastName`, `mpField`) VALUES
(1, 'Susan', 'Hendrix', 'Mcknight', 'Doctor'),
(2, 'Irwin ', 'Simmons', 'Kane', 'Doctor'),
(3, 'Jeremy ', 'Ewing', 'Goodwin', 'Nurse'),
(4, 'Muriel ', 'Joyce', 'Holden', 'Physical Therapist');

-- --------------------------------------------------------

--
-- Table structure for table `tbl06132023goodwin`
--

CREATE TABLE `tbl06132023goodwin` (
  `appID` int(11) NOT NULL,
  `appTimeSlot` varchar(100) DEFAULT NULL,
  `ptName` varchar(50) DEFAULT '---',
  `ptServiceCode` varchar(50) DEFAULT '---',
  `ptServiceDesc` varchar(100) DEFAULT '---'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl06132023goodwin`
--

INSERT INTO `tbl06132023goodwin` (`appID`, `appTimeSlot`, `ptName`, `ptServiceCode`, `ptServiceDesc`) VALUES
(1, '8:00', '---', '---', '---'),
(2, '8:30', '---', '---', '---'),
(3, '9:00', '---', '---', '---'),
(4, '9:30', 'Hina Y. Lego', '---', '---'),
(5, '10:00', '---', '---', '---'),
(6, '10:30', '---', '---', '---'),
(7, '11:00', '---', '---', '---'),
(8, '11:30', '---', '---', '---'),
(9, '13:00', '---', '---', '---'),
(10, '13:30', '---', '---', '---'),
(11, '14:00', '---', '---', '---'),
(12, '14:30', '---', '---', '---'),
(13, '15:00', '---', '---', '---'),
(14, '15:30', '---', '---', '---'),
(15, '16:00', '---', '---', '---'),
(16, '16:30', '---', '---', '---'),
(17, '17:00', '---', '---', '---');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `householdava`
--
ALTER TABLE `householdava`
  ADD PRIMARY KEY (`memberID`),
  ADD UNIQUE KEY `memberID` (`memberID`);

--
-- Indexes for table `householdfaraday`
--
ALTER TABLE `householdfaraday`
  ADD PRIMARY KEY (`memberID`),
  ADD UNIQUE KEY `memberID` (`memberID`);

--
-- Indexes for table `householdlego`
--
ALTER TABLE `householdlego`
  ADD PRIMARY KEY (`memberID`),
  ADD UNIQUE KEY `memberID` (`memberID`);

--
-- Indexes for table `householdlist`
--
ALTER TABLE `householdlist`
  ADD PRIMARY KEY (`householdName`),
  ADD UNIQUE KEY `householdName` (`householdName`);

--
-- Indexes for table `householdmarcus`
--
ALTER TABLE `householdmarcus`
  ADD PRIMARY KEY (`memberID`),
  ADD UNIQUE KEY `memberID` (`memberID`);

--
-- Indexes for table `medicalproviders`
--
ALTER TABLE `medicalproviders`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `tbl06132023goodwin`
--
ALTER TABLE `tbl06132023goodwin`
  ADD PRIMARY KEY (`appID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `householdava`
--
ALTER TABLE `householdava`
  MODIFY `memberID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `householdfaraday`
--
ALTER TABLE `householdfaraday`
  MODIFY `memberID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `householdlego`
--
ALTER TABLE `householdlego`
  MODIFY `memberID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8125;

--
-- AUTO_INCREMENT for table `householdmarcus`
--
ALTER TABLE `householdmarcus`
  MODIFY `memberID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `medicalproviders`
--
ALTER TABLE `medicalproviders`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl06132023goodwin`
--
ALTER TABLE `tbl06132023goodwin`
  MODIFY `appID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
