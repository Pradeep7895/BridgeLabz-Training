use PracticeDB;

CREATE TABLE Departments (
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50) NOT NULL
);

CREATE TABLE Employees (
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary DECIMAL(10,2),
    DeptID INT,
    CONSTRAINT FK_Employees_Departments
    FOREIGN KEY (DeptID)
    REFERENCES Departments(DeptID)
);

INSERT INTO Departments (DeptID, DeptName) VALUES
(10, 'Human Resources'),
(20, 'IT'),
(30, 'Finance'),
(40, 'Marketing');

INSERT INTO Employees (EmpID, EmpName, Salary, DeptID) VALUES
(1, 'Rahul', 55000, 20),
(2, 'Anita', 48000, 10),
(3, 'Karan', 62000, 20),
(4, 'Meena', 45000, 30),
(5, 'Rohit', 50000, NULL);

--------INNER JOIN----
-- Syntax: 
-- SELECT columns
-- FROM table1
-- INNER JOIN table2
-- ON join_condition;

SELECT E.EmpID, E.EmpName, E.Salary, D.DeptName
FROM Employees E
INNER JOIN Departments D
ON E.DeptID = D.DeptID;

------LEFT JOIN------

-- Syntax:
-- SELECT columns
-- FROM table1
-- LEFT JOIN table2
-- ON join_condition;

SELECT E.EmpID, E.EmpName, E.Salary, D.DeptName
FROM Employees E
LEFT JOIN Departments D
ON E.DeptID = D.DeptID;

------RIGHT JOIN-----
-- Syntax:
-- SELECT columns
-- FROM table1
-- RIGHT JOIN table2
-- ON join_condition;

SELECT E.EmpID, E.EmpName, E.Salary, D.DeptName
FROM Employees E
RIGHT JOIN Departments D
ON E.DeptID = D.DeptID;

-------FULL OUTER JOIN-----
-- Syntax:
-- SELECT columns
-- FROM table1
-- FULL OUTER JOIN table2
-- ON join_condition;

SELECT E.EmpID, E.EmpName, E.Salary, D.DeptName
FROM Employees E
FULL OUTER JOIN Departments D
ON E.DeptID = D.DeptID;

------CROSS JOIN------
-- Syntax:
-- SELECT columns
-- FROM table1
-- CROSS JOIN table2;

SELECT E.EmpName, D.DeptName
FROM Employees E
CROSS JOIN Departments D;
