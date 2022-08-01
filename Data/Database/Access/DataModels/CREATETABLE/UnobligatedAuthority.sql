CREATE TABLE IF NOT EXISTS "UnobligatedAuthority" 
(
	"UnobligatedAuthorityId"	INTEGER NOT NULL UNIQUE,
	"BudgetYear"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyTitle"	TEXT(80) NULL DEFAULT 'NS',
	"BureauTitle"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccount"	TEXT(80) NULL DEFAULT 'NS',
	"AgencyCode"	TEXT(80) NULL DEFAULT 'NS',
	"BureauCode"	TEXT(80) NULL DEFAULT 'NS',
	"AccountCode"	TEXT(80) NULL DEFAULT 'NS',
	"Transmit"	TEXT(80) NULL DEFAULT 'NS',
	"AgencySequence"	TEXT(80) NULL DEFAULT 'NS',
	"OmbAccountTitle"	TEXT(80) NULL DEFAULT 'NS',
	"LineName"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"PriorYearAmount"	NUMERIC NULL DEFAULT 0,
	"CurrentYearAmount"	NUMERIC NULL DEFAULT 0,
	"BudgetYearAmount"	NUMERIC NULL DEFAULT 0,
	PRIMARY KEY("UnobligatedAuthorityId" AUTOINCREMENT)
);