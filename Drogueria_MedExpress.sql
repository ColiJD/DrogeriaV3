USE [master]
GO
/****** Object:  Database [DROGUERIA]    Script Date: 8/4/2022 14:19:12 ******/
CREATE DATABASE [DROGUERIA]
go
use DROGUERIA
go
CREATE TABLE [dbo].[Categoria](
	[codigo_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion_categoria] [varchar](60) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[codigo_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](50) NULL,
	[descripcion_producto] [varchar](100) NULL,
	[categoria_producto] [int] NULL,
	[proveedor_producto] [int] NULL,
	[existencia_producto] [int] NULL,
	[precio_producto] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[codigo_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_proveedor] [varchar](50) NULL,
	[direccion_proveedor] [varchar](50) NULL,
	[correo_proveedor] [varchar](50) NULL,
	[telefono_proveedor] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_productos]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_productos]
AS
SELECT dbo.Producto.codigo_producto, dbo.Producto.nombre_producto, dbo.Producto.descripcion_producto, dbo.Categoria.descripcion_categoria, dbo.Proveedor.nombre_proveedor, dbo.Producto.existencia_producto, dbo.Producto.precio_producto
FROM  dbo.Producto INNER JOIN
       dbo.Proveedor ON dbo.Producto.proveedor_producto = dbo.Proveedor.codigo_proveedor INNER JOIN
       dbo.Categoria ON dbo.Producto.categoria_producto = dbo.Categoria.codigo_categoria
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[codigo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [varchar](80) NULL,
	[direccion_cliente] [varchar](60) NULL,
	[correo_cliente] [varchar](60) NULL,
	[telefono_cliente] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[codigo_empleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre_empleado] [varchar](50) NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[codigo_tipo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[codigo_factura] [int] IDENTITY(1,1) NOT NULL,
	[codigo_cliente] [int] NULL,
	[codigo_empleado] [int] NULL,
	[subtotal] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_factura]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_factura]
AS
SELECT dbo.Factura.codigo_factura, dbo.Cliente.nombre_cliente, dbo.Empleado.nombre_empleado, dbo.Factura.subtotal
FROM  dbo.Factura INNER JOIN
       dbo.Empleado ON dbo.Factura.codigo_empleado = dbo.Empleado.codigo_empleado INNER JOIN
       dbo.Cliente ON dbo.Factura.codigo_cliente = dbo.Cliente.codigo_cliente
GO
/****** Object:  View [dbo].[DataGridViewFactura]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DataGridViewFactura]
AS
SELECT dbo.Factura.codigo_factura, dbo.Factura.codigo_cliente, dbo.Cliente.nombre_cliente, dbo.Factura.codigo_empleado, dbo.Empleado.nombre_empleado, dbo.Factura.subtotal
FROM  dbo.Factura INNER JOIN
       dbo.Cliente ON dbo.Factura.codigo_cliente = dbo.Cliente.codigo_cliente INNER JOIN
       dbo.Empleado ON dbo.Factura.codigo_empleado = dbo.Empleado.codigo_empleado
GO
/****** Object:  View [dbo].[cbx_Empleado]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[cbx_Empleado]
AS
SELECT codigo_empleado, nombre_empleado, username, password, codigo_tipo
FROM  dbo.Empleado
WHERE (codigo_tipo = 3)
GO
/****** Object:  View [dbo].[view_producto]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[view_producto]
AS
SELECT dbo.Producto.codigo_producto AS Expr1, dbo.Producto.nombre_producto AS Expr2, dbo.Producto.existencia_producto AS Expr3, dbo.Producto.proveedor_producto AS Expr4, dbo.Producto.descripcion_producto AS Expr5, dbo.Producto.categoria_producto AS Expr6, dbo.Categoria.descripcion_categoria, dbo.Proveedor.nombre_proveedor, dbo.Producto.precio_producto
FROM  dbo.Categoria INNER JOIN
       dbo.Producto ON dbo.Categoria.codigo_categoria = dbo.Producto.categoria_producto INNER JOIN
       dbo.Proveedor ON dbo.Producto.proveedor_producto = dbo.Proveedor.codigo_proveedor
GO
/****** Object:  Table [dbo].[Detalle_Factura]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Factura](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[codigo_factura] [int] NULL,
	[codigo_producto] [int] NULL,
	[cantidad] [int] NULL,
	[precio_producto] [money] NULL,
	[subtotal] [money] NULL,
 CONSTRAINT [PK_Detalle_Factura] PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 8/4/2022 14:19:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[codigo_tipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 
GO
INSERT [dbo].[Categoria] ([codigo_categoria], [descripcion_categoria]) VALUES (1, N'Inyecciones
')
GO
INSERT [dbo].[Categoria] ([codigo_categoria], [descripcion_categoria]) VALUES (2, N'Jarabes
')
GO
INSERT [dbo].[Categoria] ([codigo_categoria], [descripcion_categoria]) VALUES (3, N'Tabletas

 y Capsulas')
GO
INSERT [dbo].[Categoria] ([codigo_categoria], [descripcion_categoria]) VALUES (4, N'Cremas
')
GO
INSERT [dbo].[Categoria] ([codigo_categoria], [descripcion_categoria]) VALUES (5, N'Material Medico
')
GO
SET IDENTITY_INSERT [dbo].[Categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (1, N'Farmacia del ahorro 20', N'Tegucigalpa', N'fahorro20@gmail.com', 98786757)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (2, N'Farmacia Kielsa 14', N'San Pedro Sula', N'fkielsa14@gmail.com', 95673423)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (3, N'Farmacia Kielsa 3', N'San Pedro Sula', N'fkielsa3@gmail.com', 95673421)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (4, N'Farmacia del ahorro 15', N'Tegucigalpa', N'fahorro15@gmail.com', 90785435)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (5, N'Farcia Kielsa 13', N'La Ceiba', N'fkielsa13@gmail.com', 96785645)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (6, N'Farmacia Regis 8', N'Tegucigalpa', N'fregis8@gmail.com', 95679099)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (7, N'Farmacia Siman 4', N'Tegucigalpa', N'fsiman4@gmail.com', 96783979)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (8, N'Farmacia Regis 2', N'Comayagua', N'fregis2@gmail.com', 93456787)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (9, N'Farmacia Siman 5', N'San Pedro Sula', N'fsiman5@gmail.com', 95674212)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (10, N'Farmacia Kielsa 11', N'Comayagua', N'fkielsa11@gmail.com', 93569099)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (13, N'Farmacia kielsa 23', N'Comayagua', N'f@gmail.com', 45676334)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (24, N'Farmacia Kielsa 46', N'San Pedro Sula', N'fk46@gmail.com', 34567612)
GO
INSERT [dbo].[Cliente] ([codigo_cliente], [nombre_cliente], [direccion_cliente], [correo_cliente], [telefono_cliente]) VALUES (30, N'Farmacia Kielsa #2', N'Tegucigalpa La Peña calle #2', N'farmakiel_2@gmail.com', 34565786)
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Detalle_Factura] ON 
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (1, 16, 13, 3, 40.0000, 120.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (2, 17, 19, 3, 130.0000, 390.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (3, 17, 5, 4, 190.0000, 760.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (4, 18, 4, 1, 180.0000, 180.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (5, 20, 6, 3, 200.0000, 600.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (6, 20, 8, 2, 140.0000, 280.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (7, 21, 16, 2, 210.0000, 420.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (8, 21, 5, 5, 190.0000, 950.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (9, 23, 2, 2, 20.0000, 40.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (10, 23, 1, 5, 150.0000, 750.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (11, 24, 2, 5, 20.0000, 100.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (12, 25, 4, 2, 180.0000, 360.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (13, 26, 7, 4, 230.0000, 920.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (14, 26, 3, 5, 190.0000, 950.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (15, 27, 4, 2, 180.0000, 360.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (16, 27, 2, 4, 20.0000, 80.0000)
GO
INSERT [dbo].[Detalle_Factura] ([id_detalle], [codigo_factura], [codigo_producto], [cantidad], [precio_producto], [subtotal]) VALUES (17, 28, 4, 1, 180.0000, 180.0000)
GO
SET IDENTITY_INSERT [dbo].[Detalle_Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 
GO
INSERT [dbo].[Empleado] ([codigo_empleado], [nombre_empleado], [username], [password], [codigo_tipo]) VALUES (1, N'Maria Gonzalez', N'mariagonzalez', N'1111', 1)
GO
INSERT [dbo].[Empleado] ([codigo_empleado], [nombre_empleado], [username], [password], [codigo_tipo]) VALUES (2, N'Andrea Valdez', N'andreavaldez', N'2222', 2)
GO
INSERT [dbo].[Empleado] ([codigo_empleado], [nombre_empleado], [username], [password], [codigo_tipo]) VALUES (3, N'Katherine Pinto', N'katherinepinto', N'1234', 2)
GO
INSERT [dbo].[Empleado] ([codigo_empleado], [nombre_empleado], [username], [password], [codigo_tipo]) VALUES (4, N'Jared Mendez', N'jaredmendez', N'4321', 3)
GO
INSERT [dbo].[Empleado] ([codigo_empleado], [nombre_empleado], [username], [password], [codigo_tipo]) VALUES (5, N'Miguel Aguilar', N'miguelaguilar', N'5555', 3)
GO
INSERT [dbo].[Empleado] ([codigo_empleado], [nombre_empleado], [username], [password], [codigo_tipo]) VALUES (6, N'Oscar Wilde', N'oscarwilde', N'oscar333', 3)
GO
SET IDENTITY_INSERT [dbo].[Empleado] OFF
GO
SET IDENTITY_INSERT [dbo].[Factura] ON 
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (5, 2, 2, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (6, 2, 3, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (7, 3, 1, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (8, 3, 4, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (9, 2, 4, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (10, 7, 4, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (11, 1, 4, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (12, 1, 4, NULL)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (13, 3, 5, 2750.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (14, 3, 5, 2750.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (15, 24, 6, 800.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (16, 9, 5, 720.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (17, 10, 6, 1150.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (18, 4, 5, 180.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (19, 10, 6, 570.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (20, 7, 4, 880.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (21, 6, 6, 1370.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (22, 7, 4, 200.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (23, 5, 6, 790.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (24, 30, 5, 100.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (25, 6, 6, 360.0000)
GO
INSERT [dbo].[Factura] ([codigo_factura], [codigo_cliente], [codigo_empleado], [subtotal]) VALUES (26, 8, 5, 1870.0000)
GO
SET IDENTITY_INSERT [dbo].[Factura] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (1, N'Alcohol Clinico', N'Galon', 5, 2, 65, 150.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (2, N'Bicarbonato de sodio', N'Sobre', 5, 3, 39, 20.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (3, N'Penicilina Procainica', N'Caja', 1, 3, 55, 190.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (4, N'Lidocaina', N'Frasco', 1, 2, 79, 180.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (5, N'Acido Folico', N'Caja', 3, 4, 47, 190.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (6, N'Amlodipina', N'Caja', 3, 1, 64, 200.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (7, N'Ambroxol Compuesto
', N'Bote', 2, 5, 53, 230.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (8, N'Miel Balsamica
', N'Bote', 2, 1, 82, 140.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (9, N'Bisturi
', N'Equipo Cirugia', 5, 2, 78, 160.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (10, N'Algodon Hospitalario
', N'Esterilizado', 5, 4, 71, 90.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (11, N'Bolsa de Orina para Adulto
', N'Esterilizado', 5, 1, 61, 80.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (12, N'Cateter', N'Equipo Cirugia', 5, 5, 89, 110.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (13, N'Gasa', N'Esterilizado', 5, 3, 76, 40.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (14, N'Hidrocortizona
', N'Bote', 4, 2, 62, 240.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (16, N'Loratadina', N'Bote', 2, 2, 68, 210.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (19, N'Vitamina C', N'Caja', 3, 3, 247, 130.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (25, N'Vitamina A', N'Caja', 1, 2, 100, 234.0000)
GO
INSERT [dbo].[Producto] ([codigo_producto], [nombre_producto], [descripcion_producto], [categoria_producto], [proveedor_producto], [existencia_producto], [precio_producto]) VALUES (26, N'Vitamina B', N'Caja', 2, 3, 0, 0.0000)
GO
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 
GO
INSERT [dbo].[Proveedor] ([codigo_proveedor], [nombre_proveedor], [direccion_proveedor], [correo_proveedor], [telefono_proveedor]) VALUES (1, N'Farinter', N'Tegucigalpa', N'farinter@gmail.com', 78906754)
GO
INSERT [dbo].[Proveedor] ([codigo_proveedor], [nombre_proveedor], [direccion_proveedor], [correo_proveedor], [telefono_proveedor]) VALUES (2, N'Dromeinter', N'San Pedro Sula', N'dromeinter@gmail.com', 89786556)
GO
INSERT [dbo].[Proveedor] ([codigo_proveedor], [nombre_proveedor], [direccion_proveedor], [correo_proveedor], [telefono_proveedor]) VALUES (3, N'Drogueria Universal', N'Choluteca', N'drouni@gmail.com', 89674534)
GO
INSERT [dbo].[Proveedor] ([codigo_proveedor], [nombre_proveedor], [direccion_proveedor], [correo_proveedor], [telefono_proveedor]) VALUES (4, N'Haster', N'Comayagua', N'haster@gmail.com', 56789878)
GO
INSERT [dbo].[Proveedor] ([codigo_proveedor], [nombre_proveedor], [direccion_proveedor], [correo_proveedor], [telefono_proveedor]) VALUES (5, N'Drogueria Nacional', N'Tegucigalpa', N'dnacional@gmail.com', 89785676)
GO
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Usuario] ON 
GO
INSERT [dbo].[Tipo_Usuario] ([codigo_tipo], [nombre_tipo]) VALUES (1, N'Gerente')
GO
INSERT [dbo].[Tipo_Usuario] ([codigo_tipo], [nombre_tipo]) VALUES (2, N'Administrador')
GO
INSERT [dbo].[Tipo_Usuario] ([codigo_tipo], [nombre_tipo]) VALUES (3, N'Vendedor')
GO
SET IDENTITY_INSERT [dbo].[Tipo_Usuario] OFF
GO
ALTER TABLE [dbo].[Detalle_Factura]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Factura_Producto] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[Producto] ([codigo_producto])
GO
ALTER TABLE [dbo].[Detalle_Factura] CHECK CONSTRAINT [FK_Detalle_Factura_Producto]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD FOREIGN KEY([codigo_tipo])
REFERENCES [dbo].[Tipo_Usuario] ([codigo_tipo])
GO
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD FOREIGN KEY([codigo_cliente])
REFERENCES [dbo].[Cliente] ([codigo_cliente])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([categoria_producto])
REFERENCES [dbo].[Categoria] ([codigo_categoria])
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([proveedor_producto])
REFERENCES [dbo].[Proveedor] ([codigo_proveedor])
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
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 18
               Left = 115
               Bottom = 377
               Right = 557
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'cbx_Empleado'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'cbx_Empleado'
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
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 18
               Left = 115
               Bottom = 377
               Right = 524
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 18
               Left = 639
               Bottom = 377
               Right = 1081
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Factura"
            Begin Extent = 
               Top = 18
               Left = 1196
               Bottom = 377
               Right = 1623
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DataGridViewFactura'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'DataGridViewFactura'
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
         Begin Table = "Factura"
            Begin Extent = 
               Top = 18
               Left = 115
               Bottom = 377
               Right = 542
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Empleado"
            Begin Extent = 
               Top = 18
               Left = 657
               Bottom = 377
               Right = 1099
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Cliente"
            Begin Extent = 
               Top = 18
               Left = 1214
               Bottom = 377
               Right = 1623
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_factura'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_factura'
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
         Begin Table = "Categoria"
            Begin Extent = 
               Top = 18
               Left = 115
               Bottom = 277
               Right = 603
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Producto"
            Begin Extent = 
               Top = 18
               Left = 718
               Bottom = 377
               Right = 1204
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Proveedor"
            Begin Extent = 
               Top = 18
               Left = 1319
               Bottom = 377
               Right = 1788
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_producto'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_producto'
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
         Begin Table = "Producto"
            Begin Extent = 
               Top = 18
               Left = 115
               Bottom = 377
               Right = 601
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "Proveedor"
            Begin Extent = 
               Top = 28
               Left = 1033
               Bottom = 387
               Right = 1502
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Categoria"
            Begin Extent = 
               Top = 18
               Left = 1617
               Bottom = 277
               Right = 2105
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_productos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'view_productos'
GO
USE [master]
GO
ALTER DATABASE [DROGUERIA] SET  READ_WRITE 
GO
