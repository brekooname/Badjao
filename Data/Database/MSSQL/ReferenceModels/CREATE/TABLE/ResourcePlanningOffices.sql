IF NOT EXISTS ( SELECT * 
				FROM INFORMATION_SCHEMA.TABLES 
				WHERE TABLE_NAME = N'ResourcePlanningOffices' )
BEGIN
CREATE TABLE [dbo].[ResourcePlanningOffices]
(
	[ResourcPlanningOfficesId] INT IDENTITY(1,1) NOT NULL,
	[Code] VARCHAR(80) NULL DEFAULT ('NS'),
	[Name] VARCHAR(80) NULL DEFAULT ('NOT SPECIFIED')
);
END
