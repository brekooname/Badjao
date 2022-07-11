CREATE TABLE Holidays
(
	HolidaysId INTEGER NOT NULL UNIQUE IDENTITY(1,1),
	ColumbusDay DATETIME NULL,
	ThanksgivingDay DATETIME NULL,
	ChristmasDay DATETIME NULL,
	NewYearsDay DATETIME NULL,
	MartinLutherKingDay DATETIME NULL,
	PresidentsDay DATETIME NULL,
	MemorialDay DATETIME NULL,
	VeteransDay DATETIME NULL,
	LaborDay DATETIME NULL,
        CONSTRAINT PK_Holidays
        PRIMARY KEY (HolidaysId) 
);

