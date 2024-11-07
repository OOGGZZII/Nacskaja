-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2024. Nov 07. 10:24
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `restaurantdb`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `food`
--

CREATE TABLE `food` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `size` text NOT NULL,
  `description` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `ingreedients`
--

CREATE TABLE `ingreedients` (
  `id` int(11) NOT NULL,
  `name` text NOT NULL,
  `price` int(11) NOT NULL,
  `ammountremaining` int(11) NOT NULL,
  `storagelow` int(11) NOT NULL,
  `unitofmeasure` tinytext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `recepie`
--

CREATE TABLE `recepie` (
  `foodid` int(11) NOT NULL,
  `ingreedientid` int(11) NOT NULL,
  `ammountused` int(11) NOT NULL,
  `details` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `food`
--
ALTER TABLE `food`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `ingreedients`
--
ALTER TABLE `ingreedients`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `recepie`
--
ALTER TABLE `recepie`
  ADD KEY `foodid` (`foodid`),
  ADD KEY `ingreedientid` (`ingreedientid`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `food`
--
ALTER TABLE `food`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT a táblához `ingreedients`
--
ALTER TABLE `ingreedients`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `recepie`
--
ALTER TABLE `recepie`
  ADD CONSTRAINT `recepie_ibfk_1` FOREIGN KEY (`foodid`) REFERENCES `food` (`id`) ON DELETE CASCADE,
  ADD CONSTRAINT `recepie_ibfk_2` FOREIGN KEY (`ingreedientid`) REFERENCES `ingreedients` (`id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
