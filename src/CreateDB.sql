USE [master]
GO
/****** Object:  Database [BookstoreManagement]    Script Date: 5/23/2018 4:12:51 PM ******/
CREATE DATABASE [BookstoreManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BookstoreManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.NEARSQL\MSSQL\DATA\BookstoreManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookstoreManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.NEARSQL\MSSQL\DATA\BookstoreManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookstoreManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookstoreManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookstoreManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookstoreManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookstoreManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookstoreManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookstoreManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BookstoreManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookstoreManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookstoreManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookstoreManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookstoreManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookstoreManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookstoreManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookstoreManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookstoreManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BookstoreManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookstoreManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookstoreManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookstoreManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookstoreManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookstoreManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookstoreManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookstoreManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookstoreManagement] SET  MULTI_USER 
GO
ALTER DATABASE [BookstoreManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookstoreManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BookstoreManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BookstoreManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BookstoreManagement] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BookstoreManagement]
GO
/****** Object:  Table [dbo].[BookImport]    Script Date: 5/23/2018 4:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookImport](
	[ID] [nchar](8) NOT NULL,
	[Name] [nchar](30) NULL,
	[Category] [nchar](10) NULL,
	[Author] [nchar](20) NULL,
	[Amount] [int] NULL,
	[Price] [int] NULL,
	[ReceivedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_BookImport] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parameter]    Script Date: 5/23/2018 4:12:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parameter](
	[MinImportAmount] [int] NULL,
	[MinInventoryAmount] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[BookImport] ([ID], [Name], [Category], [Author], [Amount], [Price], [ReceivedDate]) VALUES (N'001     ', N'The Handmaid''s Tale           ', NULL, N'Margaret Atwood     ', 150, 50, CAST(N'2018-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[BookImport] ([ID], [Name], [Category], [Author], [Amount], [Price], [ReceivedDate]) VALUES (N'002     ', N'The Silver Pigs               ', NULL, N'Lindsey Davis       ', 200, 30, CAST(N'2018-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[BookImport] ([ID], [Name], [Category], [Author], [Amount], [Price], [ReceivedDate]) VALUES (N'003     ', N'The Signature of All Things   ', NULL, N'Elizabeth Gilbert   ', 165, 45, CAST(N'2018-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[BookImport] ([ID], [Name], [Category], [Author], [Amount], [Price], [ReceivedDate]) VALUES (N'4       ', N'50 shades of boobs            ', N'porn      ', N'me                  ', 100, 50, CAST(N'2018-05-23T16:11:32.1200000' AS DateTime2))
INSERT [dbo].[Parameter] ([MinImportAmount], [MinInventoryAmount]) VALUES (150, 300)
USE [master]
GO
ALTER DATABASE [BookstoreManagement] SET  READ_WRITE 
GO
