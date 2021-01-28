USE [Estancias_II]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 01/02/2021 18:47:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Categorias]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Categorias] ON
INSERT [dbo].[Categorias] ([id_categoria], [nombre]) VALUES (1, N'Bebidas')
SET IDENTITY_INSERT [dbo].[Categorias] OFF
/****** Object:  Table [dbo].[Ventas]    Script Date: 01/02/2021 18:47:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ventas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Ventas](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[cantidadProductos] [int] NOT NULL,
	[subtotal] [decimal](18, 0) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[empleado] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON
INSERT [dbo].[Ventas] ([id_venta], [cantidadProductos], [subtotal], [fecha], [empleado]) VALUES (1, 5, CAST(100 AS Decimal(18, 0)), CAST(0x0000AC9100EBC7D9 AS DateTime), N'Christian')
INSERT [dbo].[Ventas] ([id_venta], [cantidadProductos], [subtotal], [fecha], [empleado]) VALUES (2, 2, CAST(50 AS Decimal(18, 0)), CAST(0x0000AC9300BDAC9F AS DateTime), N'Jacob')
SET IDENTITY_INSERT [dbo].[Ventas] OFF
/****** Object:  Table [dbo].[Usuarios]    Script Date: 01/02/2021 18:47:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](100) NOT NULL,
	[apellidos] [varchar](100) NOT NULL,
	[usuario] [varchar](100) NOT NULL,
	[contraseña] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON
INSERT [dbo].[Usuarios] ([id_usuario], [nombres], [apellidos], [usuario], [contraseña]) VALUES (1, N'Josue Jacob', N'Luna Estrada', N'Jacob Fender', N'1234')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
/****** Object:  StoredProcedure [dbo].[SP_USUARIO_MODIFICAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_USUARIO_MODIFICAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--USUARIO_MODIFICAR
CREATE PROCEDURE [dbo].[SP_USUARIO_MODIFICAR]
(
	@nombres varchar(100),
	@apellidos varchar(100),
	@usuario varchar(100),
	@contraseña nvarchar(100),
	@id_usuario int
)
AS
BEGIN
	UPDATE Usuario SET nombres=@nombres, apellidos=@apellidos, usuario=@usuario,
	contraseña=@contraseña WHERE id_usuario=@id_usuario
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LLENAR_COMBO_CATEGORIAS]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_LLENAR_COMBO_CATEGORIAS]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_LLENAR_COMBO_CATEGORIAS]
AS
BEGIN
	SELECT*FROM Categorias ORDER BY nombre
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_MOSTRAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_VENTAS_MOSTRAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--VENTAS_MOSTRAR
CREATE PROCEDURE [dbo].[SP_VENTAS_MOSTRAR]
AS
SELECT id_venta as [ID], cantidadProductos as [Cantidad de Productos], subtotal as [Subtotal],
fecha as [Fecha], empleado as [Empleado] FROM Ventas ORDER BY fecha
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_INSERTAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_VENTAS_INSERTAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--VENTAS_INSERTAR
CREATE PROCEDURE [dbo].[SP_VENTAS_INSERTAR]
(
	@cantidadProductos int,
	@subtotal decimal,
	@empleado varchar(100)
)
AS
BEGIN
	INSERT Ventas(cantidadProductos, subtotal, fecha, empleado)
	VALUES(@cantidadProductos, @subtotal,GETDATE(), @empleado)
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_ELIMINAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_VENTAS_ELIMINAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--VENATAS_ELIMINAR
CREATE PROCEDURE [dbo].[SP_VENTAS_ELIMINAR]
(
	@id_venta int
)
AS
BEGIN
	DELETE Ventas WHERE id_venta=@id_venta
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_BUSCAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_VENTAS_BUSCAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_VENTAS_BUSCAR]
(
	@fecha datetime
)
AS
BEGIN
	 SELECT id_venta as [ID], cantidadProductos as [Cantidad de Productos], subtotal as [Subtotal],
     fecha as [Fecha], empleado as [Empleado] FROM Ventas WHERE fecha=@fecha
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIO_INSERTAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_USUARIO_INSERTAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_USUARIO_INSERTAR]
(
	@nombres varchar(100),
	@apellidos varchar(100),
	@usuario varchar(100),
	@contraseña nvarchar(100),
	@id_usuario int output
)
AS
BEGIN
	INSERT Usuarios(nombres, apellidos, usuario, contraseña)
	VALUES(@nombres, @apellidos,@usuario,@contraseña)
	SET @id_usuario=SCOPE_IDENTITY()
END
' 
END
GO
/****** Object:  Table [dbo].[Detalles_Ventas]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Detalles_Ventas]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Detalles_Ventas](
	[id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](100) NOT NULL,
	[cantidad] [int] NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
	[id_venta] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Detalles_Ventas] ON
INSERT [dbo].[Detalles_Ventas] ([id_detalle_venta], [producto], [cantidad], [total], [id_venta]) VALUES (1, N'Coca-Cola', 2, CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[Detalles_Ventas] ([id_detalle_venta], [producto], [cantidad], [total], [id_venta]) VALUES (2, N'Gorditas', 4, CAST(32 AS Decimal(18, 0)), 2)
SET IDENTITY_INSERT [dbo].[Detalles_Ventas] OFF
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CATEGORIA]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INSERTAR_CATEGORIA]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_INSERTAR_CATEGORIA]
(
	@nombre varchar(50),
	@id_categoria int output
)
AS
BEGIN 
	INSERT Categorias(nombre)
	VALUES(@nombre)
	SET @id_categoria=SCOPE_IDENTITY()
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INICIO_SESION]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INICIO_SESION]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_INICIO_SESION]
(
	@usuario varchar(100),
	@contraseña nvarchar(100)
)
AS
SELECT usuario FROM Usuarios WHERE usuario=@usuario and contraseña=@contraseña' 
END
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Productos]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precioCompra] [decimal](18, 0) NOT NULL,
	[precioVenta] [decimal](18, 0) NOT NULL,
	[id_categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON
INSERT [dbo].[Productos] ([id_producto], [nombre], [precioCompra], [precioVenta], [id_categoria]) VALUES (1, N'Agua Embotellada', CAST(8 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), 1)
INSERT [dbo].[Productos] ([id_producto], [nombre], [precioCompra], [precioVenta], [id_categoria]) VALUES (2, N'Coca-Cola', CAST(15 AS Decimal(18, 0)), CAST(20 AS Decimal(18, 0)), 1)
INSERT [dbo].[Productos] ([id_producto], [nombre], [precioCompra], [precioVenta], [id_categoria]) VALUES (6, N'Gorditas', CAST(8 AS Decimal(18, 0)), CAST(10 AS Decimal(18, 0)), 1)
SET IDENTITY_INSERT [dbo].[Productos] OFF
/****** Object:  Table [dbo].[Inventario]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Inventario]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Inventario](
	[id_inventario] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[existencia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Inventario] ON
INSERT [dbo].[Inventario] ([id_inventario], [id_producto], [existencia]) VALUES (7, 2, 5)
INSERT [dbo].[Inventario] ([id_inventario], [id_producto], [existencia]) VALUES (9, 1, 4)
SET IDENTITY_INSERT [dbo].[Inventario] OFF
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_VENTAS_VER]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_DETALLES_VENTAS_VER]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--DETALLES-VENTAS_VER
CREATE PROCEDURE [dbo].[SP_DETALLES_VENTAS_VER]
(
	@id_venta int
)
AS
SELECT D.id_venta as [No. Venta], D.producto as [Producto], D.cantidad as [Cantidad],
D.total as [Total] FROM Detalles_Ventas D WHERE id_venta=@id_venta' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_VENTAS_MODIFICAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_DETALLES_VENTAS_MODIFICAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--DETALLES-VENTAS_MODIFICAR
CREATE PROCEDURE [dbo].[SP_DETALLES_VENTAS_MODIFICAR]
(
	@cantidad int,
	@id_detalle_venta int
)
AS
BEGIN
	UPDATE Detalles_Ventas SET cantidad=@cantidad WHERE id_detalle_venta=@id_detalle_venta
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_VENTAS_INSERTAR]    Script Date: 01/02/2021 18:47:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_DETALLES_VENTAS_INSERTAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_DETALLES_VENTAS_INSERTAR]
(
	@id_venta int,
	@producto varchar(100),
	@cantidad int,
	@total decimal
)
AS
BEGIN
	INSERT Detalles_Ventas(producto, cantidad, total, id_venta)
	VALUES(@producto, @cantidad, @total,@id_venta)
	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_VENTAS_ELIMINAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_DETALLES_VENTAS_ELIMINAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--DETALLES-VENTAS_ELIMINAR
CREATE PROCEDURE [dbo].[SP_DETALLES_VENTAS_ELIMINAR]
(
	@id_detalle_venta int
)
AS
BEGIN
	DELETE Detalles_Ventas WHERE id_detalle_venta=@id_detalle_venta
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_MOSTRAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_PRODUCTOS_MOSTRAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_PRODUCTOS_MOSTRAR]
AS
	SELECT P.id_producto as [Código], P.nombre as [Producto], P.precioCompra as [Precio Compra],
	P.precioVenta as [Precio Venta], C.nombre as [Categoria] FROM Productos P INNER JOIN Categorias C
	ON P.id_categoria=C.id_categoria ORDER BY P.nombre
--BUSCAR_PRODUCTOS' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_MODIFICAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_PRODUCTOS_MODIFICAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--PRODUCTOS_MODIFICAR
CREATE PROCEDURE [dbo].[SP_PRODUCTOS_MODIFICAR]
(
	@id_producto int,
	@nombre varchar(100),
	@precioCompra decimal,
	@precioVenta decimal,
	@id_categoria int
)
AS
BEGIN
	UPDATE Productos SET nombre=@nombre, precioCompra=@precioCompra, precioVenta=@precioVenta,
	id_categoria=@id_categoria WHERE id_producto=@id_producto
END	
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_INSERTAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_PRODUCTOS_INSERTAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--PRODUCTOS_INSERTAR
CREATE PROCEDURE [dbo].[SP_PRODUCTOS_INSERTAR]
(
	@nombre varchar(100),
	@precioCompra decimal,
	@precioVenta decimal,
	@id_categoria int
)
AS
BEGIN
	INSERT INTO Productos(nombre, precioCompra, precioVenta, id_categoria)
	VALUES(@nombre, @precioCompra, @precioVenta, @id_categoria)
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_ELIMINAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_PRODUCTOS_ELIMINAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--PRODUCTOS_ELIMINAR
CREATE PROCEDURE [dbo].[SP_PRODUCTOS_ELIMINAR]
(
	@id_producto int
)
AS
BEGIN
	DELETE Productos WHERE id_producto=@id_producto
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_BUSCAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_PRODUCTOS_BUSCAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_PRODUCTOS_BUSCAR]
(
	@nombre varchar(100)
)
AS
BEGIN
	SELECT P.id_producto as [Código], P.nombre as [Producto], P.precioCompra as [Precio Compra],
	P.precioVenta as [Precio Venta], C.nombre as [Categoria] FROM Productos P INNER JOIN Categorias C
	ON P.id_categoria=C.id_categoria WHERE P.nombre like+''%''+@nombre+''%'' ORDER BY P.nombre
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LLENAR_COMBO_PRODUCTOS]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_LLENAR_COMBO_PRODUCTOS]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--LLENAR_COMBO_PRODUCTOS
CREATE PROCEDURE [dbo].[SP_LLENAR_COMBO_PRODUCTOS]
AS
BEGIN
	SELECT*FROM Productos
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_MOSTRAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INVENTARIO_MOSTRAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--INVENTARIO_MOSTRAR
CREATE PROCEDURE [dbo].[SP_INVENTARIO_MOSTRAR]
AS
SELECT  P.id_producto as [Código del producto], P.nombre as [Producto],
P.precioVenta as [Precio Venta], I.existencia as Existencia FROM Inventario I INNER JOIN Productos P ON I.id_producto=P.id_producto
ORDER BY P.nombre
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_MODIFICAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INVENTARIO_MODIFICAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_INVENTARIO_MODIFICAR]
(
	@id_producto int,
	@existencia int
)
AS
BEGIN
	UPDATE Inventario SET existencia=@existencia WHERE id_producto=@id_producto
END' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_INSERTAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INVENTARIO_INSERTAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_INVENTARIO_INSERTAR]
(
	@id_producto int,
	@existencia int
)
AS
BEGIN
	INSERT Inventario(id_producto, existencia)
	VALUES(@id_producto, @existencia)	
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_ELIMINAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INVENTARIO_ELIMINAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--INVENTARIO_ELIMINAR
CREATE PROCEDURE [dbo].[SP_INVENTARIO_ELIMINAR]
(
	@id_producto int
)
AS
BEGIN
	DELETE Inventario WHERE id_producto=@id_producto
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_BUSCAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_INVENTARIO_BUSCAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--INVENTARIO_BUSCAR
CREATE PROCEDURE [dbo].[SP_INVENTARIO_BUSCAR]
(
	@nombre varchar(100)
)
AS
SELECT  P.id_producto as [Código del producto], P.nombre as [Producto],
P.precioVenta as [Precio Venta], I.existencia as Existencia FROM Inventario I INNER JOIN Productos P ON I.id_producto=P.id_producto
WHERE P.nombre like+''%''+@nombre+''%'' ORDER BY P.nombre
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_INVENTARIO_INSERTAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_DETALLES_INVENTARIO_INSERTAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[SP_DETALLES_INVENTARIO_INSERTAR]
(
	@id_producto int,
	@existencia int
)
AS
BEGIN
	UPDATE Inventario SET existencia=existencia-@existencia WHERE id_producto=@id_producto
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_INVENTARIO_ELIMINAR]    Script Date: 01/02/2021 18:47:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SP_DETALLES_INVENTARIO_ELIMINAR]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'--DETALLES_VENTAS-INVENTARIO
CREATE PROCEDURE [dbo].[SP_DETALLES_INVENTARIO_ELIMINAR]
(
	@id_producto int,
	@existencia int
	
)
AS
BEGIN
	UPDATE Inventario SET existencia=existencia+@existencia WHERE id_producto=@id_producto
END' 
END
GO
/****** Object:  ForeignKey [FK__Detalles___id_ve__29572725]    Script Date: 01/02/2021 18:47:38 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Detalles___id_ve__29572725]') AND parent_object_id = OBJECT_ID(N'[dbo].[Detalles_Ventas]'))
ALTER TABLE [dbo].[Detalles_Ventas]  WITH CHECK ADD FOREIGN KEY([id_venta])
REFERENCES [dbo].[Ventas] ([id_venta])
GO
/****** Object:  ForeignKey [FK__Productos__id_ca__08EA5793]    Script Date: 01/02/2021 18:47:38 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Productos__id_ca__08EA5793]') AND parent_object_id = OBJECT_ID(N'[dbo].[Productos]'))
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
/****** Object:  ForeignKey [FK__Inventari__id_pr__0DAF0CB0]    Script Date: 01/02/2021 18:47:38 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK__Inventari__id_pr__0DAF0CB0]') AND parent_object_id = OBJECT_ID(N'[dbo].[Inventario]'))
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
