USE [Data]
GO

/****** Object:  Table [dbo].[AdministrativeRequests]    Script Date: 8/17/2022 7:43:19 AM ******/
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

