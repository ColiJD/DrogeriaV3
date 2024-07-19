USE [DROGUERIA]
GO

/** Object:  Table [dbo].[Facturass]    Script Date: 7/17/2024 2:56:39 PM **/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Facturass](
    [Id_factura] [int] IDENTITY(1,1) NOT NULL,
    [empleado_factura] [nchar](50) NOT NULL,
    [cliente_factura] [nchar](50) NOT NULL,
    [Id_producto] [int] NOT NULL,
    [nombre_producto] [nchar](100) NOT NULL,
    [precio] [decimal](18, 2) NOT NULL,
    [cantidad] [int] NOT NULL,
    [subtotal] [decimal](18, 2) NOT NULL,
    [impuesto] [decimal](18, 2) NOT NULL,
    [total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Facturass] PRIMARY KEY CLUSTERED 
(
    [Id_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO