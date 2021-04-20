-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2021-04-19 22:44:20.294

-- tables
-- Table: Address
-- Create a new database called 'DatabaseName'
-- Connect to the 'master' database to run this snippet

CREATE TABLE Address (
    CustomerID int  NOT NULL,
    AddressType int  NOT NULL,
    StreetAddress1 varchar(250)  NOT NULL,
    StreetAddress2 varchar(250)  NULL,
    City varchar(100)  NOT NULL,
    Zip varchar(10)  NOT NULL,
    State varchar(2)  NOT NULL,
    CONSTRAINT Address_pk PRIMARY KEY  (CustomerID,AddressType)
);

-- Table: AddressType
CREATE TABLE AddressType (
    AddressType int  NOT NULL,
    AddressDescription varchar(20)  NOT NULL,
    CONSTRAINT AddressType_pk PRIMARY KEY  (AddressType)
);

-- Table: Automobile
CREATE TABLE Automobile (
    AutomobileID int  NOT NULL IDENTITY,
    Vin varchar(17)  NOT NULL,
    Make varchar(128)  NOT NULL,
    Model varchar(128)  NOT NULL,
    Year smallint  NOT NULL,
    CONSTRAINT Automobile_pk PRIMARY KEY  (AutomobileID)
);

-- Table: Customer
CREATE TABLE Customer (
    CustomerID int  NOT NULL IDENTITY,
    FirstName varchar(50)  NOT NULL,
    LastName varchar(50)  NOT NULL,
    CONSTRAINT Customer_pk PRIMARY KEY  (CustomerID)
);

-- Table: Labor
CREATE TABLE Labor (
    LaborID int  NOT NULL IDENTITY,
    WorkOrderID int  NOT NULL,
    LaborDesc text  NOT NULL,
    LaborNotes text  NOT NULL,
    LaborPrice decimal(10,2)  NOT NULL,
    CONSTRAINT Labor_pk PRIMARY KEY  (LaborID)
);

-- Table: Owns
CREATE TABLE Owns (
    CustomerID int  NOT NULL,
    AutomobileID int  NOT NULL,
    CONSTRAINT Owns_pk PRIMARY KEY  (CustomerID,AutomobileID)
);

-- Table: Part
CREATE TABLE Part (
    PartID int  NOT NULL IDENTITY,
    WorkOrderID int  NOT NULL,
    PartPrice decimal(10,2)  NOT NULL,
    PartMargin decimal(10,2)  NOT NULL,
    PartDescription varchar(100)  NOT NULL,
    PartNumber varchar(100)  NULL,
    CONSTRAINT Part_pk PRIMARY KEY  (PartID)
);

-- Table: PhoneNumber
CREATE TABLE PhoneNumber (
    CustomerID int  NOT NULL,
    PhoneType int  NOT NULL,
    PhoneNumber varchar(15)  NOT NULL,
    CONSTRAINT PhoneNumber_pk PRIMARY KEY  (CustomerID,PhoneType)
);

-- Table: PhoneType
CREATE TABLE PhoneType (
    PhoneType int  NOT NULL,
    PhoneDescription varchar(20)  NOT NULL,
    CONSTRAINT PhoneType_pk PRIMARY KEY  (PhoneType)
);

-- Table: WorkOrder
CREATE TABLE WorkOrder (
    WorkOrderID int  NOT NULL IDENTITY,
    CustomerID int  NOT NULL,
    AutomobileID int  NOT NULL,
    Date datetime  NOT NULL,
    Subtotal decimal(10,2)  NOT NULL,
    Tax decimal(10,2)  NOT NULL,
    WorkOrderNotes text  NOT NULL,
    AmountPaid decimal(10,2)  NOT NULL,
    PaidInFull binary(1)  NOT NULL,
    CONSTRAINT WorkOrder_pk PRIMARY KEY  (WorkOrderID)
);

-- foreign keys
-- Reference: Address_AddressType (table: Address)
ALTER TABLE Address ADD CONSTRAINT Address_AddressType
    FOREIGN KEY (AddressType)
    REFERENCES AddressType (AddressType);

-- Reference: Address_Customer (table: Address)
ALTER TABLE Address ADD CONSTRAINT Address_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customer (CustomerID);

-- Reference: Labor_WorkOrder (table: Labor)
ALTER TABLE Labor ADD CONSTRAINT Labor_WorkOrder
    FOREIGN KEY (WorkOrderID)
    REFERENCES WorkOrder (WorkOrderID);

-- Reference: Owns_Automobile (table: Owns)
ALTER TABLE Owns ADD CONSTRAINT Owns_Automobile
    FOREIGN KEY (AutomobileID)
    REFERENCES Automobile (AutomobileID);

-- Reference: Owns_Customer (table: Owns)
ALTER TABLE Owns ADD CONSTRAINT Owns_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customer (CustomerID);

-- Reference: Parts_WorkOrder (table: Part)
ALTER TABLE Part ADD CONSTRAINT Parts_WorkOrder
    FOREIGN KEY (WorkOrderID)
    REFERENCES WorkOrder (WorkOrderID);

-- Reference: PhoneNumber_Customer (table: PhoneNumber)
ALTER TABLE PhoneNumber ADD CONSTRAINT PhoneNumber_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customer (CustomerID);

-- Reference: PhoneNumber_PhoneType (table: PhoneNumber)
ALTER TABLE PhoneNumber ADD CONSTRAINT PhoneNumber_PhoneType
    FOREIGN KEY (PhoneType)
    REFERENCES PhoneType (PhoneType);

-- Reference: WorkOrder_Automobile (table: WorkOrder)
ALTER TABLE WorkOrder ADD CONSTRAINT WorkOrder_Automobile
    FOREIGN KEY (AutomobileID)
    REFERENCES Automobile (AutomobileID);

-- Reference: WorkOrder_Customer (table: WorkOrder)
ALTER TABLE WorkOrder ADD CONSTRAINT WorkOrder_Customer
    FOREIGN KEY (CustomerID)
    REFERENCES Customer (CustomerID);

-- End of file.

