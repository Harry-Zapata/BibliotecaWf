USE [master]
GO
/****** Object:  Database [biblioteca]    Script Date: 22/09/2023 12:14:42 ******/
CREATE DATABASE [biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\biblioteca_log.ldf' , SIZE = 73728KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [biblioteca] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [biblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [biblioteca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [biblioteca] SET RECOVERY FULL 
GO
ALTER DATABASE [biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [biblioteca] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'biblioteca', N'ON'
GO
ALTER DATABASE [biblioteca] SET QUERY_STORE = ON
GO
ALTER DATABASE [biblioteca] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [biblioteca]
GO
/****** Object:  Table [dbo].[Libros]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Libros](
	[idlibro] [varchar](20) NOT NULL,
	[titulolibro] [varchar](150) NOT NULL,
	[editorial] [varchar](50) NULL,
	[pais] [varchar](20) NULL,
	[año] [int] NULL,
	[nPag] [int] NULL,
	[existencia] [int] NOT NULL,
 CONSTRAINT [PK_MAT_BIBLIO_idlibro] PRIMARY KEY CLUSTERED 
(
	[idlibro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AUTOR]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AUTOR](
	[idAutor] [char](4) NOT NULL,
	[nomAutor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AUTOR_idAutor] PRIMARY KEY CLUSTERED 
(
	[idAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LIBROS_AUTOR]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIBROS_AUTOR](
	[idLibro] [varchar](20) NOT NULL,
	[idAutor] [char](4) NOT NULL,
 CONSTRAINT [PK__MB_AUTOR_idlibro_idAutor] PRIMARY KEY CLUSTERED 
(
	[idLibro] ASC,
	[idAutor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Vista_Libros_Autor]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Vista_Libros_Autor]
AS
SELECT        dbo.LIBROS_AUTOR.idLibro, dbo.AUTOR.nomAutor
FROM            dbo.AUTOR INNER JOIN
                         dbo.LIBROS_AUTOR ON dbo.AUTOR.idAutor = dbo.LIBROS_AUTOR.idAutor INNER JOIN
                         dbo.Libros ON dbo.LIBROS_AUTOR.idLibro = dbo.Libros.idlibro
GO
/****** Object:  View [dbo].[VConsultarLibrosAutor]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VConsultarLibrosAutor]
AS
SELECT        dbo.LIBROS_AUTOR.idLibro, dbo.AUTOR.nomAutor, dbo.Libros.titulolibro, dbo.Libros.editorial, dbo.Libros.pais, dbo.Libros.año, dbo.Libros.nPag, dbo.Libros.existencia
FROM            dbo.AUTOR INNER JOIN
                         dbo.LIBROS_AUTOR ON dbo.AUTOR.idAutor = dbo.LIBROS_AUTOR.idAutor INNER JOIN
                         dbo.Libros ON dbo.LIBROS_AUTOR.idLibro = dbo.Libros.idlibro
GO
/****** Object:  Table [dbo].[PRESTAMO]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRESTAMO](
	[codPrestamo] [int] IDENTITY(1,1) NOT NULL,
	[idlibro] [varchar](20) NOT NULL,
	[fechaP] [date] NOT NULL,
	[fechaD] [date] NOT NULL,
	[anulado] [varchar](5) NULL,
 CONSTRAINT [PK_PRESTAMO_codOper] PRIMARY KEY CLUSTERED 
(
	[codPrestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ConsultarLibros]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ConsultarLibros]
AS
SELECT        dbo.PRESTAMO.codPrestamo, dbo.Libros.titulolibro, dbo.PRESTAMO.fechaP, dbo.PRESTAMO.fechaD, dbo.AUTOR.nomAutor, dbo.Libros.existencia, dbo.PRESTAMO.anulado
FROM            dbo.AUTOR INNER JOIN
                         dbo.LIBROS_AUTOR ON dbo.AUTOR.idAutor = dbo.LIBROS_AUTOR.idAutor INNER JOIN
                         dbo.Libros ON dbo.LIBROS_AUTOR.idLibro = dbo.Libros.idlibro INNER JOIN
                         dbo.PRESTAMO ON dbo.LIBROS_AUTOR.idLibro = dbo.PRESTAMO.idlibro
WHERE        (dbo.PRESTAMO.anulado = 'No')
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nomUsuario] [varchar](50) NULL,
	[passUsuario] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'A009', N'Federico manzano')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B001', N'El Comercio')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B002', N'Hernando Soto')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B003', N'Vargas LLosa')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B004', N'Peru 21')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B005', N'Felipe Calderon')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B006', N'Garcia Marques')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B007', N'Luis Razuri')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B008', N'JulioRuiz Vargas')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B009', N'Nuevo autor')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B010', N'Creado Reciente')
INSERT [dbo].[AUTOR] ([idAutor], [nomAutor]) VALUES (N'B011', N'Garcilazo de la vega')
GO
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0001', N'La Nacion', N'Comercio', N'Bolibia', 1996, 22, 5)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0002', N'Liderasgo', N'USP', N'Peru', 2010, 50, 10)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0003', N'Ciudad de los perros', N'Navarrete', N'Peru', 1980, 101, 6)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0004', N'Macroeconomia', N'UNT', N'Argentina', 2010, 101, 5)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0005', N'Matematicas I', N'La Republica', N'Chile', 1996, 50, 5)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0006', N'Planeta', N'Navarrete', N'Peru', 2023, 5, 21)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0007', N'El Principe', N'DODJ', N'Italia', 1532, 300, 1)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0008', N'Las 48 leyes del poder', N'Oceano', N'UK', 2012, 830, 1)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0009', N'La Busqueda', N'Ballena', N'Peru', 2010, 500, 90)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0010', N'Julian', N'Luis', N'Peru', 1099, 5, 991)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0012', N'Buscando A Julius', N'Ballena', N'Peru', 2009, 700, -5)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0013', N'Ronaldiño', N'Kaka', N'Gotica', 2000, 50, 2)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0014', N'Karlos ', N'i¿''kjnn', N'oipioj', 89, 45, 44)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0015', N'Nuevo Libro', N'Navarreta', N'Peru', 2023, 500, 5)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0016', N'Libro Editor', N'Foset', N'Peru', 2015, 55, 5)
INSERT [dbo].[Libros] ([idlibro], [titulolibro], [editorial], [pais], [año], [nPag], [existencia]) VALUES (N'A0020', N'Libro Reporte', N'Navarrete', N'Peru', 2005, 15, 80)
GO
INSERT [dbo].[LIBROS_AUTOR] ([idLibro], [idAutor]) VALUES (N'A0010', N'B002')
INSERT [dbo].[LIBROS_AUTOR] ([idLibro], [idAutor]) VALUES (N'A0012', N'B001')
INSERT [dbo].[LIBROS_AUTOR] ([idLibro], [idAutor]) VALUES (N'A0013', N'B003')
INSERT [dbo].[LIBROS_AUTOR] ([idLibro], [idAutor]) VALUES (N'A0014', N'B004')
INSERT [dbo].[LIBROS_AUTOR] ([idLibro], [idAutor]) VALUES (N'A0015', N'B004')
INSERT [dbo].[LIBROS_AUTOR] ([idLibro], [idAutor]) VALUES (N'A0016', N'B001')
INSERT [dbo].[LIBROS_AUTOR] ([idLibro], [idAutor]) VALUES (N'A0020', N'B003')
GO
SET IDENTITY_INSERT [dbo].[PRESTAMO] ON 

INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (9, N'A0003', CAST(N'2014-05-12' AS Date), CAST(N'2014-05-31' AS Date), NULL)
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (10, N'A0001', CAST(N'2015-02-12' AS Date), CAST(N'2015-03-28' AS Date), NULL)
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (11, N'A0004', CAST(N'2016-01-20' AS Date), CAST(N'2016-02-10' AS Date), NULL)
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (12, N'A0002', CAST(N'2016-02-10' AS Date), CAST(N'2016-02-20' AS Date), NULL)
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (13, N'A0005', CAST(N'2016-03-01' AS Date), CAST(N'2016-03-30' AS Date), NULL)
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (14, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (15, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (16, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (17, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-29' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (18, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (19, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (20, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (21, N'A0013', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'No')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (22, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (23, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (24, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (25, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (26, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (27, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (28, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (29, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (30, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (31, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (32, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (33, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (34, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (35, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (36, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (37, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (38, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (39, N'A0013', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'No')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (40, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (41, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (42, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (43, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (44, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (45, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (46, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (47, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (48, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (49, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (50, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (51, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (52, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (53, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (54, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (55, N'A0013', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'No')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (56, N'A0012', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'si')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (57, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'No')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (58, N'A0010', CAST(N'2023-09-15' AS Date), CAST(N'2023-09-15' AS Date), N'No')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (59, N'A0012', CAST(N'2023-09-21' AS Date), CAST(N'2023-09-21' AS Date), N'No')
INSERT [dbo].[PRESTAMO] ([codPrestamo], [idlibro], [fechaP], [fechaD], [anulado]) VALUES (60, N'A0012', CAST(N'2023-09-21' AS Date), CAST(N'2023-09-18' AS Date), N'No')
SET IDENTITY_INSERT [dbo].[PRESTAMO] OFF
GO
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([idUsuario], [nomUsuario], [passUsuario]) VALUES (1, N'admin', N'admin')
INSERT [dbo].[USUARIO] ([idUsuario], [nomUsuario], [passUsuario]) VALUES (2, N'admin1', N'admin')
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
GO
ALTER TABLE [dbo].[LIBROS_AUTOR]  WITH CHECK ADD  CONSTRAINT [FK_MB_AUTOR_idAutor] FOREIGN KEY([idAutor])
REFERENCES [dbo].[AUTOR] ([idAutor])
GO
ALTER TABLE [dbo].[LIBROS_AUTOR] CHECK CONSTRAINT [FK_MB_AUTOR_idAutor]
GO
ALTER TABLE [dbo].[LIBROS_AUTOR]  WITH CHECK ADD  CONSTRAINT [FK_MB_AUTOR_idLIBRO] FOREIGN KEY([idLibro])
REFERENCES [dbo].[Libros] ([idlibro])
GO
ALTER TABLE [dbo].[LIBROS_AUTOR] CHECK CONSTRAINT [FK_MB_AUTOR_idLIBRO]
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_libro_Autor]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Actualizar_libro_Autor]
@idlibro varchar(20),
@idAutor char(4)
as
update Libros_autor
set
idAutor=@idAutor
where idlibro=@idlibro
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_libros]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Actualizar_libros]

@idlibro varchar(20),
@titulolibro varchar(150),
@editorial varchar(50),
@pais varchar(20),
@año int,
@nPag int,
@existencia int
as
update Libros
set
titulolibro=@titulolibro,
editorial=@editorial,
pais=@pais,
año=@año,
nPag=@nPag,
existencia=@existencia
where idlibro = @idlibro
GO
/****** Object:  StoredProcedure [dbo].[Actualizar_librosExistencia]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--CREACION DE PROCEDIMIENTO ALMACENADO Actualizar_librosExistencia
create procedure [dbo].[Actualizar_librosExistencia]
@idLibro varchar(20),
@existencia int
as
Update Libros
set existencia=@existencia
where idlibro=@idLibro
GO
/****** Object:  StoredProcedure [dbo].[Anular_prestamo]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREACION DE PROCEDIMIENTO ALMACENADO Anular_prestamo
create procedure [dbo].[Anular_prestamo]
@idLibro varchar(20),
@Anulado varchar(20)
as
Update PRESTAMO
set Anulado=@Anulado
where idlibro=@idLibro

GO
/****** Object:  StoredProcedure [dbo].[BUSCAR_AUTOR]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[BUSCAR_AUTOR]
@idAutor char(4)
as
select * from Autor where idAutor=@idAutor
GO
/****** Object:  StoredProcedure [dbo].[Consultar_libro_Idlibro]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Consultar_libro_Idlibro]
@idlibro varchar(20)
as
select * from Libros where idlibro=@idlibro

GO
/****** Object:  StoredProcedure [dbo].[EDITAR_AUTOR]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EDITAR_AUTOR]
@idAutor char(4),
@nomAutor varchar(50)
as
update Autor
set
nomAutor=@nomAutor
where idAutor=@idAutor
GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editar_usuario]
@idUsuario int,
@nomUsuario varchar(50),
@passUsuario varchar(50)
as
update USUARIO
set
nomUsuario=@nomUsuario,
passUsuario=@passUsuario
where idUsuario=@idUsuario
GO
/****** Object:  StoredProcedure [dbo].[ELIMINAR_AUTOR]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ELIMINAR_AUTOR]
@idAutor char(4)
as
delete Autor where idAutor=@idAutor
GO
/****** Object:  StoredProcedure [dbo].[Eliminar_libro]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Eliminar_libro]
@idlibro varchar(20)
as 
delete Libros where idlibro = @idlibro
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_AUTOR]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[INSERTAR_AUTOR]
@idAutor char(4),
@nomAutor varchar(50)
as
Insert into Autor(idAutor,nomAutor)
values(@idAutor,@nomAutor)
GO
/****** Object:  StoredProcedure [dbo].[insertar_libros]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_libros]

@idlibro varchar(20),
@titulolibro varchar(150),
@editorial varchar(50),
@pais varchar(20),
@año int,
@nPag int,
@existencia int
as
Insert into Libros(idlibro,titulolibro,editorial,pais,año,nPag,existencia)
values(@idlibro,@titulolibro,@editorial,@pais,@año,@nPag,@existencia)
set @idlibro=@@IDENTITY
GO
/****** Object:  StoredProcedure [dbo].[Insertar_prestamo]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- CREACIONDE DE PROCEDIMIENTO ALMACENADO Insertar_prestamo
create procedure [dbo].[Insertar_prestamo]
@idLibro varchar(20),
@fechaP date,
@fechaD date,
@Anulado varchar(20)
as
Insert into PRESTAMO(idLibro,fechaP,fechaD,Anulado)
values(@idLibro,@fechaP,@fechaD,@Anulado)
set @idlibro = @@identity

GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertar_usuario]
@nomUsuario varchar(50),
@passUsuario varchar(50)
as
insert into USUARIO(nomUsuario,passUsuario)
values(@nomUsuario,@passUsuario)
GO
/****** Object:  StoredProcedure [dbo].[insertarLibro_autor]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertarLibro_autor]
@idlibro varchar(20),
@idAutor char(4)
as
Insert into LIBROS_AUTOR(idLibro,idAutor)
values(@idlibro,@idAutor)
GO
/****** Object:  StoredProcedure [dbo].[listar_libros]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listar_libros]
as
select * from Libros

GO
/****** Object:  StoredProcedure [dbo].[listar_prestamo]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listar_prestamo]
as
select * from PRESTAMO
GO
/****** Object:  StoredProcedure [dbo].[llenar_Autor]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[llenar_Autor]
as
select * from AUTOR

GO
/****** Object:  StoredProcedure [dbo].[ReporteAño]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ReporteAño]
@año int,
@año2 int
as
select * from VConsultarLibrosAutor where año between @año and @año2
GO
/****** Object:  StoredProcedure [dbo].[VConsultar_libros_anio]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VConsultar_libros_anio]
@añoInicio int,
@añoFin int
as
select * from VConsultarLibrosAutor where año between @añoInicio and @añoFin
GO
/****** Object:  StoredProcedure [dbo].[VConsultar_libros_editorial]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VConsultar_libros_editorial]
@editorial varchar(20)
as
select * from VConsultarLibrosAutor where editorial Like '%' + @editorial + '%' ESCAPE '\'
GO
/****** Object:  StoredProcedure [dbo].[VConsultar_libros_Pais]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VConsultar_libros_Pais]
@pais varchar(20)
as
select * from VConsultarLibrosAutor where pais Like '%' + @pais + '%' ESCAPE '\'
GO
/****** Object:  StoredProcedure [dbo].[Vconsultar_libros_prestamos]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Vconsultar_libros_prestamos]
@librosP varchar(150)
as
select * from VConsultarLibrosAutor where nomAutor Like '%' + @librosP + '%' ESCAPE '\' or titulolibro Like '%' + @librosP + '%' ESCAPE '\'
GO
/****** Object:  StoredProcedure [dbo].[VConsultar_libros_titulo]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VConsultar_libros_titulo]
@titulolibro varchar(150)
as
select * from VConsultarLibrosAutor where titulolibro Like '%' + @titulolibro + '%' ESCAPE '\'
GO
/****** Object:  StoredProcedure [dbo].[VConsultarLibroFechaI]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VConsultarLibroFechaI]
@fechaI date,
@fechaF date
as
select * from ConsultarLibros where fechaP between @fechaI and @fechaF
GO
/****** Object:  StoredProcedure [dbo].[VConsultarLibroFin]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VConsultarLibroFin]
@fechaI date,
@fechaF date
as
select * from ConsultarLibros where fechaD between @fechaI and @fechaF
GO
/****** Object:  StoredProcedure [dbo].[verificar_usuario]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[verificar_usuario]
@nomUsuario varchar(50),
@passUsuario varchar(50)
as
select * from USUARIO where nomUsuario=@nomUsuario and passUsuario=@passUsuario
GO
/****** Object:  StoredProcedure [dbo].[vincular_libro_Autor]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[vincular_libro_Autor]
@idlibro varchar(20)
as
select * from Vista_Libros_Autor where idlibro=@idlibro
GO
/****** Object:  StoredProcedure [dbo].[Vlistar_libros]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Vlistar_libros]
as
select * from VConsultarLibrosAutor
GO
/****** Object:  StoredProcedure [dbo].[VlistarConsultarLibros]    Script Date: 22/09/2023 12:14:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VlistarConsultarLibros]
as
select * from ConsultarLibros
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
         Begin Table = "AUTOR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Libros"
            Begin Extent = 
               Top = 126
               Left = 508
               Bottom = 306
               Right = 678
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LIBROS_AUTOR"
            Begin Extent = 
               Top = 4
               Left = 346
               Bottom = 100
               Right = 516
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PRESTAMO"
            Begin Extent = 
               Top = 6
               Left = 662
               Bottom = 136
               Right = 832
            End
            DisplayFlags = 280
            TopColumn = 1
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ConsultarLibros'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ConsultarLibros'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ConsultarLibros'
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
         Begin Table = "AUTOR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Libros"
            Begin Extent = 
               Top = 16
               Left = 756
               Bottom = 257
               Right = 926
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LIBROS_AUTOR"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VConsultarLibrosAutor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VConsultarLibrosAutor'
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
         Begin Table = "AUTOR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Libros"
            Begin Extent = 
               Top = 11
               Left = 767
               Bottom = 141
               Right = 937
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LIBROS_AUTOR"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Libros_Autor'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vista_Libros_Autor'
GO
USE [master]
GO
ALTER DATABASE [biblioteca] SET  READ_WRITE 
GO
