USE [GunnarsWebApp]

/****** Object:  Table [dbo].[Employees]    Script Date: 2016-08-01 14:26:49 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON


if EXISTS (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Addresses' AND TABLE_SCHEMA = 'dbo')
    drop table dbo.Addresses;

if EXISTS (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Contacts' AND TABLE_SCHEMA = 'dbo')
    drop table dbo.Contacts;

if EXISTS (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Employees' AND TABLE_SCHEMA = 'dbo')
    drop table dbo.Employees;

CREATE TABLE [dbo].[Employees](
	Id [int] IDENTITY(1,1) NOT NULL,
	FirstName [nvarchar](50) NULL,
    LastName [nvarchar](50) NULL,
	UserName [nvarchar](50) NULL
 CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED 
(
	Id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Contacts]    Script Date: 2016-08-01 14:26:49 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[Contacts](
	Id [int] IDENTITY(1,1) NOT NULL,
    EmployeeId [int] NOT NULL,
	Phone [nvarchar](50) NULL,
    Email [nvarchar](50) NULL
 CONSTRAINT [PK_dbo.Contacts] PRIMARY KEY CLUSTERED 
(
	Id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


/****** Object:  Table [dbo].[Addresses]    Script Date: 2016-08-01 14:26:49 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON


CREATE TABLE [dbo].[Addresses](
	Id [int] IDENTITY(1,1) NOT NULL,
    EmployeeId [int] NOT NULL,
	City [nvarchar](50) NOT NULL,
    Street [nvarchar](50) NOT NULL,
	Zip [nvarchar](50) NOT NULL
 CONSTRAINT [PK_dbo.Addresses] PRIMARY KEY CLUSTERED 
(
	Id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


SET IDENTITY_INSERT [dbo].[Employees] ON 
INSERT [dbo].[Employees] (Id,FirstName,LastName,UserName) VALUES (1,N'Gunnar', N'Siréus', N'gunnar')
INSERT [dbo].[Employees] (Id,FirstName,LastName,UserName) VALUES (2,N'Robert', N'Nilsson', N'robert')
SET IDENTITY_INSERT [dbo].[Employees] OFF

SET IDENTITY_INSERT [dbo].[Contacts] ON 
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (1,1, N'070 7823206', N'gunnar.sireus@gmail.com')
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (2,2, N'070 998877', N'robert.nilsson@gmail.com')
SET IDENTITY_INSERT [dbo].[Contacts] OFF

SET IDENTITY_INSERT [dbo].[Addresses] ON 

INSERT [dbo].[Addresses] (Id,EmployeeId, [City], [Street], [Zip]) VALUES (1,1, N'Bromma', N'Grimstahamnsvägen 4', N'168 39')
INSERT [dbo].[Addresses] (Id,EmployeeId, [City], [Street], [Zip]) VALUES (2,2, N'Huddinge', N'Huddingevägen 4', N'123 45')
SET IDENTITY_INSERT [dbo].[Addresses] OFF

