BEGIN TRANSACTION;
CREATE TABLE Allocations
(
	PrcId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	BFY TEXT(255),
	AhCode TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Amount	FLOAT,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ActivityCode TEXT(255),
	NpmName TEXT(255),
	NpmCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode INTEGER,
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio	TEXT NOT NULL,
	ChangeDate TEXT(255),
	PRIMARY KEY(PrcId AUTOINCREMENT)
);

CREATE TABLE ApplicationTables
(
	ApplicationTableId INTEGER NOT NULL UNIQUE,
	TableName TEXT(255),
	Model TEXT(255),
	CONSTRAINT PrimaryKeyApplicationTables PRIMARY KEY(ApplicationTableId)
);

CREATE TABLE Deobligations 
(
	DeobligationId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	DocumentNumber TEXT(255),
	CalendarYear TEXT(255),
	OrgCode TEXT(255),
	ProgramProjectCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	ProcessedDate DATETIME,
	Amount DOUBLE,
	CONSTRAINT PrimaryKeyDeobligations PRIMARY KEY(DeobligationId)
);

CREATE TABLE RegionalTransfers
(
	RegionalTransferId INTEGER NOT NULL UNIQUE,
	TransferId INTEGER NOT NULL UNIQUE,
	ReprogrammingNumber TEXT(255),
	ProcessedDate DATETIME,
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	FromTo TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Amount DOUBLE,
	FundName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocName TEXT(255),
	DocPrefix TEXT(255),
	CONSTRAINT ForeignKeyRegionalTransfers FOREIGN KEY(TransferId) REFERENCES Transfers,
	CONSTRAINT PrimaryKeyRegionalTransfers PRIMARY KEY(RegionalTransferId)
);

CREATE TABLE DivisionBudgetData
(
	DivisionBudgetDataId INTEGER NOT NULL UNIQUE,
	BFY TEXT(255),
	AhCode TEXT(255),
	RcCode TEXT(255),
	FundCode TEXT(255),
	CONSTRAINT PrimaryKeyDivisionBudgetData PRIMARY KEY(DivisionBudgetDataId)
);

CREATE TABLE Changes
(
	ChangeId INTEGER NOT NULL UNIQUE,
	TableName TEXT(255),
	FieldName TEXT(255),
	ActionType TEXT(255),
	OldValue TEXT(255),
	NewValue TEXT(255),
	ChangeDate DATETIME,
	Message TEXT(255),
	CONSTRAINT PrimaryKeyChanges PRIMARY KEY(ChangeId)
);

CREATE TABLE BackUpAllocations
(
	BackupAllocationId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AhCode TEXT(255),
	OrgCode TEXT(255),
	RcCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	Amount DOUBLE,
	AllocationRatio INTEGER,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ActivityCode TEXT(255),
	NpmName TEXT(255),
	NpmCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	ChangeDate DATETIME,
	CONSTRAINT ForeignKeyBackUpAllocations FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyBackUpAllocations PRIMARY KEY(BackupAllocationId)
);

CREATE TABLE Distribution
(
	DistributionId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	BFY TEXT(255),
	AhCode TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	BudgetLevel TEXT(255),
	RcCode TEXT(255),
	AllocationRatio DOUBLE,
	Amount DOUBLE,
	CONSTRAINT ForeignKeyDistribution FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyDistribution PRIMARY KEY(DistributionId)
);

CREATE TABLE DivisionAuthority
(
	DivisionAuthorityId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ActivityCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Reduction DOUBLE,
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	CONSTRAINT ForeignKeyDivisionAuthority FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyDivisionAuthority PRIMARY KEY(DivisionAuthorityId)
);

CREATE TABLE DivisionExecution
(
	DivisionExecutionId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	BFY TEXT(255),
	AhCode TEXT(255),
	FundCode TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	FundName TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ActivityCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	SiteProjectCode TEXT(255),
	Amount DOUBLE,
	OpenCommitments DOUBLE,
	CommitmentRatio DOUBLE,
	Obligations DOUBLE,
	ObligationRatio DOUBLE,
	Used DOUBLE,
	Utilization DOUBLE,
	Available DOUBLE,
	Availability DOUBLE,
	CONSTRAINT PrimaryKeyDivisionExecution PRIMARY KEY(DivisionExecutionId)
);

CREATE TABLE DivisionRescissionAuthority
(
	DivisionAuthorityId INTEGER NOT NULL UNIQUE,
	RescissionId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ActivityCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Reduction DOUBLE,
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	CONSTRAINT ForeignKeyDivisionRescission FOREIGN KEY(RescissionId) REFERENCES Rescission,
	CONSTRAINT ForeignKeyDivisionAllocations FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyDivisionRescissionAuthority PRIMARY KEY(DivisionAuthorityId)
);

CREATE TABLE ExecutionTables
(
	ExecutionTableId INTEGER NOT NULL UNIQUE,
	TableName TEXT(255),
	TableType	TEXT(50),
	CONSTRAINT PrimaryKeyExecutionTables PRIMARY KEY(ExecutionTableId)
);

CREATE TABLE QueryDefinitions
(
	QueryDefinitionId INTEGER NOT NULL UNIQUE,
	Name TEXT(255),
	Type TEXT(255),
	CONSTRAINT PrimaryKeyQueryDefinitions PRIMARY KEY(QueryDefinitionId)
);

CREATE TABLE RecoveryFundTransfers
(
	RecoveryFundTransferId INTEGER NOT NULL UNIQUE,
	TransferId INTEGER NOT NULL UNIQUE,
	ReprogrammingNumber TEXT(255),
	ProcessedDate DATETIME,
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AccountCode TEXT(255),
	OrgCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Amount DOUBLE,
	FundName TEXT(255),
	ProgramProjectName TEXT(255),
	BocName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	CONSTRAINT ForeignKeyRecoveryFundTransfers FOREIGN KEY(TransferId) REFERENCES Transfers,
	CONSTRAINT PrimaryKeyRecoveryFundTransfers PRIMARY KEY(RecoveryFundTransferId)
);

CREATE TABLE RegionalAuthority
(
	RegionalAuthorityId INTEGER NOT NULL UNIQUE,
	RescissionId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ActivityCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Reduction DOUBLE,
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	CONSTRAINT ForeignKeyRegionalAuthorityAllocations FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT ForeignKeyRegionalAuthorityRescissions FOREIGN KEY(RescissionId) REFERENCES Rescission,
	CONSTRAINT PrimaryKeyRegionalAuthority PRIMARY KEY(RegionalAuthorityId)
);

CREATE TABLE Rescission
(
	RescissionId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER,
	RPIO TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ActivityCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Allocation DOUBLE,
	Reduction DOUBLE,
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	CONSTRAINT ForeignKeyRescission FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyRescission PRIMARY KEY(RescissionId)
);

CREATE TABLE StatusOfFunds
(
	StatusOfFundsId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	BFY TEXT(255),
	AhCode TEXT(255),
	AhName TEXT(255),
	ProgramAreaName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	AccountCode TEXT(255),
	LowerName TEXT(255),
	RcCode TEXT(255),
	RcName TEXT(255),
	DivisionName TEXT(255),
	OrgCode TEXT(255),
	OrgName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	Amount DOUBLE,
	OpenCommitments DOUBLE,
	ULO DOUBLE,
	TotalExpenseAccruals DOUBLE,
	Expenditures DOUBLE,
	Obligations DOUBLE,
	Used DOUBLE,
	Available DOUBLE,
	NpmCode TEXT(255),
	NpmName TEXT(255),
	NpmTitle TEXT(255),
	ProgramAreaCode TEXT(255),
	CONSTRAINT PrimaryKeyStatusOfFunds PRIMARY KEY(StatusOfFundsId)
);

CREATE TABLE Supplemental
(
	SupplementalId INTEGER NOT NULL UNIQUE,
	Type TEXT(255),
	RcCode TEXT(255),
	FundCode TEXT(255),
	BFY TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	Amount DOUBLE,
	TimeOff DOUBLE,
	CONSTRAINT PrimaryKeySupplemental PRIMARY KEY(SupplementalId)
);

CREATE TABLE TravelObligations
(
	TravelObligationId INTEGER NOT NULL UNIQUE,
	RpioCode TEXT(255),
	BFY TEXT(255),
	AhCode TEXT(255),
	AhName TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	OrgCode TEXT(255),
	OrgName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	RcCode TEXT(255),
	RcName TEXT(255),
	FocCode TEXT(255),
	FocName TEXT(255),
	FirstName TEXT(255),
	LastName TEXT(255),
	DepartureDate DATETIME,
	ReturnDate DATETIME,
	DocumentType TEXT(255),
	DCN TEXT(255),
	Obligations DOUBLE,
	ULO DOUBLE,
	Expenditures DOUBLE,
	NpmCode TEXT(255),
	CONSTRAINT PrimaryKeyTravelObligations PRIMARY KEY(TravelObligationId)
);

CREATE TABLE ProgrammaticReservePriorYearUtilization
(
	ProgrammaticReservePriorYearUtilizationId INTEGER,
	OrgCode INTEGER,
	BFY INTEGER,
	RcCode TEXT(255),
	DivisionName TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocCode INTEGER,
	BocName TEXT(255),
	CurrentYear INTEGER,
	Reduction INTEGER,
	Budget INTEGER,
	PriorYear INTEGER,
	OpenCommitments INTEGER,
	ULO INTEGER
);

CREATE TABLE ReimbursableFunds
(
	ReimbursableFundId INTEGER,
	RPIO INTEGER,
	BFY INTEGER,
	FundCode TEXT(255),
	AccountCode TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	BocCode INTEGER,
	DocumentControlNumber TEXT(255),
	AgreeementNumber TEXT(255),
	Amount	FLOAT NULL DEFAULT 0,
	OpenCommitments INTEGER,
	Obligations	FLOAT NULL DEFAULT 0,
	ULO INTEGER,
	Available	REAL
);

CREATE TABLE DocumentControlNumbers
(
	DocumentControlNumberId INTEGER NOT NULL UNIQUE,
	RcCode TEXT(255),
	DocumentControlNumber TEXT(255),
	PRIMARY KEY(DocumentControlNumberId AUTOINCREMENT)
);

CREATE TABLE DivisionTravel
(
	PrcId INTEGER NOT NULL UNIQUE,
	DivisionAuthorityId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AhCode TEXT(255),
	OrgCode TEXT(255),
	RcCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ActivityCode TEXT(255),
	NpmName TEXT(255),
	NpmCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	PRIMARY KEY(PrcId AUTOINCREMENT)
);

CREATE TABLE ExternalUpdates
(
	ExternalUpdateId INTEGER NOT NULL UNIQUE,
	ExtId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	AhCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ActivityCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	Amount	FLOAT,
	PRIMARY KEY(ExternalUpdateId AUTOINCREMENT)
);

CREATE TABLE ProgrammaticReserve
(
	ProgrammaticReserveId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ActivityCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	CurrentYear DOUBLE,
	Reduction DOUBLE,
	Ratio DOUBLE,
	Budget DOUBLE,
	PriorYear DOUBLE,
	FundName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	Delta DOUBLE,
	CONSTRAINT ForeignKeyProgrammaticReserve FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyProgrammaticReserve PRIMARY KEY(ProgrammaticReserveId AUTOINCREMENT)
);

CREATE TABLE PurchaseRequestNumbers
(
	PurchaseRequestId INTEGER NOT NULL UNIQUE,
	RcCode TEXT(255),
	PurchaseRequest TEXT(255),
	PRIMARY KEY(PurchaseRequestId AUTOINCREMENT)
);

CREATE TABLE Purchases
(
	PurchaseId INTEGER NOT NULL UNIQUE,
	RpioCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	AhCode TEXT(255),
	AhName TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	DocumentControlNumbers TEXT(255),
	ObligationDocumentNumber TEXT(255),
	DocType TEXT(255),
	DcnPrefix TEXT(255),
	System TEXT(255),
	LineNumber TEXT(255),
	FocCode TEXT(255),
	FocName TEXT(255),
	OriginalActionDate DATETIME,
	LastActionDate DATETIME,
	TransactionNumber TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	OrgCode TEXT(255),
	OrgName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	ActivityCode TEXT(255),
	PurchaseRequestNumber TEXT(255),
	ReimbursableAgreementNumber TEXT(255),
	SiteProjectCode TEXT(255),
	VendorCode TEXT(255),
	VendorName TEXT(255),
	Commitments DOUBLE,
	OpenCommitments DOUBLE,
	Obligations DOUBLE,
	Deobligations DOUBLE,
	Used DOUBLE,
	ULO DOUBLE,
	Expenditures DOUBLE,
	CONSTRAINT PrimaryKeyPurchases PRIMARY KEY(PurchaseId AUTOINCREMENT)
);

CREATE TABLE RegionalTravel
(
	RegionalTravelId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	BudgetLevel	TEXT(255) NOT NULL,
	RPIO	TEXT(255) NOT NULL,
	BFY	TEXT(255) NOT NULL,
	FundCode	TEXT(255) NOT NULL,
	AhCode	TEXT(255) NOT NULL,
	OrgCode	TEXT(255) NOT NULL,
	RcCode	TEXT(255) NOT NULL,
	AccountCode TEXT(255),
	BocCode	TEXT(255) NOT NULL,
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ActivityCode TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	CONSTRAINT ForeignKeyRegionalTravel FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyRegionalTravel PRIMARY KEY(RegionalTravelId AUTOINCREMENT)
);

CREATE TABLE ReimbursableAgreements
(
	ReimbursableAgreementId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AgreementNumber TEXT(255),
	StartDate TEXT(255),
	EndDate INTEGER,
	RcCode TEXT(255),
	OrgCode TEXT(255),
	DivisionName TEXT(255),
	SiteProjectCode TEXT(255),
	AccountCode TEXT(255),
	VendorCode TEXT(255),
	VendorName TEXT(255),
	Amount	FLOAT,
	OpenCommitments	FLOAT,
	Obligations	FLOAT,
	ULO	FLOAT,
	Available	FLOAT,
	PRIMARY KEY(ReimbursableAgreementId AUTOINCREMENT)
);

CREATE TABLE ReimbursableSurvey
(
	ReimbursableSurveyId INTEGER NOT NULL UNIQUE,
	BFY TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	Amount	FLOAT,
	PRIMARY KEY(ReimbursableSurveyId AUTOINCREMENT)
);

CREATE TABLE Reprogrammings
(
	ReprogrammingId INTEGER NOT NULL UNIQUE,
	ReprogrammingNumber TEXT(255),
	ProcessedDate TEXT(255),
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	OrgCode TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	Amount	FLOAT,
	SPIO TEXT(255),
	Purpose TEXT(255),
	ExtendedPurpose TEXT(255),
	FromTo TEXT(255),
	DocType TEXT(255),
	DocPrefix TEXT(255),
	NpmCode TEXT(255),
	Line TEXT(255),
	Subline TEXT(255),
	PRIMARY KEY(ReprogrammingId AUTOINCREMENT)
);

CREATE TABLE SystemUpdates
(
	SystemUpdateId INTEGER NOT NULL UNIQUE,
	ExtId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	Amount	FLOAT,
	PRIMARY KEY(SystemUpdateId AUTOINCREMENT)
);

CREATE TABLE Transfers
(
	TransferId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	DocPrefix TEXT(255),
	DocType TEXT(255),
	BFY TEXT(255),
	RpioCode TEXT(255),
	RpioName TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	ReprogrammingNumber TEXT(255),
	ControlNumber TEXT(255),
	ProcessedDate	datetime,
	Quarter TEXT(255),
	Line TEXT(255),
	Subline TEXT(255),
	AhCode TEXT(255),
	AhName TEXT(255),
	OrgCode TEXT(255),
	OrganizationName TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	AccountCode TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramProjectCode TEXT(255),
	FromTo TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	Amount DOUBLE,
	Purpose TEXT(255),
	PurposeExtended TEXT(255),
	ResourceType TEXT(255),
	CONSTRAINT PrimaryKeyTransfers PRIMARY KEY(TransferId AUTOINCREMENT)
);

CREATE TABLE UpperReconcilliation
(
	ReconcilliationId INTEGER NOT NULL UNIQUE,
	ExtId INTEGER NOT NULL,
	PrcId INTEGER NOT NULL UNIQUE,
	BFY TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	FundName TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	BocName TEXT(255),
	DivisionName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	System	FLOAT,
	Budget	FLOAT,
	Delta	FLOAT,
	NET TEXT(255),
	PRIMARY KEY(ReconcilliationId AUTOINCREMENT)
);

CREATE TABLE LowerReconcilliation
(
	ReconcilliationId INTEGER NOT NULL UNIQUE,
	ExtId INTEGER NOT NULL,
	PrcId INTEGER NOT NULL UNIQUE,
	BFY TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	FundName TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	System	FLOAT,
	Budget	FLOAT,
	Delta	FLOAT,
	NET TEXT(255),
	PRIMARY KEY(ReconcilliationId AUTOINCREMENT)
);

CREATE TABLE AgencyTransfers
(
	AgencyTransferId INTEGER NOT NULL UNIQUE,
	TransferId INTEGER NOT NULL UNIQUE,
	ReprogrammingNumber TEXT(255),
	ProcessedDate	datetime,
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AccountCode TEXT(255),
	OrgCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Amount	money,
	FundName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocName TEXT(255),
	FromTo TEXT(255),
	SPIO TEXT(255),
	CONSTRAINT ForeignKeyAgencyTransfers FOREIGN KEY(TransferId) REFERENCES Transfers,
	CONSTRAINT PrimaryKeyAgencyTransfers PRIMARY KEY(AgencyTransferId)
);

CREATE TABLE CarryoverSurvey
(
	CarryoverSurveyId INTEGER NOT NULL UNIQUE,
	BFY TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	Amount	FLOAT NULL DEFAULT 0,
	PRIMARY KEY(CarryoverSurveyId AUTOINCREMENT)
);

CREATE TABLE ControlNumbers
(
	ControlNumberId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	RegionNumber DOUBLE,
	BFY TEXT(255),
	CalendarYear TEXT(255),
	FundCode TEXT(255),
	FundNumber TEXT(255),
	AhCode TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	DivisionNumber DOUBLE,
	DateIssued DATETIME,
	Purpose TEXT(255),
	PRIMARY KEY(ControlNumberId AUTOINCREMENT)
);

CREATE TABLE CongressionalTransfers
(
	CongressionalTransferId INTEGER NOT NULL UNIQUE,
	ReprogrammingNumber TEXT(255),
	ProcessedDate DATETIME,
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AccountCode TEXT(255),
	OrgCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Amount	NUMBER,
	FundName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	BocName TEXT(255),
	SPIO TEXT(255),
	CONSTRAINT PrimaryKeyCongressionalTransfers PRIMARY KEY(CongressionalTransferId)
);

CREATE TABLE OperatingPlans
(
	OppId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BFY TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	FundCode TEXT(255),
	OrgCode INTEGER,
	AccountCode TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	RcCode TEXT(255),
	Amount DOUBLE,
	NpmCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramAreaCode TEXT(255),
	NpmName TEXT(255),
	AhName TEXT(255),
	FundName TEXT(255),
	OrgName TEXT(255),
	ActivityCode TEXT(255),
	ActivityName TEXT(255),
	DivisionName TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	PRIMARY KEY(OppId AUTOINCREMENT)
);

CREATE TABLE RegionalRescissionAuthority
(
	RegionalRescissionAuthorityId INTEGER NOT NULL UNIQUE,
	RescissionId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BudgetLevel TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ActivityCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Reduction DOUBLE,
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	CONSTRAINT ForeignKeyRegionalAuthorityAllocations FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT ForeignKeyRegionalAuthorityRescissions FOREIGN KEY(RescissionId) REFERENCES Rescission,
	CONSTRAINT PrimaryKeyRegionalRescissionAuthority PRIMARY KEY(RegionalRescissionAuthorityId)
);

CREATE TABLE EmployeeData
(
	EmployeeDataId INTEGER NOT NULL UNIQUE,
	RpioCode TEXT(255),
	RpioName TEXT(255),
	ActionDate DATETIME,
	HiringAuthority TEXT(255),
	SupervisorId TEXT(255),
	JobTitle TEXT(255),
	HrOrgCode TEXT(255),
	HrOrgName TEXT(255),
	EmployeeId TEXT(255),
	FirstName TEXT(255),
	LastName TEXT(255),
	RetirementPlan TEXT(255),
	ScheduledRetirementDate DATETIME,
	HireDate DATETIME,
	Grade TEXT(255),
	Step TEXT(255),
	GradeEntry DATETIME,
	LastIncrease DATETIME,
	StepEntry DATETIME,
	WigiDueDate DATETIME,
	EmployeeStatus TEXT(255),
	HoursEarnedYearToDate DOUBLE,
	CarryoverHours DOUBLE,
	HoursAdjustedYearToDate DOUBLE,
	HoursBalance DOUBLE,
	ProjectedAnnualHours DOUBLE,
	ProjectedNextPeriodHours DOUBLE,
	HoursTakenYearToDate DOUBLE,
	CONSTRAINT PrimaryKeyEmployeeData PRIMARY KEY(EmployeeDataId)
);

CREATE TABLE Employees
(
	PersonnelId INTEGER NOT NULL UNIQUE,
	RcCode TEXT(255),
	EpaNumber TEXT(255),
	LastName TEXT(255),
	FirstName TEXT(255),
	CONSTRAINT PrimaryKeyEmployees PRIMARY KEY(PersonnelId)
);

CREATE TABLE EmployeePayroll
(
	EmployeePayrollId INTEGER NOT NULL UNIQUE,
	RcCode TEXT(255),
	DivisionName TEXT(255),
	EpaNumber TEXT(255),
	LastName TEXT(255),
	FirstName TEXT(255),
	ReportingCode TEXT(255),
	ReportingCodeName TEXT(255),
	Hours DOUBLE,
	Days DOUBLE,
	CONSTRAINT PrimaryKeyEmployeePayroll PRIMARY KEY(EmployeePayrollId)
);

CREATE TABLE FullTimeEquivalents
(
	FullTimeEquivalentId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AhCode TEXT(255),
	OrgCode TEXT(255),
	RcCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ActivityCode TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	CONSTRAINT ForeignKeyFullTimeEquivalents FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyFullTimeEquivalents PRIMARY KEY(FullTimeEquivalentId)
);

CREATE TABLE HumanResourceOrganizations
(
	HumanResourceOrganizationId INTEGER,
	RcCode	NVARCHAR(255),
	DivisionName	NVARCHAR(255),
	HrOrgCode	NVARCHAR(255),
	HrOrgName	NVARCHAR(255)
);

CREATE TABLE PayPeriods
(
	PayPeriodId INTEGER NOT NULL UNIQUE,
	Period	TEXT(255) NOT NULL,
	PayPeriod TEXT(255),
	StartDate DATETIME,
	EndDate DATETIME,
	CONSTRAINT PrimaryKeyPayPeriods PRIMARY KEY(PayPeriodId)
);

CREATE TABLE Payroll
(
	PayrollId INTEGER NOT NULL UNIQUE,
	PrcId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AhCode TEXT(255),
	OrgCode TEXT(255),
	RcCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	Amount DOUBLE,
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ActivityCode TEXT(255),
	NpmCode TEXT(255),
	NpmName TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio DOUBLE,
	ChangeDate DATETIME,
	CONSTRAINT ForiegnKeyPayroll FOREIGN KEY(PrcId) REFERENCES Allocations,
	CONSTRAINT PrimaryKeyPayroll PRIMARY KEY(PayrollId)
);

CREATE TABLE PayrollHours
(
	PayrollHoursId INTEGER NOT NULL UNIQUE,
	RpioCode TEXT(255),
	PayPeriod TEXT(255),
	StartDate DATETIME,
	EndDate DATETIME,
	EpaNumber TEXT(255),
	FirstName TEXT(255),
	LastName TEXT(255),
	ProcessedDate DATETIME,
	HrOrgCode TEXT(255),
	HrOrgCodeName TEXT(255),
	ReportingCode TEXT(255),
	ReportingCodeName TEXT(255),
	ApprovalDate DATETIME,
	WorkCode TEXT(255),
	Hours DOUBLE,
	CONSTRAINT PrimaryKeyPayrollHours PRIMARY KEY(PayrollHoursId)
);

CREATE TABLE PayrollObligations
(
	PayrollObligationId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	BFY TEXT(255),
	FundCode TEXT(255),
	AhCode TEXT(255),
	OrgCode TEXT(255),
	RcCode TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectCode TEXT(255),
	Amount DOUBLE,
	Hours DOUBLE,
	CumulativeBenefits DOUBLE,
	AnnualBasePaid DOUBLE,
	AnnualBaseHours DOUBLE,
	AnnualOvertimePaid DOUBLE,
	AnnualOvertimeHours DOUBLE,
	AnnualOtherHours DOUBLE,
	AnnualOtherPaid DOUBLE,
	AllocationPercentage TEXT(255),
	PayPeriod TEXT(255),
	FocCode TEXT(255),
	FocName TEXT(255),
	WorkCode TEXT(255),
	WorkCodeName TEXT(255),
	HumanResourceOrganizationCode TEXT(255),
	CONSTRAINT PrimaryKeyPayrollObligations PRIMARY KEY(PayrollObligationId)
);

CREATE TABLE WorkCodes
(
	WorkCodeId INTEGER NOT NULL UNIQUE,
	RpioCode	TEXT(255) DEFAULT (NS),
	WorkCode	TEXT(255) DEFAULT (NS),
	WorkCodeName	TEXT(255) DEFAULT (NS),
	ChargeType	TEXT(255) DEFAULT (NS),
	Notifications	TEXT(255) DEFAULT (NS),
	PayPeriod	TEXT(255) DEFAULT (NS),
	BFY	TEXT(255) DEFAULT (NS),
	ApproverUserName	TEXT(255) DEFAULT (NS),
	ApprovedDate	TEXT(255) DEFAULT (NS),
	ModifierUserName	TEXT(255) DEFAULT (NS),
	ModifiedDate	TEXT(255) DEFAULT (NS),
	FundCode	TEXT(255) DEFAULT (NS),
	FocCode	TEXT(255) DEFAULT (NS),
	CostOrgCode	TEXT(255) DEFAULT (NS),
	CostOrgName	TEXT(255) DEFAULT (NS),
	RcCode	TEXT(255) DEFAULT (NS),
	AccountCode	TEXT(255) DEFAULT (NS),
	WorkProjectCode	TEXT(255) DEFAULT (NS),
	WorkProjectName	TEXT(255) DEFAULT (NS),
	Percentage	FLOAT NOT NULL DEFAULT (0.0),
	CONSTRAINT PrimaryKeyWorkCodes PRIMARY KEY(WorkCodeId)
);

CREATE TABLE BudgetParameters
(
	BudgetParameterId INTEGER NOT NULL UNIQUE,
	AhCode TEXT(255),
	BFY TEXT(255),
	RcCode TEXT(255),
	FundCode TEXT(255),
	CONSTRAINT PrimaryKeyBudgetParameters PRIMARY KEY(BudgetParameterId)
);

CREATE TABLE ReferenceTables
(
	ReferenceTableId INTEGER NOT NULL UNIQUE,
	TableName TEXT(255),
	Type TEXT(255),
	CONSTRAINT PrimaryKeyReferenceTables PRIMARY KEY(ReferenceTableId)
);

CREATE TABLE PeoplePlus
(
	PeoplePlusId INTEGER NOT NULL UNIQUE,
	RcCode TEXT(255),
	DivisionName TEXT(255),
	EpaNumber TEXT(255),
	LastName TEXT(255),
	FirstName TEXT(255),
	ReportingCode TEXT(255),
	ReportingCodeName TEXT(255),
	WorkCode TEXT(255),
	Hours	FLOAT,
	CONSTRAINT PrimaryKeyPeoplePlus PRIMARY KEY(PeoplePlusId)
);

CREATE TABLE EmployeeLeave
(
	EmployeeLeaveId INTEGER NOT NULL UNIQUE,
	LastName TEXT(255),
	FirstName TEXT(255),
	EmployeeId TEXT(255),
	HoursEarnedYearToDate	FLOAT,
	CarryoverHours	FLOAT,
	HoursAdjustedYearToDate	FLOAT,
	HoursBalance	FLOAT,
	ProjectedAnnualHours	FLOAT,
	ProjectedNextPeriodHours	FLOAT,
	HoursTakenYearToDate	FLOAT,
	CONSTRAINT PrimaryKeyEmployeeLeave PRIMARY KEY(EmployeeLeaveId)
);

CREATE TABLE DivisionTraining
(
	DivisionTrainingId INTEGER NOT NULL UNIQUE,
	PrcId	FLOAT,
	BudgetLevel TEXT(255),
	RPIO TEXT(255),
	BFY TEXT(255),
	AhCode TEXT(255),
	FundCode TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	BocCode TEXT(255),
	RcCode TEXT(255),
	Amount	DECIMAL(18, 0),
	FundName TEXT(255),
	BocName TEXT(255),
	Division TEXT(255),
	DivisionName TEXT(255),
	ActivityCode TEXT(255),
	NpmName TEXT(255),
	NpmCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	GoalCode TEXT(255),
	GoalName TEXT(255),
	ObjectiveCode TEXT(255),
	ObjectiveName TEXT(255),
	AllocationRatio	FLOAT,
	ChangeDate DATETIME,
	CONSTRAINT PrimaryKeyDivisionTraining PRIMARY KEY(DivisionTrainingId)
);

CREATE TABLE LocatorData
(
	LocatorId INTEGER NOT NULL UNIQUE,
	LastName TEXT(255),
	FirstName TEXT(255),
	Email TEXT(255),
	PhoneNumber TEXT(255),
	MailCode TEXT(255),
	Office TEXT(255),
	CellNumber TEXT(255),
	Status TEXT(255),
	CONSTRAINT PrimaryKeyLocatorData PRIMARY KEY(LocatorId)
);

CREATE TABLE DivisionPersonnel
(
	PersonnelId INTEGER NOT NULL UNIQUE,
	RcCode TEXT(255),
	EmployeeId TEXT(255),
	LastName TEXT(255),
	FirstName TEXT(255),
	JobTitle TEXT(255),
	Grade TEXT(255),
	Step TEXT(255),
	HireDate DATETIME,
	Tenure	FLOAT,
	HrOrgName TEXT(255),
	Email TEXT(255),
	PhoneNumber TEXT(255),
	Office TEXT(255),
	MailCode TEXT(255),
	CONSTRAINT PrimaryKeyDivisionPersonnel PRIMARY KEY(PersonnelId)
);

CREATE TABLE CarryoverEstimates
(
	CarryoverEstimateId INTEGER NOT NULL UNIQUE,
	BudgetLevel TEXT(255),
	BFY TEXT(255),
	AhCode TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	BocCode TEXT(255),
	BocName TEXT(255),
	Balance	FLOAT NULL DEFAULT 0,
	OpenCommitment	RREA,
	Estimate	FLOAT NULL DEFAULT 0,
	PRIMARY KEY(CarryoverEstimateId AUTOINCREMENT)
);

CREATE TABLE PayrollAccruals
(
	PayrollAccrualId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	EpaNumber TEXT(255),
	LastName TEXT(255),
	FirstName TEXT(255),
	FundCode TEXT(255),
	FundName TEXT(255),
	OrgCode TEXT(255),
	AccountCode TEXT(255),
	ProgramProjectCode TEXT(255),
	ProgramProjectName TEXT(255),
	ProgramAreaCode TEXT(255),
	ProgramAreaName TEXT(255),
	WorkCode TEXT(255),
	HrOrgCode TEXT(255),
	PayPeriod TEXT(255),
	StartDate DATETIME,
	EndDate DATETIME,
	Amount DOUBLE,
	Hours DOUBLE,
	Benfits DOUBLE,
	OvertimePaid DOUBLE,
	OvertimeHours DOUBLE,
	CONSTRAINT PrimaryKeyPayrollAccruals PRIMARY KEY(PayrollAccrualId AUTOINCREMENT)
);

CREATE TABLE PayrollCostCodes
(
	PayrollCostCodeId INTEGER NOT NULL UNIQUE,
	RPIO TEXT(255),
	AhCode TEXT(255),
	BFY TEXT(255),
	RcCode TEXT(255),
	DivisionName TEXT(255),
	WorkCode TEXT(255),
	WorkCodeName TEXT(255),
	HrOrgCode TEXT(255),
	HrOrgName TEXT(255),
	CONSTRAINT PrimaryKeyPayrollCostCodes PRIMARY KEY(PayrollCostCodeId AUTOINCREMENT)
);

CREATE TABLE ReportingCodes
(
	ReportingCodesId INTEGER NOT NULL UNIQUE,
	ReportingCode TEXT(255),
	ReportingCodeName TEXT(255),
	CONSTRAINT PrimaryKeyReportingCodes PRIMARY KEY(ReportingCodesId AUTOINCREMENT)
);

CREATE TABLE SiteProjectCodes
(
	SiteProjectCodeId INTEGER NOT NULL UNIQUE,
	RcCode TEXT(255),
	DivisionName TEXT(255),
	SiteProjectCode TEXT(255),
	CONSTRAINT PrimaryKeySiteProjectCodes PRIMARY KEY(SiteProjectCodeId AUTOINCREMENT)
);

COMMIT;
