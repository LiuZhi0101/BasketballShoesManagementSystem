create database GoodsDB
go
use GoodsDB
/****** Object:  Table [dbo].[Admin_Info]    Script Date: 2023/5/20 19:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin_Info](
	[Admin_ID] [int] IDENTITY(1,1) NOT NULL,
	[Admin_Uid] [varchar](20) NOT NULL,
	[Admin_Pwd] [varchar](20) NOT NULL,
	[Admin_Phone] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Admin_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Goods]    Script Date: 2023/5/20 19:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Goods](
	[Goods_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ru_Uid] [varchar](10) NOT NULL,
	[Goods_Name] [varchar](20) NOT NULL,
	[Goods_Brand] [varchar](20) NOT NULL,
	[Goods_Spec] [varchar](20) NOT NULL,
	[Goods_Type] [varchar](20) NOT NULL,
	[Goods_Number] [int] NOT NULL,
	[Goods_Place] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Goods_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Goods_Chu]    Script Date: 2023/5/20 19:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Goods_Chu](
	[Chu_ID] [int] IDENTITY(1,1) NOT NULL,
	[Chu_Uid] [int] NULL,
	[Chu_Name] [varchar](20) NOT NULL,
	[Chu_Brand] [varchar](20) NOT NULL,
	[Chu_Spec] [varchar](20) NOT NULL,
	[Chu_Type] [varchar](20) NOT NULL,
	[Chu_Number] [int] NOT NULL,
	[Chu_Time] [datetime] NOT NULL,
	[Chu_state] [int] NOT NULL,
	[Chu_Place] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Chu_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Goods_Damage]    Script Date: 2023/5/20 19:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Goods_Damage](
	[Damage_ID] [int] IDENTITY(1,1) NOT NULL,
	[Damage_Uid] [int] NULL,
	[Damage_Name] [varchar](20) NOT NULL,
	[Damage_Brand] [varchar](20) NOT NULL,
	[Damage_Spec] [varchar](20) NOT NULL,
	[Damage_Type] [varchar](20) NOT NULL,
	[Damage_Number] [int] NOT NULL,
	[Damage_Time] [datetime] NOT NULL,
	[Damage_state] [int] NOT NULL,
	[Damage_Place] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Damage_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Goods_Ru]    Script Date: 2023/5/20 19:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Goods_Ru](
	[Ru_ID] [int] IDENTITY(1,1) NOT NULL,
	[Ru_Uid] [varchar](10) NOT NULL,
	[Ru_Name] [varchar](20) NOT NULL,
	[Ru_Brand] [varchar](20) NOT NULL,
	[Ru_Spec] [varchar](20) NOT NULL,
	[Ru_Type] [varchar](20) NOT NULL,
	[Ru_Number] [int] NOT NULL,
	[Ru_Time] [datetime] NOT NULL,
	[Ru_state] [int] NOT NULL,
	[Ru_Place] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Ru_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Room]    Script Date: 2023/5/20 19:53:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Room](
	[Room_ID] [int] IDENTITY(1,1) NOT NULL,
	[Room_name] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Room_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Admin_Info] ON 

INSERT [dbo].[Admin_Info] ([Admin_ID], [Admin_Uid], [Admin_Pwd], [Admin_Phone]) VALUES (1, N'admin', N'123', N'15115113140')
INSERT [dbo].[Admin_Info] ([Admin_ID], [Admin_Uid], [Admin_Pwd], [Admin_Phone]) VALUES (2, N'123', N'123', N'15674043561')
INSERT [dbo].[Admin_Info] ([Admin_ID], [Admin_Uid], [Admin_Pwd], [Admin_Phone]) VALUES (3, N'789', N'123', N'15574597975')
INSERT [dbo].[Admin_Info] ([Admin_ID], [Admin_Uid], [Admin_Pwd], [Admin_Phone]) VALUES (4, N'456', N'123', N'18613941367')
SET IDENTITY_INSERT [dbo].[Admin_Info] OFF
SET IDENTITY_INSERT [dbo].[Goods] ON 

INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (1, N'202110', N'Nike男鞋', N'Nike', N'35', N'板鞋', 110, 1)
INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (2, N'202110', N'Nike男鞋', N'Nike', N'35', N'板鞋', 98, 1)
INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (3, N'2021101', N'Nike男鞋', N'Nike', N'37', N'板鞋', 100, 1)
INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (4, N'1', N'Nike男鞋', N'Nike', N'35', N'板鞋', 30, 8)
INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (5, N'1', N'Nike男鞋', N'Nike', N'35', N'板鞋', 30, 8)
INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (6, N'2', N'Nike男鞋', N'Nike', N'35', N'板鞋', 1, 9)
INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (7, N'1', N'Nike男鞋', N'Nike', N'35', N'板鞋', 30, 8)
INSERT [dbo].[Goods] ([Goods_ID], [Ru_Uid], [Goods_Name], [Goods_Brand], [Goods_Spec], [Goods_Type], [Goods_Number], [Goods_Place]) VALUES (8, N'2', N'Nike男鞋', N'Nike', N'35', N'板鞋', 1, 9)
SET IDENTITY_INSERT [dbo].[Goods] OFF
SET IDENTITY_INSERT [dbo].[Goods_Chu] ON 

INSERT [dbo].[Goods_Chu] ([Chu_ID], [Chu_Uid], [Chu_Name], [Chu_Brand], [Chu_Spec], [Chu_Type], [Chu_Number], [Chu_Time], [Chu_state], [Chu_Place]) VALUES (1, 1, N'Nike男鞋', N'Nike', N'35', N'板鞋', 30, CAST(N'2023-05-19 20:29:14.000' AS DateTime), 2, 8)
INSERT [dbo].[Goods_Chu] ([Chu_ID], [Chu_Uid], [Chu_Name], [Chu_Brand], [Chu_Spec], [Chu_Type], [Chu_Number], [Chu_Time], [Chu_state], [Chu_Place]) VALUES (2, 1, N'Nike男鞋', N'Nike', N'35', N'板鞋', 35, CAST(N'2023-05-20 16:25:38.000' AS DateTime), 1, 8)
SET IDENTITY_INSERT [dbo].[Goods_Chu] OFF
SET IDENTITY_INSERT [dbo].[Goods_Damage] ON 

INSERT [dbo].[Goods_Damage] ([Damage_ID], [Damage_Uid], [Damage_Name], [Damage_Brand], [Damage_Spec], [Damage_Type], [Damage_Number], [Damage_Time], [Damage_state], [Damage_Place]) VALUES (1, 2, N'Nike男鞋', N'Nike', N'35', N'板鞋', 1, CAST(N'2023-05-20 14:57:04.000' AS DateTime), 2, N'报损仓库')
INSERT [dbo].[Goods_Damage] ([Damage_ID], [Damage_Uid], [Damage_Name], [Damage_Brand], [Damage_Spec], [Damage_Type], [Damage_Number], [Damage_Time], [Damage_state], [Damage_Place]) VALUES (2, 2, N'Nike男鞋', N'Nike', N'35', N'板鞋', 1, CAST(N'2023-05-20 16:26:09.000' AS DateTime), 1, N'报损仓库')
SET IDENTITY_INSERT [dbo].[Goods_Damage] OFF
SET IDENTITY_INSERT [dbo].[Goods_Ru] ON 

INSERT [dbo].[Goods_Ru] ([Ru_ID], [Ru_Uid], [Ru_Name], [Ru_Brand], [Ru_Spec], [Ru_Type], [Ru_Number], [Ru_Time], [Ru_state], [Ru_Place]) VALUES (3, N'202110', N'Nike男鞋', N'Nike', N'35', N'板鞋', 100, CAST(N'2023-05-19 15:26:35.000' AS DateTime), 2, 1)
INSERT [dbo].[Goods_Ru] ([Ru_ID], [Ru_Uid], [Ru_Name], [Ru_Brand], [Ru_Spec], [Ru_Type], [Ru_Number], [Ru_Time], [Ru_state], [Ru_Place]) VALUES (4, N'2021101', N'Nike男鞋', N'Nike', N'37', N'板鞋', 100, CAST(N'2023-05-19 16:42:47.000' AS DateTime), 2, 1)
INSERT [dbo].[Goods_Ru] ([Ru_ID], [Ru_Uid], [Ru_Name], [Ru_Brand], [Ru_Spec], [Ru_Type], [Ru_Number], [Ru_Time], [Ru_state], [Ru_Place]) VALUES (5, N'202110', N'Nike男鞋', N'Nike', N'35', N'板鞋', 100, CAST(N'2023-05-19 16:57:40.000' AS DateTime), 2, 1)
SET IDENTITY_INSERT [dbo].[Goods_Ru] OFF
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (1, N'1号仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (2, N'2号仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (3, N'3号仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (4, N'4号仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (5, N'5号仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (6, N'6号仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (7, N'7号仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (8, N'出货仓库')
INSERT [dbo].[Room] ([Room_ID], [Room_name]) VALUES (9, N'报损仓库')
SET IDENTITY_INSERT [dbo].[Room] OFF
ALTER TABLE [dbo].[Goods]  WITH CHECK ADD FOREIGN KEY([Goods_Place])
REFERENCES [dbo].[Room] ([Room_ID])
GO
ALTER TABLE [dbo].[Goods_Chu]  WITH CHECK ADD FOREIGN KEY([Chu_Place])
REFERENCES [dbo].[Room] ([Room_ID])
GO
ALTER TABLE [dbo].[Goods_Chu]  WITH CHECK ADD FOREIGN KEY([Chu_Uid])
REFERENCES [dbo].[Goods] ([Goods_ID])
GO
ALTER TABLE [dbo].[Goods_Damage]  WITH CHECK ADD FOREIGN KEY([Damage_Uid])
REFERENCES [dbo].[Goods] ([Goods_ID])
GO
ALTER TABLE [dbo].[Goods_Ru]  WITH CHECK ADD FOREIGN KEY([Ru_Place])
REFERENCES [dbo].[Room] ([Room_ID])
GO
ALTER TABLE [dbo].[Goods_Chu]  WITH CHECK ADD CHECK  (([Chu_state]=(1) OR [Chu_state]=(2)))
GO
ALTER TABLE [dbo].[Goods_Damage]  WITH CHECK ADD CHECK  (([Damage_state]=(1) OR [Damage_state]=(2)))
GO
ALTER TABLE [dbo].[Goods_Ru]  WITH CHECK ADD CHECK  (([Ru_state]=(1) OR [Ru_state]=(2)))
GO
