CREATE TABLE [dbo].[Resources]
(
	 Clothing BIT NOT NULL,
    Education BIT NOT NULL,
    Employment BIT NOT NULL,
    Finances BIT NOT NULL,
    Food BIT NOT NULL,
    Housing BIT NOT NULL,
    Natural_Disaster BIT NOT NULL,
    Senior BIT NOT NULL,
    Utilities_Rent BIT NOT NULL,
    Medicatl_Prescription BIT NOT NULL,
    Veterans BIT NOT NULL,
    Other text NOT NULL,
    Organizations_ID integer NOT NULL,
    ID integer NOT NULL CONSTRAINT Resources_pk PRIMARY KEY,
    CONSTRAINT Resources_Organizations FOREIGN KEY (ID)
    REFERENCES Organizations (ID)
)
