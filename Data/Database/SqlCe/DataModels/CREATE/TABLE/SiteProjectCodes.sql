CREATE TABLE SiteProjectCodes
(
	SiteProjectCodesId INT NOT NULL IDENTITY (1,1),
    RcCode NVARCHAR(255) NULL,
    DivisionName NVARCHAR(255) NULL,
	SiteProjectCode NVARCHAR(255) NULL,
        CONSTRAINT PK_SiteProjectCodes
        PRIMARY KEY (SiteProjectCodesId)
);
