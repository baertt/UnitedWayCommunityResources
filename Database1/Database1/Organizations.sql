CREATE TABLE [dbo].[Organizations]
(
	ID integer NOT NULL CONSTRAINT Organizations_pk PRIMARY KEY,
    Name text NOT NULL,
    Phone integer NULL ,
    Email text NULL,
    Website text NULL,
    Requirements text NULL,
    Appointment BIT
)
