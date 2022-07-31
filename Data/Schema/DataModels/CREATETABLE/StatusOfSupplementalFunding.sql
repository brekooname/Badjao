CREATE TABLE StatusOfSupplementalFunding 
(
	StatusOfSupplementalFunding	INTEGER NOT NULL UNIQUE,
	StatusOfFundsId	INTEGER NOT NULL,
	BudgetLevel	TEXT DEFAULT NS,
	BFY	TEXT DEFAULT NS,
	EFY	TEXT DEFAULT NS,
	RpioCode	TEXT DEFAULT NS,
	RpioName	TEXT DEFAULT NS,
	AhCode	TEXT DEFAULT NS,
	AhName	TEXT DEFAULT NS,
	FundCode	TEXT DEFAULT NS,
	FundName	TEXT DEFAULT NS,
	OrgCode	TEXT DEFAULT NS,
	OrgName	TEXT DEFAULT NS,
	AccountCode	TEXT DEFAULT NS,
	BocCode	TEXT DEFAULT NS,
	BocName	TEXT DEFAULT NS,
	ProgramProjectCode	TEXT DEFAULT NS,
	ProgramProjectName	TEXT DEFAULT NS,
	ProgramAreaCode	TEXT DEFAULT NS,
	ProgramAreaName	TEXT DEFAULT NS,
	RcCode	TEXT DEFAULT NS,
	RcName	TEXT DEFAULT NS,
	LowerName	TEXT DEFAULT NS,
	Amount	FLOAT DEFAULT 0,
	Budgeted	FLOAT DEFAULT 0,
	Posted	FLOAT DEFAULT 0,
	OpenCommitments	FLOAT DEFAULT 0,
	ULO	FLOAT DEFAULT 0,
	Expenditures	FLOAT DEFAULT 0,
	Obligations	FLOAT DEFAULT 0,
	Used	FLOAT DEFAULT 0,
	Available	FLOAT DEFAULT 0,
	NpmCode	TEXT DEFAULT NS,
	NpmName	TEXT DEFAULT NS,
	PRIMARY KEY(SupplementalAuthorityId AUTOINCREMENT)
);

