CREATE TABLE [dbo].[AppropriationDocuments]
(
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
 CONSTRAINT [AppropriationDocumentsPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AppropriationDocumentsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
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


