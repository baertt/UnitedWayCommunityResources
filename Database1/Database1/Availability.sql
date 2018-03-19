CREATE TABLE [dbo].[Availability]
(
	Organizations_ID integer NOT NULL,
    ID integer NOT NULL CONSTRAINT Availability_pk PRIMARY KEY,
    Weekday text NOT NULL,
    Repeat tinyint DEFAULT 0 NOT NULL,
    Start_Time datetime NOT NULL,
    End_Time datetime NOT NULL,
    CONSTRAINT Table_4_Organizations FOREIGN KEY (Organizations_ID)
    REFERENCES Organizations (ID)
)
