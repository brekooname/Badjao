IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'MonthlyOutlays' )
BEGIN
CREATE TABLE [dbo].[MonthlyOutlays]
(
	[MonthlyOutlaysId] INT IDENTITY(1,1) NOT NULL,
	[FiscalYear] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineNumber] VARCHAR(80) NULL DEFAULT ('NS'),
	[LineTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[TaxationCode] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAgency] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAccount] VARCHAR(80) NULL DEFAULT ('NS'),
	[SubAccount] VARCHAR(80) NULL DEFAULT ('NS'),
	[BFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[EFY] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAgency] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbBureau] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccount] VARCHAR(80) NULL DEFAULT ('NS'),
	[AgencySequence] VARCHAR(80) NULL DEFAULT ('NS'),
	[BureauSequence] VARCHAR(80) NULL DEFAULT ('NS'),
	[AccountSequence] VARCHAR(80) NULL DEFAULT ('NS'),
	[AgencyTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[BureauTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[OmbAccountTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[TreasuryAccountTitle] VARCHAR(80) NULL DEFAULT ('NS'),
	[October] MONEY NULL DEFAULT 0,
	[November] MONEY NULL DEFAULT 0,
	[December] MONEY NULL DEFAULT 0,
	[January] MONEY NULL DEFAULT 0,
	[Feburary] MONEY NULL DEFAULT 0,
	[March] MONEY NULL DEFAULT 0,
	[April] MONEY NULL DEFAULT 0,
	[May] MONEY NULL DEFAULT 0,
	[June] MONEY NULL DEFAULT 0,
	[July] MONEY NULL DEFAULT 0,
	[August] MONEY NULL DEFAULT 0,
	[September] MONEY NULL DEFAULT 0
);
END
