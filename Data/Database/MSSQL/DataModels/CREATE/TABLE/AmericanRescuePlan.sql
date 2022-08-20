CREATE TABLE [dbo].[AmericanRescuePlan]
(
	[AmericanRescuePlanId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[LowerName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[Budgeted] [decimal](18, 0) NULL,
	[Posted] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Expenditures] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Used] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	 CONSTRAINT [AmericanRescuePlanPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[AmericanRescuePlanId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[AmericanRescuePlan]  WITH CHECK ADD  CONSTRAINT [AmericanRescuePlanStatusOfFundsForeignKey] FOREIGN KEY([StatusOfFundsId])
REFERENCES [dbo].[StatusOfFunds] ([StatusOfFundsId])
GO

ALTER TABLE [dbo].[AmericanRescuePlan] CHECK CONSTRAINT [AmericanRescuePlanStatusOfFundsForeignKey]
GO

