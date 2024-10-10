-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 10, 2024 at 02:08 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `payrollsystem`
--

-- --------------------------------------------------------

--
-- Table structure for table `deductions`
--

CREATE TABLE `deductions` (
  `deductionsID` int(11) NOT NULL,
  `employeeID` int(11) NOT NULL,
  `month` varchar(50) NOT NULL,
  `year` int(11) NOT NULL,
  `philhealth` varchar(11) NOT NULL,
  `sss` varchar(11) NOT NULL,
  `pagibig` varchar(11) NOT NULL,
  `absences` int(11) NOT NULL,
  `philhealthAmount` varchar(20) NOT NULL,
  `sssAmount` varchar(20) NOT NULL,
  `pagibigAmount` varchar(20) NOT NULL,
  `absencesAmount` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `deductions`
--

INSERT INTO `deductions` (`deductionsID`, `employeeID`, `month`, `year`, `philhealth`, `sss`, `pagibig`, `absences`, `philhealthAmount`, `sssAmount`, `pagibigAmount`, `absencesAmount`) VALUES
(26, 13, 'July', 2024, '5%', '4.5%', '2%', 2, '1130.9', '1017.81', '452.36', '1738'),
(27, 14, 'July', 2024, '5%', '4.5%', '2%', 1, '1121.7', '1009.53', '448.68', '862'),
(28, 15, 'July', 2024, '5%', '4.5%', '2%', 2, '1189.35', '1070.415', '475.74', '1828'),
(29, 16, 'July', 2024, '5%', '4.5%', '2%', 3, '1136', '1022.4', '454.4', '2619'),
(32, 13, 'August', 2024, '6%', '5%', '3%', 0, '1357.08', '1130.9', '678.54', '0'),
(33, 22, 'August', 2024, '6%', '5%', '3%', 3, '1682.52', '1402.1', '841.26', '3234');

-- --------------------------------------------------------

--
-- Table structure for table `registeremployee`
--

CREATE TABLE `registeremployee` (
  `employeeID` int(11) NOT NULL,
  `lastname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) NOT NULL,
  `contact` varchar(20) NOT NULL,
  `jobtitle` varchar(50) NOT NULL,
  `salary` int(11) NOT NULL,
  `email` varchar(50) NOT NULL,
  `address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `registeremployee`
--

INSERT INTO `registeremployee` (`employeeID`, `lastname`, `firstname`, `middlename`, `contact`, `jobtitle`, `salary`, `email`, `address`) VALUES
(13, 'Roduta', 'Bradley', 'Atendido', '09914535716', 'Merchandiser', 22618, 'bradley@gmail.com', 'Bacoor Cavite'),
(14, 'Saldon Jr.', 'Joseph Elmer', 'Sabino', '09397339786', 'Sales Executive', 22434, 'josephelmer@gmail.com', 'Las Pinas City'),
(15, 'Icawat', 'Laila Jane', '', '09489236507', 'Sales Associate', 23787, 'lailajane@gmail.com', 'Bacoor Cavite'),
(16, 'Calderon', 'Ara Mae', '', '09875677467', 'Cashier', 22720, 'aramae@gmail.com', 'Bacoor Cavite'),
(22, 'Oli', 'Jonathan', 'Buban', '09760084029', 'Marketing Coordinator', 28042, 'jonathan@gmail.com', 'Bacoor Cavite');

-- --------------------------------------------------------

--
-- Table structure for table `salary`
--

CREATE TABLE `salary` (
  `salaryID` int(11) NOT NULL,
  `employeeID` int(11) NOT NULL,
  `month` varchar(50) NOT NULL,
  `year` int(11) NOT NULL,
  `totalDeduction` decimal(11,2) NOT NULL,
  `totalSalary` decimal(11,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `salary`
--

INSERT INTO `salary` (`salaryID`, `employeeID`, `month`, `year`, `totalDeduction`, `totalSalary`) VALUES
(7, 13, 'July', 2024, 4339.07, 18278.93),
(9, 14, 'July', 2024, 3441.91, 18992.09),
(10, 15, 'July', 2024, 4563.51, 19223.50),
(11, 16, 'July', 2024, 5231.80, 17488.20),
(14, 13, 'August', 2024, 3166.52, 19553.48),
(15, 22, 'August', 2024, 7159.88, 20882.12);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `deductions`
--
ALTER TABLE `deductions`
  ADD PRIMARY KEY (`deductionsID`),
  ADD KEY `employeeID` (`employeeID`);

--
-- Indexes for table `registeremployee`
--
ALTER TABLE `registeremployee`
  ADD PRIMARY KEY (`employeeID`);

--
-- Indexes for table `salary`
--
ALTER TABLE `salary`
  ADD PRIMARY KEY (`salaryID`),
  ADD KEY `employeeID` (`employeeID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `deductions`
--
ALTER TABLE `deductions`
  MODIFY `deductionsID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=34;

--
-- AUTO_INCREMENT for table `registeremployee`
--
ALTER TABLE `registeremployee`
  MODIFY `employeeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `salary`
--
ALTER TABLE `salary`
  MODIFY `salaryID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `deductions`
--
ALTER TABLE `deductions`
  ADD CONSTRAINT `deductions_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `registeremployee` (`employeeID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `salary`
--
ALTER TABLE `salary`
  ADD CONSTRAINT `salary_ibfk_1` FOREIGN KEY (`employeeID`) REFERENCES `registeremployee` (`employeeID`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
