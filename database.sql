
DROP DATABASE IF EXISTS `movedb`;
CREATE DATABASE IF NOT EXISTS `movedb`;
USE `movedb`;

#
# Table structure for table 'Дверной блок'
#

DROP TABLE IF EXISTS `Дверной блок`;

CREATE TABLE `Дверной блок` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название` VARCHAR(255), 
  `Ширина` FLOAT NULL, 
  `Высота` FLOAT NULL, 
  `Тип` VARCHAR(255), 
  `Створки` VARCHAR(255), 
  `Материал` VARCHAR(255), 
  `Ограждающее свойство` VARCHAR(255), 
  `Способ открывание` VARCHAR(255), 
  `Цена` FLOAT NULL, 
  PRIMARY KEY (`Код`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Дверной блок'
#

INSERT INTO `Дверной блок` (`Код`, `Название`, `Ширина`, `Высота`, `Тип`, `Створки`, `Материал`, `Ограждающее свойство`, `Способ открывание`, `Цена`) VALUES (1, 'Одиночный стандарт', 800, 2000, 'Внутренние', 'Одностворчатый', 'Дерево', 'Глухие', 'Распашные', 340);
INSERT INTO `Дверной блок` (`Код`, `Название`, `Ширина`, `Высота`, `Тип`, `Створки`, `Материал`, `Ограждающее свойство`, `Способ открывание`, `Цена`) VALUES (2, 'Двойной стандарт', 1300, 2000, 'Внутренние', 'Двухстворчатый', 'Металл', 'Полуостекленные', 'Распашные', 450);
INSERT INTO `Дверной блок` (`Код`, `Название`, `Ширина`, `Высота`, `Тип`, `Створки`, `Материал`, `Ограждающее свойство`, `Способ открывание`, `Цена`) VALUES (3, 'Одиночный раздвижной', 700, 2000, 'Внутренние', 'Одностворчатый', 'Дерево', 'Глухие', 'Раздвижные', 325);
# 3 records

#
# Table structure for table 'Изготовление дверных блоков'
#

DROP TABLE IF EXISTS `Изготовление дверных блоков`;

CREATE TABLE `Изготовление дверных блоков` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Дверной блок` INTEGER, 
  `Количество` INTEGER, 
  `Дата изготовления` DATETIME, 
  `Кем изготовлено` INTEGER, 
  PRIMARY KEY (`Код`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Изготовление дверных блоков'
#

INSERT INTO `Изготовление дверных блоков` (`Код`, `Дверной блок`, `Количество`, `Дата изготовления`, `Кем изготовлено`) VALUES (1, 1, 10, '2020-11-05 00:00:00', 2);
INSERT INTO `Изготовление дверных блоков` (`Код`, `Дверной блок`, `Количество`, `Дата изготовления`, `Кем изготовлено`) VALUES (2, 2, 15, '2020-11-06 00:00:00', 2);
# 2 records

#
# Table structure for table 'Изготовление оконных блоков'
#

DROP TABLE IF EXISTS `Изготовление оконных блоков`;

CREATE TABLE `Изготовление оконных блоков` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Оконный блок` INTEGER, 
  `Количество` INTEGER, 
  `Дата изготовления` DATETIME, 
  `Кем изготовлено` INTEGER, 
  PRIMARY KEY (`Код`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Изготовление оконных блоков'
#

INSERT INTO `Изготовление оконных блоков` (`Код`, `Оконный блок`, `Количество`, `Дата изготовления`, `Кем изготовлено`) VALUES (1, 1, 15, '2020-11-04 00:00:00', 3);
INSERT INTO `Изготовление оконных блоков` (`Код`, `Оконный блок`, `Количество`, `Дата изготовления`, `Кем изготовлено`) VALUES (2, 2, 8, '2020-11-05 00:00:00', 3);
# 2 records

#
# Table structure for table 'Материалы для дверей'
#

DROP TABLE IF EXISTS `Материалы для дверей`;

CREATE TABLE `Материалы для дверей` (
  `Материал` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Материал`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Материалы для дверей'
#

INSERT INTO `Материалы для дверей` (`Материал`) VALUES ('Дерево');
INSERT INTO `Материалы для дверей` (`Материал`) VALUES ('Пластик');
INSERT INTO `Материалы для дверей` (`Материал`) VALUES ('Металл');
INSERT INTO `Материалы для дверей` (`Материал`) VALUES ('Стекло');
# 4 records

#
# Table structure for table 'Материалы для окон'
#

DROP TABLE IF EXISTS `Материалы для окон`;

CREATE TABLE `Материалы для окон` (
  `Материал` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Материал`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Материалы для окон'
#

INSERT INTO `Материалы для окон` (`Материал`) VALUES ('Поливинилхлорид');
INSERT INTO `Материалы для окон` (`Материал`) VALUES ('Дерево');
# 2 records

#
# Table structure for table 'Направление открытия окна'
#

DROP TABLE IF EXISTS `Направление открытия окна`;

CREATE TABLE `Направление открытия окна` (
  `Направление` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Направление`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Направление открытия окна'
#

INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Поворот на себя');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Поворот от себя');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Поворот двухсторонний');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Подвесной');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Откидной');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Поворотно-откидной');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Раздвижной');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Подъемный');
INSERT INTO `Направление открытия окна` (`Направление`) VALUES ('Глухой');
# 9 records

#
# Table structure for table 'Ограждающие свойства двери'
#

DROP TABLE IF EXISTS `Ограждающие свойства двери`;

CREATE TABLE `Ограждающие свойства двери` (
  `Ограждение` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Ограждение`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Ограждающие свойства двери'
#

INSERT INTO `Ограждающие свойства двери` (`Ограждение`) VALUES ('Глухие');
INSERT INTO `Ограждающие свойства двери` (`Ограждение`) VALUES ('Полуостекленные');
INSERT INTO `Ограждающие свойства двери` (`Ограждение`) VALUES ('Остекленные');
# 3 records

#
# Table structure for table 'Оконные стекла'
#

DROP TABLE IF EXISTS `Оконные стекла`;

CREATE TABLE `Оконные стекла` (
  `Название` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Название`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Оконные стекла'
#

INSERT INTO `Оконные стекла` (`Название`) VALUES ('Одинарный слой стекол');
INSERT INTO `Оконные стекла` (`Название`) VALUES ('Двойной слой стекол');
INSERT INTO `Оконные стекла` (`Название`) VALUES ('Тройной слой стекол');
INSERT INTO `Оконные стекла` (`Название`) VALUES ('Четыре слоя стекла');
# 4 records

#
# Table structure for table 'Оконный блок'
#

DROP TABLE IF EXISTS `Оконный блок`;

CREATE TABLE `Оконный блок` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название` VARCHAR(255), 
  `Ширина` FLOAT NULL, 
  `Высота` FLOAT NULL, 
  `Материал` VARCHAR(255), 
  `Створки` VARCHAR(255), 
  `Направление открытия` VARCHAR(255), 
  `Проветривание` VARCHAR(255), 
  `Цена` FLOAT NULL, 
  PRIMARY KEY (`Код`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Оконный блок'
#

INSERT INTO `Оконный блок` (`Код`, `Название`, `Ширина`, `Высота`, `Материал`, `Створки`, `Направление открытия`, `Проветривание`, `Цена`) VALUES (1, 'Одиночный стандарт', 870, 1420, 'Дерево', 'Двухстворчатый', 'Поворот на себя', 'Поворотно-откидные створки', 800);
INSERT INTO `Оконный блок` (`Код`, `Название`, `Ширина`, `Высота`, `Материал`, `Створки`, `Направление открытия`, `Проветривание`, `Цена`) VALUES (2, 'Двойной стандарт', 2080, 1420, 'Поливинилхлорид', 'Трехстворчатый', 'Поворот на себя', 'Поворотно-откидные створки', 1400);
# 2 records

#
# Table structure for table 'Пользователи'
#

DROP TABLE IF EXISTS `Пользователи`;

CREATE TABLE `Пользователи` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `ФИО` VARCHAR(255), 
  `Логин` VARCHAR(255), 
  `Пароль` VARCHAR(255), 
  `Роль` INTEGER, 
  PRIMARY KEY (`Код`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Пользователи'
#

INSERT INTO `Пользователи` (`Код`, `ФИО`, `Логин`, `Пароль`, `Роль`) VALUES (1, 'Администратор', 'admin', 'admin', 1);
INSERT INTO `Пользователи` (`Код`, `ФИО`, `Логин`, `Пароль`, `Роль`) VALUES (2, 'Иванов Иван Иванович', 'door', 'door', 2);
INSERT INTO `Пользователи` (`Код`, `ФИО`, `Логин`, `Пароль`, `Роль`) VALUES (3, 'Петров Петр Петрович', 'window', 'window', 3);
# 3 records

#
# Table structure for table 'Проветривание'
#

DROP TABLE IF EXISTS `Проветривание`;

CREATE TABLE `Проветривание` (
  `Тип проветривания` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Тип проветривания`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Проветривание'
#

INSERT INTO `Проветривание` (`Тип проветривания`) VALUES ('Форточка');
INSERT INTO `Проветривание` (`Тип проветривания`) VALUES ('Поворотно-откидные створки');
INSERT INTO `Проветривание` (`Тип проветривания`) VALUES ('Фрамуга');
INSERT INTO `Проветривание` (`Тип проветривания`) VALUES ('Вентиляционные клапаны');
# 4 records

#
# Table structure for table 'Роли пользователей'
#

DROP TABLE IF EXISTS `Роли пользователей`;

CREATE TABLE `Роли пользователей` (
  `Код` INTEGER NOT NULL, 
  `Название` VARCHAR(255), 
  PRIMARY KEY (`Код`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Роли пользователей'
#

INSERT INTO `Роли пользователей` (`Код`, `Название`) VALUES (1, 'Администратор');
INSERT INTO `Роли пользователей` (`Код`, `Название`) VALUES (2, 'Создатель дверей');
INSERT INTO `Роли пользователей` (`Код`, `Название`) VALUES (3, 'Создатель окон');
# 3 records

#
# Table structure for table 'Створки'
#

DROP TABLE IF EXISTS `Створки`;

CREATE TABLE `Створки` (
  `Название` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Название`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Створки'
#

INSERT INTO `Створки` (`Название`) VALUES ('Одностворчатый');
INSERT INTO `Створки` (`Название`) VALUES ('Двухстворчатый');
INSERT INTO `Створки` (`Название`) VALUES ('Многостворчатый');
INSERT INTO `Створки` (`Название`) VALUES ('Трехстворчатый');
# 4 records

#
# Table structure for table 'Тип двери'
#

DROP TABLE IF EXISTS `Тип двери`;

CREATE TABLE `Тип двери` (
  `Название` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Название`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Тип двери'
#

INSERT INTO `Тип двери` (`Название`) VALUES ('Наружные');
INSERT INTO `Тип двери` (`Название`) VALUES ('Внутренние');
INSERT INTO `Тип двери` (`Название`) VALUES ('Шкафные');
INSERT INTO `Тип двери` (`Название`) VALUES ('Служебные');
# 4 records

#
# Table structure for table 'Тип открытия двери'
#

DROP TABLE IF EXISTS `Тип открытия двери`;

CREATE TABLE `Тип открытия двери` (
  `Тип` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Тип`)
) ENGINE=myisam DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Тип открытия двери'
#

INSERT INTO `Тип открытия двери` (`Тип`) VALUES ('Распашные');
INSERT INTO `Тип открытия двери` (`Тип`) VALUES ('Раздвижные');
# 2 records

