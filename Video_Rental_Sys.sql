USE [master]
GO
/****** Object:  Database [Video_Rental_Sys]    Script Date: 3/12/2020 12:01:27 AM ******/
CREATE DATABASE [Video_Rental_Sys]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Video_Rental_Sys', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Video_Rental_Sys.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Video_Rental_Sys_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Video_Rental_Sys_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Video_Rental_Sys] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Video_Rental_Sys].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ARITHABORT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Video_Rental_Sys] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Video_Rental_Sys] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Video_Rental_Sys] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Video_Rental_Sys] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Video_Rental_Sys] SET  MULTI_USER 
GO
ALTER DATABASE [Video_Rental_Sys] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Video_Rental_Sys] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Video_Rental_Sys] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Video_Rental_Sys] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Video_Rental_Sys] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Video_Rental_Sys] SET QUERY_STORE = OFF
GO
USE [Video_Rental_Sys]
GO
/****** Object:  Table [dbo].[Customer_Cunt]    Script Date: 3/12/2020 12:01:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Cunt](
	[CustomerID] [int] NULL,
	[CountNo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Record]    Script Date: 3/12/2020 12:01:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Record](
	[Customer_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_FirstName] [varchar](50) NULL,
	[Customer_LastName] [varchar](50) NULL,
	[Customer_Mobile] [varchar](50) NULL,
	[Customer_Address] [varchar](50) NULL,
 CONSTRAINT [PK_Customer_Record] PRIMARY KEY CLUSTERED 
(
	[Customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental_Record]    Script Date: 3/12/2020 12:01:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental_Record](
	[Rental_ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [int] NULL,
	[Movie_ID] [int] NULL,
	[Rental_Date] [varchar](50) NULL,
	[Return_Date] [varchar](50) NULL,
 CONSTRAINT [PK_Rental_Record] PRIMARY KEY CLUSTERED 
(
	[Rental_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video_Cunt]    Script Date: 3/12/2020 12:01:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video_Cunt](
	[MovieID] [int] NULL,
	[CountNo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video_Record]    Script Date: 3/12/2020 12:01:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video_Record](
	[Video_ID] [int] IDENTITY(1,1) NOT NULL,
	[Video_Title] [varchar](50) NULL,
	[Video_Ratting] [varchar](50) NULL,
	[Video_Year] [int] NULL,
	[Video_Cost] [int] NULL,
	[Video_Copies] [int] NULL,
	[Video_Plot] [varchar](50) NULL,
	[Video_Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Video_Record] PRIMARY KEY CLUSTERED 
(
	[Video_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer_Cunt] ([CustomerID], [CountNo]) VALUES (16, 1)
SET IDENTITY_INSERT [dbo].[Customer_Record] ON 

INSERT [dbo].[Customer_Record] ([Customer_ID], [Customer_FirstName], [Customer_LastName], [Customer_Mobile], [Customer_Address]) VALUES (15, N'Jong', N'Li', N'741852963', N'Auckland')
INSERT [dbo].[Customer_Record] ([Customer_ID], [Customer_FirstName], [Customer_LastName], [Customer_Mobile], [Customer_Address]) VALUES (16, N'Lisa', N'Ray', N'7418529631', N'Wellington')
SET IDENTITY_INSERT [dbo].[Customer_Record] OFF
SET IDENTITY_INSERT [dbo].[Rental_Record] ON 

INSERT [dbo].[Rental_Record] ([Rental_ID], [Customer_ID], [Movie_ID], [Rental_Date], [Return_Date]) VALUES (27, 16, 19, N'13/12/2019 12:00:00 AM', N'13/12/2019 12:00:00 AM')
SET IDENTITY_INSERT [dbo].[Rental_Record] OFF
INSERT [dbo].[Video_Cunt] ([MovieID], [CountNo]) VALUES (19, 1)
SET IDENTITY_INSERT [dbo].[Video_Record] ON 

INSERT [dbo].[Video_Record] ([Video_ID], [Video_Title], [Video_Ratting], [Video_Year], [Video_Cost], [Video_Copies], [Video_Plot], [Video_Genre]) VALUES (19, N'Race', N'5', 2012, 5, 5, N'Action', N'Action')
INSERT [dbo].[Video_Record] ([Video_ID], [Video_Title], [Video_Ratting], [Video_Year], [Video_Cost], [Video_Copies], [Video_Plot], [Video_Genre]) VALUES (20, N'War', N'6', 1985, 2, 10, N'Action', N'ACtion')
SET IDENTITY_INSERT [dbo].[Video_Record] OFF
ALTER TABLE [dbo].[Rental_Record]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Record_Customer_Record] FOREIGN KEY([Customer_ID])
REFERENCES [dbo].[Customer_Record] ([Customer_ID])
GO
ALTER TABLE [dbo].[Rental_Record] CHECK CONSTRAINT [FK_Rental_Record_Customer_Record]
GO
ALTER TABLE [dbo].[Rental_Record]  WITH CHECK ADD  CONSTRAINT [FK_Rental_Record_Video_Record] FOREIGN KEY([Movie_ID])
REFERENCES [dbo].[Video_Record] ([Video_ID])
GO
ALTER TABLE [dbo].[Rental_Record] CHECK CONSTRAINT [FK_Rental_Record_Video_Record]
GO
USE [master]
GO
ALTER DATABASE [Video_Rental_Sys] SET  READ_WRITE 
GO
