-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Дек 12 2023 г., 07:04
-- Версия сервера: 8.0.31
-- Версия PHP: 8.0.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `educationmanagement`
--

-- --------------------------------------------------------

--
-- Структура таблицы `assessments`
--

DROP TABLE IF EXISTS `assessments`;
CREATE TABLE IF NOT EXISTS `assessments` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idStudent` int DEFAULT NULL,
  `idSubject` int DEFAULT NULL,
  `assessment` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idStudent` (`idStudent`),
  KEY `idSubject` (`idSubject`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `assessments`
--

INSERT INTO `assessments` (`id`, `idStudent`, `idSubject`, `assessment`) VALUES
(1, 1, 1, 5),
(2, 2, 3, 4),
(3, 1, 3, 5),
(4, 1, 3, 1);

-- --------------------------------------------------------

--
-- Структура таблицы `grup`
--

DROP TABLE IF EXISTS `grup`;
CREATE TABLE IF NOT EXISTS `grup` (
  `id` int NOT NULL AUTO_INCREMENT,
  `number` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `grup`
--

INSERT INTO `grup` (`id`, `number`) VALUES
(1, '185'),
(2, '28'),
(3, '250');

-- --------------------------------------------------------

--
-- Структура таблицы `positions`
--

DROP TABLE IF EXISTS `positions`;
CREATE TABLE IF NOT EXISTS `positions` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `positions`
--

INSERT INTO `positions` (`id`, `name`) VALUES
(1, 'администратор'),
(2, 'учитель');

-- --------------------------------------------------------

--
-- Структура таблицы `staff`
--

DROP TABLE IF EXISTS `staff`;
CREATE TABLE IF NOT EXISTS `staff` (
  `id` int NOT NULL AUTO_INCREMENT,
  `staffName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `lastName` varchar(20) DEFAULT NULL,
  `idPositions` int DEFAULT NULL,
  `salary` int DEFAULT NULL,
  `login` varchar(20) DEFAULT NULL,
  `pass` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idPositions` (`idPositions`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `staff`
--

INSERT INTO `staff` (`id`, `staffName`, `lastName`, `idPositions`, `salary`, `login`, `pass`) VALUES
(3, 'вася', 'коля', 1, 1000, 'root', 'root'),
(4, 'Коля', 'Стоякина', 2, 1000, 'login', 'pass');

-- --------------------------------------------------------

--
-- Структура таблицы `students`
--

DROP TABLE IF EXISTS `students`;
CREATE TABLE IF NOT EXISTS `students` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idGrup` int DEFAULT NULL,
  `stuName` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `lastName` varchar(20) DEFAULT NULL,
  `address` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idGrup` (`idGrup`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `students`
--

INSERT INTO `students` (`id`, `idGrup`, `stuName`, `lastName`, `address`) VALUES
(1, 1, 'кирилл', 'помазов', 'Ул. Пушкина. д. коло'),
(2, 2, 'Елена', 'Томилова', 'адлвоадв'),
(3, 2, 'Вася', 'Пупкин', 'ул. вдалыодв д. 34');

-- --------------------------------------------------------

--
-- Структура таблицы `subjects`
--

DROP TABLE IF EXISTS `subjects`;
CREATE TABLE IF NOT EXISTS `subjects` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(20) DEFAULT NULL,
  `idTeacher` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `idTeacher` (`idTeacher`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `subjects`
--

INSERT INTO `subjects` (`id`, `name`, `idTeacher`) VALUES
(1, 'физка', NULL),
(2, 'lkjlkj', 3),
(3, 'информатика', 4);

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `assessments`
--
ALTER TABLE `assessments`
  ADD CONSTRAINT `assessments_ibfk_1` FOREIGN KEY (`idStudent`) REFERENCES `students` (`id`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `assessments_ibfk_2` FOREIGN KEY (`idSubject`) REFERENCES `subjects` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `staff`
--
ALTER TABLE `staff`
  ADD CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`idPositions`) REFERENCES `positions` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`idGrup`) REFERENCES `grup` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Ограничения внешнего ключа таблицы `subjects`
--
ALTER TABLE `subjects`
  ADD CONSTRAINT `subjects_ibfk_1` FOREIGN KEY (`idTeacher`) REFERENCES `staff` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
