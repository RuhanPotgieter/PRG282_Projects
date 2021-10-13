USE [master]
GO

/****** Object:  Database [Students]    Script Date: 2021/10/13 20:18:22 ******/
DROP DATABASE [Students]
GO

/****** Object:  Database [Students]    Script Date: 2021/10/13 20:18:22 ******/
CREATE DATABASE [Students]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Students', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Students.mdf' , SIZE = 25600KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Students_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Students_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Students].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Students] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Students] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Students] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Students] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Students] SET ARITHABORT OFF 
GO

ALTER DATABASE [Students] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Students] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Students] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Students] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Students] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Students] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Students] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Students] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Students] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Students] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Students] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Students] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Students] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Students] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Students] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Students] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Students] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Students] SET RECOVERY FULL 
GO

ALTER DATABASE [Students] SET  MULTI_USER 
GO

ALTER DATABASE [Students] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Students] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Students] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Students] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Students] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Students] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [Students] SET QUERY_STORE = OFF
GO

ALTER DATABASE [Students] SET  READ_WRITE 
GO
