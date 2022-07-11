CREATE TABLE "OperatingPlans" (
	"OppId"	INTEGER NOT NULL UNIQUE,
	"RPIO"	TEXT,
	"BFY"	TEXT,
	"BudgetLevel"	TEXT,
	"AhCode"	TEXT,
	"FundCode"	TEXT,
	"OrgCode"	INTEGER,
	"AccountCode"	TEXT,
	"BocCode"	TEXT,
	"BocName"	TEXT,
	"RcCode"	TEXT,
	"Amount"	DOUBLE,
	"NpmCode"	TEXT,
	"ProgramProjectCode"	TEXT,
	"ProgramAreaCode"	TEXT,
	"NpmName"	TEXT,
	"AhName"	TEXT,
	"FundName"	TEXT,
	"OrgName"	TEXT,
	"ActivityCode"	TEXT,
	"ActivityName"	TEXT,
	"DivisionName"	TEXT,
	"ProgramProjectName"	TEXT,
	"ProgramAreaName"	TEXT,
	"GoalCode"	TEXT,
	"GoalName"	TEXT,
	"ObjectiveCode"	TEXT,
	"ObjectiveName"	TEXT,
	PRIMARY KEY("OppId" AUTOINCREMENT)
)