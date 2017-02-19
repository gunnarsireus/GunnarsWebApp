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

if EXISTS (select * from INFORMATION_SCHEMA.TABLES where TABLE_NAME = 'Departments' AND TABLE_SCHEMA = 'dbo')
    drop table dbo.Departments;

CREATE TABLE [dbo].[Departments](
	Id [int] IDENTITY(1,1) NOT NULL,
	Name [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED 
(
	Id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Employees](
	Id [int] IDENTITY(1,1) NOT NULL,
	DepartmentId [int] NOT NULL,
	FirstName [nvarchar](50) NULL,
    LastName [nvarchar](50) NULL,
	UserName [nvarchar](50) NULL
 CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED 
(
	Id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
CONSTRAINT [FK_dbo.DepartmentsEmployees] FOREIGN KEY (DepartmentId)     
    REFERENCES Departments (Id)     
    ON DELETE CASCADE 
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
CONSTRAINT [FK_dbo.ContactsEmployees] FOREIGN KEY (EmployeeId)     
    REFERENCES Employees (Id)     
    ON DELETE CASCADE    
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
CONSTRAINT [FK_dbo.AddressesEmployees] FOREIGN KEY (EmployeeId)     
    REFERENCES Employees (Id)     
    ON DELETE CASCADE  
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Departments] ON 
INSERT [dbo].[Departments] (Id,Name) VALUES (1,N'IT')
INSERT [dbo].[Departments] (Id,Name) VALUES (2,N'HR')
INSERT [dbo].[Departments] (Id,Name) VALUES (3,N'XX')
SET IDENTITY_INSERT [dbo].[Departments] OFF

SET IDENTITY_INSERT [dbo].[Employees] ON 
INSERT [dbo].[Employees] (Id,DepartmentId,FirstName,LastName,UserName) VALUES (1,1,N'Mark', N'Andersson', N'mark')
INSERT [dbo].[Employees] (Id,DepartmentId,FirstName,LastName,UserName) VALUES (2,2,N'Steve', N'Andersson', N'steve')
INSERT [dbo].[Employees] (Id,DepartmentId,FirstName,LastName,UserName) VALUES (3,1,N'Ben', N'Andersson', N'ben')
INSERT [dbo].[Employees] (Id,DepartmentId,FirstName,LastName,UserName) VALUES (4,1,N'Phillip', N'Andersson', N'phillip')
INSERT [dbo].[Employees] (Id,DepartmentId,FirstName,LastName,UserName) VALUES (5,2,N'Mary', N'Andersson', N'mary')
INSERT [dbo].[Employees] (Id,DepartmentId,FirstName,LastName,UserName) VALUES (6,1,N'Gunnar', N'Siréus', N'gunnar')
INSERT [dbo].[Employees] (Id,DepartmentId,FirstName,LastName,UserName) VALUES (7,2,N'Robert', N'Lind', N'robert')
SET IDENTITY_INSERT [dbo].[Employees] OFF

SET IDENTITY_INSERT [dbo].[Contacts] ON 
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (1,1, N'-', N'-')
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (2,2, N'-', N'-')
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (3,3, N'-', N'-')
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (4,4, N'-', N'-')
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (5,5, N'-', N'-')
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (6,6, N'070 7823206', N'gunnar.sireus@gmail.com')
INSERT [dbo].[Contacts] (Id, EmployeeId,Phone, Email) VALUES (7,7, N'070 998877', N'robert.lind@gmail.com')
SET IDENTITY_INSERT [dbo].[Contacts] OFF

SET IDENTITY_INSERT [dbo].[Addresses] ON 
INSERT [dbo].[Addresses] (Id, EmployeeId,[City], [Street],[Zip]) VALUES (1,1, N'-', N'-', N'-')
INSERT [dbo].[Addresses] (Id, EmployeeId,[City], [Street],[Zip]) VALUES (2,2, N'-', N'-', N'-')
INSERT [dbo].[Addresses] (Id, EmployeeId,[City], [Street],[Zip]) VALUES (3,3, N'-', N'-', N'-')
INSERT [dbo].[Addresses] (Id, EmployeeId,[City], [Street],[Zip]) VALUES (4,4, N'-', N'-', N'-')
INSERT [dbo].[Addresses] (Id, EmployeeId,[City], [Street],[Zip]) VALUES (5,5, N'-', N'-', N'-')
INSERT [dbo].[Addresses] (Id, EmployeeId,[City], [Street], [Zip]) VALUES (6,6, N'Bromma', N'Grimstahamnsvägen 4', N'168 39')
INSERT [dbo].[Addresses] (Id, EmployeeId,[City], [Street], [Zip]) VALUES (7,7, N'Kramfors', N'Kramforsvägen 4', N'123 45')
SET IDENTITY_INSERT [dbo].[Addresses] OFF

