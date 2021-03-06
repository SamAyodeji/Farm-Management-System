USE [FARM.DB]
GO
/****** Object:  Table [dbo].[TransDB]    Script Date: 06/04/2017 23:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransDB](
	[s/n] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[Batch_number] [varchar](max) NOT NULL,
	[Mortality] [varchar](max) NOT NULL,
	[Feed] [int] NOT NULL,
	[Medication_Type] [varchar](50) NOT NULL,
	[Medication_Amt] [money] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Logindb]    Script Date: 06/04/2017 23:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Logindb](
	[sn] [int] IDENTITY(1,1) NOT NULL,
	[Full name] [varchar](50) NULL,
	[USERNAME] [varchar](50) NOT NULL,
	[PASSWORD] [varchar](50) NOT NULL,
	[Re-type_Password] [varchar](50) NULL,
	[date] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FARMINFO.DB]    Script Date: 06/04/2017 23:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FARMINFO.DB](
	[S/N] [int] IDENTITY(1,1) NOT NULL,
	[TYPE] [varchar](50) NOT NULL,
	[BATCH CODE] [varchar](100) NOT NULL,
	[NUMBER OF COLLECTION] [varchar](max) NOT NULL,
	[AGE OF COLLECTION] [varchar](10) NOT NULL,
	[TOTAL MORTALITY] [varchar](max) NOT NULL,
	[TOTAL FEED(KG)] [int] NOT NULL,
	[AMT OF TOTAL MEDICATION] [money] NOT NULL,
	[DATE_COLLECT] [date] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FARMINFO]    Script Date: 06/04/2017 23:50:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FARMINFO](
	[S/N] [int] IDENTITY(1,1) NOT NULL,
	[TYPE] [varchar](50) NOT NULL,
	[BATCH_NUMBER] [int] NOT NULL,
	[NUMBER_COLLECTED] [int] NOT NULL,
	[AGE_COLLECTED] [varchar](10) NOT NULL,
	[TOTAL_MORTALITY] [int] NOT NULL,
	[TOTAL_FEED(KG)] [int] NOT NULL,
	[MEDICATION_AMT] [money] NOT NULL,
	[DATE_COLLECT] [date] NOT NULL,
	[STATUS] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Logindb_date]    Script Date: 06/04/2017 23:50:37 ******/
ALTER TABLE [dbo].[Logindb] ADD  CONSTRAINT [DF_Logindb_date]  DEFAULT (getdate()) FOR [date]
GO
/****** Object:  Default [DF_FARMINFO.DB_DATE OF COLLECTION]    Script Date: 06/04/2017 23:50:37 ******/
ALTER TABLE [dbo].[FARMINFO] ADD  CONSTRAINT [DF_FARMINFO.DB_DATE OF COLLECTION]  DEFAULT (getdate()) FOR [DATE_COLLECT]
GO
/****** Object:  Default [DF_FARMINFO_status]    Script Date: 06/04/2017 23:50:37 ******/
ALTER TABLE [dbo].[FARMINFO] ADD  CONSTRAINT [DF_FARMINFO_status]  DEFAULT ((0)) FOR [STATUS]
GO
