CREATE TABLE Reprogrammings 
(
	ReprogrammingsId INT NOT NULL IDENTITY (1,1),
	TransfersId INT NOT NULL, 
	ReprogrammingNumber NVARCHAR(255),
	ProcessedDate NVARCHAR(255),
	RPIO NVARCHAR(255),
	AhCode NVARCHAR(255),
	BFY NVARCHAR(255),
	FundCode NVARCHAR(255),
	FundName NVARCHAR(255),
	AccountCode NVARCHAR(255),
	ProgramProjectCode NVARCHAR(255),
	ProgramProjectName NVARCHAR(255),
	ProgramAreaCode NVARCHAR(255),
	ProgramAreaName NVARCHAR(255),
	OrgCode NVARCHAR(255),
	BocCode NVARCHAR(255),
	BocName NVARCHAR(255),
	RcCode NVARCHAR(255),
	DivisionName NVARCHAR(255),
	Amount NUMERIC,
	SPIO NVARCHAR(255),
	Purpose NVARCHAR(255),
	ExtendedPurpose NVARCHAR(255),
	FromTo NVARCHAR(255),
	DocType NVARCHAR(255),
	DocPrefix NVARCHAR(255),
	NpmCode NVARCHAR(255),
	Line NVARCHAR(255),
	Subline NVARCHAR(255),
		CONSTRAINT PK_Reprogrammings 
		PRIMARY KEY (ReprogrammingsId),
		CONSTRAINT FK_Reprogrammings 
		FOREIGN KEY (TransfersId) 
		REFERENCES Transfers
);