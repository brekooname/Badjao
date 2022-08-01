CREATE TABLE HeadquartersAuthority 
(
	HeadquartersAuthorityId	INTEGER NOT NULL,
	AllocationsId	INTEGER,
	StatusOfFundsId	INTEGER,
	BudgetLevel	TEXT(80) NULL DEFAULT NS,
	BFY	TEXT(80) NULL DEFAULT NS,
	EFY	TEXT(80) NULL DEFAULT NS,
	RpioCode	TEXT(80) NULL DEFAULT NS,
	RpioName	TEXT(80) NULL DEFAULT NS,
	AhCode	TEXT(80) NULL DEFAULT NS,
	AhName	TEXT(80) NULL DEFAULT NS,
	FundCode	TEXT(80) NULL DEFAULT NS,
	FundName	TEXT(80) NULL DEFAULT NS,
	OrgCode	TEXT(80) NULL DEFAULT NS,
	OrgName	TEXT(80) NULL DEFAULT NS,
	AccountCode	TEXT(80) NULL DEFAULT NS,
	ProgramProjectCode	TEXT(80) NULL DEFAULT NS,
	ProgramProjectName	TEXT(80) NULL DEFAULT NS,
	ProgramAreaCode	TEXT(80) NULL DEFAULT NS,
	ProgramAreaName	TEXT(80) NULL DEFAULT NS,
	RcCode	TEXT(80) NULL DEFAULT NS,
	RcName	TEXT(80) NULL DEFAULT NS,
	BocCode	TEXT(80) NULL DEFAULT NS,
	BocName	TEXT(80) NULL DEFAULT NS,
	Amount	FLOAT NULL DEFAULT 0,
	NpmCode	TEXT(80) NULL DEFAULT NS,
	NpmName	TEXT(80) NULL DEFAULT NS,
	PRIMARY KEY(HeadquartersAuthorityId)
);