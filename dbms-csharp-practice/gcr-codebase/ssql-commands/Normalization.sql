/*
CREATE TABLE table_name (
    column_name data_type [constraints],
    PRIMARY KEY (col1, col2)
);
*/
CREATE DATABASE CollegeDB;
USE CollegeDB;
GO

-- 1NF(Repeating values removed)

/*
    CREATE TABLE Student(
        StudentID INT,
        Name VARCHAR(50),
        Subjects VARCHAR(100)  -- "Math,Science,English"
    );
*/
CREATE TABLE Student1(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50)
);

CREATE TABLE StudentSubject(
    StudentID INT,
    Subject VARCHAR(50),
    PRIMARY KEY (StudentID, Subject),
    FOREIGN KEY (StudentID) REFERENCES Student1(StudentID)
);

-- 2NF(Remove partial dependency)

/*
    CREATE TABLE Enrollment(
        StudentID INT,
        CourseID INT,
        StudentName VARCHAR(50),
        CourseName VARCHAR(50),
        PRIMARY KEY (StudentID, CourseID)
    );

*/

CREATE TABLE Student2(
    StudentID INT PRIMARY KEY,
    StudentName VARCHAR(50)
);

CREATE TABLE Course(
    CourseID INT PRIMARY KEY,
    CourseName VARCHAR(50)
);

CREATE TABLE Enrollment(
    StudentID INT,
    CourseID INT,
    PRIMARY KEY (StudentID, CourseID),
    FOREIGN KEY (StudentID) REFERENCES Student2(StudentID),
    FOREIGN KEY (CourseID) REFERENCES Course(CourseID)
);


-- 3NF(Remove transitive dependency)

/*
    CREATE TABLE Employee(
        EmpID INT PRIMARY KEY,
        EmpName VARCHAR(50),
        DeptID INT,
        DeptName VARCHAR(50)
    );

*/

CREATE TABLE Department(
    DeptID INT PRIMARY KEY,
    DeptName VARCHAR(50)
);

CREATE TABLE Employee(
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    DeptID INT,
    FOREIGN KEY (DeptID) REFERENCES Department(DeptID)
);


-- BCNF(Every determinant is candidate key)

/*
    CREATE TABLE CourseInstructor(
        CourseID INT,
        InstructorID INT,
        InstructorName VARCHAR(50),
        PRIMARY KEY (CourseID, InstructorID)
    );

*/

CREATE TABLE Instructor(
    InstructorID INT PRIMARY KEY,
    InstructorName VARCHAR(50)
);

CREATE TABLE CourseInstructor(
    CourseID INT,
    InstructorID INT,
    PRIMARY KEY (CourseID, InstructorID),
    FOREIGN KEY (InstructorID) REFERENCES Instructor(InstructorID)
);