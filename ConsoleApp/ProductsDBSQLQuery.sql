CREATE DATABASE ProductsDB;

USE ProductsDB;

CREATE TABLE Product
(
	product_id INT NOT NULL,
	product_name VARCHAR(256) NOT NULL,
	PRIMARY KEY(product_id)
);

CREATE TABLE Category
(
	category_id INT NOT NULL,
	categoty_name VARCHAR(256) NOT NULL,
	PRIMARY KEY(category_id)
);

CREATE TABLE ProductCategoty
(
	product_id INT NOT NULL,
	category_id INT NOT NULL,
	PRIMARY KEY(product_id, category_id),
	FOREIGN KEY (product_id) REFERENCES Product (product_id),
	FOREIGN KEY (category_id) REFERENCES Category (category_id),
);

INSERT INTO Product (product_id, product_name)
	VALUES
	(1, 'Джинсы'),
	(2, 'Брюки черные'),
	(3, 'Шорты'),
	(4, 'Футболка'),
	(5, 'Куртка'),
	(6, 'Кросовки'),
	(7, 'Ботики'),
	(8, 'Сапоги'),
	(9, 'Боксерские перчатки'),
	(10, 'Бейсболка'),
	(11, 'Шапка'),
	(12, 'Часы'),
	(13, 'Кольцо'),
	(14, 'Толстовка'),
	(15, 'Цепочка'),
	(16, 'Брюки белые'),
	(17, 'Носки'),
	(18, 'Ремень'),
	(19, 'Рубашка'),
	(20, 'Майка'),
	(21, 'Рюкзак'),
	(22, 'Шарф'),
	(23, 'Очки');

INSERT INTO Category(category_id, categoty_name)
	VALUES
	(1, 'Мужская одежда'),
	(2, 'Женская одежда'),
	(3, 'Детская одежда'),
	(4, 'Верхняя одежда'),
	(5, 'Футболки\рубашки'),
	(6, 'Аксессуары'),
	(7, 'Летняя обувь'),
	(8, 'Штаны'),
	(9, 'Сумки'),
	(10, 'Головные уборы'),
	(11, 'Нижнее белье'),
	(12, 'Зимняя обувь');


INSERT INTO ProductCategoty(product_id, category_id)
	VALUES
	(1, 1),
	(2, 1),
	(3, 2),
	(4, 2),
	(7, 2),
	(8, 3),
	(12, 2),
	(13, 2),
	(14, 1),
	(15, 3),
	(19, 1),
	(20, 3),
	(21, 1),
	(23, 1),
	(5, 4),
	(14, 4),
	(4, 5),
	(19, 5),
	(20, 5),
	(12, 6),
	(13, 6),
	(15, 6),
	(18, 6),
	(23, 6),
	(6, 7),
	(7, 7),
	(8, 7),
	(1, 8),
	(2, 8),
	(3, 8),
	(16, 8),
	(21, 9),
	(10, 10),
	(11, 10);

SELECT Product.product_name AS 'Имя продукта', Category.categoty_name AS 'Имя категории' FROM Product
	LEFT JOIN ProductCategoty ON Product.product_id = ProductCategoty.product_id
	LEFT JOIN Category ON Category.category_id = ProductCategoty.category_id;

/*
DROP TABLE ProductCategoty;
DROP TABLE Category;
DROP TABLE Product;
DROP DATABASE ProductsDB;
*/