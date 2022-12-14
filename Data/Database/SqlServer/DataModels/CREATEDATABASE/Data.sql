USE [Data]
GO
/****** Object:  Table [dbo].[AccountingEvents]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountingEvents](
	[AccountingEventsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_AccountingEvents] PRIMARY KEY CLUSTERED 
(
	[AccountingEventsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
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
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[AccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ActivityCodes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivityCodes](
	[ActivityId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
 CONSTRAINT [PK_ActivityCodes] PRIMARY KEY CLUSTERED 
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Actuals]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actuals](
	[ActualsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[AppropriationName] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RpioActivityCode] [nvarchar](80) NULL,
	[RpioActivityName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Balance] [decimal](18, 0) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
 CONSTRAINT [PK_Actuals] PRIMARY KEY CLUSTERED 
(
	[ActualsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AdministrativeRequests]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdministrativeRequests](
	[AdministrativeRequestsId] [int] IDENTITY(1,1) NOT NULL,
	[RequestId] [int] NULL,
	[ControlTeamAnalyst] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[DocumentTitle] [nvarchar](255) NULL,
	[Amount] [decimal](18, 0) NULL,
	[FundCode] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[OriginalRequestDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Duration] [float] NULL,
	[BFS] [nvarchar](255) NULL,
	[Comments] [nvarchar](max) NULL,
	[RequestDocument] [nvarchar](max) NULL,
	[RequestType] [nvarchar](255) NULL,
	[TypeCode] [nvarchar](255) NULL,
	[Decision] [nvarchar](255) NULL,
 CONSTRAINT [PK_AdministrativeRequests] PRIMARY KEY CLUSTERED 
(
	[AdministrativeRequestsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Allocations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Allocations](
	[AllocationsId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
 CONSTRAINT [PK_Allocations] PRIMARY KEY CLUSTERED 
(
	[AllocationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AllowanceHolders]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AllowanceHolders](
	[AllowanceHoldersId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_AllowanceHolders] PRIMARY KEY CLUSTERED 
(
	[AllowanceHoldersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AmericanRescuePlan]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AmericanRescuePlan](
	[AmericanRescuePlanId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NULL,
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
 CONSTRAINT [PK_AmericanRescuePlan] PRIMARY KEY CLUSTERED 
(
	[AmericanRescuePlanId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnualCarryoverEstimates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualCarryoverEstimates](
	[CarryoverEstimatesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	[Estimate] [decimal](18, 0) NULL,
 CONSTRAINT [PK_AnnualCarryoverEstimates] PRIMARY KEY CLUSTERED 
(
	[CarryoverEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnualCarryoverSurvey]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualCarryoverSurvey](
	[CarryoverSurveyId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_AnnualCarryoverSurvey] PRIMARY KEY CLUSTERED 
(
	[CarryoverSurveyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnualReimbursableEstimates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualReimbursableEstimates](
	[ReimbursableEstimatesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	[Estimate] [decimal](18, 0) NULL,
 CONSTRAINT [PK_AnnualReimbursableEstimates] PRIMARY KEY CLUSTERED 
(
	[ReimbursableEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnnualReimbursableSurvey]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnnualReimbursableSurvey](
	[ReimbursableSurveyId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_AnnualReimbursableSurvey] PRIMARY KEY CLUSTERED 
(
	[ReimbursableSurveyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApplicationTables]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApplicationTables](
	[ApplicationTablesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Model] [nvarchar](80) NULL,
 CONSTRAINT [PK_ApplicationTables] PRIMARY KEY CLUSTERED 
(
	[ApplicationTablesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ApportionmentData]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ApportionmentData](
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
 CONSTRAINT [PK_ApportionmentData] PRIMARY KEY CLUSTERED 
(
	[ApportionmentDataId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppropriationAvailableBalances]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationAvailableBalances](
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
 CONSTRAINT [PK_AppropriationAvailableBalances] PRIMARY KEY CLUSTERED 
(
	[AppropriationAvailableBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppropriationDocuments]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationDocuments](
	[AppropriationDocumentsId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AppropriationFund] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentDate] [datetime] NULL,
	[LastDocumentDate] [datetime] NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BudgetingControls] [nvarchar](80) NULL,
	[PostingControls] [nvarchar](80) NULL,
	[PreCommitmentControls] [nvarchar](80) NULL,
	[CommitmentControls] [nvarchar](80) NULL,
	[ObligationControls] [nvarchar](80) NULL,
	[AccrualControls] [nvarchar](80) NULL,
	[ExpenditureControls] [nvarchar](80) NULL,
	[ExpenseControls] [nvarchar](80) NULL,
	[ReimbursementControls] [nvarchar](80) NULL,
	[ReimbursableAgreementControls] [nvarchar](80) NULL,
	[Budgeted] [decimal](18, 0) NULL,
	[Posted] [decimal](18, 0) NULL,
	[CarryOut] [decimal](18, 0) NULL,
	[CarryIn] [decimal](18, 0) NULL,
	[EstimatedReimbur0sements] [decimal](18, 0) NULL,
	[EstimatedRecoveries] [decimal](18, 0) NULL,
 CONSTRAINT [PK_AppropriationDocuments] PRIMARY KEY CLUSTERED 
(
	[AppropriationDocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppropriationLevelAuthority]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppropriationLevelAuthority](
	[AppropriationBalancesId] [int] IDENTITY(1,1) NOT NULL,
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
 CONSTRAINT [PK_AppropriationLevelAuthority] PRIMARY KEY CLUSTERED 
(
	[AppropriationBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appropriations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appropriations](
	[AppropriationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NOT NULL,
	[Title] [nvarchar](80) NULL,
	[PublicLaw] [nvarchar](80) NULL,
	[EnactedDate] [datetime] NULL,
 CONSTRAINT [PK_Appropriations] PRIMARY KEY CLUSTERED 
(
	[AppropriationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetaryResourceExecution]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetaryResourceExecution](
	[BudgetaryResourceExecutionId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[LastUpdate] [datetime] NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[TreasuryAgencyCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[STAT] [nvarchar](80) NULL,
	[CreditIndicator] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineDescription] [nvarchar](80) NULL,
	[SectionName] [nvarchar](80) NULL,
	[SectionNumber] [nvarchar](80) NULL,
	[LineType] [nvarchar](80) NULL,
	[FinancingAccounts] [nvarchar](80) NULL,
	[November] [decimal](18, 0) NULL,
	[January] [decimal](18, 0) NULL,
	[Feburary] [decimal](18, 0) NULL,
	[April] [decimal](18, 0) NULL,
	[May] [decimal](18, 0) NULL,
	[June] [decimal](18, 0) NULL,
	[August] [decimal](18, 0) NULL,
	[October] [decimal](18, 0) NULL,
	[Amount1] [decimal](18, 0) NULL,
	[Amount2] [decimal](18, 0) NULL,
	[Amount3] [decimal](18, 0) NULL,
	[Amount4] [decimal](18, 0) NULL,
	[Agency] [nvarchar](80) NULL,
	[Bureau] [nvarchar](80) NULL,
 CONSTRAINT [PK_BudgetaryResourceExecution] PRIMARY KEY CLUSTERED 
(
	[BudgetaryResourceExecutionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetControls]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetControls](
	[BudgetControlsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[BudgetedTransType] [nvarchar](80) NULL,
	[PostedTransType] [nvarchar](80) NULL,
	[EstimatedReimbursementsTransType] [nvarchar](80) NULL,
	[SpendingAdjustmentTransType] [nvarchar](80) NULL,
	[EstimatedRecoveriesTransType] [nvarchar](80) NULL,
	[ActualRecoveriesTransType] [nvarchar](80) NULL,
	[StatusReserveTransType] [nvarchar](80) NULL,
	[ProfitLossTransType] [nvarchar](80) NULL,
	[EstimatedReimbursementsSpendingOption] [nvarchar](80) NULL,
	[EstimatedReimursementsBudgetingOption] [nvarchar](80) NULL,
	[TrackAgreementLowerLevel] [nvarchar](80) NULL,
	[BudgetEstimatedLowerLevel] [nvarchar](80) NULL,
	[EstimatedRecoveriesSpendingOption] [nvarchar](80) NULL,
	[EstimatedRecoveriesBudgetingOption] [nvarchar](80) NULL,
	[RecoveryNextLevel] [nvarchar](80) NULL,
	[RecoveryBudgetMismatch] [nvarchar](80) NULL,
	[ProfitLossSpendingOption] [nvarchar](80) NULL,
	[ProfitLossBudgetOption] [nvarchar](80) NULL,
	[RecoveriesCarryInLowerLevel] [nvarchar](80) NULL,
	[RecoveriesCarryInLowerLevelControl] [nvarchar](80) NULL,
	[RecoveriesCarryInAmountControl] [nvarchar](80) NULL,
	[BudgetedControl] [nvarchar](80) NULL,
	[PostedControl] [nvarchar](80) NULL,
	[PreCommitmentSpendingControl] [nvarchar](80) NULL,
	[CommitmentSpendingControl] [nvarchar](80) NULL,
	[ObligationSpendingControl] [nvarchar](80) NULL,
	[AccrualSpendingControl] [nvarchar](80) NULL,
	[ExpenditureSpendingControl] [nvarchar](80) NULL,
	[ExpenseSpendingControl] [nvarchar](80) NULL,
	[ReimbursableSpendingControl] [nvarchar](80) NULL,
	[ReimbursableAgreementSpendingControl] [nvarchar](80) NULL,
	[FteBudgetingControl] [nvarchar](80) NULL,
	[FteSpendingControl] [nvarchar](80) NULL,
	[TransactionTypeControl] [nvarchar](80) NULL,
	[AuthorityDistributionControl] [nvarchar](80) NULL,
 CONSTRAINT [PK_BudgetControls] PRIMARY KEY CLUSTERED 
(
	[BudgetControlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetDocuments]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetDocuments](
	[BudgetDocumentsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[DocumentDate] [datetime] NULL,
	[LastDocumentDate] [datetime] NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ReimbursableAgreementControls] [nvarchar](80) NULL,
	[BudgetingControls] [nvarchar](80) NULL,
	[PostingControls] [nvarchar](80) NULL,
	[PreCommitmentControls] [nvarchar](80) NULL,
	[CommitmentControls] [nvarchar](80) NULL,
	[ObligationControls] [nvarchar](80) NULL,
	[ExpenditureControls] [nvarchar](80) NULL,
	[ExpenseControls] [nvarchar](80) NULL,
	[AccrualControls] [nvarchar](80) NULL,
	[ReimbursementControls] [nvarchar](80) NULL,
	[Budgeted] [decimal](18, 0) NULL,
	[Posted] [decimal](18, 0) NULL,
	[CarryOut] [decimal](18, 0) NULL,
	[CarryIn] [decimal](18, 0) NULL,
	[EstimatedRecoveries] [decimal](18, 0) NULL,
	[EstimatedReimbursements] [decimal](18, 0) NULL,
 CONSTRAINT [PK_BudgetDocuments] PRIMARY KEY CLUSTERED 
(
	[BudgetDocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetObjectClasses]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetObjectClasses](
	[BudgetObjectClassesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_BudgetObjectClasses] PRIMARY KEY CLUSTERED 
(
	[BudgetObjectClassesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BudgetOutlays]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BudgetOutlays](
	[BudgetOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[AgencyName] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[Line] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineSection] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[BeaCategory] [nvarchar](80) NULL,
	[BeaCategoryName] [nvarchar](80) NULL,
	[LineCategory] [nvarchar](80) NULL,
	[PriorYear] [decimal](18, 0) NULL,
	[CurrentYear] [decimal](18, 0) NULL,
	[BudgetYear] [decimal](18, 0) NULL,
	[OutYear1] [decimal](18, 0) NULL,
	[OutYear2] [decimal](18, 0) NULL,
	[OutYear3] [decimal](18, 0) NULL,
	[OutYear4] [decimal](18, 0) NULL,
	[OutYear5] [decimal](18, 0) NULL,
	[OutYear6] [decimal](18, 0) NULL,
	[OutYear7] [decimal](18, 0) NULL,
	[OutYear8] [decimal](18, 0) NULL,
	[OutYear9] [decimal](18, 0) NULL,
 CONSTRAINT [PK_BudgetOutlays] PRIMARY KEY CLUSTERED 
(
	[BudgetOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CapitalPlanningInvestmentCodes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapitalPlanningInvestmentCodes](
	[CapitalPlanningInvestmentCodesId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_CPIC] PRIMARY KEY CLUSTERED 
(
	[CapitalPlanningInvestmentCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarryoverApportionments]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarryoverApportionments](
	[CarryoverApportionmentsId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetAccount] [nvarchar](80) NULL,
	[TreasuryAccount] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[Group] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[AuthorityType] [nvarchar](80) NULL,
	[Request] [decimal](18, 0) NULL,
	[Balance] [decimal](18, 0) NULL,
	[Deobligations] [decimal](18, 0) NULL,
	[Amount] [decimal](18, 0) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineSplit] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
 CONSTRAINT [PK_CarryoverApportionments] PRIMARY KEY CLUSTERED 
(
	[CarryoverApportionmentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarryoverRequests]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarryoverRequests](
	[CarryoverRequestsId] [int] IDENTITY(1,1) NOT NULL,
	[ControlTeamAnalyst] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[DocumentTitle] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[FundCode] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[OriginalRequestDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[BFS] [nvarchar](80) NULL,
	[Comments] [nvarchar](max) NULL,
	[RequestDocument] [nvarchar](max) NULL,
	[Duration] [int] NULL,
 CONSTRAINT [PK_CarryoverRequests] PRIMARY KEY CLUSTERED 
(
	[CarryoverRequestsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Changes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Changes](
	[ChangesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[FieldName] [nvarchar](80) NULL,
	[Action] [nvarchar](80) NULL,
	[OldValue] [nvarchar](80) NULL,
	[NewValue] [nvarchar](80) NULL,
	[TimeStamp] [datetime] NULL,
	[Message] [nvarchar](80) NULL,
 CONSTRAINT [PK_Changes] PRIMARY KEY CLUSTERED 
(
	[ChangesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompassLevels]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompassLevels](
	[CompassLevelsId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[AppropriationName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[PostedControlFlag] [nvarchar](80) NULL,
	[ActualRecoveryTransType] [nvarchar](80) NULL,
	[CommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[BudgetDefault] [nvarchar](80) NULL,
	[LowerChildExpenditureSpendingControlFlag] [nvarchar](80) NULL,
	[LowerChildExpenseSpendingControlFlag] [nvarchar](80) NULL,
	[FteControlFlag] [nvarchar](80) NULL,
	[AccrualSpendingControlFlag] [nvarchar](80) NULL,
	[ObligationSpendingControlFlag] [nvarchar](80) NULL,
	[PreCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[LowerCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[LowerObligationSpendingControlFlag] [nvarchar](80) NULL,
	[LowerExpenditureSpendingControlFlag] [nvarchar](80) NULL,
	[LowerExpenseSpendingControlFlag] [nvarchar](80) NULL,
	[LowerPostedControlFlag] [nvarchar](80) NULL,
	[LowerPostedTransType] [nvarchar](80) NULL,
	[LowerTransType] [nvarchar](80) NULL,
	[LowerPostedFlag] [nvarchar](80) NULL,
	[LowerPreCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[LowerRecoveriesSpendingOption] [nvarchar](80) NULL,
	[LowerRecoveriesOption] [nvarchar](80) NULL,
	[LowerReimbursableSpendingOption] [nvarchar](80) NULL,
	[Date] [datetime] NULL,
	[TotalAuthority] [decimal](18, 0) NULL,
	[OriginalAmount] [decimal](18, 0) NULL,
	[CarryoverAvailabilityPercentage] [decimal](18, 0) NULL,
	[CarryIn] [decimal](18, 0) NULL,
	[CarryOut] [decimal](18, 0) NULL,
	[FundsIn] [decimal](18, 0) NULL,
	[FundsOut] [decimal](18, 0) NULL,
	[RecoveriesWithdrawn] [decimal](18, 0) NULL,
	[ActualRecoveries] [decimal](18, 0) NULL,
	[ActualReimbursements] [decimal](18, 0) NULL,
	[AgreementReimbursables] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CompassLevels] PRIMARY KEY CLUSTERED 
(
	[CompassLevelsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompassOutlays]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompassOutlays](
	[CompassOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[AppropriationName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[TotalObligations] [decimal](18, 0) NULL,
	[UnliquidatedObligations] [decimal](18, 0) NULL,
	[ObligationsPaid] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CompassOutlays] PRIMARY KEY CLUSTERED 
(
	[CompassOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongressionalControls]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongressionalControls](
	[CongressionalControlsId] [int] IDENTITY(1,1) NOT NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[SubProjectCode] [nvarchar](80) NULL,
	[SubProjectName] [nvarchar](80) NULL,
	[ReprogrammingRestriction] [nvarchar](80) NULL,
	[IncreaseRestriction] [nvarchar](80) NULL,
	[DecreaseRestriction] [nvarchar](80) NULL,
	[MemoRequirement] [nvarchar](80) NULL,
 CONSTRAINT [PK_CongressionalControls] PRIMARY KEY CLUSTERED 
(
	[CongressionalControlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CongressionalReprogrammings]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongressionalReprogrammings](
	[CongressionalReprogrammingsId] [int] IDENTITY(1,1) NOT NULL,
	[ReprogrammingNumber] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[Description] [nvarchar](155) NULL,
	[ExtendedDescription] [nvarchar](max) NULL,
	[FromTo] [nvarchar](80) NULL,
	[Cycle] [nvarchar](80) NULL,
 CONSTRAINT [PK_CongressionalReprogrammings] PRIMARY KEY CLUSTERED 
(
	[CongressionalReprogrammingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ContactsId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](80) NULL,
	[LastName] [nvarchar](80) NULL,
	[FullName] [nvarchar](80) NULL,
	[Email] [nvarchar](80) NULL,
	[RPIO] [nvarchar](80) NULL,
	[Section] [nvarchar](80) NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ContactsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CostAreas]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CostAreas](
	[CostAreasId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_CostAreas] PRIMARY KEY CLUSTERED 
(
	[CostAreasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataRuleDescriptions]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataRuleDescriptions](
	[DataRuleDescriptionsId] [int] IDENTITY(1,1) NOT NULL,
	[Schedule] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[RuleNumber] [nvarchar](80) NULL,
	[RuleDescription] [nvarchar](max) NULL,
	[ScheduleOrder] [nvarchar](80) NULL,
 CONSTRAINT [PK_DataRuleDescriptions] PRIMARY KEY CLUSTERED 
(
	[DataRuleDescriptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Defactos]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Defactos](
	[DefactosId] [int] NOT NULL,
	[StatusOfFundsId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](255) NULL,
	[BFY] [nvarchar](255) NULL,
	[EFY] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[RpioName] [nvarchar](255) NULL,
	[AhCode] [nvarchar](255) NULL,
	[AhName] [nvarchar](255) NULL,
	[FundCode] [nvarchar](255) NULL,
	[FundName] [nvarchar](255) NULL,
	[OrgCode] [nvarchar](255) NULL,
	[OrgName] [nvarchar](255) NULL,
	[AccountCode] [nvarchar](255) NULL,
	[RcCode] [nvarchar](255) NULL,
	[BocCode] [nvarchar](255) NULL,
	[BocName] [nvarchar](255) NULL,
	[ProgramProjectCode] [nvarchar](255) NULL,
	[ProgramProjectName] [nvarchar](255) NULL,
	[ProgramAreaCode] [nvarchar](255) NULL,
	[ProgramAreaName] [nvarchar](255) NULL,
	[RcName] [nvarchar](255) NULL,
	[LowerName] [nvarchar](255) NULL,
	[Amount] [money] NULL,
	[Budgeted] [money] NULL,
	[Posted] [money] NULL,
	[OpenCommitments] [money] NULL,
	[ULO] [money] NULL,
	[Expenditures] [money] NULL,
	[Obligations] [money] NULL,
	[Used] [money] NULL,
	[Available] [money] NULL,
	[NpmCode] [nvarchar](255) NULL,
	[NpmName] [nvarchar](255) NULL,
 CONSTRAINT [PK_Defactos] PRIMARY KEY CLUSTERED 
(
	[DefactosId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deobligations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deobligations](
	[DeobligationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Deobligations] PRIMARY KEY CLUSTERED 
(
	[DeobligationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentControlNumbers]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentControlNumbers](
	[DocumentControlNumbersId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentPrefix] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
 CONSTRAINT [PK_DocumentControlNumbers] PRIMARY KEY CLUSTERED 
(
	[DocumentControlNumbersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Documents]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[DocumentsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Category] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[System] [nvarchar](80) NULL,
 CONSTRAINT [PK_Documents] PRIMARY KEY CLUSTERED 
(
	[DocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Earmarks]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Earmarks](
	[EarmarksId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[StateCode] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ProjectOfficerLastName] [nvarchar](80) NULL,
	[ProjectOfficerFirstName] [nvarchar](80) NULL,
	[ProjectOfficerPhoneNumber] [nvarchar](80) NULL,
	[ProjectOfficerMailCode] [nvarchar](80) NULL,
	[CommitmentDate] [datetime] NULL,
	[ObligationDate] [datetime] NULL,
	[ProjectStatus] [nvarchar](80) NULL,
	[ProjectOfficerComments] [nvarchar](80) NULL,
 CONSTRAINT [PK_Earmarks] PRIMARY KEY CLUSTERED 
(
	[EarmarksId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExecutionTables]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExecutionTables](
	[ExecutionTablesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
 CONSTRAINT [PK_ExecutionTables] PRIMARY KEY CLUSTERED 
(
	[ExecutionTablesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenditures]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenditures](
	[ExpendituresId] [int] IDENTITY(1,1) NOT NULL,
	[ObligationsId] [int] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](255) NULL,
	[ProcessedDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Age] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Expenditures] PRIMARY KEY CLUSTERED 
(
	[ExpendituresId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FederalHolidays]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FederalHolidays](
	[FederalHolidaysId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[Columbus] [datetime] NULL,
	[Veterans] [datetime] NULL,
	[Thanksgiving] [datetime] NULL,
	[Christmas] [datetime] NULL,
	[NewYears] [datetime] NULL,
	[MartinLutherKing] [datetime] NULL,
	[Washingtons] [datetime] NULL,
	[Memorial] [datetime] NULL,
	[Juneteenth] [datetime] NULL,
	[Independence] [datetime] NULL,
	[Labor] [datetime] NULL,
 CONSTRAINT [PK_FederalHolidays] PRIMARY KEY CLUSTERED 
(
	[FederalHolidaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinanceObjectClasses]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinanceObjectClasses](
	[FinanceObjectClassesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
 CONSTRAINT [PK_FinanceObjectClasses] PRIMARY KEY CLUSTERED 
(
	[FinanceObjectClassesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FiscalYears]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalYears](
	[FiscalYearsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NOT NULL,
	[EFY] [nvarchar](80) NULL,
	[StartDate] [nvarchar](80) NULL,
	[Columbus] [datetime] NULL,
	[Veterans] [datetime] NULL,
	[Thanksgiving] [datetime] NULL,
	[Christmas] [datetime] NULL,
	[NewYears] [datetime] NULL,
	[MartinLutherKing] [datetime] NULL,
	[Washingtons] [datetime] NULL,
	[Memorial] [datetime] NULL,
	[Juneteenth] [datetime] NULL,
	[Independence] [datetime] NULL,
	[Labor] [datetime] NULL,
	[ExpiringYear] [nvarchar](80) NULL,
	[ExpirationDate] [nvarchar](80) NULL,
	[WorkDays] [float] NULL,
	[WeekDays] [float] NULL,
	[WeekEnds] [float] NULL,
	[EndDate] [nvarchar](80) NULL,
	[Availability] [nvarchar](80) NULL,
 CONSTRAINT [PK_FiscalYears] PRIMARY KEY CLUSTERED 
(
	[FiscalYearsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FiscalYearsBackUp]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FiscalYearsBackUp](
	[FiscalYearsBackUpId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYearsId] [int] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FirstYear] [nvarchar](80) NULL,
	[LastYear] [nvarchar](80) NULL,
	[ExpiringYear] [nvarchar](80) NULL,
	[CalendarYearStartDate] [datetime] NULL,
	[FiscalYearStartDate] [datetime] NULL,
	[CalendarYearEndDate] [datetime] NULL,
	[FiscalYearEndDate] [datetime] NULL,
	[ExpirationDate] [datetime] NULL,
	[Availability] [nvarchar](80) NULL,
	[NewYears] [datetime] NULL,
	[MartinLutherKing] [datetime] NULL,
	[Presidents] [datetime] NULL,
	[Memorial] [datetime] NULL,
	[Juneteeth] [datetime] NULL,
	[Independence] [datetime] NULL,
	[Labor] [datetime] NULL,
	[Columbus] [datetime] NULL,
	[Veterans] [datetime] NULL,
	[Thanksgiving] [datetime] NULL,
	[Christmas] [datetime] NULL,
	[WorkDays] [int] NULL,
	[WeekDays] [int] NULL,
	[WeekEnds] [int] NULL,
 CONSTRAINT [PK_FiscalYearsBackUp] PRIMARY KEY CLUSTERED 
(
	[FiscalYearsBackUpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FullTimeEquivalents]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FullTimeEquivalents](
	[FullTimeEquivialentsId] [int] IDENTITY(1,1) NOT NULL,
	[OperatingPlansId] [int] NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ITProjectCode] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProjectTypeName] [nvarchar](80) NULL,
	[ProjectTypeCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[LocalCode] [nvarchar](80) NULL,
	[LocalCodeName] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[CostAreaCode] [nvarchar](80) NULL,
	[CostAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
 CONSTRAINT [PK_FullTimeEquivalents] PRIMARY KEY CLUSTERED 
(
	[FullTimeEquivialentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Funds]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funds](
	[FundsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[ShortName] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[SubLevelPrefix] [nvarchar](80) NULL,
	[ATA] [nvarchar](80) NULL,
	[AID] [nvarchar](80) NULL,
	[BeginningPeriodOfAvailability] [nvarchar](80) NULL,
	[EndingPeriodOfAvailability] [nvarchar](80) NULL,
	[A] [nvarchar](80) NULL,
	[MAIN] [nvarchar](80) NULL,
	[SUB] [nvarchar](80) NULL,
	[FundCategory] [nvarchar](80) NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[FundGroup] [nvarchar](80) NULL,
	[NoYear] [nvarchar](80) NULL,
	[Carryover] [nvarchar](80) NULL,
	[AllowSpendAgainstCanceled] [nvarchar](80) NULL,
	[AllowNewSpendAgainstExpired] [nvarchar](80) NULL,
	[CanceledYearSpendingAccount] [nvarchar](80) NULL,
	[ApplyAtAllLevels] [nvarchar](80) NULL,
	[BatsFund] [nvarchar](80) NULL,
	[BatsEndDate] [nvarchar](80) NULL,
	[BatsOptionId] [nvarchar](80) NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
 CONSTRAINT [PK_Funds] PRIMARY KEY CLUSTERED 
(
	[FundsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FundSymbols]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FundSymbols](
	[FundSymbolsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
 CONSTRAINT [PK_FundSymbols] PRIMARY KEY CLUSTERED 
(
	[FundSymbolsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goals]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goals](
	[GoalsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[Title] [nvarchar](80) NULL,
 CONSTRAINT [PK_Goals] PRIMARY KEY CLUSTERED 
(
	[GoalsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GrowthRates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrowthRates](
	[GrowthRatesId] [int] NOT NULL,
	[RateId] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPTION] [nvarchar](80) NULL,
	[BudgetYearRate] [decimal](18, 0) NULL,
	[OutYear1] [decimal](18, 0) NULL,
	[OutYear2] [decimal](18, 0) NULL,
	[OutYear3] [decimal](18, 0) NULL,
	[OutYear4] [decimal](18, 0) NULL,
	[OutYear5] [decimal](18, 0) NULL,
	[OutYear6] [decimal](18, 0) NULL,
	[OutYear7] [decimal](18, 0) NULL,
	[OutYear8] [decimal](18, 0) NULL,
	[OutYear9] [decimal](18, 0) NULL,
	[Sort] [nvarchar](80) NULL,
 CONSTRAINT [PK_GrowthRates] PRIMARY KEY CLUSTERED 
(
	[GrowthRatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GsPayScales]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GsPayScales](
	[GsPayScalesId] [int] IDENTITY(1,1) NOT NULL,
	[LOCNAME] [nvarchar](80) NULL,
	[GRADE] [float] NULL,
	[ANNUAL1] [float] NULL,
	[HOURLY1] [nvarchar](80) NULL,
	[OVERTIME1] [nvarchar](80) NULL,
	[ANNUAL2] [float] NULL,
	[HOURLY2] [nvarchar](80) NULL,
	[OVERTIME2] [nvarchar](80) NULL,
	[ANNUAL3] [float] NULL,
	[HOURLY3] [nvarchar](80) NULL,
	[OVERTIME3] [nvarchar](80) NULL,
	[ANNUAL4] [float] NULL,
	[HOURLY4] [nvarchar](80) NULL,
	[OVERTIME4] [nvarchar](80) NULL,
	[ANNUAL5] [float] NULL,
	[HOURLY5] [nvarchar](80) NULL,
	[OVERTIME5] [nvarchar](80) NULL,
	[ANNUAL6] [float] NULL,
	[HOURLY6] [nvarchar](80) NULL,
	[OVERTIME6] [nvarchar](80) NULL,
	[ANNUAL7] [float] NULL,
	[HOURLY7] [nvarchar](80) NULL,
	[OVERTIME7] [nvarchar](80) NULL,
	[ANNUAL8] [float] NULL,
	[HOURLY8] [nvarchar](80) NULL,
	[OVERTIME8] [nvarchar](80) NULL,
	[ANNUAL9] [float] NULL,
	[HOURLY9] [nvarchar](80) NULL,
	[OVERTIME9] [nvarchar](80) NULL,
	[ANNUAL10] [float] NULL,
	[HOURLY10] [nvarchar](80) NULL,
	[OVERTIME10] [nvarchar](80) NULL,
 CONSTRAINT [PK_GsPayScales] PRIMARY KEY CLUSTERED 
(
	[GsPayScalesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeadquartersAuthority]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeadquartersAuthority](
	[HeadquartersAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[AllocationsId] [int] NULL,
	[StatusOfFundsId] [int] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
 CONSTRAINT [PK_HeadquartersAuthority] PRIMARY KEY CLUSTERED 
(
	[HeadquartersAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeadquartersOffices]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeadquartersOffices](
	[HeadquartersOfficesId] [int] IDENTITY(1,1) NOT NULL,
	[ResourcePlanningOfficesId] [int] NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_HeadquartersOffices] PRIMARY KEY CLUSTERED 
(
	[HeadquartersOfficesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HumanResourceOrganizations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HumanResourceOrganizations](
	[HumanResourceOrganizationsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_HumanResourceOrganizations] PRIMARY KEY CLUSTERED 
(
	[HumanResourceOrganizationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[ImagesId] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](80) NULL,
	[FilePath] [nvarchar](80) NULL,
	[FileExtension] [nvarchar](80) NULL,
	[ImageFile] [image] NULL,
	[Attachments] [nvarchar](80) NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[ImagesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InfrastructureAccounts]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InfrastructureAccounts](
	[InfrastructureAccountsId] [int] IDENTITY(1,1) NOT NULL,
	[StrategicPlan] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramName] [nvarchar](80) NULL,
	[ProgramDescription] [nvarchar](80) NULL,
 CONSTRAINT [PK_InfrastructureAccounts] PRIMARY KEY CLUSTERED 
(
	[InfrastructureAccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobsActCarryoverEstimates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobsActCarryoverEstimates](
	[CarryoverEstimatesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	[Estimate] [decimal](18, 0) NULL,
 CONSTRAINT [PK_JobsActCarryoverEstimates] PRIMARY KEY CLUSTERED 
(
	[CarryoverEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LedgerAccounts]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LedgerAccounts](
	[LedgerAccountsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[AccountNumber] [nvarchar](80) NULL,
	[AccountName] [nvarchar](80) NULL,
	[BeginningBalance] [decimal](18, 0) NULL,
	[CreditBalance] [decimal](18, 0) NULL,
	[DebitBalance] [decimal](18, 0) NULL,
	[ClosingAmount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_LedgerAccounts] PRIMARY KEY CLUSTERED 
(
	[LedgerAccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Messages]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messages](
	[MessagesId] [int] IDENTITY(1,1) NOT NULL,
	[Message] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
	[Form] [nvarchar](80) NULL,
 CONSTRAINT [PK_Messages] PRIMARY KEY CLUSTERED 
(
	[MessagesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonthlyLedgerAccountBalances]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonthlyLedgerAccountBalances](
	[MonthlyLedgerAccountBalancesId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[LedgerAccount] [nvarchar](80) NULL,
	[LedgerName] [nvarchar](80) NULL,
	[ApportionmentAccountCode] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[TreasurySymbolName] [nvarchar](80) NULL,
	[BudgetAccountCode] [nvarchar](80) NULL,
	[BudgetAccountName] [nvarchar](80) NULL,
	[FiscalMonth] [nvarchar](80) NULL,
	[CreditBalance] [decimal](18, 0) NULL,
	[DebitBalance] [decimal](18, 0) NULL,
	[YearToDateAmount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_MonthlyLedgerAccountBalances] PRIMARY KEY CLUSTERED 
(
	[MonthlyLedgerAccountBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MonthlyOutlays]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonthlyOutlays](
	[MonthlyOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineTitle] [nvarchar](80) NULL,
	[TaxationCode] [nvarchar](80) NULL,
	[TreasuryAgencyCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[SubAccount] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbBureauCode] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[AgencySequence] [nvarchar](80) NULL,
	[BureauSequence] [nvarchar](80) NULL,
	[AccountSequence] [nvarchar](80) NULL,
	[AgencyTitle] [nvarchar](80) NULL,
	[BureauTitle] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[TreasuryAccountName] [nvarchar](80) NULL,
	[October] [decimal](18, 0) NULL,
	[November] [decimal](18, 0) NULL,
	[December] [decimal](18, 0) NULL,
	[January] [decimal](18, 0) NULL,
	[Feburary] [decimal](18, 0) NULL,
	[March] [decimal](18, 0) NULL,
	[April] [decimal](18, 0) NULL,
	[May] [decimal](18, 0) NULL,
	[June] [decimal](18, 0) NULL,
	[July] [decimal](18, 0) NULL,
	[August] [decimal](18, 0) NULL,
	[September] [decimal](18, 0) NULL,
 CONSTRAINT [PK_MonthlyOutlays] PRIMARY KEY CLUSTERED 
(
	[MonthlyOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NationalPrograms]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NationalPrograms](
	[NationalProgramsId] [int] NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NULL,
	[RpioCode] [nvarchar](255) NULL,
	[Title] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ObjectClassOutlays]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectClassOutlays](
	[ObjectClassOutlaysId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbAgencyName] [nvarchar](80) NULL,
	[OmbBureauCode] [nvarchar](80) NULL,
	[OmbBureauName] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ObligationType] [nvarchar](80) NULL,
	[DirectReimbursableTitle] [nvarchar](80) NULL,
	[ObjectClassGroupNumber] [nvarchar](80) NULL,
	[ObjectClassGroupName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FinanceObjectClass] [nvarchar](255) NULL,
	[PriorYear] [decimal](18, 0) NULL,
	[CurrentYear] [decimal](18, 0) NULL,
	[BudgetYear] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ObjectClassOutlays] PRIMARY KEY CLUSTERED 
(
	[ObjectClassOutlaysId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Objectives]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Objectives](
	[ObjectivesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[Title] [nvarchar](80) NULL,
 CONSTRAINT [PK_Objectives] PRIMARY KEY CLUSTERED 
(
	[ObjectivesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Obligations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Obligations](
	[ObligationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Age] [decimal](18, 0) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Expenditures] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Obligations] PRIMARY KEY CLUSTERED 
(
	[ObligationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OMB]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OMB](
	[OmbId] [int] IDENTITY(1,1) NOT NULL,
	[AccountNumber] [nvarchar](80) NULL,
	[AccountName] [nvarchar](80) NULL,
	[AgencyName] [nvarchar](80) NULL,
	[BureauName] [nvarchar](80) NULL,
 CONSTRAINT [PK_OMB] PRIMARY KEY CLUSTERED 
(
	[OmbId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpenCommitments]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpenCommitments](
	[OpenCommitmentsId] [int] IDENTITY(1,1) NOT NULL,
	[ObligationsId] [int] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Age] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_OpenCommitments] PRIMARY KEY CLUSTERED 
(
	[OpenCommitmentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperatingPlans]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperatingPlans](
	[OperatingPlansId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ITProjectCode] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProjectTypeName] [nvarchar](80) NULL,
	[ProjectTypeCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[LocalCode] [nvarchar](80) NULL,
	[LocalCodeName] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[CostAreaCode] [nvarchar](80) NULL,
	[CostAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
 CONSTRAINT [PK_OperatingPlans] PRIMARY KEY CLUSTERED 
(
	[OperatingPlansId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperatingPlanUpdates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperatingPlanUpdates](
	[OperatingPlanUpdatesId] [int] IDENTITY(1,1) NOT NULL,
	[OppId] [int] NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[ActivityName] [nvarchar](80) NULL,
	[DivisionName] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[GoalCode] [nvarchar](80) NULL,
	[GoalName] [nvarchar](80) NULL,
	[ObjectiveCode] [nvarchar](80) NULL,
	[ObjectiveName] [nvarchar](80) NULL,
 CONSTRAINT [PK_OperatingPlanUpdates] PRIMARY KEY CLUSTERED 
(
	[OperatingPlanUpdatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Organizations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Organizations](
	[OrganizationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[PreventNewUse] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[Usage] [nvarchar](80) NULL,
	[UseAsCostOrg] [nvarchar](80) NULL,
	[SubCodeRequired] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[SubRcCode] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
 CONSTRAINT [PK_Organizations] PRIMARY KEY CLUSTERED 
(
	[OrganizationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayPeriods]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayPeriods](
	[PayPeriodsId] [int] IDENTITY(1,1) NOT NULL,
	[Period] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_PayPeriods] PRIMARY KEY CLUSTERED 
(
	[PayPeriodsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayrollActivity]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollActivity](
	[PayrollActivityId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[SubRcCode] [nvarchar](80) NULL,
	[SubRcName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[HrOrgCode] [nvarchar](80) NULL,
	[HrOrgName] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[CheckDate] [datetime] NULL,
	[Amount] [decimal](18, 0) NULL,
	[Hours] [decimal](18, 0) NULL,
	[BasePaid] [decimal](18, 0) NULL,
	[BaseHours] [decimal](18, 0) NULL,
	[Benefits] [decimal](18, 0) NULL,
	[OvertimePaid] [decimal](18, 0) NULL,
	[OvertimeHours] [decimal](18, 0) NULL,
 CONSTRAINT [PK_PayrollActivity] PRIMARY KEY CLUSTERED 
(
	[PayrollActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayrollAuthority]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollAuthority](
	[PayrollAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[AllocationsId] [int] NULL,
	[StatusOfFundsId] [int] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
 CONSTRAINT [PK_PayrollAuthority] PRIMARY KEY CLUSTERED 
(
	[PayrollAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayrollCostCodes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollCostCodes](
	[PayrollCostCodesId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[SubRcCode] [nvarchar](80) NULL,
	[SubRcName] [nvarchar](80) NULL,
	[HrOrgCode] [nvarchar](80) NULL,
	[HrOrgName] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
 CONSTRAINT [PK_PayrollCostCodes] PRIMARY KEY CLUSTERED 
(
	[PayrollCostCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PayrollRequests]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PayrollRequests](
	[PayrollRequestsId] [int] IDENTITY(1,1) NOT NULL,
	[ControlTeamAnalyst] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[DocumentTitle] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[FundCode] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[OriginalRequestDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[BFS] [nvarchar](80) NULL,
	[Comments] [nvarchar](80) NULL,
	[RequestDocument] [nvarchar](max) NULL,
	[Duration] [int] NULL,
 CONSTRAINT [PK_PayrollRequests] PRIMARY KEY CLUSTERED 
(
	[PayrollRequestsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramAreas]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramAreas](
	[ProgramAreasId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramAreas] PRIMARY KEY CLUSTERED 
(
	[ProgramAreasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramFinancingSchedule]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramFinancingSchedule](
	[ProgramFinancingScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[TreasuryAgencyCode] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[LedgerAccountCode] [nvarchar](80) NULL,
	[SectionNumber] [nvarchar](80) NULL,
	[SectionName] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[LineDescription] [nvarchar](80) NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbFundCode] [nvarchar](80) NULL,
	[OmbAccountTitle] [nvarchar](80) NULL,
	[AgencySequence] [nvarchar](80) NULL,
	[AccountSequence] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OriginalAmount] [decimal](18, 0) NULL,
	[BudgetAmount] [decimal](18, 0) NULL,
	[AgencyAmount] [decimal](18, 0) NULL,
	[Amount] [decimal](18, 0) NULL,
	[AgencyName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramFinancingSchedule] PRIMARY KEY CLUSTERED 
(
	[ProgramFinancingScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramProjectDescriptions]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramProjectDescriptions](
	[ProgramProjectDescriptionsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[ProgramTitle] [nvarchar](80) NULL,
	[Laws] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramProjectDescriptions] PRIMARY KEY CLUSTERED 
(
	[ProgramProjectDescriptionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramProjects]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramProjects](
	[ProgramProjectsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProgramProjects] PRIMARY KEY CLUSTERED 
(
	[ProgramProjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectCostCodes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectCostCodes](
	[ProjectCostCodesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
 CONSTRAINT [PK_ProjectCostCodes] PRIMARY KEY CLUSTERED 
(
	[ProjectCostCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Projects]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Projects](
	[ProjectsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_Projects] PRIMARY KEY CLUSTERED 
(
	[ProjectsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[ProvidersId] [int] IDENTITY(1,1) NOT NULL,
	[ProviderName] [nvarchar](80) NULL,
	[FileExtension] [nvarchar](80) NULL,
	[Connection] [nvarchar](80) NULL,
	[Properties] [nvarchar](80) NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[ProvidersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PublicLaws]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PublicLaws](
	[PublicLawsId] [int] IDENTITY(1,1) NOT NULL,
	[LawNumber] [nvarchar](80) NULL,
	[BillTitle] [nvarchar](80) NULL,
	[EnactedDate] [datetime] NULL,
	[Congress] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
 CONSTRAINT [PK_PublicLaws] PRIMARY KEY CLUSTERED 
(
	[PublicLawsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QueryDefinitions]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QueryDefinitions](
	[QueryDefinitionsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
 CONSTRAINT [PK_QueryDefinitions] PRIMARY KEY CLUSTERED 
(
	[QueryDefinitionsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecoveryAct]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecoveryAct](
	[RecoveryActId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ARRA] PRIMARY KEY CLUSTERED 
(
	[RecoveryActId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReferenceTables]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReferenceTables](
	[ReferenceTablesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Type] [nvarchar](80) NULL,
 CONSTRAINT [PK_ReferenceTables] PRIMARY KEY CLUSTERED 
(
	[ReferenceTablesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegionalAuthority]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegionalAuthority](
	[RegionalAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[AllocationsId] [int] NULL,
	[StatusOfFundsId] [int] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
 CONSTRAINT [PK_RegionalAuthority] PRIMARY KEY CLUSTERED 
(
	[RegionalAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegionalOffices]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegionalOffices](
	[RegionalOfficesId] [int] IDENTITY(1,1) NOT NULL,
	[ResourcePlanningOfficesId] [int] NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_RegionalOffices] PRIMARY KEY CLUSTERED 
(
	[RegionalOfficesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReimbursableAgreements]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReimbursableAgreements](
	[ReimbursableAgreementsId] [int] IDENTITY(1,1) NOT NULL,
	[RPIO] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[AgreementNumber] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ReimbursableAgreements] PRIMARY KEY CLUSTERED 
(
	[ReimbursableAgreementsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReimbursableFunds]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReimbursableFunds](
	[ReimbursableFundsId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[AgreeementNumber] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
 CONSTRAINT [PK_ReimbursableFunds] PRIMARY KEY CLUSTERED 
(
	[ReimbursableFundsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reports](
	[ReportsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Title] [nvarchar](80) NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[ReportsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reprogrammings]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reprogrammings](
	[ReprogrammingsId] [int] IDENTITY(1,1) NOT NULL,
	[DocPrefix] [nvarchar](80) NULL,
	[ReprogrammingNumber] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[DocType] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[FromTo] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Purpose] [nvarchar](max) NULL,
	[ExtendedPurpose] [nvarchar](max) NULL,
	[ResourceType] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Reprogrammings] PRIMARY KEY CLUSTERED 
(
	[ReprogrammingsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResourcePlanningOffices]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResourcePlanningOffices](
	[ResourcePlanningOfficesId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [PK_ResourcePlanningOffices] PRIMARY KEY CLUSTERED 
(
	[ResourcePlanningOfficesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resources]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resources](
	[ResourcesId] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](80) NULL,
	[FileType] [nvarchar](80) NULL,
	[FilePath] [nvarchar](max) NULL,
	[FileExtension] [nvarchar](80) NULL,
 CONSTRAINT [PK_Resources] PRIMARY KEY CLUSTERED 
(
	[ResourcesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResponsibilityCenters]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResponsibilityCenters](
	[ResponsibilityCentersId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
	[Title] [nvarchar](80) NULL,
 CONSTRAINT [PK_ResponsibilityCenters] PRIMARY KEY CLUSTERED 
(
	[ResponsibilityCentersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SchemaTypes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchemaTypes](
	[SchemaTypesId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nvarchar](80) NULL,
	[Database] [nvarchar](80) NULL,
 CONSTRAINT [PK_SchemaTypes] PRIMARY KEY CLUSTERED 
(
	[SchemaTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteActivity]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteActivity](
	[SiteActivityId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[ActionCode] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[City] [nvarchar](80) NULL,
	[CongressionalDistrict] [nvarchar](80) NULL,
	[ProjectType] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[LastActivity] [datetime] NULL,
	[Requested] [decimal](18, 0) NULL,
	[Accepted] [decimal](18, 0) NULL,
	[Closed] [decimal](18, 0) NULL,
	[Outstanding] [decimal](18, 0) NULL,
	[Refunded] [decimal](18, 0) NULL,
	[Reversal] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SiteActivity] PRIMARY KEY CLUSTERED 
(
	[SiteActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiteProjectCodes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiteProjectCodes](
	[SiteProjectCodesId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[CongressionalDistrict] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[SiteProjectCode] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[ActionCode] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
 CONSTRAINT [PK_SiteProjectCodes] PRIMARY KEY CLUSTERED 
(
	[SiteProjectCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpecialAccounts]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialAccounts](
	[SpecialAccountsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[SpecialAccountFund] [nvarchar](80) NULL,
	[SpecialAccountNumber] [nvarchar](80) NULL,
	[SpecialAccountName] [nvarchar](80) NULL,
	[AccountStatus] [nvarchar](80) NULL,
	[NplStatusCode] [nvarchar](80) NULL,
	[NplStatusName] [nvarchar](80) NULL,
	[SiteId] [nvarchar](80) NULL,
	[CerclisId] [nvarchar](80) NULL,
	[SiteCode] [nvarchar](80) NULL,
	[SiteName] [nvarchar](80) NULL,
	[OperableUnit] [nvarchar](80) NULL,
	[PipelineCode] [nvarchar](80) NULL,
	[PipelineDescription] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[TransactionType] [nvarchar](80) NULL,
	[TransactionTypeName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[TransactionDate] [datetime] NULL,
	[AvailableBalance] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Disbursements] [decimal](18, 0) NULL,
	[UnpaidBalances] [decimal](18, 0) NULL,
	[Collections] [decimal](18, 0) NULL,
	[CumulativeReceipts] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SpecialAccounts] PRIMARY KEY CLUSTERED 
(
	[SpecialAccountsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpendingRates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpendingRates](
	[SpendingRatesId] [int] IDENTITY(1,1) NOT NULL,
	[OmbAgencyCode] [nvarchar](80) NULL,
	[OmbAgencyName] [nvarchar](80) NULL,
	[OmbBureauCode] [nvarchar](80) NULL,
	[OmbBureauName] [nvarchar](80) NULL,
	[TreausuryAgencyCode] [nvarchar](80) NULL,
	[TreausuryAccountCode] [nvarchar](80) NULL,
	[TreausuryAccountName] [nvarchar](80) NULL,
	[AccountTitle] [nvarchar](80) NULL,
	[Subfunction] [nvarchar](80) NULL,
	[Line] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[Category] [nvarchar](80) NULL,
	[Subcategory] [nvarchar](80) NULL,
	[SubcategoryName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[Jurisdiction] [nvarchar](80) NULL,
	[YearOfAuthority] [nvarchar](80) NULL,
	[BudgetAuthority] [decimal](18, 0) NULL,
	[OutYear1] [decimal](18, 0) NULL,
	[OutYear2] [decimal](18, 0) NULL,
	[OutYear3] [decimal](18, 0) NULL,
	[OutYear4] [decimal](18, 0) NULL,
	[OutYear5] [decimal](18, 0) NULL,
	[OutYear6] [decimal](18, 0) NULL,
	[OutYear7] [decimal](18, 0) NULL,
	[OutYear8] [decimal](18, 0) NULL,
	[OutYear9] [decimal](18, 0) NULL,
	[OutYear10] [decimal](18, 0) NULL,
	[OutYear11] [decimal](18, 0) NULL,
	[TotalSpendout] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SpendingRates] PRIMARY KEY CLUSTERED 
(
	[SpendingRatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateGrantObligations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateGrantObligations](
	[StateGrantObligationsId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[StateCode] [nvarchar](80) NULL,
	[StateName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_StateGrantObligations] PRIMARY KEY CLUSTERED 
(
	[StateGrantObligationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StateOrganizations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StateOrganizations](
	[StateOrganizationsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Code] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
 CONSTRAINT [PK_StateOrganizations] PRIMARY KEY CLUSTERED 
(
	[StateOrganizationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfAppropriations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfAppropriations](
	[StatusOfAppropriationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[AppropriationFundCode] [nvarchar](80) NULL,
	[AppropriationFundName] [nvarchar](80) NULL,
	[Availability] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[AppropriationCreationDate] [datetime] NULL,
	[AppropriationCode] [nvarchar](80) NULL,
	[SubAppropriationCode] [nvarchar](80) NULL,
	[AppropriationDescription] [nvarchar](80) NULL,
	[FundGroup] [nvarchar](80) NULL,
	[FundGroupName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[TransType] [nvarchar](80) NULL,
	[ActualRecoveryTransType] [nvarchar](80) NULL,
	[CommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[AgreementLimit] [nvarchar](80) NULL,
	[EstimatedRecoveriesTransType] [nvarchar](80) NULL,
	[EstimatedReimbursmentsTransType] [nvarchar](80) NULL,
	[ExpenseSpendingControlFlag] [nvarchar](80) NULL,
	[ObligationSpendingControlFlag] [nvarchar](80) NULL,
	[PreCommitmentSpendingControlFlag] [nvarchar](80) NULL,
	[PostedControlFlag] [nvarchar](80) NULL,
	[PostedFlag] [nvarchar](80) NULL,
	[RecordCarryoverAtLowerLevel] [nvarchar](80) NULL,
	[ReimbursableSpendingOption] [nvarchar](80) NULL,
	[RecoveriesOption] [nvarchar](80) NULL,
	[RecoveriesSpendingOption] [nvarchar](80) NULL,
	[OriginalBudgetedAmount] [decimal](18, 0) NULL,
	[ApportionmentsPosted] [decimal](18, 0) NULL,
	[TotalAuthority] [decimal](18, 0) NULL,
	[TotalBudgeted] [decimal](18, 0) NULL,
	[TotalPostedAmount] [decimal](18, 0) NULL,
	[FundsWithdrawnPriorYearsAmount] [decimal](18, 0) NULL,
	[FundingInAmount] [decimal](18, 0) NULL,
	[FundingOutAmount] [decimal](18, 0) NULL,
	[TotalAccrualRecoveries] [decimal](18, 0) NULL,
	[TotalActualReimbursements] [decimal](18, 0) NULL,
	[TotalAgreementReimbursables] [decimal](18, 0) NULL,
	[TotalCarriedForwardIn] [decimal](18, 0) NULL,
	[TotalCarriedForwardOut] [decimal](18, 0) NULL,
	[TotalCommitted] [decimal](18, 0) NULL,
	[TotalEstimatedRecoveries] [decimal](18, 0) NULL,
	[TotalEstimatedReimbursements] [decimal](18, 0) NULL,
	[TotalExpenses] [decimal](18, 0) NULL,
	[TotalExpenditureExpenses] [decimal](18, 0) NULL,
	[TotalExpenseAccruals] [decimal](18, 0) NULL,
	[TotalPreCommitments] [decimal](18, 0) NULL,
	[UnliquidatedPreCommitments] [decimal](18, 0) NULL,
	[TotalObligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[VoidedAmount] [decimal](18, 0) NULL,
	[TotalUsedAmount] [decimal](18, 0) NULL,
	[AvailableAmount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_StatusOfAppropriations] PRIMARY KEY CLUSTERED 
(
	[StatusOfAppropriationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfFunds]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfFunds](
	[StatusOfFundsId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
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
 CONSTRAINT [PK_StatusOfFunds] PRIMARY KEY CLUSTERED 
(
	[StatusOfFundsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfJobsActFunding]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfJobsActFunding](
	[StatusOfJobsActFundingId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
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
	[Balance] [decimal](18, 0) NULL,
 CONSTRAINT [PK_StatusOfJobsActFunding] PRIMARY KEY CLUSTERED 
(
	[StatusOfJobsActFundingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusOfSupplementalFunding]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusOfSupplementalFunding](
	[SupplementalAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[StatusOfFundsId] [int] NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
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
	[Balance] [decimal](18, 0) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
 CONSTRAINT [PK_StatusOfSupplementalFunding] PRIMARY KEY CLUSTERED 
(
	[SupplementalAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SuperfundSites]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SuperfundSites](
	[SuperfundSitesId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[City] [nvarchar](80) NULL,
	[State] [nvarchar](80) NULL,
	[SSID] [nvarchar](80) NULL,
	[SiteProjectName] [nvarchar](80) NULL,
	[EpaSiteId] [nvarchar](80) NULL,
 CONSTRAINT [PK_SuperfundSites] PRIMARY KEY CLUSTERED 
(
	[SuperfundSitesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplementalCarryoverEstimates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplementalCarryoverEstimates](
	[SupplementalCarryoverEstimatesID] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[TreasuryAccountCode] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	[Estimate] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SupplementalCarryoverEstimates] PRIMARY KEY CLUSTERED 
(
	[SupplementalCarryoverEstimatesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplementalReimburseableEstimates]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplementalReimburseableEstimates](
	[ReimbursableEstimatesId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[OpenCommitments] [decimal](18, 0) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[Available] [decimal](18, 0) NULL,
	[Estimate] [decimal](18, 0) NULL,
 CONSTRAINT [PK_SupplementalReimburseableEstimates] PRIMARY KEY CLUSTERED 
(
	[ReimbursableEstimatesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfers]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfers](
	[TransfersId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetLevel] [nvarchar](80) NULL,
	[DocPrefix] [nvarchar](80) NULL,
	[DocType] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[ReprogrammingNumber] [nvarchar](80) NULL,
	[ControlNumber] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[Quarter] [nvarchar](80) NULL,
	[Line] [nvarchar](80) NULL,
	[Subline] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramAreaCode] [nvarchar](80) NULL,
	[ProgramAreaName] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[FromTo] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
	[Purpose] [nvarchar](max) NULL,
	[ExtendedPurpose] [nvarchar](max) NULL,
	[ResourceType] [nvarchar](80) NULL,
 CONSTRAINT [PK_Transfers] PRIMARY KEY CLUSTERED 
(
	[TransfersId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TransTypes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransTypes](
	[TransTypesId] [int] IDENTITY(1,1) NOT NULL,
	[FundCode] [nvarchar](80) NULL,
	[Appropriation] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[DocType] [nvarchar](80) NULL,
	[AppropriationBill] [nvarchar](80) NULL,
	[ContinuingResolution] [nvarchar](80) NULL,
	[RescissionCurrentYear] [nvarchar](80) NULL,
	[RescissionPriorYear] [nvarchar](80) NULL,
	[SequesterReduction] [nvarchar](80) NULL,
	[SequesterReturn] [nvarchar](80) NULL,
 CONSTRAINT [PK_TransTypes] PRIMARY KEY CLUSTERED 
(
	[TransTypesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TravelActivity]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TravelActivity](
	[TravelActivityId] [int] IDENTITY(1,1) NOT NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[FirstName] [nvarchar](80) NULL,
	[LastName] [nvarchar](80) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[Duration] [float] NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[Obligations] [decimal](18, 0) NULL,
	[ULO] [decimal](18, 0) NULL,
	[Expenditures] [decimal](18, 0) NULL,
 CONSTRAINT [PK_TravelActivity] PRIMARY KEY CLUSTERED 
(
	[TravelActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnliquidatedObligations]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnliquidatedObligations](
	[UnliquidatedObligationsId] [int] IDENTITY(1,1) NOT NULL,
	[ObligationsId] [int] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[RpioCode] [nvarchar](80) NULL,
	[RpioName] [nvarchar](80) NULL,
	[AhCode] [nvarchar](80) NULL,
	[AhName] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OrgCode] [nvarchar](80) NULL,
	[OrgName] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramProjectCode] [nvarchar](80) NULL,
	[ProgramProjectName] [nvarchar](80) NULL,
	[RcCode] [nvarchar](80) NULL,
	[RcName] [nvarchar](80) NULL,
	[DocumentType] [nvarchar](80) NULL,
	[DocumentNumber] [nvarchar](80) NULL,
	[DocumentControlNumber] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[ProcessedDate] [datetime] NULL,
	[LastActivityDate] [datetime] NULL,
	[Age] [float] NULL,
	[BocCode] [nvarchar](80) NULL,
	[BocName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[NpmCode] [nvarchar](80) NULL,
	[NpmName] [nvarchar](80) NULL,
	[VendorCode] [nvarchar](80) NULL,
	[VendorName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_UnliquidatedObligations] PRIMARY KEY CLUSTERED 
(
	[UnliquidatedObligationsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnobligatedAuthority]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnobligatedAuthority](
	[UnobligatedAuthorityId] [int] IDENTITY(1,1) NOT NULL,
	[ReportYear] [nvarchar](80) NULL,
	[AgencyCode] [nvarchar](80) NULL,
	[BureauCode] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[OmbAccount] [nvarchar](80) NULL,
	[OmbAccountName] [nvarchar](80) NULL,
	[LineName] [nvarchar](80) NULL,
	[LineNumber] [nvarchar](80) NULL,
	[BudgetYear] [decimal](18, 0) NULL,
	[PriorYear] [decimal](18, 0) NULL,
	[CurrentYear] [decimal](18, 0) NULL,
	[AgencyName] [nvarchar](80) NULL,
	[BureauName] [nvarchar](80) NULL,
 CONSTRAINT [PK_UnobligatedAuthority] PRIMARY KEY CLUSTERED 
(
	[UnobligatedAuthorityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UnobligatedBalances]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UnobligatedBalances](
	[UnobligatedBalancesId] [int] IDENTITY(1,1) NOT NULL,
	[BudgetYear] [nvarchar](80) NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[TreasurySymbol] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[OmbAccountCode] [nvarchar](80) NULL,
	[AccountNumber] [nvarchar](80) NULL,
	[AccountName] [nvarchar](80) NULL,
	[Amount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_UnobligatedBalances] PRIMARY KEY CLUSTERED 
(
	[UnobligatedBalancesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[URL]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[URL](
	[UrlsId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Location] [nvarchar](80) NULL,
	[Address] [nvarchar](max) NULL,
 CONSTRAINT [PK_URL] PRIMARY KEY CLUSTERED 
(
	[UrlsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkCodes]    Script Date: 8/19/2022 7:56:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkCodes](
	[WorkCodesId] [int] IDENTITY(1,1) NOT NULL,
	[SecurityOrg] [nvarchar](80) NULL,
	[WorkCode] [nvarchar](80) NULL,
	[WorkCodeName] [nvarchar](80) NULL,
	[WorkCodeShortName] [nvarchar](80) NULL,
	[ChargeType] [nvarchar](80) NULL,
	[PreventNewUse] [nvarchar](80) NULL,
	[ReOrgCode] [nvarchar](80) NULL,
	[Active] [nvarchar](80) NULL,
	[Pay Year] [nvarchar](80) NULL,
	[PayPeriod] [nvarchar](80) NULL,
	[PayType] [nvarchar](80) NULL,
	[FiscalYear] [nvarchar](80) NULL,
	[ActivityCode] [nvarchar](80) NULL,
	[Justification] [nvarchar](80) NULL,
	[AllocationReason] [nvarchar](80) NULL,
	[Status] [nvarchar](80) NULL,
	[ApprovedBy] [nvarchar](80) NULL,
	[ApprovalDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](80) NULL,
	[ModifiedDate] [datetime] NULL,
	[BFY] [nvarchar](80) NULL,
	[EFY] [nvarchar](80) NULL,
	[FundCode] [nvarchar](80) NULL,
	[FundName] [nvarchar](80) NULL,
	[FocCode] [nvarchar](80) NULL,
	[FocName] [nvarchar](80) NULL,
	[BETC] [nvarchar](80) NULL,
	[BetcName] [nvarchar](80) NULL,
	[CostOrgCode] [nvarchar](80) NULL,
	[CostOrgName] [nvarchar](80) NULL,
	[Organization] [nvarchar](80) NULL,
	[Organization Name] [nvarchar](80) NULL,
	[AccountCode] [nvarchar](80) NULL,
	[ProgramName] [nvarchar](80) NULL,
	[ProjectCode] [nvarchar](80) NULL,
	[ProjectName] [nvarchar](80) NULL,
	[BudgetYear] [nvarchar](80) NULL,
	[AllocationPercentage] [decimal](18, 0) NULL,
 CONSTRAINT [PK_WorkCodes] PRIMARY KEY CLUSTERED 
(
	[WorkCodesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Allocations] ADD  CONSTRAINT [DF_Allocations_Amount]  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  CONSTRAINT [DF_AppropriationDocuments_Budgeted]  DEFAULT ((0)) FOR [Budgeted]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  CONSTRAINT [DF_AppropriationDocuments_Posted]  DEFAULT ((0)) FOR [Posted]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  CONSTRAINT [DF_AppropriationDocuments_CarryOut]  DEFAULT ((0)) FOR [CarryOut]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  CONSTRAINT [DF_AppropriationDocuments_CarryIn]  DEFAULT ((0)) FOR [CarryIn]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  CONSTRAINT [DF_AppropriationDocuments_EstimatedReimbur0sements]  DEFAULT ((0)) FOR [EstimatedReimbur0sements]
GO
ALTER TABLE [dbo].[AppropriationDocuments] ADD  CONSTRAINT [DF_AppropriationDocuments_EstimatedRecoveries]  DEFAULT ((0)) FOR [EstimatedRecoveries]
GO
ALTER TABLE [dbo].[Expenditures] ADD  CONSTRAINT [DF_Expenditures_Amount]  DEFAULT ((0)) FOR [Amount]
GO
ALTER TABLE [dbo].[HeadquartersAuthority]  WITH CHECK ADD  CONSTRAINT [HeadquartersAuthorityAllocationsForeignKey] FOREIGN KEY([AllocationsId])
REFERENCES [dbo].[Allocations] ([AllocationsId])
GO
ALTER TABLE [dbo].[HeadquartersAuthority] CHECK CONSTRAINT [HeadquartersAuthorityAllocationsForeignKey]
GO
ALTER TABLE [dbo].[HeadquartersAuthority]  WITH CHECK ADD  CONSTRAINT [HeadquartersAuthorityStatusOfFundsForeignKey] FOREIGN KEY([StatusOfFundsId])
REFERENCES [dbo].[StatusOfFunds] ([StatusOfFundsId])
GO
ALTER TABLE [dbo].[HeadquartersAuthority] CHECK CONSTRAINT [HeadquartersAuthorityStatusOfFundsForeignKey]
GO
ALTER TABLE [dbo].[StatusOfSupplementalFunding]  WITH CHECK ADD  CONSTRAINT [StatusOfSupplementalFundingStatusOfFundsForeignKey] FOREIGN KEY([StatusOfFundsId])
REFERENCES [dbo].[StatusOfFunds] ([StatusOfFundsId])
GO
ALTER TABLE [dbo].[StatusOfSupplementalFunding] CHECK CONSTRAINT [StatusOfSupplementalFundingStatusOfFundsForeignKey]
GO
