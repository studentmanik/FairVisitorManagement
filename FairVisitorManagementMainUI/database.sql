
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
/****** Object:  Table [dbo].[VisitorInfoTable]    Script Date: 5/26/2015 5:11:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VisitorInfoTable](
	[VisitorId] [int] NOT NULL,
	[VisitorName] [varchar](50) NULL,
	[VisitorEmail] [varchar](50) NULL,
	[VisitorContactNumber] [varchar](50) NULL,
	[ZoneTypeId] [int] NOT NULL,
 CONSTRAINT [PK_VisitorInfoTable] PRIMARY KEY CLUSTERED 
(
	[VisitorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ZoneTypeTable]    Script Date: 5/26/2015 5:11:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZoneTypeTable](
	[ZoneTypeId] [int] NOT NULL,
	[ZoneType] [varchar](50) NULL,
 CONSTRAINT [PK_ZoneTypeTable] PRIMARY KEY CLUSTERED 
(
	[ZoneTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[VisitorInfoTable]  WITH CHECK ADD  CONSTRAINT [FK_VisitorInfoTable_ZoneTypeTable] FOREIGN KEY([ZoneTypeId])
REFERENCES [dbo].[ZoneTypeTable] ([ZoneTypeId])
GO
ALTER TABLE [dbo].[VisitorInfoTable] CHECK CONSTRAINT [FK_VisitorInfoTable_ZoneTypeTable]
GO
USE [master]
GO
ALTER DATABASE [FairVisitorManagementDataBase] SET  READ_WRITE 
GO
