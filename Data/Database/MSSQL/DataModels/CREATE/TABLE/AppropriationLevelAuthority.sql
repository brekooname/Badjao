CREATE TABLE [dbo].[AppropriationLevelAuthority]
(
	[AppropriationLevelAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[Budgeted] [decimal](18, 0) NULL,
	[Posted] [decimal](18, 0) NULL,
	[CarryOut] [decimal](18, 0) NULL,
	[CarryIn] [decimal](18, 0) NULL,
	[EstimatedReimbursements] [decimal](18, 0) NULL,
	[EstimatedRecoveries] [decimal](18, 0) NULL,
	 CONSTRAINT [AppropriationLevelAuthorityPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[AppropriationLevelAuthorityId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


