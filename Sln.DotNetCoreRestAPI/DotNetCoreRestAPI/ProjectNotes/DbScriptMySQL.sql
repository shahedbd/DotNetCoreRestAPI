/****** Object:  Table [dbo].[PersonalInfo]    Script Date: 1/24/2019 2:25:15 AM ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
CREATE TABLE PersonalInfo(
	`ID` bigint AUTO_INCREMENT NOT NULL,
	`FirstName` nvarchar(150) NULL,
	`LastName` nvarchar(150) NULL,
	`DateOfBirth` datetime(3) NULL,
	`City` nvarchar(150) NULL,
	`Country` nvarchar(150) NULL,
	`MobileNo` nvarchar(150) NULL,
	`NID` nvarchar(150) NULL,
	`Email` nvarchar(150) NULL,
	`CreatedDate` datetime(3) NULL CONSTRAINT [DF__PersonalI__Creat__21B6055D]  DEFAULT ('0001-01-01T00:00:00.0000000'),
	`LastModifiedDate` datetime(3) NULL CONSTRAINT [DF__PersonalI__LastU__22AA2996]  DEFAULT ('0001-01-01T00:00:00.0000000'),
	`CreationUser` nvarchar(150) NULL,
	`LastUpdateUser` nvarchar(150) NULL,
	`Status` tinyint Unsigned NULL,
 CONSTRAINT `PK_PersonalInfo` PRIMARY KEY 
(
	`ID` ASC
) 
);

