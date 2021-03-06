USE [master]
GO
/****** Object:  Database [FairVisitorManagementDataBase]    Script Date: 5/28/2015 4:03:12 AM ******/
CREATE DATABASE [FairVisitorManagementDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FairVisitorManagementDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FairVisitorManagementDataBase.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FairVisitorManagementDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\FairVisitorManagementDataBase_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FairVisitorManagementDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [FairVisitorManagementDataBase]
GO
/****** Object:  Table [dbo].[VisitorAndZoneName]    Script Date: 5/28/2015 4:03:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitorAndZoneName](
	[VisitorId] [int] NOT NULL,
	[ZoneTypeId] [int] NOT NULL,
 CONSTRAINT [PK_VisitorAndZoneName_1] PRIMARY KEY CLUSTERED 
(
	[VisitorId] ASC,
	[ZoneTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VisitorInfoTable]    Script Date: 5/28/2015 4:03:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VisitorInfoTable](
	[VisitorId] [int] IDENTITY(1,1) NOT NULL,
	[VisitorName] [varchar](50) NULL,
	[VisitorEmail] [varchar](50) NULL,
	[VisitorContactNumber] [varchar](50) NULL,
 CONSTRAINT [PK_VisitorInfoTable] PRIMARY KEY CLUSTERED 
(
	[VisitorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ZoneTypeTable]    Script Date: 5/28/2015 4:03:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZoneTypeTable](
	[ZoneTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ZoneType] [varchar](50) NULL,
 CONSTRAINT [PK_ZoneTypeTable] PRIMARY KEY CLUSTERED 
(
	[ZoneTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (6, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (6, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (7, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (8, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (9, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (10, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1006, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1007, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1007, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1007, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1007, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1008, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1008, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1008, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1009, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1009, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1009, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1009, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1010, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1010, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1011, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1011, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1012, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1012, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1012, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1013, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1013, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1013, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1013, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1013, 5)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1013, 6)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1014, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1014, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1014, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1014, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1014, 5)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1014, 6)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1015, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1015, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1015, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1015, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1015, 5)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1015, 6)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1016, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1016, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1016, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1016, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1016, 5)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1016, 6)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1017, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1017, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1017, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1017, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1017, 5)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1017, 6)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1018, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1018, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1018, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1018, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1018, 5)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1018, 6)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1019, 1)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1019, 2)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1019, 3)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1019, 4)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1019, 5)
INSERT [dbo].[VisitorAndZoneName] ([VisitorId], [ZoneTypeId]) VALUES (1019, 6)
SET IDENTITY_INSERT [dbo].[VisitorInfoTable] ON 

INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (2, N'manik', N'manik@dsf', N'0987654345')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (3, N'mndk', N'sdf@sdf', N'65432')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (4, N'mnk', N'sadfa@', N'098')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (5, N'fghd', N'fgdhg', N'fgdh')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (6, N'manike', N'ssdf9iksd', N'564534')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (7, N'mn', N'sda', N'sdf45')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (8, N'mnfsd', N'sdadf', N'sdf45')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (9, N'mnfsdasfa', N'sdadf', N'sdf45')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (10, N'MN', N'3242@DF', N'34355')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1006, N'man', N'Studentmanik@gmil.com', N'554346543325443')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1007, N'mns', N'sfas@hjfsf.cd', N'9876543')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1008, N'mbvc', N'gfdf@bfgdf.hfgd', N'876543676')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1009, N'dsfad', N'dfsdfas', N'fasdf')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1010, N'hgfdsd', N'gfhsgdf', N'876543')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1011, N'f', N'dsfg', N'dsfg534')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1012, N'raju', N'raju@mail.com', N'54365454')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1013, N'', N'', N'')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1014, N'dsfa', N'sdf', N'sdf')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1015, N'sdf', N'sdfas', N'sdfa')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1016, N'ghf', N'jhgf', N'jhgf876543')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1017, N'dsfa', N'dfgsd', N'fgsdf')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1018, N'54', N'65', N'hgf765')
INSERT [dbo].[VisitorInfoTable] ([VisitorId], [VisitorName], [VisitorEmail], [VisitorContactNumber]) VALUES (1019, N'uyttr', N'fgdfd', N'gfds')
SET IDENTITY_INSERT [dbo].[VisitorInfoTable] OFF
SET IDENTITY_INSERT [dbo].[ZoneTypeTable] ON 

INSERT [dbo].[ZoneTypeTable] ([ZoneTypeId], [ZoneType]) VALUES (1, N'Enterprise Application Zone')
INSERT [dbo].[ZoneTypeTable] ([ZoneTypeId], [ZoneType]) VALUES (2, N'Mobile Apps Zone')
INSERT [dbo].[ZoneTypeTable] ([ZoneTypeId], [ZoneType]) VALUES (3, N'Game & Multimedia Zone')
INSERT [dbo].[ZoneTypeTable] ([ZoneTypeId], [ZoneType]) VALUES (4, N'Telecom Software Zone')
INSERT [dbo].[ZoneTypeTable] ([ZoneTypeId], [ZoneType]) VALUES (5, N'Digital Bangladesh Zone')
INSERT [dbo].[ZoneTypeTable] ([ZoneTypeId], [ZoneType]) VALUES (6, N'java')
INSERT [dbo].[ZoneTypeTable] ([ZoneTypeId], [ZoneType]) VALUES (7, N'E-Commerce')
SET IDENTITY_INSERT [dbo].[ZoneTypeTable] OFF
ALTER TABLE [dbo].[VisitorAndZoneName]  WITH CHECK ADD  CONSTRAINT [FK_VisitorAndZoneName_VisitorAndZoneName] FOREIGN KEY([VisitorId])
REFERENCES [dbo].[VisitorInfoTable] ([VisitorId])
GO
ALTER TABLE [dbo].[VisitorAndZoneName] CHECK CONSTRAINT [FK_VisitorAndZoneName_VisitorAndZoneName]
GO
ALTER TABLE [dbo].[VisitorAndZoneName]  WITH CHECK ADD  CONSTRAINT [FK_VisitorAndZoneName_ZoneTypeTable] FOREIGN KEY([ZoneTypeId])
REFERENCES [dbo].[ZoneTypeTable] ([ZoneTypeId])
GO
ALTER TABLE [dbo].[VisitorAndZoneName] CHECK CONSTRAINT [FK_VisitorAndZoneName_ZoneTypeTable]
GO
USE [master]
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET  READ_WRITE 
GO
