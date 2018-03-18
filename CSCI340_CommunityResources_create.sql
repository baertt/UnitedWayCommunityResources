-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2018-03-18 20:29:32.469

-- tables
-- Table: Availability
CREATE TABLE Availability (
    Organizations_ID integer NOT NULL,
    ID integer NOT NULL CONSTRAINT Availability_pk PRIMARY KEY,
    Weekday text,
    Repeat tinyint DEFAULT 0,
    Start_Time datetime,
    End_Time datetime,
    CONSTRAINT Table_4_Organizations FOREIGN KEY (Organizations_ID)
    REFERENCES Organizations (ID)
);

-- Table: Location
CREATE TABLE Location (
    ID integer NOT NULL CONSTRAINT Location_pk PRIMARY KEY,
    Street_Address text,
    City text,
    Zip_Code integer NOT NULL,
    Organizations_ID integer NOT NULL,
    CONSTRAINT Location_Organizations FOREIGN KEY (Organizations_ID)
    REFERENCES Organizations (ID)
);

-- Table: Organizations
CREATE TABLE Organizations (
    ID integer NOT NULL CONSTRAINT Organizations_pk PRIMARY KEY,
    Name text,
    Phone integer NOT NULL,
    Email text NOT NULL,
    Website text NOT NULL,
    Requirements text NOT NULL,
    Appointment boolean
);

-- Table: Resources
CREATE TABLE Resources (
    Clothing boolean,
    Education boolean,
    Employment boolean,
    Finances boolean,
    Food boolean,
    Housing boolean,
    Natural_Disaster boolean,
    Senior boolean,
    Utilities_Rent boolean,
    Medicatl_Prescription boolean,
    Veterans boolean,
    Other text NOT NULL,
    Organizations_ID integer NOT NULL,
    ID integer NOT NULL CONSTRAINT Resources_pk PRIMARY KEY,
    CONSTRAINT Resources_Organizations FOREIGN KEY (Organizations_ID)
    REFERENCES Organizations (ID)
);

-- End of file.

