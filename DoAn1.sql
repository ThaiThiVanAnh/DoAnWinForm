CREATE DATABASE QLCT;
GO
USE QLCT;
GO

CREATE TABLE Expenses (
    ExpenseID INT PRIMARY KEY IDENTITY(1,1),   -- Mã chi tiêu, tự động tăng
    ExpenseName NVARCHAR(100) NOT NULL,        -- Tên chi tiêu
    Amount DECIMAL(18, 2) NOT NULL,            -- Số tiền mỗi đơn vị
    ExpenseDate DATE NOT NULL,                 -- Ngày chi tiêu
    Quantity INT NOT NULL,                     -- Số lượng
    TotalAmount AS (Amount * Quantity),        -- Tổng tiền, tính tự động
    Note NVARCHAR(255)                         -- Ghi chú
);
