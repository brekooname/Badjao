CREATE TABLE IF NOT EXISTS ReimbursableSurvey 
(
	ReimbursableSurveyId	INTEGER NOT NULL UNIQUE,
	BFY	 TEXT(80) NULL DEFAULT 'NS',
	FundCode	 TEXT(80) NULL DEFAULT 'NS',
	FundName	 TEXT(80) NULL DEFAULT 'NS',
	Amount	NUMERIC NULL DEFAULT 0.0,
	PRIMARY KEY(ReimbursableSurveyId AUTOINCREMENT)
);