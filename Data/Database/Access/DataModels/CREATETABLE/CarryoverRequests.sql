CREATE TABLE CarryoverRequests 
(
    CarryoverReissuanceRequestsId AUTOINCREMENT NOT NULL UNIQUE,
    ControlTeamAnalyst TEXT(80) NULL DEFAULT NS,
    RpioCode TEXT(80) NULL DEFAULT NS,
    DocumentTitle TEXT(80) NULL DEFAULT NS,
    Amount TEXT(80) NULL DEFAULT NS,
    FundCode TEXT(80) NULL DEFAULT NS,
    Status TEXT(80) NULL DEFAULT NS,
    OriginalRequestDate TEXT(80) NULL DEFAULT NS,
    LastActivityDate TEXT(80) NULL DEFAULT NS,
    BFS TEXT(80) NULL DEFAULT NS,
    Comments TEXT(80) NULL DEFAULT NS,
    RequestDocument TEXT(80) NULL DEFAULT NS,
    Duration TEXT(80) NULL DEFAULT NS,
    CONSTAINT CarryoverReissuanceRequestsPrimaryKey
        PRIMARY KEY(CarryoverReissuanceRequestsId)
);