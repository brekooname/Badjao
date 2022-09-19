CREATE TABLE CompassOutlays 
(
    CompassOutlaysId AUTOINCREMENT NOT NULL UNIQUE,
    BFY TEXT(80) NULL DEFAULT NS,
    EFY TEXT(80) NULL DEFAULT NS,
    FundCode TEXT(80) NULL DEFAULT NS,
    FundName TEXT(80) NULL DEFAULT NS,
    AppropriationCode TEXT(80) NULL DEFAULT NS,
    AppropriationName TEXT(80) NULL DEFAULT NS,
    TreasurySymbol TEXT(80) NULL DEFAULT NS,
    ProgramAreaCode TEXT(80) NULL DEFAULT NS,
    ProgramAreaName TEXT(80) NULL DEFAULT NS,
    ProgramProjectCode TEXT(80) NULL DEFAULT NS,
    ProgramProjectName TEXT(80) NULL DEFAULT NS,
    BocCode TEXT(80) NULL DEFAULT NS,
    BocName TEXT(80) NULL DEFAULT NS,
    TotalObligations DOUBLE NULL DEFAULT 0.0,
    UnliquidatedObligations DOUBLE NULL DEFAULT 0.0,
    ObligationsPaid DOUBLE NULL,
    CONSTRAINT CompassOutlaysPrimaryKey
        PRIMARY KEY(CompassOutlaysId)
);