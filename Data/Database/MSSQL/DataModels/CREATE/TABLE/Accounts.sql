CREATE TABLE [dbo].[Accounts]
(
	[AccountsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[AgencyActivity] [nvarchar](80) NULL,
 CONSTRAINT [AccountsPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


