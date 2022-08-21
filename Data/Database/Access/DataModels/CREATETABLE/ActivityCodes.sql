CREATE TABLE ActivityCodes 
(
    ActivityCodesId AUTOINCREMENT NOT NULL UNIQUE,
    Code TEXT(80) NULL DEFAULT NS,
    Name TEXT(80) NULL DEFAULT NS,
    Title TEXT(80)
    CONSTRAINT ActivityCodesPrimaryKey
        PRIMARY KEY(ActivityCodesId)
);