USE [Generacion23]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 25/12/2023 06:36:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Paterno] [varchar](50) NOT NULL,
	[Materno] [varchar](50) NOT NULL,
	[FechaAlta] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_persona] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 25/12/2023 06:36:41 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Edad] [int] NULL,
	[FechaAlta] [smalldatetime] NULL,
	[Paterno] [varchar](50) NULL,
	[Materno] [varchar](50) NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[persona] ON 

INSERT [dbo].[persona] ([id], [Nombre], [Paterno], [Materno], [FechaAlta]) VALUES (1, N'Oscar', N'Morales', N'Cruz', CAST(N'2023-12-04T11:44:00' AS SmallDateTime))
INSERT [dbo].[persona] ([id], [Nombre], [Paterno], [Materno], [FechaAlta]) VALUES (2, N'Oscar', N'Morales', N'Cruz', CAST(N'2023-12-04T11:51:00' AS SmallDateTime))
INSERT [dbo].[persona] ([id], [Nombre], [Paterno], [Materno], [FechaAlta]) VALUES (3, N'Omar', N'Morales', N'Cruz', CAST(N'2023-12-04T11:58:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[persona] OFF
GO
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([Id], [Nombre], [Edad], [FechaAlta], [Paterno], [Materno]) VALUES (2, N'Juana', 29, CAST(N'1996-10-08T00:00:00' AS SmallDateTime), N'Montes', N'Alarcon')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad], [FechaAlta], [Paterno], [Materno]) VALUES (3, N'Ana', 5, CAST(N'1998-10-08T00:00:00' AS SmallDateTime), N'Robles', N'Salas')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad], [FechaAlta], [Paterno], [Materno]) VALUES (8, N'Enrique', 28, CAST(N'1997-01-01T00:00:00' AS SmallDateTime), N'Morales', N'Nieto')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad], [FechaAlta], [Paterno], [Materno]) VALUES (9, N'Gerardo', 36, CAST(N'1997-01-01T00:00:00' AS SmallDateTime), N'Gonzalez', N'Ochoa')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad], [FechaAlta], [Paterno], [Materno]) VALUES (10, N'Pedro', 16, CAST(N'1997-01-01T00:00:00' AS SmallDateTime), N'Acosta', N'Dominguez')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad], [FechaAlta], [Paterno], [Materno]) VALUES (1010, N'Maridel', 38, CAST(N'2023-12-04T00:00:00' AS SmallDateTime), N'Peña', N'Cruz')
INSERT [dbo].[Personas] ([Id], [Nombre], [Edad], [FechaAlta], [Paterno], [Materno]) VALUES (1013, N'Enrique', 26, CAST(N'2023-12-07T17:01:00' AS SmallDateTime), N'Becerril', N'Ocazo')
SET IDENTITY_INSERT [dbo].[Personas] OFF
GO
