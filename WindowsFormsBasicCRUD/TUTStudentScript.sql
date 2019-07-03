USE [master]
GO
/****** Object:  Database [TUTStudentDb]    Script Date: 7/3/2019 11:56:40 PM ******/
CREATE DATABASE [TUTStudentDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TUTStudentDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TUTStudentDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TUTStudentDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\TUTStudentDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TUTStudentDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TUTStudentDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TUTStudentDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TUTStudentDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TUTStudentDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TUTStudentDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [TUTStudentDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TUTStudentDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TUTStudentDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TUTStudentDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TUTStudentDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TUTStudentDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TUTStudentDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TUTStudentDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TUTStudentDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TUTStudentDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TUTStudentDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TUTStudentDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TUTStudentDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TUTStudentDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TUTStudentDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TUTStudentDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TUTStudentDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TUTStudentDb] SET RECOVERY FULL 
GO
ALTER DATABASE [TUTStudentDb] SET  MULTI_USER 
GO
ALTER DATABASE [TUTStudentDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TUTStudentDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TUTStudentDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TUTStudentDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TUTStudentDb', N'ON'
GO
USE [TUTStudentDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [TUTStudentDb]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 7/3/2019 11:56:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[GStudentId] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Birthdate] [date] NULL,
	[Gender] [nvarchar](50) NULL,
	[Address] [nvarchar](200) NULL,
	[School] [nvarchar](200) NULL,
	[Status] [binary](50) NULL,
	[Recorded] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[GStudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_GStudentId]  DEFAULT (newsequentialid()) FOR [GStudentId]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_Recorded]  DEFAULT (sysdatetime()) FOR [Recorded]
GO
USE [master]
GO
ALTER DATABASE [TUTStudentDb] SET  READ_WRITE 
GO
