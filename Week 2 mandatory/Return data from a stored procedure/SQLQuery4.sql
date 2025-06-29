USE CompanyDB;
GO
DROP PROCEDURE IF EXISTS sp_CountEmployeesByDepartment;
GO
CREATE PROCEDURE sp_CountEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO
EXEC sp_CountEmployeesByDepartment @DepartmentID = 2;
