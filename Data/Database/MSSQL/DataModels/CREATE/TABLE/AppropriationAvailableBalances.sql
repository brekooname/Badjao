CREATE TABLE [dbo].[AppropriationAvailableBalances]
(
	[AppropriationAvailableBalancesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AppropriationFundCode] [nvarchar](80) NULL,
	[AppropriationFundName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[Availability] [nvarchar](80) NULL,
	[TotalAuthority] [decimal](18, 0) NULL,
	[TotalUsed] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	 CONSTRAINT [AppropriationAvailableBalancesPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[AppropriationAvailableBalancesId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


