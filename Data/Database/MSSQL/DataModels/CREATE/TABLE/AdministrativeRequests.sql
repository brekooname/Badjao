CREATE TABLE [dbo].[AdministrativeRequests]
(
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
	 CONSTRAINT [AdministrativeRequestsPrimaryKey] PRIMARY KEY CLUSTERED 
	(
		[AdministrativeRequestsId] ASC
	)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


