CREATE TABLE [dbo].[ActivityCodes]
(
	[ActivityId] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](80) NOT NULL,
	[Name] [nvarchar](80) NULL,
	[Description] [nvarchar](80) NULL,
 CONSTRAINT [ActivityCodesPrimaryKey] PRIMARY KEY CLUSTERED 
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


