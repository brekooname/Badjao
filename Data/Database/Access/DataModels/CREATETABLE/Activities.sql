CREATE TABLE Activities
(
 ActivityId INTEGER NOT NULL UNIQUE CONSTRAINT PrimaryKeyActivity PRIMARY KEY AUTOINCREMENT,
 Code TEXT(80) NOT NULL,
 Name TEXT(80) NULL DEFAULT NS,
 Title TEXT(80) NULL
);

