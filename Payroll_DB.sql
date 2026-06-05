/*=========================================================
    HR & Payroll Management System
    FINAL DATABASE SCRIPT
=========================================================*/

CREATE DATABASE HRPayrollDB;
GO

USE HRPayrollDB;
GO

/*=========================================================
    DEPARTMENTS
=========================================================*/

CREATE TABLE Departments
(
    DepartmentID INT IDENTITY(1,1) PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL,
    Description VARCHAR(255)
);
GO

/*=========================================================
    DESIGNATIONS
=========================================================*/

CREATE TABLE Designations
(
    DesignationID INT IDENTITY(1,1) PRIMARY KEY,
    DesignationName VARCHAR(100) NOT NULL,
    DepartmentID INT NOT NULL,

    CONSTRAINT FK_Designation_Department
    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID)
);
GO

/*=========================================================
    EMPLOYEES
=========================================================*/

CREATE TABLE Employees
(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,

    FullName VARCHAR(150) NOT NULL,

    DateOfBirth DATE NOT NULL,

    Gender VARCHAR(10),

    NIC VARCHAR(20) UNIQUE,

    Phone VARCHAR(20),

    Email VARCHAR(100) UNIQUE,

    Address VARCHAR(255),

    DepartmentID INT NOT NULL,

    DesignationID INT NOT NULL,

    JoiningDate DATE NOT NULL,

    EmploymentType VARCHAR(20),

    BasicSalary DECIMAL(18,2) NOT NULL,

    Status VARCHAR(20) DEFAULT 'Active',

    CONSTRAINT FK_Employee_Department
    FOREIGN KEY (DepartmentID)
    REFERENCES Departments(DepartmentID),

    CONSTRAINT FK_Employee_Designation
    FOREIGN KEY (DesignationID)
    REFERENCES Designations(DesignationID)
);
GO

/*=========================================================
    USERS
=========================================================*/

CREATE TABLE Users
(
    UserID INT IDENTITY(1,1) PRIMARY KEY,

    EmployeeID INT UNIQUE NULL,

    Username VARCHAR(50) UNIQUE NOT NULL,

    PasswordHash VARCHAR(255) NOT NULL,

    Role VARCHAR(20) NOT NULL,

    CONSTRAINT CK_User_Role
    CHECK (Role IN ('Admin','Employee')),

    CONSTRAINT FK_User_Employee
    FOREIGN KEY (EmployeeID)
    REFERENCES Employees(EmployeeID)
);
GO

/*=========================================================
    ATTENDANCE
=========================================================*/

CREATE TABLE Attendance
(
    AttendanceID INT IDENTITY(1,1) PRIMARY KEY,

    EmployeeID INT NOT NULL,

    AttendanceDate DATE NOT NULL,

    CheckIn TIME NULL,

    CheckOut TIME NULL,

    TotalHours DECIMAL(5,2) NULL,

    Status VARCHAR(20),

    CONSTRAINT FK_Attendance_Employee
    FOREIGN KEY (EmployeeID)
    REFERENCES Employees(EmployeeID),

    CONSTRAINT UQ_Attendance
    UNIQUE(EmployeeID, AttendanceDate)
);
GO

/*=========================================================
    LEAVE BALANCES
=========================================================*/

CREATE TABLE LeaveBalances
(
    BalanceID INT IDENTITY(1,1) PRIMARY KEY,

    EmployeeID INT NOT NULL UNIQUE,

    AnnualLeave INT DEFAULT 14,

    CasualLeave INT DEFAULT 7,

    MedicalLeave INT DEFAULT 7,

    CONSTRAINT FK_LeaveBalance_Employee
    FOREIGN KEY (EmployeeID)
    REFERENCES Employees(EmployeeID)
);
GO

/*=========================================================
    LEAVE REQUESTS
=========================================================*/

CREATE TABLE LeaveRequests
(
    LeaveID INT IDENTITY(1,1) PRIMARY KEY,

    EmployeeID INT NOT NULL,

    LeaveType VARCHAR(30) NOT NULL,

    FromDate DATE NOT NULL,

    ToDate DATE NOT NULL,

    NumberOfDays INT NOT NULL,

    Reason VARCHAR(500),

    Status VARCHAR(20) DEFAULT 'Pending',

    ApprovedBy INT NULL,

    ApprovalDate DATE NULL,

    Comments VARCHAR(500),

    CONSTRAINT FK_LeaveRequest_Employee
    FOREIGN KEY (EmployeeID)
    REFERENCES Employees(EmployeeID),

    CONSTRAINT FK_LeaveRequest_ApprovedBy
    FOREIGN KEY (ApprovedBy)
    REFERENCES Users(UserID)
);
GO

/*=========================================================
    PAYROLL
=========================================================*/

CREATE TABLE Payroll
(
    PayrollID INT IDENTITY(1,1) PRIMARY KEY,

    EmployeeID INT NOT NULL,

    PayrollMonth INT NOT NULL,

    PayrollYear INT NOT NULL,

    WorkingDays INT DEFAULT 0,

    PresentDays INT DEFAULT 0,

    AbsentDays INT DEFAULT 0,

    BasicSalary DECIMAL(18,2) DEFAULT 0,

    Allowance DECIMAL(18,2) DEFAULT 0,

    OTAmount DECIMAL(18,2) DEFAULT 0,

    EPF DECIMAL(18,2) DEFAULT 0,

    ETF DECIMAL(18,2) DEFAULT 0,

    TaxAmount DECIMAL(18,2) DEFAULT 0,

    OtherDeductions DECIMAL(18,2) DEFAULT 0,

    NetSalary DECIMAL(18,2) DEFAULT 0,

    PayrollStatus VARCHAR(20) DEFAULT 'Pending',

    GeneratedDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Payroll_Employee
    FOREIGN KEY (EmployeeID)
    REFERENCES Employees(EmployeeID),

    CONSTRAINT UQ_Payroll
    UNIQUE(EmployeeID, PayrollMonth, PayrollYear)
);
GO

/*=========================================================
    SEED DEPARTMENTS
=========================================================*/

INSERT INTO Departments
(
    DepartmentName,
    Description
)
VALUES
('IT','Information Technology'),
('HR','Human Resource Department'),
('Finance','Finance Department'),
('Engineering','Engineering Department');
GO

/*=========================================================
    SEED DESIGNATIONS
=========================================================*/

INSERT INTO Designations
(
    DesignationName,
    DepartmentID
)
VALUES
('System Analyst',1),
('Software Developer',1),
('HR Executive',2),
('Accountant',3),
('Engineer',4);
GO

/*=========================================================
    DEFAULT ADMIN ACCOUNT
=========================================================*/

INSERT INTO Users
(
    EmployeeID,
    Username,
    PasswordHash,
    Role
)
VALUES
(
    NULL,
    'admin',
    'admin123',
    'Admin'
);
GO

/*=========================================================
    SAMPLE EMPLOYEE
=========================================================*/

INSERT INTO Employees
(
    FullName,
    DateOfBirth,
    Gender,
    NIC,
    Phone,
    Email,
    Address,
    DepartmentID,
    DesignationID,
    JoiningDate,
    EmploymentType,
    BasicSalary,
    Status
)
VALUES
(
    'John Doe',
    '1998-05-10',
    'Male',
    '981231234V',
    '0771234567',
    'john@example.com',
    'Colombo',
    1,
    2,
    GETDATE(),
    'Permanent',
    75000,
    'Active'
);
GO

/*=========================================================
    SAMPLE EMPLOYEE LOGIN
=========================================================*/

INSERT INTO Users
(
    EmployeeID,
    Username,
    PasswordHash,
    Role
)
VALUES
(
    1,
    'john',
    '123',
    'Employee'
);
GO

/*=========================================================
    SAMPLE LEAVE BALANCE
=========================================================*/

INSERT INTO LeaveBalances
(
    EmployeeID,
    AnnualLeave,
    CasualLeave,
    MedicalLeave
)
VALUES
(
    1,
    14,
    7,
    7
);
GO