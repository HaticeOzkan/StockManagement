USE [master]
GO
/****** Object:  Database [StockManagement]    Script Date: 05/01/2019 14:53:59 ******/
CREATE DATABASE [StockManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StockManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StockManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\StockManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StockManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StockManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StockManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StockManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StockManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StockManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StockManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StockManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StockManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StockManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StockManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StockManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [StockManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StockManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StockManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StockManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StockManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StockManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [StockManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StockManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [StockManagement] SET  MULTI_USER 
GO
ALTER DATABASE [StockManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StockManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StockManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StockManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StockManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [StockManagement] SET QUERY_STORE = OFF
GO
USE [StockManagement]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[BrandID] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[BrandID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhoneCases]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhoneCases](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](150) NULL,
	[Price] [decimal](18, 2) NULL,
	[Color] [int] NULL,
	[StockCount] [int] NULL,
 CONSTRAINT [PK_PhoneCases] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phones]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phones](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](150) NULL,
	[Price] [decimal](18, 2) NULL,
	[IMEI1] [nvarchar](50) NULL,
	[IMEI2] [nvarchar](50) NULL,
	[ModelCode] [nvarchar](50) NULL,
	[BrandID] [int] NULL,
	[StockCount] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Index [StockCount]    Script Date: 05/01/2019 14:53:59 ******/
CREATE NONCLUSTERED INDEX [StockCount] ON [dbo].[PhoneCases]
(
	[StockCount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AddStockPhone]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AddStockPhone]
@ID int,@StockCount int
as
begin
update Phones set StockCount+=@StockCount where ID=@ID 
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteBrand]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[DeleteBrand]
@ID int
as
begin
delete from Brands where BrandID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[DeletePhone]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DeletePhone]
@ID int
as
begin
delete from Phones where ID=@ID
end
GO
/****** Object:  StoredProcedure [dbo].[GetAvailableProduct]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetAvailableProduct]
@q as nvarchar(50) = NULL
AS
BEGIN

DECLARE @sql AS nvarchar(MAX)
SET @sql = 'SELECT ID, ProductName, Price, IMEI1, IMEI2 FROM Phones '

IF (@q IS NOT NULL)
BEGIN
	SET @sql += 'WHERE StockCount != 0 AND (ProductName LIKE ''%'+@q+'%'''
	SET @sql += 'OR IMEI1 LIKE ''%'+@q+'%'''
	SET @sql += 'OR IMEI2 LIKE ''%'+@q+'%'''
	SET @sql += 'OR ModelCode LIKE ''%'+@q+'%'')'
END
	ELSE
		SET @sql += 'WHERE StockCount != 0'

SET @sql += ' UNION ALL '
SET @sql += 'SELECT ID, ProductName, Price, '''', '''' FROM PhoneCases '

IF (@q IS NOT NULL)
	SET @sql += 'WHERE StockCount != 0 AND ProductName LIKE ''%'+@q+'%'''
ELSE
	SET @sql += 'WHERE StockCount != 0'

--SELECT @sql
exec (@sql)
END
GO
/****** Object:  StoredProcedure [dbo].[GetPhones]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[GetPhones]
as
begin
SELECT p.*,b.BrandID AS BID,b.BrandName FROM Phones p inner join Brands b on p.BrandID=b.BrandID
 order by BrandID,ProductName
end
--il
GO
/****** Object:  StoredProcedure [dbo].[InsertPhone]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertPhone]
@ProductName nvarchar(150),@Price decimal, @IMEI1 nvarchar(50),@IMEI2 nvarchar(50),@ModelCode nvarchar(50),@BrandId int,@StockCount int
as
begin
insert into Phones (ProductName,Price,IMEI1,IMEI2,ModelCode,BrandID,StockCount)values(@ProductName,@Price, @IMEI1,@IMEI1,@ModelCode,@BrandId,@StockCount)
end-- ıd yazmadık
GO
/****** Object:  StoredProcedure [dbo].[InsertPhoneCase]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[InsertPhoneCase]
@ProductName nvarchar(150),@Price decimal(18,2),@Color int,@StkCount int
as
begin
insert into PhoneCases (ProductName,Price,Color,StockCount) values (@ProductName,@Price,@Color,@StkCount)
end
GO
/****** Object:  StoredProcedure [dbo].[SearchPhone]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SearchPhone]
@ID int=0,@MC nvarchar(50)=''
as
begin
select p.ModelCode,p.Price,p.ProductName,p.ID,b.BrandName
from dbo.Phones P inner join dbo.Brands b 
on p.BrandID=b.BrandID  
where( b.BrandID=@ID OR @ID=0)
AND
(ModelCode like '%'+@MC+'%' OR @MC='')
end
GO
/****** Object:  StoredProcedure [dbo].[UpdatePhoneCase]    Script Date: 05/01/2019 14:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UpdatePhoneCase]
@ID int,@StkSay int
as
begin
update PhoneCases set StockCount+=@StkSay where ID=@ID 
end
GO
USE [master]
GO
ALTER DATABASE [StockManagement] SET  READ_WRITE 
GO
