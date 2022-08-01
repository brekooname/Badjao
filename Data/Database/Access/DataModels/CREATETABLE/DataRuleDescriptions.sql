CREATE TABLE IF NOT EXISTS "DataRuleDescriptions" 
(
	"DataRuleDescriptionsId"	INTEGER NOT NULL UNIQUE,
	"Schedule"	TEXT(80) NULL DEFAULT 'NS',
	"LineNumber"	TEXT(80) NULL DEFAULT 'NS',
	"RuleNumber"	TEXT(80) NULL DEFAULT 'NS',
	"RuleDescription"	TEXT(255) NULL DEFAULT 'NS',
	"ScheduleOrder"	TEXT(80) NULL DEFAULT 'NS',
	PRIMARY KEY("DataRuleDescriptionsId" AUTOINCREMENT)
);