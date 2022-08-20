CREATE TABLE [dbo].[Appropriations]
(
	[AppropriationsId] [int] IDENTITY(1,1) NOT NULL,
	[BFY] [nvarchar](80) NOT NULL,
	[Title] [nvarchar](80) NULL,
	[PublicLaw] [nvarchar](80) NULL,
	[EnactedDate] [datetime] NULL,
	 CONSTRAINT [AppropriationsPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[AppropriationsId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


