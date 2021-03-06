USE [Punto_de_Venta]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalles]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalles](
	[id_detalle] [int] IDENTITY(1,1) NOT NULL,
	[cantidad] [int] NOT NULL,
	[total] [decimal](18, 0) NOT NULL,
	[id_producto] [int] NOT NULL,
	[id_venta] [int] NOT NULL,
	[id_eliminar] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_detalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[id_inventario] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[existencia] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[precioCompra] [decimal](18, 0) NOT NULL,
	[precioVenta] [decimal](18, 0) NOT NULL,
	[id_categoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](100) NOT NULL,
	[apellidos] [varchar](100) NOT NULL,
	[usuario] [varchar](100) NOT NULL,
	[contraseña] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[cantidadProductos] [int] NOT NULL,
	[subtotal] [decimal](18, 0) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[empleado] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Detalles]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD FOREIGN KEY([id_producto])
REFERENCES [dbo].[Productos] ([id_producto])
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD FOREIGN KEY([id_categoria])
REFERENCES [dbo].[Categorias] ([id_categoria])
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_ELIMINAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DETALLES_ELIMINAR]
(
	@id_eliminar int
)
AS
BEGIN 
	DELETE Detalles WHERE id_eliminar=@id_eliminar
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_INSERTAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DETALLES_INSERTAR]
(
	@id_venta int,
	@id_producto int,
	@cantidad int,
	@total decimal,
	@id_eliminar int
)
AS
BEGIN
	INSERT INTO Detalles(id_venta, id_producto, cantidad, total, id_eliminar)
	VALUES(@id_venta, @id_producto, @cantidad, @total, @id_eliminar)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_DETALLES_VER]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DETALLES_VER]
(
	@id_venta int
)
AS
BEGIN
	SELECT D.id_venta as [No. Venta], P.nombre as [Producto], P.precioVenta as [Precio], D.cantidad as [Cantidad],
	D.total as [Total] FROM Detalles D INNER JOIN Productos P ON D.id_producto=P.id_producto INNER JOIN Ventas V 
	ON D.id_venta=V.id_venta WHERE D.id_venta=@id_venta ORDER BY P.nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INICIO_SESION]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INICIO_SESION]
(
	@usuario varchar(100),
	@contraseña nvarchar(100)
)
AS
SELECT usuario FROM Usuarios WHERE usuario=@usuario and contraseña=@contraseña
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERTAR_CATEGORIA]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERTAR_CATEGORIA]
(
	@nombre varchar(50)
)
AS
BEGIN 
	INSERT INTO Categorias(nombre)
	VALUES(@nombre)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_BUSCAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--INVENTARIO_BUSCAR
CREATE PROCEDURE [dbo].[SP_INVENTARIO_BUSCAR]
(
	@nombre varchar(100)
)
AS
SELECT  P.id_producto as [Código del producto], P.nombre as [Producto],
P.precioVenta as [Precio Venta], I.existencia as Existencia FROM Inventario I INNER JOIN Productos P ON I.id_producto=P.id_producto
WHERE P.nombre like+'%'+@nombre+'%' ORDER BY P.nombre
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_ELIMINAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--INVENTARIO_ELIMINAR
CREATE PROCEDURE [dbo].[SP_INVENTARIO_ELIMINAR]
(
	@id_producto int
)
AS
BEGIN
	DELETE Inventario WHERE id_producto=@id_producto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_INSERTAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INVENTARIO_INSERTAR]
(
	@id_producto int,
	@existencia int
)
AS
BEGIN
	INSERT Inventario(id_producto, existencia)
	VALUES(@id_producto, @existencia)	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_MODIFICAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INVENTARIO_MODIFICAR]
(
	@id_producto int,
	@existencia int
)
AS
BEGIN
	UPDATE Inventario SET existencia=@existencia WHERE id_producto=@id_producto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INVENTARIO_MOSTRAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--INVENTARIO_MOSTRAR
CREATE PROCEDURE [dbo].[SP_INVENTARIO_MOSTRAR]
AS
SELECT  P.id_producto as [Código del producto], P.nombre as [Producto],
P.precioVenta as [Precio Venta], I.existencia as Existencia FROM Inventario I INNER JOIN Productos P ON I.id_producto=P.id_producto
ORDER BY P.nombre
GO
/****** Object:  StoredProcedure [dbo].[SP_LLENAR_COMBO_CATEGORIAS]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LLENAR_COMBO_CATEGORIAS]
AS
BEGIN
	SELECT*FROM Categorias ORDER BY nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LLENAR_COMBO_PRODUCTOS]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--LLENAR_COMBO_PRODUCTOS
CREATE PROCEDURE [dbo].[SP_LLENAR_COMBO_PRODUCTOS]
AS
BEGIN
	SELECT*FROM Productos
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LLENAR_COMBO_PRODUCTOS_INVENTARIO]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LLENAR_COMBO_PRODUCTOS_INVENTARIO]
AS
BEGIN
SELECT P.nombre FROM Inventario I INNER JOIN Productos P ON I.id_producto=P.id_producto 
ORDER BY P.nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_BUSCAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTOS_BUSCAR]
(
	@nombre varchar(100)
)
AS
BEGIN
	SELECT P.id_producto as [Código], P.nombre as [Producto], P.precioCompra as [Precio Compra],
	P.precioVenta as [Precio Venta], C.nombre as [Categoria] FROM Productos P INNER JOIN Categorias C
	ON P.id_categoria=C.id_categoria WHERE P.nombre like+'%'+@nombre+'%' ORDER BY P.nombre
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_ELIMINAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PRODUCTOS_ELIMINAR
CREATE PROCEDURE [dbo].[SP_PRODUCTOS_ELIMINAR]
(
	@id_producto int
)
AS
BEGIN
	DELETE Productos WHERE id_producto=@id_producto
END
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_INSERTAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PRODUCTOS_INSERTAR
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
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_MODIFICAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--PRODUCTOS_MODIFICAR
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
GO
/****** Object:  StoredProcedure [dbo].[SP_PRODUCTOS_MOSTRAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_PRODUCTOS_MOSTRAR]
AS
	SELECT P.id_producto as [Código], P.nombre as [Producto], P.precioCompra as [Precio Compra],
	P.precioVenta as [Precio Venta], C.nombre as [Categoria] FROM Productos P INNER JOIN Categorias C
	ON P.id_categoria=C.id_categoria ORDER BY P.nombre
--BUSCAR_PRODUCTOS
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIO_INSERTAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_USUARIO_INSERTAR]
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
GO
/****** Object:  StoredProcedure [dbo].[SP_USUARIO_MODIFICAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--USUARIO_MODIFICAR
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
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_BUSCAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_VENTAS_BUSCAR]
(
	@fecha datetime
)
AS
BEGIN
	 SELECT id_venta as [ID], cantidadProductos as [Cantidad de Productos], subtotal as [Subtotal],
     fecha as [Fecha], empleado as [Empleado] FROM Ventas WHERE fecha=@fecha
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_ELIMINAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VENATAS_ELIMINAR
CREATE PROCEDURE [dbo].[SP_VENTAS_ELIMINAR]
(
	@id_venta int
)
AS
BEGIN
	DELETE Ventas WHERE id_venta=@id_venta
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_INSERTAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VENTAS_INSERTAR
CREATE PROCEDURE [dbo].[SP_VENTAS_INSERTAR]
(
	@cantidadProductos int,
	@subtotal decimal,
	@empleado varchar(100)
)
AS
BEGIN
	INSERT INTO Ventas(cantidadProductos, subtotal, fecha, empleado)
	VALUES(@cantidadProductos, @subtotal,GETDATE(), @empleado)
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_VENTAS_MOSTRAR]    Script Date: 01/03/2021 06:41:22 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--VENTAS_MOSTRAR
CREATE PROCEDURE [dbo].[SP_VENTAS_MOSTRAR]
AS
SELECT id_venta as [ID], cantidadProductos as [Cantidad de Productos], subtotal as [Subtotal],
fecha as [Fecha], empleado as [Empleado] FROM Ventas ORDER BY fecha
GO
