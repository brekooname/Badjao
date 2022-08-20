CREATE TABLE [dbo].[AnnualCarryoverSurvey]
(
	[AnnualCarryoverSurveyId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	 CONSTRAINT [AnnualCarryoverSurveyPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[AnnualCarryoverSurveyId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


