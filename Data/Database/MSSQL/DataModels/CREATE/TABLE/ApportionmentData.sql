CREATE TABLE [dbo].[ApportionmentData]
(
	[ApportionmentDataId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasuryAppropriationFundSymbol] [nvarchar](80) NULL,
	[TreasuryAppropriationFundSymbolName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
	[ApportionmentAccountName] [nvarchar](80) NULL,
	[AvailabilityType] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[ApprovalDate] [datetime] NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	 CONSTRAINT [ApportionmentDataPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[ApportionmentDataId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


