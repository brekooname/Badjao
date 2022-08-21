CREATE TABLE Funds 
(
    FundsId AUTOINCREMENT NOT NULL UNIQUE,
    BFY TEXT(80) NULL DEFAULT NS,
    EFY TEXT(80) NULL DEFAULT NS,
    Code TEXT(80) NULL DEFAULT NS,
    Name TEXT(80) NULL DEFAULT NS,
    ShortName TEXT(80) NULL DEFAULT NS,
    Status TEXT(80) NULL DEFAULT NS,
    SubLevelPrefix TEXT(80) NULL DEFAULT NS,
    ATA TEXT(80) NULL DEFAULT NS,
    BeginningPeriodOfAvailability TEXT(80) NULL DEFAULT NS,
    EndingPeriodOfAvailability TEXT(80) NULL DEFAULT NS,
    MAIN TEXT(80) NULL DEFAULT NS,
    A TEXT(80) NULL DEFAULT NS,
    AID TEXT(80) NULL DEFAULT NS,
    SUB TEXT(80) NULL DEFAULT NS,
    FundCategory TEXT(80) NULL DEFAULT NS,
    AppropriationCode TEXT(80) NULL DEFAULT NS,
    SubAppropriationCode TEXT(80) NULL DEFAULT NS,
    FundGroup TEXT(80) NULL DEFAULT NS,
    NoYear TEXT(80) NULL DEFAULT NS,
    Carryover TEXT(80) NULL DEFAULT NS,
    CancelledYearSpendingAccount TEXT(80) NULL DEFAULT NS,
    ApplyAtAllLevels TEXT(80) NULL DEFAULT NS,
    BatsFund TEXT(80) NULL DEFAULT NS,
    BatsEndDate TEXT(80) NULL DEFAULT NS,
    BatsOptionId TEXT(80) NULL DEFAULT NS,
    SecurityOrg TEXT(80) NULL DEFAULT NS,
    CONSTRAINT FundsPrimaryKey
        PRIMARY KEY(FundsId)
);