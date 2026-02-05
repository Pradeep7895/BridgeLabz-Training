----DDl Commands-----

---------Create---------

--Syntax : Create Database
--create database databaseName;

create database PracticeDB;

--Syntax: Use Database
-- use databaseName;

use PracticeDB;

--Syntax: Create Table
-- create table TableName(
--   column1 datatype [constraint]
--   column2 datatype [constraint]
--   ...
-- );

create table Students(
    StudentID int primary key,
    Name varchar(20) not null,
    Age int,
    Department varchar(30)
);

----Alter----

--Syntax: Add Column
-- alter table table_name
-- add column_name datatype;

alter table Students
add Email varchar(50) unique;

--Syntax: Modify Column Datatype
-- alter table table_name
-- alter column column_name new_datatype

alter table Students
alter column Name varchar(50);

--Syntax : Drop Column
-- alter table table_name
-- drop column column_name;

alter table Students
drop column Age;

--------Drop------
--Syntax: Drop table
--drop table table_name;

--drop table Students;

--Synatx: Drop Database
--drop database database_name

--drop database PracticeDB;

-------Truncate-----
--Syntax: Truncate table table_name

--truncate table Students;


-----DML Commands-----
----Insert---

--Syntax: Insert Single Record
-- Insert into table_name(column1, column2,...)
-- Values(value1, value2,...);

insert into Students (StudentID, Name, Age, Department, Email)
values(1, 'Pradeep', 22, 'CSE', 'Pradeep@gmail.com');

--Syntax: Insert Multiple Records
-- INSERT INTO table_name (column1, column2, ...)
-- VALUES
-- (value1, value2, ...),
-- (value1, value2, ...);

insert into Students(StudentID, Name, Age, Department, Email)
values
(2, 'Abhay', 21,'CSE', 'Abhay@gmail.com'),
(3,'Abhishek', 22,'Mechanical', 'Abhishek@gmail.com');

-------Update------
--Syntax: Update Records
--update table_name
--set column1= value1
--where condition

update Students
set Department = 'IT'
where StudentID = 2;

------Delete-----
--Syntax: Delete specific record
--delete from table_name
--where Condition

delete from Students
where StudentID = 2;

--Syntax: Delete all records
--delete from table_name

delete from Students;

----DQL Commands----
-----Select----

--Syntax: Select All Columns
-- SELECT * FROM table_name;

Select * from Students;

--Syntax: Select Specific Columns
-- SELECT column1, column2
-- FROM table_name;

Select Name, Department from Students;

--Syntax: Select with WHERE Clause
--select column1, column2
--from table_name
--where condition;

select Name,Age from Students where Age>21;

--Syntax: Select with AND / OR 
--select * from table_name
--where condition1 and condition2;

select *from Students where Department= 'CSE' and Age>21;

--Syntax: select with Order by
--select * from table_name
--order by column_name ASC|DESC;

select * from Students
order by Age ASC;

--Syntax: Select with distinct
--select distinct column_name from table_name;

select distinct Department 
from Students;

--Syntax: select with Like
--select * from table_name
--where column_name Like pattern;

select * from Students
where Name like 'P%';

--Syntax: select with IN
--select * from table_name
--where column_name IN (value1, value2);

select * from Students
where Department IN ('cse', 'IT');

--Syntax: select with between
--select * from table_name
--where column_name between value1 and value2;

select * from Students
where Age between 20 and 21;


---------DCL Commands---------

--------GRANT-------
--Syntax: Grant Permission on Table 
-- GRANT permission_type
-- ON object_name
-- TO user_name;

GRANT SELECT
ON Students
TO user1;

-- Syntax: Grant Multiple Permissions 
-- GRANT permission1, permission2
-- ON object_name
-- TO user_name;

GRANT INSERT, UPDATE
ON Students
TO user1;

-- Syntax: Grant Permission with GRANT OPTION 
-- GRANT permission_type
-- ON object_name
-- TO user_name
-- WITH GRANT OPTION;

GRANT SELECT
ON Students
TO user1
WITH GRANT OPTION;

--------REVOKE--------
-- Syntax: Revoke Permission 
-- REVOKE permission_type
-- ON object_name
-- FROM user_name;

REVOKE SELECT
ON Students
FROM user1;

-- Syntax: Revoke Multiple Permissions 
-- REVOKE permission1, permission2
-- ON object_name
-- FROM user_name;

REVOKE INSERT, UPDATE
ON Students
FROM user1;


----------TCL Commands---------

------COMMIT------
-- Syntax: Commit Transaction 
-- COMMIT;

BEGIN TRANSACTION;

INSERT INTO Students VALUES (1, 'Rahul', 21, 'CSE');

COMMIT;

--------ROLLBACK--------
-- Syntax: Rollback Transaction 
-- ROLLBACK;

BEGIN TRANSACTION;

UPDATE Students
SET Department = 'IT'
WHERE StudentID = 1;

ROLLBACK;

-------SAVEPOINT------
-- Syntax: Savepointv
-- SAVE TRANSACTION savepoint_name;

BEGIN TRANSACTION;

INSERT INTO Students VALUES (2, 'Anita', 22, 'ECE');

SAVE TRANSACTION SP1;

UPDATE Students
SET Department = 'IT'
WHERE StudentID = 2;

ROLLBACK TRANSACTION SP1;

COMMIT;