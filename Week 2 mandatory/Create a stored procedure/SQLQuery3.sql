USE CompanyDB;
GO
DROP PROCEDURE IF EXISTS sp_InsertEmployee;
GO
IF OBJECT_ID('Employees', 'U') IS NULL
BEGIN
    CREATE TABLE Employees (
        EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
        FirstName VARCHAR(50),
        LastName VARCHAR(50),
        DepartmentID INT,
        Salary DECIMAL(10,2),
        JoinDate DATE
    );
END;
GO
CREATE PROCEDURE sp_InsertEmployee
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Salary DECIMAL(10,2),
    @JoinDate DATE
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Salary, JoinDate)
    VALUES (@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
END;
GO
EXEC sp_InsertEmployee 
    @FirstName = 'Naveen',
    @LastName = 'Krishna',
    @DepartmentID = 1,
    @Salary = 75000.00,
    @JoinDate = '2024-12-01';
SELECT * FROM Employees;
