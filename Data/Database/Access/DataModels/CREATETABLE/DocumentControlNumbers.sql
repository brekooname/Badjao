CREATE TABLE DocumentControlNumbers 
(
    DocumentControlNumberId AUTOINCREMENT NOT NULL UNIQUE,
    RpioCode TEXT(80) NULL DEFAULT NS,
    RpioName TEXT(80) NULL DEFAULT NS,
    DocumentType TEXT(80) NULL DEFAULT NS,
    DocumentNumber TEXT(80) NULL DEFAULT NS,
    DocumentPrefix TEXT(80) NULL DEFAULT NS,
    DocumentControlNumber TEXT(80) NULL DEFAULT NS,
    CONSTRAINT DocumentControlNumberPrimaryKey
        PRIMARY KEY(DocumentControlNumberId)
);