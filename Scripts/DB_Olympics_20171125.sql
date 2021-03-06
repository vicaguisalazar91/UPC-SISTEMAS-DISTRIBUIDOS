USE [master]
GO
/****** Object:  Database [DB_Olympics]    Script Date: 11/25/2017 20:01:57 ******/
CREATE DATABASE [DB_Olympics] ON  PRIMARY 
( NAME = N'DB_Olympics', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DB_Olympics.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_Olympics_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\DB_Olympics_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_Olympics] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_Olympics].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_Olympics] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [DB_Olympics] SET ANSI_NULLS OFF
GO
ALTER DATABASE [DB_Olympics] SET ANSI_PADDING OFF
GO
ALTER DATABASE [DB_Olympics] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [DB_Olympics] SET ARITHABORT OFF
GO
ALTER DATABASE [DB_Olympics] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [DB_Olympics] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [DB_Olympics] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [DB_Olympics] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [DB_Olympics] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [DB_Olympics] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [DB_Olympics] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [DB_Olympics] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [DB_Olympics] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [DB_Olympics] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [DB_Olympics] SET  DISABLE_BROKER
GO
ALTER DATABASE [DB_Olympics] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [DB_Olympics] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [DB_Olympics] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [DB_Olympics] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [DB_Olympics] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [DB_Olympics] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [DB_Olympics] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [DB_Olympics] SET  READ_WRITE
GO
ALTER DATABASE [DB_Olympics] SET RECOVERY FULL
GO
ALTER DATABASE [DB_Olympics] SET  MULTI_USER
GO
ALTER DATABASE [DB_Olympics] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [DB_Olympics] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_Olympics', N'ON'
GO
USE [DB_Olympics]
GO
/****** Object:  Table [dbo].[Team]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Team](
	[TeamId] [int] NOT NULL,
	[TeamName] [varchar](100) NOT NULL,
	[CoachName] [varchar](100) NOT NULL,
	[SkiersNumber] [int] NOT NULL,
 CONSTRAINT [PK_Team] PRIMARY KEY CLUSTERED 
(
	[TeamId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Team] ([TeamId], [TeamName], [CoachName], [SkiersNumber]) VALUES (0, N'Individual', N'Ninguno', 1)
INSERT [dbo].[Team] ([TeamId], [TeamName], [CoachName], [SkiersNumber]) VALUES (1, N'Relampago', N'Juan Braazinni', 5)
INSERT [dbo].[Team] ([TeamId], [TeamName], [CoachName], [SkiersNumber]) VALUES (2, N'Rayos', N'Manuel Barrantes', 3)
INSERT [dbo].[Team] ([TeamId], [TeamName], [CoachName], [SkiersNumber]) VALUES (3, N'Quickers', N'Barndon Ledesma', 4)
/****** Object:  Table [dbo].[Track]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Track](
	[TrackId] [int] NOT NULL,
	[TrackLength] [decimal](18, 2) NULL,
	[difficultylevel] [varchar](100) NULL,
 CONSTRAINT [PK_Track] PRIMARY KEY CLUSTERED 
(
	[TrackId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Track] ([TrackId], [TrackLength], [difficultylevel]) VALUES (1, CAST(5.00 AS Decimal(18, 2)), N'Rojo')
INSERT [dbo].[Track] ([TrackId], [TrackLength], [difficultylevel]) VALUES (2, CAST(10.00 AS Decimal(18, 2)), N'Azul')
INSERT [dbo].[Track] ([TrackId], [TrackLength], [difficultylevel]) VALUES (3, CAST(8.00 AS Decimal(18, 2)), N'Negro')
INSERT [dbo].[Track] ([TrackId], [TrackLength], [difficultylevel]) VALUES (4, CAST(10.00 AS Decimal(18, 2)), N'Verde')
INSERT [dbo].[Track] ([TrackId], [TrackLength], [difficultylevel]) VALUES (5, CAST(20.00 AS Decimal(18, 2)), N'Rojo')
INSERT [dbo].[Track] ([TrackId], [TrackLength], [difficultylevel]) VALUES (6, CAST(12.00 AS Decimal(18, 2)), N'Negro')
INSERT [dbo].[Track] ([TrackId], [TrackLength], [difficultylevel]) VALUES (7, CAST(10.00 AS Decimal(18, 2)), N'Verde')
/****** Object:  Table [dbo].[Tm_Audit]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[Tm_Audit](
	[TableId] [varchar](80) NULL,
	[ActionId] [varchar](80) NULL,
	[AuditDate] [datetime] NULL,
	[UserId] [varchar](80) NULL,
	[ModifyId] [int] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[UserPassword] [nvarchar](20) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[User] ([UserId], [UserName], [UserPassword]) VALUES (1, N'Jorge', N'peru')
INSERT [dbo].[User] ([UserId], [UserName], [UserPassword]) VALUES (2, N'Carlos', N'Colombia')
/****** Object:  Table [dbo].[TryOutType]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TryOutType](
	[TryOutTypeId] [int] NOT NULL,
	[TryOutTypeDescription] [varchar](100) NOT NULL,
 CONSTRAINT [PK_TryOutType] PRIMARY KEY CLUSTERED 
(
	[TryOutTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TryOutType] ([TryOutTypeId], [TryOutTypeDescription]) VALUES (1, N'Fondo')
INSERT [dbo].[TryOutType] ([TryOutTypeId], [TryOutTypeDescription]) VALUES (2, N'Slalom')
INSERT [dbo].[TryOutType] ([TryOutTypeId], [TryOutTypeDescription]) VALUES (3, N'Salto')
/****** Object:  Table [dbo].[Season]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Season](
	[SeasonId] [int] NOT NULL,
	[SeasonName] [varchar](100) NOT NULL,
	[ContactName] [varchar](100) NOT NULL,
	[SeasonAddress] [varchar](200) NOT NULL,
	[SeasonPhone] [int] NOT NULL,
	[kilometersNumber] [decimal](18, 2) NULL,
	[QtTracks] [int] NULL,
 CONSTRAINT [PK_Season] PRIMARY KEY CLUSTERED 
(
	[SeasonId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Season] ([SeasonId], [SeasonName], [ContactName], [SeasonAddress], [SeasonPhone], [kilometersNumber], [QtTracks]) VALUES (1, N'Olimpiadas de Invierno 2016', N'Ricardo Calderon', N'Av. Gambeta 2323 Los Alpes Suiza', 13343434, CAST(278.00 AS Decimal(18, 2)), 7)
/****** Object:  Table [dbo].[Federation]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Federation](
	[FederationID] [int] NOT NULL,
	[FederationName] [varchar](100) NOT NULL,
	[FederatedNumber] [int] NULL,
 CONSTRAINT [Pk_Federacion] PRIMARY KEY CLUSTERED 
(
	[FederationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Federation] ([FederationID], [FederationName], [FederatedNumber]) VALUES (1, N'FEP', 10)
INSERT [dbo].[Federation] ([FederationID], [FederationName], [FederatedNumber]) VALUES (2, N'Federación Peruana de Esquí', NULL)
INSERT [dbo].[Federation] ([FederationID], [FederationName], [FederatedNumber]) VALUES (3, N'ALAS SKI CO.', NULL)
/****** Object:  Table [dbo].[Administration]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administration](
	[FederationID] [int] NOT NULL,
	[SeasonId] [int] NOT NULL,
 CONSTRAINT [Pk_Administration] PRIMARY KEY CLUSTERED 
(
	[FederationID] ASC,
	[SeasonId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Administration] ([FederationID], [SeasonId]) VALUES (1, 1)
/****** Object:  Table [dbo].[Skier]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Skier](
	[NumberId] [int] NOT NULL,
	[SkierName] [varchar](100) NOT NULL,
	[SkierDocument] [int] NULL,
	[Birthdate] [datetime] NULL,
	[FederationID] [int] NOT NULL,
 CONSTRAINT [PK_Skier] PRIMARY KEY CLUSTERED 
(
	[NumberId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (11111111, N'Juanito Garay', CAST(0x0000722300000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (11335577, N'Juan Mendez', CAST(0x0000893300000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (22222222, N'Rosa Pineda', CAST(0x00007F6400000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (33333321, N'Carlos Gonzalez', CAST(0x0000789800000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (40653577, N'Jorge Prado', CAST(0x0000736A00000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (77998866, N'Camila Galoz', CAST(0x000083B900000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (88999988, N'Italo Yataco', CAST(0x0000748B00000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (95148753, N'Edward GAlvan', CAST(0x00008E4D00000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (96852436, N'Clara Danes', CAST(0x00007C7D00000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (98765452, N'Juana Manchay', CAST(0x000079C100000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (98765584, N'Donovan Morales', CAST(0x000086D800000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (99566588, N'Samuel Bentura', CAST(0x000074D600000000 AS DateTime), 1)
INSERT [dbo].[Skier] ([NumberId], [SkierName], [Birthdate], [FederationID]) VALUES (99889988, N'Logan García', CAST(0x000077B900000000 AS DateTime), 1)
/****** Object:  Table [dbo].[TryOut]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TryOut](
	[TryOutId] [int] NOT NULL,
	[TryOutName] [varchar](100) NOT NULL,
	[TryOutDate] [datetime] NULL,
	[TryOutWinnerId] [int] NULL,
	[TryOutDurationTime] [time](7) NULL,
	[TryOutTypeId] [int] NOT NULL,
 CONSTRAINT [PK_TryOut] PRIMARY KEY CLUSTERED 
(
	[TryOutId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[TryOut] ([TryOutId], [TryOutName], [TryOutDate], [TryOutWinnerId], [TryOutDurationTime], [TryOutTypeId]) VALUES (1, N'La Herradura del Campo', CAST(0x0000A5E900000000 AS DateTime), 5, CAST(0x0700F6F4F52D0000 AS Time), 1)
INSERT [dbo].[TryOut] ([TryOutId], [TryOutName], [TryOutDate], [TryOutWinnerId], [TryOutDurationTime], [TryOutTypeId]) VALUES (2, N'Ski Race', CAST(0x0000A5EA00000000 AS DateTime), 2, CAST(0x0700E03495640000 AS Time), 1)
INSERT [dbo].[TryOut] ([TryOutId], [TryOutName], [TryOutDate], [TryOutWinnerId], [TryOutDurationTime], [TryOutTypeId]) VALUES (3, N'Trofeo Ski Montaña Palentina', CAST(0x0000A5EB00000000 AS DateTime), 3, CAST(0x070008D6E8290000 AS Time), 2)
INSERT [dbo].[TryOut] ([TryOutId], [TryOutName], [TryOutDate], [TryOutWinnerId], [TryOutDurationTime], [TryOutTypeId]) VALUES (4, N'Picos de Sudamerica', CAST(0x0000A5EE00000000 AS DateTime), NULL, NULL, 1)
INSERT [dbo].[TryOut] ([TryOutId], [TryOutName], [TryOutDate], [TryOutWinnerId], [TryOutDurationTime], [TryOutTypeId]) VALUES (5, N'Cantabria', CAST(0x0000A5F000000000 AS DateTime), NULL, NULL, 1)
/****** Object:  Table [dbo].[TeamMember]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeamMember](
	[TeamMemberId] [int] NOT NULL,
	[TeamId] [int] NOT NULL,
	[NumberId] [int] NOT NULL,
 CONSTRAINT [PK_TeamMember] PRIMARY KEY CLUSTERED 
(
	[TeamMemberId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (1, 1, 11111111)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (2, 1, 22222222)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (3, 1, 33333321)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (4, 1, 99566588)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (5, 1, 98765452)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (6, 2, 99889988)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (7, 2, 88999988)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (8, 2, 98765584)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (9, 0, 40653577)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (10, 3, 77998866)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (11, 3, 96852436)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (12, 3, 95148753)
INSERT [dbo].[TeamMember] ([TeamMemberId], [TeamId], [NumberId]) VALUES (13, 0, 11335577)
/****** Object:  Table [dbo].[Stage]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stage](
	[StageId] [int] NOT NULL,
	[TryOutId] [int] NOT NULL,
 CONSTRAINT [PK_Stage_1] PRIMARY KEY CLUSTERED 
(
	[StageId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (1, 1)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (2, 1)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (3, 1)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (4, 2)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (5, 2)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (6, 2)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (7, 2)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (8, 3)
INSERT [dbo].[Stage] ([StageId], [TryOutId]) VALUES (9, 3)
/****** Object:  Table [dbo].[Competitor]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Competitor](
	[CompetitorId] [int] NOT NULL,
	[NumberId] [int] NOT NULL,
 CONSTRAINT [PK_Competitor] PRIMARY KEY CLUSTERED 
(
	[CompetitorId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (1, 11111111)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (2, 99889988)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (3, 40653577)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (4, 77998866)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (5, 11335577)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (6, 22222222)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (7, 88999988)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (8, 33333321)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (9, 98765584)
INSERT [dbo].[Competitor] ([CompetitorId], [NumberId]) VALUES (10, 98765452)
/****** Object:  Table [dbo].[Intervention]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Intervention](
	[CompetitorId] [int] NOT NULL,
	[PositionNumber] [int] NULL,
	[TryOutDurationTime] [time](7) NULL,
	[StageId] [int] NOT NULL,
 CONSTRAINT [PK_Intervention] PRIMARY KEY CLUSTERED 
(
	[CompetitorId] ASC,
	[StageId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (1, 2, CAST(0x07003E1CA32F0000 AS Time), 1)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (1, 7, CAST(0x0780A64116680000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (1, 5, CAST(0x0700D700D2640000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (1, 5, CAST(0x0700FAA5AD660000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (1, 2, CAST(0x0700B27E00650000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (1, 2, CAST(0x07002247012C0000 AS Time), 8)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (1, 2, CAST(0x070020E3772A0000 AS Time), 9)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (2, 9, CAST(0x070072E778690000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (2, 9, CAST(0x0700285C42660000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (2, 1, CAST(0x0700104FB3650000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (2, 1, CAST(0x0700E03495640000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (2, 1, CAST(0x070050FD952B0000 AS Time), 8)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (2, 3, CAST(0x070066A69B2A0000 AS Time), 9)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (3, 6, CAST(0x0700B64613680000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (3, 1, CAST(0x07009A7171640000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (3, 6, CAST(0x0700862CF5660000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (3, 4, CAST(0x070084C86B650000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (3, 3, CAST(0x07008017B42C0000 AS Time), 8)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (3, 1, CAST(0x070008D6E8290000 AS Time), 9)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (4, 3, CAST(0x070040802C310000 AS Time), 1)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 1, CAST(0x07009A88CC2E0000 AS Time), 1)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 2, CAST(0x07003E1CA32F0000 AS Time), 2)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 1, CAST(0x0700F6F4F52D0000 AS Time), 3)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 4, CAST(0x0700E4FCA7670000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 4, CAST(0x070026F8B8640000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 7, CAST(0x0700CCEF18670000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 3, CAST(0x0700F84124650000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 4, CAST(0x0700C6DAD72C0000 AS Time), 8)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (5, 4, CAST(0x0700C4764E2B0000 AS Time), 9)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (6, 1, CAST(0x0700F8587F2F0000 AS Time), 2)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (6, 2, CAST(0x0700B4E289660000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (6, 2, CAST(0x0780EF3992640000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (6, 3, CAST(0x07808CD0FD650000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (6, 6, CAST(0x07009CD5FA650000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (7, 3, CAST(0x0700709A4A320000 AS Time), 2)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (7, 1, CAST(0x0700285C42660000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (7, 7, CAST(0x070084C86B650000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (7, 2, CAST(0x07009CD5FA650000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (7, 9, CAST(0x0700FAA5AD660000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (8, 3, CAST(0x0700FC2092320000 AS Time), 3)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (8, 3, CAST(0x0700587660670000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (8, 8, CAST(0x0700104FB3650000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (8, 9, CAST(0x0700E4FCA7670000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (8, 5, CAST(0x0700CA8B8F650000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (9, 2, CAST(0x0700B65D6E320000 AS Time), 3)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (9, 5, CAST(0x07002AC0CB670000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (9, 6, CAST(0x07003E0548650000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (9, 8, CAST(0x0700587660670000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (9, 8, CAST(0x07006E1F66660000 AS Time), 7)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (10, 8, CAST(0x07001417C6680000 AS Time), 4)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (10, 3, CAST(0x0700E03495640000 AS Time), 5)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (10, 4, CAST(0x0700285C42660000 AS Time), 6)
INSERT [dbo].[Intervention] ([CompetitorId], [PositionNumber], [TryOutDurationTime], [StageId]) VALUES (10, 7, CAST(0x0700E2981E660000 AS Time), 7)
/****** Object:  Table [dbo].[Route]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Route](
	[RouteId] [int] NOT NULL,
	[SeasonId] [int] NOT NULL,
	[StageId] [int] NOT NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[RouteId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (1, 1, 1)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (2, 1, 2)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (3, 1, 3)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (4, 1, 4)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (5, 1, 5)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (6, 1, 6)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (7, 1, 7)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (8, 1, 8)
INSERT [dbo].[Route] ([RouteId], [SeasonId], [StageId]) VALUES (9, 1, 9)
/****** Object:  Table [dbo].[Track_Route]    Script Date: 11/25/2017 20:01:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Track_Route](
	[RouteId] [int] NOT NULL,
	[TrackId] [int] NOT NULL,
	[SequentialNumber] [int] NULL,
 CONSTRAINT [PK_Track_Route] PRIMARY KEY CLUSTERED 
(
	[RouteId] ASC,
	[TrackId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (1, 1, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (1, 2, 4)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (1, 5, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (1, 7, 3)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (2, 2, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (3, 3, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (3, 4, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (3, 5, 3)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (3, 6, 4)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (3, 7, 5)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (4, 1, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (4, 2, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (5, 3, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (5, 5, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (5, 7, 3)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (6, 4, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (6, 7, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (7, 1, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (7, 7, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (8, 1, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (8, 2, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (8, 3, 3)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (8, 4, 4)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (9, 5, 1)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (9, 6, 2)
INSERT [dbo].[Track_Route] ([RouteId], [TrackId], [SequentialNumber]) VALUES (9, 7, 3)
/****** Object:  StoredProcedure [dbo].[paStagePosition]    Script Date: 11/25/2017 20:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paStagePosition]
@TryOut VARCHAR(100)
AS
BEGIN
	SELECT j.StageId AS [Stage], es.SkierName AS [Skier], eq.TeamName AS [Team], i.PositionNumber AS [Position], i.TryOutDurationTime AS [Time] FROM TryOut pr
	JOIN Stage j ON pr.TryOutId = j.TryOutId
	JOIN Intervention i ON j.StageId = i.StageId
	JOIN Competitor pa ON i.CompetitorId = pa.CompetitorId
	JOIN Skier es ON pa.NumberId = es.NumberId
	JOIN TeamMember me ON es.NumberId = me.NumberId
	JOIN Team eq ON me.TeamId = eq.TeamId
	WHERE pr.TryOutName = @TryOut
END
GO
/****** Object:  StoredProcedure [dbo].[paRouteSeason]    Script Date: 11/25/2017 20:02:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[paRouteSeason]
@Season VARCHAR(100)
AS
BEGIN
	SELECT re.RouteId AS [Route], pr.SequentialNumber AS [Secuencia], p.TrackId AS [Track], p.TrackLength AS [Klm.], p.difficultylevel AS [Grado Dificul.]   FROM Season es 
	JOIN Route re ON es.SeasonId = re.SeasonId
	JOIN Track_Route pr ON re.RouteId = pr.RouteId
	JOIN Track p ON pr.TrackId = p.TrackId
	WHERE es.SeasonName = @Season
	UNION
	SELECT re.RouteId, '', '', SUM(p.TrackLength), '=========' FROM Season es 
	JOIN Route re ON es.SeasonId = re.SeasonId
	JOIN Track_Route pr ON re.RouteId = pr.RouteId
	JOIN Track p ON pr.TrackId = p.TrackId
	WHERE es.SeasonName = @Season
	GROUP BY re.RouteId
	ORDER BY 1 ASC, 5 DESC, 2 ASC
END
GO
/****** Object:  ForeignKey [Fk_AdministrationFederation]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Administration]  WITH CHECK ADD  CONSTRAINT [Fk_AdministrationFederation] FOREIGN KEY([FederationID])
REFERENCES [dbo].[Federation] ([FederationID])
GO
ALTER TABLE [dbo].[Administration] CHECK CONSTRAINT [Fk_AdministrationFederation]
GO
/****** Object:  ForeignKey [Fk_AdministrationSeason]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Administration]  WITH CHECK ADD  CONSTRAINT [Fk_AdministrationSeason] FOREIGN KEY([SeasonId])
REFERENCES [dbo].[Season] ([SeasonId])
GO
ALTER TABLE [dbo].[Administration] CHECK CONSTRAINT [Fk_AdministrationSeason]
GO
/****** Object:  ForeignKey [FK_SkierFederation]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Skier]  WITH CHECK ADD  CONSTRAINT [FK_SkierFederation] FOREIGN KEY([FederationID])
REFERENCES [dbo].[Federation] ([FederationID])
GO
ALTER TABLE [dbo].[Skier] CHECK CONSTRAINT [FK_SkierFederation]
GO
/****** Object:  ForeignKey [FK_TryOutType]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[TryOut]  WITH CHECK ADD  CONSTRAINT [FK_TryOutType] FOREIGN KEY([TryOutTypeId])
REFERENCES [dbo].[TryOutType] ([TryOutTypeId])
GO
ALTER TABLE [dbo].[TryOut] CHECK CONSTRAINT [FK_TryOutType]
GO
/****** Object:  ForeignKey [FK_MemberSkier]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[TeamMember]  WITH CHECK ADD  CONSTRAINT [FK_MemberSkier] FOREIGN KEY([NumberId])
REFERENCES [dbo].[Skier] ([NumberId])
GO
ALTER TABLE [dbo].[TeamMember] CHECK CONSTRAINT [FK_MemberSkier]
GO
/****** Object:  ForeignKey [FK_MemberTeam]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[TeamMember]  WITH CHECK ADD  CONSTRAINT [FK_MemberTeam] FOREIGN KEY([TeamId])
REFERENCES [dbo].[Team] ([TeamId])
GO
ALTER TABLE [dbo].[TeamMember] CHECK CONSTRAINT [FK_MemberTeam]
GO
/****** Object:  ForeignKey [PK_StageTryOut]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Stage]  WITH CHECK ADD  CONSTRAINT [PK_StageTryOut] FOREIGN KEY([TryOutId])
REFERENCES [dbo].[TryOut] ([TryOutId])
GO
ALTER TABLE [dbo].[Stage] CHECK CONSTRAINT [PK_StageTryOut]
GO
/****** Object:  ForeignKey [FK_CompetitorSkier]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Competitor]  WITH CHECK ADD  CONSTRAINT [FK_CompetitorSkier] FOREIGN KEY([NumberId])
REFERENCES [dbo].[Skier] ([NumberId])
GO
ALTER TABLE [dbo].[Competitor] CHECK CONSTRAINT [FK_CompetitorSkier]
GO
/****** Object:  ForeignKey [FK_Intervention_Stage]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Intervention]  WITH CHECK ADD  CONSTRAINT [FK_Intervention_Stage] FOREIGN KEY([StageId])
REFERENCES [dbo].[Stage] ([StageId])
GO
ALTER TABLE [dbo].[Intervention] CHECK CONSTRAINT [FK_Intervention_Stage]
GO
/****** Object:  ForeignKey [FK_InterventionCompetitor]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Intervention]  WITH CHECK ADD  CONSTRAINT [FK_InterventionCompetitor] FOREIGN KEY([CompetitorId])
REFERENCES [dbo].[Competitor] ([CompetitorId])
GO
ALTER TABLE [dbo].[Intervention] CHECK CONSTRAINT [FK_InterventionCompetitor]
GO
/****** Object:  ForeignKey [FK_Route_Stage]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_Stage] FOREIGN KEY([StageId])
REFERENCES [dbo].[Stage] ([StageId])
GO
ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_Stage]
GO
/****** Object:  ForeignKey [FK_RouteSeason]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_RouteSeason] FOREIGN KEY([SeasonId])
REFERENCES [dbo].[Season] ([SeasonId])
GO
ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_RouteSeason]
GO
/****** Object:  ForeignKey [FK_Track_Route]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Track_Route]  WITH CHECK ADD  CONSTRAINT [FK_Track_Route] FOREIGN KEY([RouteId])
REFERENCES [dbo].[Route] ([RouteId])
GO
ALTER TABLE [dbo].[Track_Route] CHECK CONSTRAINT [FK_Track_Route]
GO
/****** Object:  ForeignKey [FK_Track_RouteTrack]    Script Date: 11/25/2017 20:01:58 ******/
ALTER TABLE [dbo].[Track_Route]  WITH CHECK ADD  CONSTRAINT [FK_Track_RouteTrack] FOREIGN KEY([TrackId])
REFERENCES [dbo].[Track] ([TrackId])
GO
ALTER TABLE [dbo].[Track_Route] CHECK CONSTRAINT [FK_Track_RouteTrack]
GO
