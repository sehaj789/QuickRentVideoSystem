USE [master]
GO
/****** Object:  Database [QuickRentDB]    Script Date: 05-08-2021 3.20.01 AM ******/
CREATE DATABASE [QuickRentDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuickRentDB_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuickRentDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuickRentDB_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QuickRentDB.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuickRentDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuickRentDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuickRentDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuickRentDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuickRentDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuickRentDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuickRentDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuickRentDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuickRentDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuickRentDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuickRentDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuickRentDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuickRentDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuickRentDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuickRentDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuickRentDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuickRentDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuickRentDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuickRentDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuickRentDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuickRentDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuickRentDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuickRentDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuickRentDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuickRentDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuickRentDB] SET  MULTI_USER 
GO
ALTER DATABASE [QuickRentDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuickRentDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuickRentDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuickRentDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuickRentDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuickRentDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuickRentDB', N'ON'
GO
ALTER DATABASE [QuickRentDB] SET QUERY_STORE = OFF
GO
USE [QuickRentDB]
GO
/****** Object:  Table [dbo].[RentalData]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Customer_ID] [int] NOT NULL,
	[Video_ID] [int] NOT NULL,
	[Start] [varchar](50) NULL,
	[Due] [varchar](50) NULL,
	[Status] [varchar](50) NULL,
	[Cost] [int] NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VideoData]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VideoData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NULL,
	[Genre] [varchar](50) NULL,
	[Cost] [varchar](10) NULL,
	[Language] [varchar](50) NULL,
	[Copies] [int] NULL,
	[Year] [varchar](50) NULL,
 CONSTRAINT [PK_Video] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[AllBookedVideo]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[AllBookedVideo]
AS
SELECT dbo.RentalData.Video_ID AS ID, dbo.VideoData.Title, dbo.VideoData.Genre, dbo.VideoData.Cost, dbo.VideoData.Copies, dbo.VideoData.Language, dbo.VideoData.Year
FROM   dbo.RentalData INNER JOIN
             dbo.VideoData ON dbo.RentalData.Video_ID = dbo.VideoData.ID
GO
/****** Object:  View [dbo].[OutRentedVideo]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[OutRentedVideo]
AS
SELECT dbo.VideoData.ID, dbo.VideoData.Title, dbo.VideoData.Genre, dbo.VideoData.Cost, dbo.VideoData.Copies, dbo.VideoData.Language, dbo.VideoData.Year
FROM   dbo.VideoData LEFT OUTER JOIN
             dbo.RentalData ON dbo.RentalData.Video_ID = dbo.VideoData.ID
WHERE (dbo.RentalData.Video_ID IS NULL)
GO
/****** Object:  Table [dbo].[CustomerData]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerData](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[JoinDate] [varchar](50) NULL,
	[TotalPurchase] [int] NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_Customer_1] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[GetCustomerData]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetCustomerData]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT ID,Name,Phone,Address,TotalPurchase,JoinDate from CustomerData;
END
GO
/****** Object:  StoredProcedure [dbo].[GetRentalData]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRentalData] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT b.Customer_ID as 'CID',b.Video_ID as 'VID', b.ID as 'ID',c.Name as 'Customer',v.Title as 'Video',v.Cost as 'Cost',b.Start as 'Booking Date',b.Due as 'Return Date',ISNULL(b.Cost,0) as 'Amount', b.Status as 'Status'
	from RentalData b,VideoData v,CustomerData c where b.Customer_ID=c.ID and b.Video_ID=v.ID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetVideoData]    Script Date: 05-08-2021 3.20.01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetVideoData] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT ID,Title,Genre,Cost+' $' as 'Cost',Copies,Language,Year from VideoData;
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[26] 2[15] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VideoData"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 206
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RentalData"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AllBookedVideo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'AllBookedVideo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VideoData"
            Begin Extent = 
               Top = 9
               Left = 57
               Bottom = 206
               Right = 279
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "RentalData"
            Begin Extent = 
               Top = 9
               Left = 336
               Bottom = 206
               Right = 558
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OutRentedVideo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'OutRentedVideo'
GO
USE [master]
GO
ALTER DATABASE [QuickRentDB] SET  READ_WRITE 
GO
