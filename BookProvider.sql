/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Standard Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [QuanLySachDB]    Script Date: 12/19/2018 10:59:50 PM ******/
CREATE DATABASE [QuanLySachDB]
 CONTAINMENT = NONE
 GO
ALTER DATABASE [QuanLySachDB] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLySachDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLySachDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLySachDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLySachDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLySachDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLySachDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLySachDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLySachDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLySachDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLySachDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLySachDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLySachDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLySachDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLySachDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLySachDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLySachDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLySachDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLySachDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLySachDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLySachDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLySachDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLySachDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLySachDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLySachDB] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLySachDB] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLySachDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLySachDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLySachDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLySachDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLySachDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLySachDB] SET QUERY_STORE = OFF
GO
USE [QuanLySachDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [QuanLySachDB]
GO
/****** Object:  Table [dbo].[tblChiTietHoaDon]    Script Date: 12/19/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietHoaDon](
	[soHoaDon] [int] NOT NULL,
	[maSach] [nvarchar](10) NOT NULL,
	[soLuong] [int] NULL,
	[ghiChu] [nvarchar](100) NULL,
	[hieuLuc] [bit] NOT NULL,
 CONSTRAINT [PK_tblChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[soHoaDon] ASC,
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDaiLy]    Script Date: 12/19/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDaiLy](
	[maDaiLy] [nvarchar](10) NOT NULL,
	[tenDaiLy] [nvarchar](50) NOT NULL,
	[tenChuDaiLy] [nvarchar](50) NULL,
	[diaChi] [nvarchar](50) NULL,
	[dienThoai] [nvarchar](20) NULL,
	[cungCap] [bit] NOT NULL,
 CONSTRAINT [PK_tblDaiLy] PRIMARY KEY CLUSTERED 
(
	[maDaiLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDangNhap]    Script Date: 12/19/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDangNhap](
	[username] [nvarchar](30) NOT NULL,
	[password] [nvarchar](30) NOT NULL,
	[isAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_tblDangNhap] PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 12/19/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoaDon](
	[soHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[ngayLapHD] [date] NULL,
	[maDaiLy] [nvarchar](10) NULL,
	[hieuLuc] [bit] NOT NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[soHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhaXB]    Script Date: 12/19/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaXB](
	[maNhaXB] [nvarchar](10) NOT NULL,
	[tenNhaXB] [nvarchar](100) NOT NULL,
	[diaChi] [nvarchar](100) NULL,
	[dienThoai] [nvarchar](20) NULL,
	[cungCap] [bit] NOT NULL,
 CONSTRAINT [PK_tblNhaXB] PRIMARY KEY CLUSTERED 
(
	[maNhaXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 12/19/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[maSach] [nvarchar](10) NOT NULL,
	[tenSach] [nvarchar](100) NOT NULL,
	[tenTacGia] [nvarchar](50) NULL,
	[giaBia] [nvarchar](10) NULL,
	[giaBanChoDaiLy] [nvarchar](10) NULL,
	[maNhaXB] [nvarchar](10) NOT NULL,
	[trang] [int] NULL,
	[cungCap] [bit] NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS004', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS005', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS006', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS007', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS008', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS009', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS010', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS011', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS012', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (13, N'MS013', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (14, N'MS001', 5000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (14, N'MS003', 5000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (14, N'MS019', 100, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (14, N'MS020', 1000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (15, N'MS017', 12000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (15, N'MS018', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (15, N'MS020', 10000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (15, N'MS021', 15000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (15, N'MS022', 20000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (15, N'MS023', 15000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (15, N'MS024', 20000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (16, N'MS004', 5000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (16, N'MS005', 5000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (16, N'MS006', 5000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (16, N'MS007', 5000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (16, N'MS008', 5000, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (17, N'MS003', 1233, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (17, N'MS004', 123123, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (17, N'MS005', 123123, NULL, 1)
INSERT [dbo].[tblChiTietHoaDon] ([soHoaDon], [maSach], [soLuong], [ghiChu], [hieuLuc]) VALUES (17, N'MS006', 12311, NULL, 1)
INSERT [dbo].[tblDaiLy] ([maDaiLy], [tenDaiLy], [tenChuDaiLy], [diaChi], [dienThoai], [cungCap]) VALUES (N'DL12', N'Dai Ly', N'Dai Ly ABC', N'asdas', N'123123123', 1)
INSERT [dbo].[tblDaiLy] ([maDaiLy], [tenDaiLy], [tenChuDaiLy], [diaChi], [dienThoai], [cungCap]) VALUES (N'DL2', N'Nhà sách Sài Gòn', N'BBB', N'Quận Bình Thạnh, TP.HCM', N'0209907654', 1)
INSERT [dbo].[tblDaiLy] ([maDaiLy], [tenDaiLy], [tenChuDaiLy], [diaChi], [dienThoai], [cungCap]) VALUES (N'DL3', N'Nhà sách ABC', N'Lê Vũ Việt', N'Quận Thủ Đức, TP.HCM', N'0124987456', 1)
INSERT [dbo].[tblDaiLy] ([maDaiLy], [tenDaiLy], [tenChuDaiLy], [diaChi], [dienThoai], [cungCap]) VALUES (N'DL4', N'Nhà sách Ruby', N'Phan Hoàng Minh Luân', N'Quận 1, TP.HCM', N'0345789456', 1)
INSERT [dbo].[tblDaiLy] ([maDaiLy], [tenDaiLy], [tenChuDaiLy], [diaChi], [dienThoai], [cungCap]) VALUES (N'DL5', N'Nhà sách AAA', N'Trần Văn A', N'Q3, TP HCM', N'0348251616', 1)
INSERT [dbo].[tblDaiLy] ([maDaiLy], [tenDaiLy], [tenChuDaiLy], [diaChi], [dienThoai], [cungCap]) VALUES (N'DL6', N'Nhà sách TT', N'TEST 123', N'Nguyễn Thiện Thuật, Quận 3', N'0966453777', 0)
INSERT [dbo].[tblDangNhap] ([username], [password], [isAdmin]) VALUES (N'admin', N'daithanh', 1)
INSERT [dbo].[tblDangNhap] ([username], [password], [isAdmin]) VALUES (N'daithanh', N'123', 1)
SET IDENTITY_INSERT [dbo].[tblHoaDon] ON 

INSERT [dbo].[tblHoaDon] ([soHoaDon], [ngayLapHD], [maDaiLy], [hieuLuc]) VALUES (13, CAST(N'2018-10-30' AS Date), N'DL4', 1)
INSERT [dbo].[tblHoaDon] ([soHoaDon], [ngayLapHD], [maDaiLy], [hieuLuc]) VALUES (14, CAST(N'2018-10-30' AS Date), N'DL2', 1)
INSERT [dbo].[tblHoaDon] ([soHoaDon], [ngayLapHD], [maDaiLy], [hieuLuc]) VALUES (15, CAST(N'2018-10-30' AS Date), N'DL5', 1)
INSERT [dbo].[tblHoaDon] ([soHoaDon], [ngayLapHD], [maDaiLy], [hieuLuc]) VALUES (16, CAST(N'2018-10-30' AS Date), N'DL3', 1)
INSERT [dbo].[tblHoaDon] ([soHoaDon], [ngayLapHD], [maDaiLy], [hieuLuc]) VALUES (17, CAST(N'2018-11-02' AS Date), N'DL12', 1)
SET IDENTITY_INSERT [dbo].[tblHoaDon] OFF
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB000', N'Nhà xuất bản TZB', N'Phạm Văn Chiêu, Gò Vấp, TP HCM', N'01245487888', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB001', N'Nhà xuất bản Kim Đồng', N'55 Quang Trung, Hai Bà Trưng, Hà Nội', N'02439434730', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB002', N'Nhà xuất bản Trẻ', N'161B Lý Chính Thắng, Phường 7, Quận 3, Thành phố Hồ Chí Minh', N'02839316289', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB003', N'Nhà xuất bản Tổng hợp thành phố Hồ Chí Minh', N'62 Nguyễn Thị Minh Khai, Phường Đa Kao, Quận 1, TP.HCM', N'02838225340', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB004', N'Nhà xuất bản chính trị quốc gia', N'Số 6/86 Duy Tân, Cầu Giấy, Hà Nội', N'02438221633', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB005', N'Nhà xuất bản giáo dục', N'81 Trần Hưng Đạo, Hà Nội', N'02438220801', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB006', N'Nhà xuất bản Hội Nhà văn', N'Số 65 Nguyễn Du, Hà Nội', N'02438222135', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB007', N'Nhà xuất bản Tư pháp', N'Số 35 Trần Quốc Toản, Hoàn Kiếm, Hà Nội', N'02462632078', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB008', N'Nhà xuất bản thông tin và truyền thông', N'Tầng 6, Tòa nhà Cục Tần số Vô tuyến điện, số 115 Trần Duy Hưng, Hà Nội', N'02435772145', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB009', N'Nhà xuất bản lao động', N'175 Giảng Võ, Đống Đa, Hà Nội', N'02438515380', 1)
INSERT [dbo].[tblNhaXB] ([maNhaXB], [tenNhaXB], [diaChi], [dienThoai], [cungCap]) VALUES (N'NXB010', N'Nhà xuất bản giao thông vận tải', N'80B Trần Hưng Đạo, Hoàn Kiếm, Hà Nội', N'02439423346', 0)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS001', N'Ngôi nhà ấm áp', N'Nhiều tác giả', N'60000', N'55000', N'NXB001', 128, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS002', N'Lời cảm ơn', N'Nhiều tác giả', N'20000', N'18000', N'NXB001', 12, 0)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS003', N'Trái Đất là một vòng tròn', N'Nhiều tác giả', N'65000', N'60000', N'NXB001', 122, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS004', N'Ngũ quái Sài Gòn tập 1', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS005', N'Ngũ quái Sài Gòn tập 2', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS006', N'Ngũ quái Sài Gòn tập 3', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS007', N'Ngũ quái Sài Gòn tập 4', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS008', N'Ngũ quái Sài Gòn tập 5', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS009', N'Ngũ quái Sài Gòn tập 6', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS010', N'Ngũ quái Sài Gòn tập 7', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS011', N'Ngũ quái Sài Gòn tập 8', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS012', N'Ngũ quái Sài Gòn tập 9', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS013', N'Ngũ quái Sài Gòn tập 10', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS014', N'Ngũ quái Sài Gòn tập 11', N'Bùi Chí Vinh', N'39000', N'37000', N'NXB002', 248, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS015', N'Vì sao mình nhảy nhót', N'Naoki Higashida', N'65000', N'59000', N'NXB002', 182, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS016', N'Truyện ngắn Vũ Trọng Phụng', N'Vũ Trọng Phụng', N'80000', N'69000', N'NXB003', 423, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS017', N'Truyện ngắn Thạch Lam', N'Thạch Lam', N'67000', N'54000', N'NXB003', 291, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS018', N'Bỗng nhiên mà họ lớn', N'Đỗ Hồng Ngọc', N'78000', N'60000', N'NXB003', 162, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS019', N'Elon Musk: Tesla, SpaceX và sứ mệnh tìm kiếm một tương lai ngoài sức tưởng tượng', N'Ashlee Vance', N'300000', N'240000', N'NXB003', 500, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS020', N'Thanh xuân đáng giá bao nhiêu?', N'Nhiều tác giả', N'65000', N'50000', N'NXB001', 123, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS021', N'Tôi thấy hoa vàng trên cỏ xanh', N'Nguyễn Nhật Ánh', N'50000', N'43000', N'NXB002', 378, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS022', N'Cuộc đời có bao lâu mà...', N'Nhã Nam', N'55000', N'45000', N'NXB000', 168, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS023', N'Yêu và được Yêu', N'Nhã Nam', N'40000', N'35000', N'NXB000', 200, 1)
INSERT [dbo].[tblSach] ([maSach], [tenSach], [tenTacGia], [giaBia], [giaBanChoDaiLy], [maNhaXB], [trang], [cungCap]) VALUES (N'MS024', N'Mỉm cười và bước tới', N'Nhiều tác giả', N'45000', N'40000', N'NXB000', 196, 1)
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHoaDon_tblHoaDon] FOREIGN KEY([soHoaDon])
REFERENCES [dbo].[tblHoaDon] ([soHoaDon])
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_tblChiTietHoaDon_tblHoaDon]
GO
ALTER TABLE [dbo].[tblChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblChiTietHoaDon_tblSach] FOREIGN KEY([maSach])
REFERENCES [dbo].[tblSach] ([maSach])
GO
ALTER TABLE [dbo].[tblChiTietHoaDon] CHECK CONSTRAINT [FK_tblChiTietHoaDon_tblSach]
GO
ALTER TABLE [dbo].[tblHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tblHoaDon_tblDaiLy] FOREIGN KEY([maDaiLy])
REFERENCES [dbo].[tblDaiLy] ([maDaiLy])
GO
ALTER TABLE [dbo].[tblHoaDon] CHECK CONSTRAINT [FK_tblHoaDon_tblDaiLy]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_tblSach_tblNhaXB] FOREIGN KEY([maNhaXB])
REFERENCES [dbo].[tblNhaXB] ([maNhaXB])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_tblSach_tblNhaXB]
GO
/****** Object:  StoredProcedure [dbo].[GetNewestBill]    Script Date: 12/19/2018 10:59:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetNewestBill]
AS 
BEGIN
	select tblChiTietHoaDon.soHoaDon, maDaiLy, ngayLapHD, tblSach.maSach, tenSach, tenTacGia, giaBia, giaBanChoDaiLy, soLuong, maNhaXB, trang
from tblChiTietHoaDon, tblHoaDon, tblSach
where tblChiTietHoaDon.maSach=tblSach.maSach and tblChiTietHoaDon.soHoaDon=tblHoaDon.soHoaDon
and tblChiTietHoaDon.soHoaDon = (select top 1 tblChiTietHoaDon.soHoaDon from tblChiTietHoaDon order by tblChiTietHoaDon.soHoaDon desc)
END
GO
USE [master]
GO
ALTER DATABASE [QuanLySachDB] SET  READ_WRITE 
GO
