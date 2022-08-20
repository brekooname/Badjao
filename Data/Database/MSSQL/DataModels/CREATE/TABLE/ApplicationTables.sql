CREATE TABLE [dbo].[ApplicationTables]
(
	[ApplicationTablesId] [int] IDENTITY(1,1) NOT NULL,
	[TableName] [nvarchar](80) NULL,
	[Model] [nvarchar](80) NULL,
	 CONSTRAINT [ApplicationTablesPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[ApplicationTablesId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


