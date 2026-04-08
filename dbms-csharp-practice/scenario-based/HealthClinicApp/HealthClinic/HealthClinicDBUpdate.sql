CREATE DATABASE HealthClinicDB;
GO

USE HealthClinicDB;
GO

-- PATIENTS TABLE
CREATE TABLE Patients(
   patient_id INT IDENTITY(1,1) PRIMARY KEY,
   full_name VARCHAR(100) NOT NULL,
   dob DATE NOT NULL,
   phone VARCHAR(15) UNIQUE NOT NULL,
   email VARCHAR(100) UNIQUE,
   address VARCHAR(100) ,
   blood_group VARCHAR(5),
   created_at DATETIME DEFAULT GETDATE()
);
GO
select * from Patients;
go
-- SPECIALTIES TABLE
CREATE TABLE Specialties(
   specialty_id INT IDENTITY(1,1) PRIMARY KEY,
   specialty_name VARCHAR(100) NOT NULL UNIQUE,
   is_active BIT DEFAULT 1
);
GO

SELECT * FROM Specialties;
GO

INSERT INTO Specialties (specialty_name)
VALUES ('MBBS'), ('Cardiologist'), ('Dermatologist');
GO

-- DOCTORS TABLE
CREATE TABLE Doctors(
   doctor_id INT IDENTITY(1,1) PRIMARY KEY,
   full_name VARCHAR(100) NOT NULL,
   specialty_id INT NOT NULL,
   contact VARCHAR(15),
   consultation_fee DECIMAL(10,2),
   is_active BIT DEFAULT 1,
   FOREIGN KEY (specialty_id) REFERENCES Specialties(specialty_id)
);
GO

-- APPOINTMENTS TABLE
CREATE TABLE Appointments(
   appointment_id INT IDENTITY(1,1) PRIMARY KEY,
   patient_id INT,
   doctor_id INT,
   appointment_date DATE,
   appointment_time TIME,
   status VARCHAR(20) CHECK (status IN('SCHEDULED','CANCELLED','COMPLETED')),
   created_at DATETIME DEFAULT GETDATE(),
   FOREIGN KEY(patient_id) REFERENCES Patients(patient_id),
   FOREIGN KEY(doctor_id) REFERENCES Doctors(doctor_id)
);
GO


CREATE TABLE Appointment_Audit (
    audit_id INT IDENTITY PRIMARY KEY,
    appointment_id INT,
    action VARCHAR(20),
    action_time DATETIME DEFAULT GETDATE()
);

-- VISIT TABLE
CREATE TABLE Visits (
   visit_id INT IDENTITY(1,1) PRIMARY KEY,
   appointment_id INT UNIQUE,
   diagnosis VARCHAR(255),
   prescription VARCHAR(500),
   notes VARCHAR(500),
   visit_date DATETIME DEFAULT GETDATE(),
   FOREIGN KEY (appointment_id) REFERENCES Appointments(appointment_id)
);
GO

-- PRESCRIPTIONS TABLE
CREATE TABLE Prescriptions(
   prescription_id INT IDENTITY(1,1) PRIMARY KEY,
   visit_id INT,
   medicine_name VARCHAR(100),
   dosage VARCHAR(50),
   duration VARCHAR(50),
   FOREIGN KEY (visit_id) REFERENCES Visits(visit_id)
);
GO

-- BILLING TABLE
CREATE TABLE Bills(
   bill_id INT IDENTITY(1,1) PRIMARY KEY,
   visit_id INT UNIQUE,
   total_amount DECIMAL(10,2),
   payment_status VARCHAR(20) CHECK (payment_status IN('PAID','UNPAID')),
   created_at DATETIME DEFAULT GETDATE(),
   FOREIGN KEY(visit_id) REFERENCES Visits(visit_id)
);
GO

-- PAYMENT TRANSACTIONS
CREATE TABLE Payment_Transactions (
    transaction_id INT IDENTITY(1,1) PRIMARY KEY,
    bill_id INT,
    payment_mode VARCHAR(50),
    payment_date DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (bill_id) REFERENCES Bills(bill_id)
);
GO

-- INDEXES
CREATE INDEX idx_patient_phone ON Patients(phone);
CREATE INDEX idx_appointment_date ON Appointments(appointment_date);
GO


-------STORED PROCEDURES--------
-- UC-1.1 Register New Patient
CREATE PROCEDURE SPRegister_Patient
    @name VARCHAR(100),
    @dob DATE,
    @phone VARCHAR(15),
    @email VARCHAR(100),
    @address VARCHAR(200),
    @blood_group VARCHAR(5)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Patients WHERE phone=@phone OR email=@email)
    BEGIN
        RAISERROR('Patient already exists',16,1);
        RETURN;
    END

    INSERT INTO Patients(full_name, dob, phone, email, address, blood_group)
    VALUES(@name, @dob, @phone, @email, @address, @blood_group);
END;
GO

-- UC-1.2: Update Patient Information
CREATE PROCEDURE SPUpdate_Patient
    @patient_id INT,
    @address VARCHAR(255),
    @blood_group VARCHAR(5)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Patients WHERE patient_id = @patient_id)
    BEGIN
        RAISERROR('Patient not found',16,1);
        RETURN;
    END

    UPDATE Patients
    SET address = @address,
        blood_group = @blood_group
    WHERE patient_id = @patient_id;
END;
GO

--UC- 1.4 : Get Patient Visit History
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
    INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
    LEFT JOIN Visits v ON a.appointment_id = v.appointment_id
    WHERE a.patient_id = @patient_id
    ORDER BY a.appointment_date ASC
END;
GO

--- UC-2.1: Add Doctor Profile
CREATE PROCEDURE SPAdd_Doctor
    @name VARCHAR(100),
    @specialty_id INT,
    @contact VARCHAR(15),
    @fee DECIMAL(10,2)
AS
BEGIN
    -- Validate specialty
    IF NOT EXISTS (SELECT 1 FROM Specialties WHERE specialty_id = @specialty_id)
    BEGIN
        RAISERROR('Invalid specialty selected',16,1);
        RETURN;
    END

    INSERT INTO Doctors (full_name, specialty_id, contact, consultation_fee)
    VALUES (@name, @specialty_id, @contact, @fee);
END;
GO

-- UC-2.2 Update Doctor Specialty
CREATE PROCEDURE SPUpdate_Doctor_Specialty
    @doctor_id INT,
    @new_specialty_id INT
AS
BEGIN
    BEGIN TRANSACTION;

    IF NOT EXISTS (SELECT 1 FROM Doctors WHERE doctor_id = @doctor_id)
    BEGIN
        ROLLBACK;
        RAISERROR('Doctor not found',16,1);
        RETURN;
    END

    IF NOT EXISTS (SELECT 1 FROM Specialties WHERE specialty_id = @new_specialty_id)
    BEGIN
        ROLLBACK;
        RAISERROR('Invalid specialty',16,1);
        RETURN;
    END

    UPDATE Doctors
    SET specialty_id = @new_specialty_id
    WHERE doctor_id = @doctor_id;

    COMMIT;
END;
GO

-- UC- 2.3: Get doctor by Speciality
CREATE PROCEDURE SPGet_Doctors_By_Specialty
    @specialty_name VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        d.doctor_id,
        d.full_name,
        d.contact,
        d.consultation_fee,
        d.is_active
    FROM Doctors d
    INNER JOIN Specialties s 
        ON d.specialty_id = s.specialty_id
    WHERE s.specialty_name = @specialty_name
      AND d.is_active = 1
END;
GO


--- UC-2.4: Deactivate Doctor Profile
CREATE PROCEDURE SPDeactivate_Doctor
    @doctor_id INT
AS
BEGIN
    -- Check future appointments
    IF EXISTS (
        SELECT 1 FROM Appointments
        WHERE doctor_id = @doctor_id
        AND appointment_date > CAST(GETDATE() AS DATE)
        AND status = 'SCHEDULED'
    )
    BEGIN
        RAISERROR('Doctor has future appointments. Cannot deactivate.',16,1);
        RETURN;
    END

    UPDATE Doctors
    SET is_active = 0
    WHERE doctor_id = @doctor_id;
END;
GO


--UC-3.1: Book New Appointment
CREATE OR ALTER PROCEDURE SPBook_Appointment
    @patient_id INT,
    @doctor_id INT,
    @appointment_date DATE,
    @appointment_time TIME
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY

        -- Check doctor active
        IF NOT EXISTS (
            SELECT 1 FROM Doctors
            WHERE doctor_id = @doctor_id
              AND is_active = 1
        )
        BEGIN
            RAISERROR('Doctor is not active',16,1);
            ROLLBACK;
            RETURN;
        END

        -- Check slot capacity (max 5 per time slot)
        IF (
            SELECT COUNT(*)
            FROM Appointments
            WHERE doctor_id = @doctor_id
              AND appointment_date = @appointment_date
              AND appointment_time = @appointment_time
              AND status = 'SCHEDULED'
        ) >= 5
        BEGIN
            RAISERROR('Slot is fully booked',16,1);
            ROLLBACK;
            RETURN;
        END

        INSERT INTO Appointments
        (patient_id, doctor_id, appointment_date, appointment_time, status)
        VALUES
        (@patient_id, @doctor_id, @appointment_date, @appointment_time, 'SCHEDULED');

        COMMIT;

    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO

--UC - 3.2: Check doctor Availability
CREATE OR ALTER PROCEDURE SPCheck_Doctor_Availability
    @doctor_id INT,
    @appointment_date DATE
AS
BEGIN
    SELECT 
        appointment_time,
        COUNT(*) AS booked_count
    FROM Appointments
    WHERE doctor_id = @doctor_id
      AND appointment_date = @appointment_date
      AND status = 'SCHEDULED'
    GROUP BY appointment_time
    ORDER BY appointment_time
END
GO

-- UC-3.3: Cancel Appointment
CREATE OR ALTER PROCEDURE SPCancel_Appointment
    @appointment_id INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY

        UPDATE Appointments
        SET status = 'CANCELLED'
        WHERE appointment_id = @appointment_id;

        INSERT INTO Appointment_Audit
        (appointment_id, action)
        VALUES
        (@appointment_id, 'CANCELLED');

        COMMIT;

    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO

-- UC-3.4: Reschedule Appointment
CREATE OR ALTER PROCEDURE SPReschedule_Appointment
    @appointment_id INT,
    @new_date DATE,
    @new_time TIME,
    @new_doctor_id INT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY

        -- Check availability
        IF (
            SELECT COUNT(*)
            FROM Appointments
            WHERE doctor_id = @new_doctor_id
              AND appointment_date = @new_date
              AND appointment_time = @new_time
              AND status = 'SCHEDULED'
        ) >= 5
        BEGIN
            RAISERROR('New slot not available',16,1);
            ROLLBACK;
            RETURN;
        END

        UPDATE Appointments
        SET doctor_id = @new_doctor_id,
            appointment_date = @new_date,
            appointment_time = @new_time
        WHERE appointment_id = @appointment_id;

        -- Audit entry
        INSERT INTO Appointment_Audit
        (appointment_id, action)
        VALUES
        (@appointment_id, 'RESCHEDULED');

        COMMIT;

    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO

--UC-3.5: get daily schedule
CREATE OR ALTER PROCEDURE SPGet_Daily_Schedule
    @appointment_date DATE
AS
BEGIN
    SELECT 
        a.appointment_id,
        a.appointment_time,
        p.full_name AS patient_name,
        d.full_name AS doctor_name,
        a.status
    FROM Appointments a
    INNER JOIN Patients p ON a.patient_id = p.patient_id
    INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
    WHERE a.appointment_date = @appointment_date
    ORDER BY a.appointment_time
END
GO

-- UC- 4.1: Record Visit
CREATE OR ALTER PROCEDURE SPRecord_Visit
    @appointment_id INT,
    @diagnosis VARCHAR(255),
    @prescription VARCHAR(500),
    @notes VARCHAR(500),
    @visit_id INT OUTPUT
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY

        -- Prevent duplicate visit (because appointment_id is UNIQUE)
        IF EXISTS (
            SELECT 1 FROM Visits 
            WHERE appointment_id = @appointment_id
        )
        BEGIN
            RAISERROR('Visit already recorded for this appointment',16,1);
            ROLLBACK;
            RETURN;
        END

        INSERT INTO Visits
        (appointment_id, diagnosis, prescription, notes)
        VALUES
        (@appointment_id, @diagnosis, @prescription, @notes);

        SET @visit_id = SCOPE_IDENTITY();

        UPDATE Appointments
        SET status = 'COMPLETED'
        WHERE appointment_id = @appointment_id;

        COMMIT;

    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO

--UC-4.2: View Patient medical history
CREATE OR ALTER PROCEDURE SPGet_Patient_Medical_History
    @patient_id INT
AS
BEGIN
    SELECT 
        v.visit_id,
        v.visit_date,
        v.diagnosis,
        v.prescription,
        v.notes,
        p.medicine_name,
        p.dosage,
        p.duration
    FROM Visits v
    INNER JOIN Appointments a ON v.appointment_id = a.appointment_id
    LEFT JOIN Prescriptions p ON v.visit_id = p.visit_id
    WHERE a.patient_id = @patient_id
    ORDER BY v.visit_date DESC
END
GO

--UC- 4.3: Add prescriptions
CREATE OR ALTER PROCEDURE SPAdd_Prescriptions
    @visit_id INT,
    @medicine_name VARCHAR(100),
    @dosage VARCHAR(50),
    @duration VARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Validate visit exists
    IF NOT EXISTS (
        SELECT 1 FROM Visits WHERE visit_id = @visit_id
    )
    BEGIN
        RAISERROR('Invalid visit ID',16,1);
        RETURN;
    END

    INSERT INTO Prescriptions
    (visit_id, medicine_name, dosage, duration)
    VALUES
    (@visit_id, @medicine_name, @dosage, @duration)
END
GO

-- UC-5.1: Generate Bill for Visit
CREATE OR ALTER PROCEDURE SPGenerate_Bill
    @visit_id INT,
    @additional_charges DECIMAL(10,2)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;

    BEGIN TRY

        -- Prevent duplicate bill
        IF EXISTS (SELECT 1 FROM Bills WHERE visit_id = @visit_id)
        BEGIN
            RAISERROR('Bill already generated for this visit',16,1);
            ROLLBACK;
            RETURN;
        END

        DECLARE @consultation_fee DECIMAL(10,2);

        SELECT @consultation_fee = d.consultation_fee
        FROM Visits v
        INNER JOIN Appointments a ON v.appointment_id = a.appointment_id
        INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
        WHERE v.visit_id = @visit_id;

        DECLARE @total DECIMAL(10,2);
        SET @total = ISNULL(@consultation_fee,0) + ISNULL(@additional_charges,0);

        INSERT INTO Bills(visit_id, total_amount, payment_status)
        VALUES(@visit_id, @total, 'UNPAID');

        COMMIT;

    END TRY
    BEGIN CATCH
        ROLLBACK;
        THROW;
    END CATCH
END
GO

-- UC-5.2: Record Payment
CREATE PROCEDURE SPRecord_Payment
    @bill_id INT,
    @payment_mode VARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION;

    IF NOT EXISTS (SELECT 1 FROM Bills WHERE bill_id = @bill_id)
    BEGIN
        ROLLBACK;
        RAISERROR('Bill not found',16,1);
        RETURN;
    END

    UPDATE Bills
    SET payment_status = 'PAID'
    WHERE bill_id = @bill_id;

    INSERT INTO Payment_Transactions (bill_id, payment_mode)
    VALUES (@bill_id, @payment_mode);

    COMMIT;
END;
GO

--UC- 5.3 : view outstanding bills
CREATE OR ALTER PROCEDURE SPGet_Outstanding_Bills
AS
BEGIN
    SELECT 
        p.patient_id,
        p.full_name,
        COUNT(b.bill_id) AS total_unpaid_bills,
        SUM(b.total_amount) AS total_due
    FROM Bills b
    INNER JOIN Visits v ON b.visit_id = v.visit_id
    INNER JOIN Appointments a ON v.appointment_id = a.appointment_id
    INNER JOIN Patients p ON a.patient_id = p.patient_id
    WHERE b.payment_status = 'UNPAID'
    GROUP BY p.patient_id, p.full_name
END
GO

--UC- 5.4 : Revenue Report
CREATE OR ALTER PROCEDURE SPRevenue_Report
    @start_date DATE,
    @end_date DATE
AS
BEGIN
    SELECT 
        d.full_name AS doctor_name,
        SUM(b.total_amount) AS total_revenue
    FROM Bills b
    INNER JOIN Visits v ON b.visit_id = v.visit_id
    INNER JOIN Appointments a ON v.appointment_id = a.appointment_id
    INNER JOIN Doctors d ON a.doctor_id = d.doctor_id
    WHERE b.created_at BETWEEN @start_date AND @end_date
      AND b.payment_status = 'PAID'
    GROUP BY d.full_name
    HAVING SUM(b.total_amount) > 0
END
GO

--UC-6.1 Manage Specialty Lookup
-- Add Speciality
CREATE OR ALTER PROCEDURE SPAdd_Specialty
    @specialty_name VARCHAR(100)
AS
BEGIN
    INSERT INTO Specialties(specialty_name)
    VALUES(@specialty_name)
END
GO

--Update Specialty
CREATE OR ALTER PROCEDURE SPUpdate_Specialty
    @specialty_id INT,
    @specialty_name VARCHAR(100)
AS
BEGIN
    UPDATE Specialties
    SET specialty_name = @specialty_name
    WHERE specialty_id = @specialty_id
END
GO

--Delete Specialty
CREATE OR ALTER PROCEDURE SPDelete_Specialty
    @specialty_id INT
AS
BEGIN
    IF EXISTS (
        SELECT 1 FROM Doctors
        WHERE specialty_id = @specialty_id
    )
    BEGIN
        RAISERROR('Cannot delete specialty. Doctors are assigned.',16,1)
        RETURN
    END

    DELETE FROM Specialties
    WHERE specialty_id = @specialty_id
END
GO

--View All Specialties
CREATE OR ALTER PROCEDURE SPGet_All_Specialties
AS
BEGIN
    SELECT * FROM Specialties
END
GO

-- UC-6.2 Database Backup
-- backup procedure
CREATE PROCEDURE SPBackup_Database
AS
BEGIN
    BACKUP DATABASE HealthClinicDB
    TO DISK = 'D:\HealthClinic_Backup.bak'
    WITH FORMAT, INIT;
END
GO

--UC-6.3 View System Audit Logs
-- View Audit Logs
CREATE OR ALTER PROCEDURE SPGet_Audit_Logs
    @table_name VARCHAR(50) = NULL,
    @operation VARCHAR(10) = NULL
AS
BEGIN
    SELECT *
    FROM Audit_Log
    WHERE (@table_name IS NULL OR table_name = @table_name)
      AND (@operation IS NULL OR operation = @operation)
    ORDER BY changed_at DESC
END
GO

-- AUDIT LOG TABLE
CREATE TABLE Audit_Log(
   audit_id INT IDENTITY(1,1) PRIMARY KEY,
   table_name VARCHAR(50),
   operation VARCHAR(10),
   record_id INT,
   changed_at DATETIME DEFAULT GETDATE()
);
GO

--- TRIGGERS FOR AUDIT LOGGING---
-- PATIENT AUDIT TRIGGER
CREATE TRIGGER trg_Patients_Audit
ON Patients
AFTER INSERT, UPDATE, DELETE
AS
BEGIN  
   IF EXISTS(SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
   BEGIN
      INSERT INTO Audit_Log(table_name, operation, record_id)
      SELECT 'Patients','INSERT', patient_id FROM inserted;
   END

   IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
   BEGIN
      INSERT INTO Audit_Log(table_name, operation, record_id)
      SELECT 'Patients', 'UPDATE', patient_id FROM inserted;
   END

   IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Patients', 'DELETE', patient_id FROM deleted;
    END
END;
GO

--DOCTOR AUDIT TRIGGER
CREATE TRIGGER trg_Doctors_Audit
ON Doctors
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Doctors', 'INSERT', doctor_id FROM inserted;
    END

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Doctors', 'UPDATE', doctor_id FROM inserted;
    END

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Doctors', 'DELETE', doctor_id FROM deleted;
    END
END;
GO


--- APPOINTMENTS AUDIT TRIGGER
CREATE TRIGGER trg_Appointments_Audit
ON Appointments
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Appointments', 'INSERT', appointment_id FROM inserted;
    END

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Appointments', 'UPDATE', appointment_id FROM inserted;
    END

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Appointments', 'DELETE', appointment_id FROM deleted;
    END
END;
GO

-- VISITS AUDIT TRIGGER

CREATE TRIGGER trg_Visits_Audit
ON Visits
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Visits', 'INSERT', visit_id FROM inserted;
    END

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Visits', 'UPDATE', visit_id FROM inserted;
    END

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
    BEGIN
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Visits', 'DELETE', visit_id FROM deleted;
    END
END;
GO

-- PRESCRIPTIONS AUDIT TRIGGER
CREATE TRIGGER trg_Prescriptions_Audit
ON Prescriptions
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Prescriptions', 'INSERT', prescription_id FROM inserted;

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Prescriptions', 'UPDATE', prescription_id FROM inserted;

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Prescriptions', 'DELETE', prescription_id FROM deleted;
END;
GO

--- BILLS AUDIT TRIGGER
CREATE TRIGGER trg_Bills_Audit
ON Bills
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Bills', 'INSERT', bill_id FROM inserted;

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Bills', 'UPDATE', bill_id FROM inserted;

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Bills', 'DELETE', bill_id FROM deleted;
END;
GO

-- PAYMENT TRANSACTIONS AUDIT TRIGGER
CREATE TRIGGER trg_PaymentTransactions_Audit
ON Payment_Transactions
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted) AND NOT EXISTS (SELECT 1 FROM deleted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Payment_Transactions', 'INSERT', transaction_id FROM inserted;

    IF EXISTS (SELECT 1 FROM inserted) AND EXISTS (SELECT 1 FROM deleted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Payment_Transactions', 'UPDATE', transaction_id FROM inserted;

    IF EXISTS (SELECT 1 FROM deleted) AND NOT EXISTS (SELECT 1 FROM inserted)
        INSERT INTO Audit_Log(table_name, operation, record_id)
        SELECT 'Payment_Transactions', 'DELETE', transaction_id FROM deleted;
END;
GO