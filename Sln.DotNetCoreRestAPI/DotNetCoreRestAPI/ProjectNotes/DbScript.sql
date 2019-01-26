USE [ZCodeFirst]
GO
/****** Object:  Table [dbo].[PersonalInfo]    Script Date: 1/24/2019 2:25:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalInfo](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](150) NULL,
	[LastName] [nvarchar](150) NULL,
	[DateOfBirth] [datetime] NULL,
	[City] [nvarchar](150) NULL,
	[Country] [nvarchar](150) NULL,
	[MobileNo] [nvarchar](150) NULL,
	[NID] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
	[CreatedDate] [datetime] NULL,
	[LastModifiedDate] [datetime] NULL,
	[CreationUser] [nvarchar](150) NULL,
	[LastUpdateUser] [nvarchar](150) NULL,
	[Status] [tinyint] NULL,
 CONSTRAINT [PK_PersonalInfo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

