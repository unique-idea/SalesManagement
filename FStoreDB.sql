USE [master]
-- DROP DATABASE FStoreDB
GO
/****** Object:  Database [FStoreDB]    Script Date: 11/12/2022 9:34:16 AM ******/
CREATE DATABASE [FStoreDB]
GO
USE [FStoreDB]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 11/12/2022 9:34:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberID] [int] NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[CompanyName] [nvarchar](40) NOT NULL,
	[City] [nvarchar](15) NOT NULL,
	[Country] [nvarchar](15) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/12/2022 9:34:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Discount] [float] NOT NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/12/2022 9:34:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[RequiredDate] [datetime] NULL,
	[ShippedDate] [datetime] NULL,
	[Freight] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/12/2022 9:34:17 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[ProductName] [nvarchar](40) NOT NULL,
	[Weight] [nvarchar](20) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[UnitInStock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO 
INSERT [dbo].[Members] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (1, N'user1@fstore.com', N'Kiet', N'HCM', N'Vietnam', N'user1')
INSERT [dbo].[Members] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (2, N'user2@fstore.com', N'Tien', N'HCM', N'VietNam', N'user2')
INSERT [dbo].[Members] ([MemberID], [Email], [CompanyName], [City], [Country], [Password]) VALUES (3, N'user2@fstore.com', N'Thanh', N'HCM', N'VietNam', N'user3')
GO
INSERT [dbo].[OrderDetail] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (1, 1, 20490000.0000, 1, 10)
INSERT [dbo].[OrderDetail] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (2, 2, 20990000.0000, 1, 20)
INSERT [dbo].[OrderDetail] ([OrderID], [ProductID], [UnitPrice], [Quantity], [Discount]) VALUES (3, 1, 20490000.0000, 2, 10)
GO
INSERT [dbo].[Orders] ([OrderID], [MemberID], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (1, 2, CAST(N'2022-12-10T00:00:00.000' AS DateTime), CAST(N'2022-12-15T00:00:00.000' AS DateTime), CAST(N'2022-12-18T00:00:00.000' AS DateTime), 1000.0000)
INSERT [dbo].[Orders] ([OrderID], [MemberID], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (2, 1, CAST(N'2022-10-11T00:00:00.000' AS DateTime), CAST(N'2022-10-15T00:00:00.000' AS DateTime), CAST(N'2022-10-20T00:00:00.000' AS DateTime), 2000.0000)
INSERT [dbo].[Orders] ([OrderID], [MemberID], [OrderDate], [RequiredDate], [ShippedDate], [Freight]) VALUES (3, 1, CAST(N'2022-11-11T00:00:00.000' AS DateTime), CAST(N'2022-12-15T00:00:00.000' AS DateTime), CAST(N'2022-12-15T00:00:00.000' AS DateTime), 5000.0000)
GO
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (1, 1, N'Gaming G5 GD-51VN123SO', N'2.2', 20490000.0000, 100)
INSERT [dbo].[Product] ([ProductID], [CategoryID], [ProductName], [Weight], [UnitPrice], [UnitInStock]) VALUES (2, 1, N'Gaming FX506LHB-HN188W', N'2.3', 20990000.0000, 100)
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([ProductID])
REFERENCES [dbo].[Product] ([ProductID])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
USE [master]
GO
ALTER DATABASE [FStoreDB] SET  READ_WRITE 
GO
