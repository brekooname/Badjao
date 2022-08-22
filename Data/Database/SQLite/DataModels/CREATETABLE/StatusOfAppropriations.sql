CREATE TABLE IF NOT EXISTS "StatusOfAppropriations" 
(
	"StatusOfAppropriationsId"	INTEGER NOT NULL UNIQUE,
	"BFY"	TEXT(80) NULL DEFAULT 'NS',
	"EFY"	TEXT(80) NULL DEFAULT 'NS',
	"BudgetLevel"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationFundCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationFundName"	TEXT(80) NULL DEFAULT 'NS',
	"Availability"	TEXT(80) NULL DEFAULT 'NS',
	"TreasurySymbol"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationCreationDate"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"SubAppropriationCode"	TEXT(80) NULL DEFAULT 'NS',
	"AppropriationDescription"	TEXT(80) NULL DEFAULT 'NS',
	"FundGroup"	TEXT(80) NULL DEFAULT 'NS',
	"FundGroupName"	TEXT(80) NULL DEFAULT 'NS',
	"DocumentType"	TEXT(80) NULL DEFAULT 'NS',
	"TransType"	TEXT(80) NULL DEFAULT 'NS',
	"ActualRecoveryTransType"	TEXT(80) NULL DEFAULT 'NS',
	"CommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"AgreementLimit"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedRecoveriesTransType"	TEXT(80) NULL DEFAULT 'NS',
	"EstimatedReimbursmentsTransType"	TEXT(80) NULL DEFAULT 'NS',
	"ExpenseSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"ObligationSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"PreCommitmentSpendingControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"PostedControlFlag"	TEXT(80) NULL DEFAULT 'NS',
	"PostedFlag"	TEXT(80) NULL DEFAULT 'NS',
	"RecordCarryoverAtLowerLevel"	TEXT(80) NULL DEFAULT 'NS',
	"ReimbursableSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveriesOption"	TEXT(80) NULL DEFAULT 'NS',
	"RecoveriesSpendingOption"	TEXT(80) NULL DEFAULT 'NS',
	"OriginalBudgetedAmount"	NUMERIC NULL DEFAULT 0,
	"ApportionmentsPosted"	NUMERIC NULL DEFAULT 0,
	"TotalAuthority"	NUMERIC NULL DEFAULT 0,
	"TotalBudgeted"	NUMERIC NULL DEFAULT 0,
	"TotalPostedAmount"	REAL DEFAULT 0.0,
	"FundsWithdrawnPriorYearsAmount"	NUMERIC NULL DEFAULT 0,
	"FundingInAmount"	NUMERIC NULL DEFAULT 0,
	"FundingOutAmount"	NUMERIC NULL DEFAULT 0,
	"TotalAccrualRecoveries"	NUMERIC NULL DEFAULT 0,
	"TotalActualReimbursements"	NUMERIC NULL DEFAULT 0,
	"TotalAgreementReimbursables"	NUMERIC NULL DEFAULT 0,
	"TotalCarriedForwardIn"	NUMERIC NULL DEFAULT 0,
	"TotalCarriedForwardOut"	NUMERIC NULL DEFAULT 0,
	"TotalCommitted"	NUMERIC NULL DEFAULT 0,
	"TotalEstimatedRecoveries"	NUMERIC NULL DEFAULT 0,
	"TotalEstimatedReimbursements"	NUMERIC NULL DEFAULT 0,
	"TotalExpenses"	NUMERIC NULL DEFAULT 0,
	"TotalExpenditureExpenses"	NUMERIC NULL DEFAULT 0,
	"TotalExpenseAccruals"	NUMERIC NULL DEFAULT 0,
	"TotalPreCommitments"	NUMERIC NULL DEFAULT 0,
	"UnliquidatedPreCommitments"	NUMERIC NULL DEFAULT 0,
	"TotalObligations"	NUMERIC NULL DEFAULT 0,
	"ULO"	NUMERIC NULL DEFAULT 0,
	"VoidedAmount"	NUMERIC NULL DEFAULT 0,
	"TotalUsedAmount"	NUMERIC NULL DEFAULT 0,
	"AvailableAmount"	NUMERIC NULL DEFAULT 0,
	PRIMARY KEY("StatusOfAppropriationsId" AUTOINCREMENT)
);