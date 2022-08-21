CREATE TABLE CarryoverApportionments
(
    CarryoverApportionmentsId AUTOINCREMENT NOT NULL UNIQUE,
    BudgetAccount TEXT(80) NULL DEFAULT NS,
    TreasuryAccount TEXT(80) NULL DEFAULT NS,
    BFY TEXT(80) NULL DEFAULT NS,
    EFY TEXT(80) NULL DEFAULT NS,
    Grouping TEXT(80) NULL DEFAULT NS,
    Description TEXT(80) NULL DEFAULT NS,
    LineName TEXT(80) NULL DEFAULT NS,
    AuthorityType TEXT(80) NULL DEFAULT NS,
    Request DECIMAL NULL DEFAULT 0.0,
    Balance DECIMAL NULL DEFAULT 0.0,
    Deobligations DECIMAL NULL DEFAULT 0.0,
    Amount DECIMAL NULL DEFAULT 0.0,
    LineNumber TEXT(80) NULL DEFAULT NS,
    LineSplit TEXT(80) NULL DEFAULT NS,
    ApportionmentAccountCode TEXT(80) NULL DEFAULT NS,
    TreasuryAccountCode TEXT(80) NULL DEFAULT NS,
    TreasuryAccountName TEXT(80) NULL DEFAULT NS,
    BudgetAccountCode TEXT(80) NULL DEFAULT NS,
    BudgetAccountName TEXT(80) NULL DEFAULT NS,
    CONSTRAINT CarryoverApportionmentsPrimaryKey
            PRIMARY KEY(CarryoverApportionmentsId)
);

