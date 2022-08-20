CREATE TABLE [dbo].[AccountingEvents]
(
	[AccountingEventsId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NULL,
	[Name] [nvarchar](80) NULL,
 CONSTRAINT [AccountingEventsPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[AccountingEventsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


