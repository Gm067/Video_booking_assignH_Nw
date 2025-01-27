USE [master]
GO
/****** Object:  Database [VideoDest]    Script Date: 25/02/2021 7:01:05 AM ******/
CREATE DATABASE [VideoDest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VideoDest_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoDest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'VideoDest_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\VideoDest.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [VideoDest] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VideoDest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VideoDest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VideoDest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VideoDest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VideoDest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VideoDest] SET ARITHABORT OFF 
GO
ALTER DATABASE [VideoDest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VideoDest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VideoDest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VideoDest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VideoDest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VideoDest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VideoDest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VideoDest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VideoDest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VideoDest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VideoDest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VideoDest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VideoDest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VideoDest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VideoDest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VideoDest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VideoDest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VideoDest] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VideoDest] SET  MULTI_USER 
GO
ALTER DATABASE [VideoDest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VideoDest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VideoDest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VideoDest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VideoDest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VideoDest] SET QUERY_STORE = OFF
GO
USE [VideoDest]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 25/02/2021 7:01:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [varchar](50) NULL,
	[Contact] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rental]    Script Date: 25/02/2021 7:01:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rental](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[V_ID] [int] NULL,
	[C_ID] [int] NULL,
	[BookDate] [varchar](50) NULL,
	[ReturnDate] [varchar](50) NULL,
 CONSTRAINT [PK_Rental] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Video]    Script Date: 25/02/2021 7:01:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Video](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[Plot] [varchar](50) NULL,
	[Ratting] [varchar](50) NULL,
	[Year] [varchar](50) NULL,
	[Cost] [varchar](50) NULL,
	[Copies] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([id], [Name], [Age], [Contact], [Address]) VALUES (1, N'qwq', N'12', N'3455', N'nz')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Rental] ON 

INSERT [dbo].[Rental] ([id], [V_ID], [C_ID], [BookDate], [ReturnDate]) VALUES (1, 1, 1, N'2/24/2021', N'2/24/2021')
SET IDENTITY_INSERT [dbo].[Rental] OFF
SET IDENTITY_INSERT [dbo].[Video] ON 

INSERT [dbo].[Video] ([id], [title], [Plot], [Ratting], [Year], [Cost], [Copies], [Genre]) VALUES (1, N'kee', N'action', N'2.3', N'2019', N'5', N'4', N'Cost')
SET IDENTITY_INSERT [dbo].[Video] OFF
USE [master]
GO
ALTER DATABASE [VideoDest] SET  READ_WRITE 
GO
