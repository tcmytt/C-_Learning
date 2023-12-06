CREATE DATABASE IF NOT EXISTS QuanLyQuanCafe;

USE QuanLyQuanCafe;

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE IF NOT EXISTS TableFood
(
	id INT AUTO_INCREMENT PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT 'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT 'Trống' -- Trống || Có người
);

CREATE TABLE IF NOT EXISTS Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT 'Kter',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT '0',
	Type INT NOT NULL DEFAULT 0 -- 1: admin && 0: staff
);

CREATE TABLE IF NOT EXISTS FoodCategory
(
	id INT AUTO_INCREMENT PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT 'Chưa đặt tên'
);

CREATE TABLE IF NOT EXISTS Food
(
	id INT AUTO_INCREMENT PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT 'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0,
	FOREIGN KEY (idCategory) REFERENCES FoodCategory(id)
);

CREATE TABLE Bill
(
    id INT AUTO_INCREMENT PRIMARY KEY,
    DateCheckIn DATE NOT NULL,
    DateCheckOut DATE,
    idTable INT NOT NULL,
    status INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idTable) REFERENCES TableFood(id)
) DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

CREATE TABLE IF NOT EXISTS BillInfo
(
	id INT AUTO_INCREMENT PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0,
	FOREIGN KEY (idBill) REFERENCES Bill(id),
	FOREIGN KEY (idFood) REFERENCES Food(id)
);

INSERT INTO Account (UserName, DisplayName, PassWord, Type)
VALUES ('K9', 'RongK9', '1', 1);

INSERT INTO Account (UserName, DisplayName, PassWord, Type)
VALUES ('staff', 'staff', '1', 0);

DELIMITER //
CREATE PROCEDURE USP_GetAccountByUserName(IN p_userName NVARCHAR(100))
BEGIN
	SELECT * FROM Account WHERE UserName = p_userName;
END //
DELIMITER ;

CALL USP_GetAccountByUserName('K9');


DELIMITER //

CREATE PROCEDURE USP_Login(IN p_userName NVARCHAR(100), IN p_passWord NVARCHAR(100))
BEGIN
    SELECT * FROM Account WHERE UserName = p_userName AND PassWord = p_passWord;
END //

DELIMITER ;

CALL USP_Login('admin' , '1');
