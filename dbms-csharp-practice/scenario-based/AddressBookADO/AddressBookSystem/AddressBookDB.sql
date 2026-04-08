CREATE DATABASE AddressBookDB;
GO 

USE AddressBookDB;

--CREATE TABLE CONTACTS
CREATE TABLE Contacts
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    Address NVARCHAR(200),
    City NVARCHAR(100),
    State NVARCHAR(100),
    Zip NVARCHAR(20),
    PhoneNumber NVARCHAR(20),
    Email NVARCHAR(100)
);
GO

--STORED PROCEDURE TO ADD CONTACT
CREATE PROCEDURE SPInsert_Contact
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100),
    @Address NVARCHAR(200),
    @City NVARCHAR(100),
    @State NVARCHAR(100),
    @Zip NVARCHAR(20),
    @PhoneNumber NVARCHAR(20),
    @Email NVARCHAR(100)
AS
BEGIN
    INSERT INTO Contacts
    (FirstName, LastName, Address, City, State, Zip, PhoneNumber, Email)
    VALUES
    (@FirstName, @LastName, @Address, @City, @State, @Zip, @PhoneNumber, @Email)
END
GO

--STORED PROCEDURE TO DELETE CONTACT
CREATE PROCEDURE SPDelete_Contact
    @FirstName NVARCHAR(100),
    @LastName NVARCHAR(100)
AS
BEGIN
    DELETE FROM Contacts
    WHERE FirstName = @FirstName
      AND LastName = @LastName
END
GO

-- PROCEDURE TO GET ALL CONTACTS
CREATE PROCEDURE SPGet_All_Contacts
AS
BEGIN
    SELECT * FROM Contacts
END
GO

--PROCEDURE TO GET ALL PATIENTS HISTOY
CREATE PROCEDURE SPGet_Patient_Visit_History
    @patient_id INT
AS
BEGIN

    SELECT 
        a.appointment_id,
        a.appointment_date,
        d.full_name AS doctor_name,
        v.diagnosis,
        v.visit_notes
    FROM Appointments a
    INNER JOIN Doctors d 
        ON a.doctor_id = d.doctor_id
    LEFT JOIN Visits v 
        ON a.appointment_id = v.appointment_id
    WHERE a.patient_id = @patient_id
    ORDER BY a.appointment_date ASC;
END;
GO

--AUDIT CONTACT TABLE
CREATE TABLE ContactAudit
(
    AuditId INT IDENTITY(1,1) PRIMARY KEY,
    ContactId INT,
    FirstName NVARCHAR(100),
    LastName NVARCHAR(100),
    ActionType NVARCHAR(20),
    ActionDate DATETIME DEFAULT GETDATE()
);
GO

--TRIGGER FOR INSERT CONTACT
CREATE TRIGGER trg_Contact_Insert
ON Contacts
AFTER INSERT
AS
BEGIN
    INSERT INTO ContactAudit
    (ContactId, FirstName, LastName, ActionType)
    SELECT 
        Id,
        FirstName,
        LastName,
        'INSERT'
    FROM inserted;
END;
GO

--TRIGGER FOR UPDATE CONTACT
CREATE TRIGGER trg_Contact_Update
ON Contacts
AFTER UPDATE
AS
BEGIN
    INSERT INTO ContactAudit
    (ContactId, FirstName, LastName, ActionType)
    SELECT 
        Id,
        FirstName,
        LastName,
        'UPDATE'
    FROM inserted;
END;
GO

--TRIGGER FOR DELETE CONTACT
CREATE TRIGGER trg_Contact_Delete
ON Contacts
AFTER DELETE
AS
BEGIN
    INSERT INTO ContactAudit
    (ContactId, FirstName, LastName, ActionType)
    SELECT 
        Id,
        FirstName,
        LastName,
        'DELETE'
    FROM deleted;
END;
GO