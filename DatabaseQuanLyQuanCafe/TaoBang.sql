CREATE DATABASE IF NOT EXISTS QuanLyQuanCafe;

USE QuanLyQuanCafe;

-- TableFood
CREATE TABLE TableFood (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT 'Bàn chưa có tên',
    status NVARCHAR(100) NOT NULL DEFAULT 'Trống' -- Trống || Có người
);

-- Account
CREATE TABLE Account (
    UserName NVARCHAR(100) PRIMARY KEY,
    DisplayName NVARCHAR(100) NOT NULL DEFAULT 'Kter',
    PassWord NVARCHAR(1000) NOT NULL DEFAULT '0',
    Type INT NOT NULL DEFAULT 0 -- 1: admin && 0: staff
);

-- FoodCategory
CREATE TABLE FoodCategory (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT 'Chưa đặt tên'
);

-- Food
CREATE TABLE Food (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name NVARCHAR(100) NOT NULL DEFAULT 'Chưa đặt tên',
    idCategory INT NOT NULL,
    price FLOAT NOT NULL DEFAULT 0,
    FOREIGN KEY (idCategory) REFERENCES FoodCategory(id)
);

-- Bill
CREATE TABLE Bill (
    id INT AUTO_INCREMENT PRIMARY KEY,
    DateCheckIn DATE NOT NULL ,
    DateCheckOut DATE,
    idTable INT NOT NULL,
    status INT NOT NULL DEFAULT 0, -- 1: đã thanh toán && 0: chưa thanh toán
    FOREIGN KEY (idTable) REFERENCES TableFood(id)
);

-- BillInfo
CREATE TABLE BillInfo (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idBill INT NOT NULL,
    idFood INT NOT NULL,
    count INT NOT NULL DEFAULT 0,
    FOREIGN KEY (idBill) REFERENCES Bill(id),
    FOREIGN KEY (idFood) REFERENCES Food(id)
);

-- Insert into Account
INSERT INTO Account (UserName, DisplayName, PassWord, Type)
VALUES
    ('K9', 'RongK9', '1', 1),
    ('staff', 'staff', '1', 0);

-- Stored Procedure USP_GetAccountByUserName
DELIMITER //
CREATE PROCEDURE USP_GetAccountByUserName(IN userName NVARCHAR(100))
BEGIN
    SELECT * FROM Account WHERE UserName = userName;
END //
DELIMITER ;

-- Execute the stored procedure
CALL USP_GetAccountByUserName('k9');

-- Stored Procedure USP_Login
DELIMITER //
CREATE PROCEDURE USP_Login(IN userName NVARCHAR(100), IN passWord NVARCHAR(100))
BEGIN
    SELECT * FROM Account WHERE UserName = userName AND PassWord = passWord;
END //
DELIMITER ;

-- Create a stored procedure to insert into TableFood
DELIMITER //
CREATE PROCEDURE InsertIntoTableFood()
BEGIN
    DECLARE i INT DEFAULT 0;
    
    WHILE i <= 10 DO
        INSERT INTO TableFood (name) VALUES (CONCAT('Bàn ', CAST(i AS CHAR)));
        SET i = i + 1;
    END WHILE;
END //
DELIMITER ;

-- Call the stored procedure
CALL InsertIntoTableFood();


-- Stored Procedure USP_GetTableList
DELIMITER //
CREATE PROCEDURE USP_GetTableList()
BEGIN
    SELECT * FROM TableFood;
END //
DELIMITER ;

-- Update TableFood status
UPDATE TableFood SET status = 'Có người' WHERE id = 9;

-- Execute the stored procedure
CALL USP_GetTableList();

-- Insert into FoodCategory
INSERT INTO FoodCategory (name) VALUES ('Hải sản'), ('Nông sản'), ('Lâm sản'), ('Sản sản'), ('Nước');

-- Insert into Food
INSERT INTO Food (name, idCategory, price) VALUES
    ('Mực một nắng nước sa tế', 1, 120000),
    ('Nghêu hấp xả', 1, 50000),
    ('Dú dê nướng sữa', 2, 60000),
    ('Heo rừng nướng muối ớt', 3, 75000),
    ('Cơm chiên mushi', 4, 999999),
    ('7Up', 5, 15000),
    ('Cafe', 5, 12000);

-- Insert into Bill
INSERT INTO Bill (DateCheckIn, DateCheckOut, idTable, status) VALUES
    (CURRENT_DATE(), NULL, 3, 0),
    (CURRENT_DATE(), NULL, 4, 0),
    (CURRENT_DATE(), CURRENT_DATE(), 5, 1);

-- Insert into BillInfo
INSERT INTO BillInfo (idBill, idFood, count) VALUES
    (1, 1, 2),
    (2, 3, 4),
    (3, 5, 1),
    (4, 1, 2),
    (5, 6, 2),
    (6, 5, 2);
