-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 04, 2019 at 03:30 AM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pagesmgmtdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `pagesmgmt`
--

CREATE TABLE `pagesmgmt` (
  `pageid` int(20) NOT NULL,
  `pagetitle` varchar(255) DEFAULT NULL,
  `pagebody` mediumtext DEFAULT NULL,
  `pageauthor` varchar(20) DEFAULT NULL,
  `timestamp` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pagesmgmt`
--

INSERT INTO `pagesmgmt` (`pageid`, `pagetitle`, `pagebody`, `pageauthor`, `timestamp`) VALUES
(1, 'Travel', 'On this Blogspot I will talk about my favourite cities I’ve travelled to: Grand Canyon, New York, San Francisco and Oahu, Hawaii. I will write what I liked about them as well as ways I saved money and made the most of my trips.\r\n\r\nFor this first post I will focus on Oahu, mostly Waikiki beach. I’ve never been a fan of going to the beach, maybe it has something to do with living so close to it all of my life, however once you go to Waikiki Beach you fall in love. Oahu has the perfect weather in may, not too hot but just perfect for you to go to the beach, sightseeing and hiking.', 'Alexa Perez', '2019-12-03'),
(2, 'Once Upon a Time', 'The first season premiered on October 23, 2011. The Evil Queen interrupts the wedding of Snow White and Prince Charming to announce that she will cast a curse on everyone that will leave her with the only happy ending. As a result, the majority of the characters are transported to the town of Storybrooke, Maine, where most of them have been stripped of their original memories and identities as fairy tale characters. On her 28th birthday, Emma Swan, the daughter of Snow White and Prince Charming, is brought to Storybrooke by her biological son Henry Mills in the hopes of breaking the curse cast by his adoptive mother, the Evil Queen Regina.', 'Emma Swan', '2019-12-03'),
(3, 'Music', 'Music is an art form and cultural activity whose medium is sound organized in time. General definitions of music include common elements such as pitch (which governs melody and harmony), rhythm (and its associated concepts tempo, meter, and articulation), dynamics (loudness and softness), and the sonic qualities of timbre and texture (which are sometimes termed the \"color\" of a musical sound). Different styles or types of music may emphasize, de-emphasize or omit some of these elements. Music is performed with a vast range of instruments and vocal techniques ranging from singing to rapping; there are solely instrumental pieces, solely vocal pieces (such as songs without instrumental accompaniment) and pieces that combine singing and instruments. ', 'Robin Hood', '2019-12-03');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pagesmgmt`
--
ALTER TABLE `pagesmgmt`
  ADD PRIMARY KEY (`pageid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pagesmgmt`
--
ALTER TABLE `pagesmgmt`
  MODIFY `pageid` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
