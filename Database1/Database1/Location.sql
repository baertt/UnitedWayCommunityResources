CREATE TABLE [dbo].[Location]
(
	ID integer NOT NULL CONSTRAINT Location_pk PRIMARY KEY,
    Street_Address text NOT NULL,
    City text NOT NULL,
    Zip_Code integer NULL,
    Organizations_ID integer NOT NULL,
    CONSTRAINT Location_Organizations FOREIGN KEY (Organizations_ID)
    REFERENCES Organizations (ID)
)
