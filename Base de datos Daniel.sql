
---------Creacion de la base de datos
use master
go
if exists (select * from sysdatabases where name='BDSistemaVentas')
		drop database BDSistemaVentas
go
create database BDSistemaVentas
go
---------Creacion de las tablas 
use BDSistemaVentas
go
create type TCodProducto from varchar(5)not null;
go
create type TCodCliente from varchar (6)not null;
go
---- TABLA: TProducto
create table TProducto
(  -- lista de atributos o campos
	CodProducto TCodProducto not null,
	Producto varchar(20),
	Descripcion varchar(50),
	Marca varchar (15),
	Modelo varchar (15),
	Stock int,
	PrecioUnitario float,
	------- definicion ded cables----------
	primary key (CodProducto),---- la ultima linea de codigo no lleva coma(,)
)
go
-------TABLA: TSerieProducto
create table TSerieProducto(
	CodProducto TCodProducto not null,
	Serie varchar(30),
	------definicion de las claves
	foreign key(CodProducto) references TProducto 	
)
go
----------------TABLA DE USUARIO-------------------------
create table TUsuario(
	CodUsuario varchar(10)not null,
	Contraseña varchar(8)not null,
	DNI varchar (8),
	Nombre varchar(50),
	Edad int,
	Telefono varchar(9),
	Tipo varchar (14) check (Tipo in ('VENDEDOR','ADMINISTRADOR','GERENTE')),
	Estado varchar(5) check (Estado in ('HABIL','DESHA'))
	primary key (CodUsuario)
)
go
------TABLA: TCliente -----
create table TCliente(
	CodCliente TCodCliente  not null,
	DNI varchar(8),
	Nombres varchar(50),
	Direccion varchar(50),
	Email varchar(30),
	Telefono varchar(9),
	----Determinacion de las claves
	primary key (CodCliente)
)
go
------TABLA:TDocVenta----------
create table TDocVenta(
	NroDocVenta varchar(10),
	Fecha varchar(10),
	Tipo varchar(12),
	TipoPago varchar(12),
	CodCliente TCodCliente not null,
	CodUsuario varchar(10)not null,
	-------Determinacion de Claves
	primary key (NroDocVenta),
	foreign key (CodCliente) references TCliente,
	foreign key (CodUsuario) references TUsuario
)
go
------TABLA: TDetalleVenta-------
create table TDetalleVenta(
	NroDocVenta varchar(10),
	CodProducto TCodProducto not null,
	Serie varchar(30),
	Cantidad int,
	PrecioUnitario float,
	-------Deteminacion de Claves 
	foreign key (NroDocVenta) references TDocVenta,
	foreign key (CodProducto) references TProducto
)
go
-------TABLA DE Documento de PagoVenta-----------
create table TDocVentaCredito(
	NroDocVentaCredito varchar(10),
	NroDocVenta varchar(10),
	NroCuotas int,
	FechaPago varchar(10),
	Observaciones varchar(50),
	Estado varchar(20),
	-------Determinacion de Claves
	primary key (NroDocVentaCredito),
	foreign key (NroDocVenta) references TDocVenta,
)
go
--------TABLA DE DETALLE DE PAGO DE VENTA
create table TDetalleVentaCredito(
	NroDocVentaCredito varchar(10),
	CuotaActual int,
	Fecha varchar(10),
	CodUsuario varchar(10)not null,
	MontoPagado float,
	foreign key (CodUsuario) references TUsuario,
	foreign key (NroDocVentaCredito)references TDocVentaCredito

)
go
--------TABLA DE ARQUEO ---------
create table TArqueoCaja(
	NroArqueoCaja varchar(10),
	Fecha varchar (10),
	TotalSolesInicio float,
	TotalSolesFinal float,
	CodUsuario varchar(10),
	primary key (NroArqueoCaja),
	------Determinacion de las claves primarias
	foreign key (CodUsuario) references TUsuario,
)
go
use BDSistemaVentas
go
-- ///////////////////////////////////	PROCEDIMIENTOS ALMACENADOS //////////////////////////////// */

/*********************************************************************************************************************/
/**************************************			USUARIO		**********************************************************/
/*********************************************************************************************************************/

-------------------------------------   INSERTAR UN USUARIO ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TUsuario_Insertar')
	drop procedure spu_TUsuario_Insertar
go
CREATE PROCEDURE spu_TUsuario_Insertar
	@CodUsuario varchar(10),
	@Contraseña varchar (20),
	@DNI varchar(50), 
	@Nombre	varchar (15),
	@Edad varchar (15),
	@Telefono varchar(20), 
	@Tipo varchar (14),
	@Estado varchar (5)
as
begin
--validar el codigo
	IF(@CodUsuario!='' and not exists (select * from TUsuario where CodUsuario=@CodUsuario))
	begin
		-- validar Constraseña 
		IF (@Contraseña!='')
			begin
				-- VALIDAR DNI
				IF (@DNI!='')
				begin
					-- VALIDAR NOMBRES
					IF (@Nombre!='')
						begin
							-- VALIDAR EDAD
							IF (@Edad!='')
							begin
								-- VALIDAR TELEFONO
								IF (@Telefono!='')
								begin
									-- VALIDAR TIPO
									IF (@Tipo!='')
									begin
										IF (@Estado!='')
										begin
											insert into TUsuario values(@CodUsuario,@Contraseña,@DNI,@Nombre,@Edad,@Telefono,@Tipo,@Estado)
											select CodError=0,Mensaje='Registro del USUARIO insertado exitosamente'
										end
										ELSE select CodError=1,Mensaje='El campo  ESTADO no debe estar vacio'
									end
									ELSE select CodError=1,Mensaje='El campo  TIPO no debe estar vacio'
								end
								ELSE select CodError=1,Mensaje='El campo de TELEFONO no debe estar vacio'
							end
							ELSE select CodError=1,Mensaje='El campo de EDAD no debe estar vacio'
						end 
						ELSE select CodError=1,Mensaje='El campo de NOMBRE no debe estar vacio'
					end
					ELSE select CodError=1,Mensaje='El campo de	DNI no debe estar vacio'
				end
				ELSE select CodError=1,Mensaje='El campo de	CONTRASEÑA no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El CODIGO USUARIO no puede estar vacio o ya existe este codigo'
end
go


select * from TUsuario
go

-------------------------------------   ACTUALIZAR UN USUARIO ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TUsuario_Actualizar')
	drop procedure spu_TUsuario_Actualizar
go
CREATE PROCEDURE spu_TUsuario_Actualizar
	@CodUsuario varchar(10),
	@Contraseña varchar (20),
	@DNI varchar(50), 
	@Nombre	varchar (15),
	@Edad varchar (15),
	@Telefono varchar(20), 
	@Tipo varchar (14),
	@Estado varchar (5)
as
begin
--validar el codigo
	IF(@CodUsuario!='' and exists (select * from TUsuario where CodUsuario=@CodUsuario))
	begin
		-- validar Constraseña 
		IF (@Contraseña!='')
			begin
				-- VALIDAR DNI
				IF (@DNI!='')
				begin
					-- VALIDAR NOMBRES
					IF (@Nombre!='')
						begin
							-- VALIDAR MODELO
							IF (@Edad!='')
							begin
								-- VALIDAR SERIE
								IF (@Telefono!='')
								begin
									-- VALIDAR STOCK
									IF (@Tipo!='')
									begin
										-- VALIDAR ESTADO
										IF (@Estado!='')
										begin
											update TUsuario set 
												Contraseña=@Contraseña,
												DNI=@DNI,
												Nombre=@Nombre,
												Edad=@Edad,
												Telefono=@Telefono,
												Tipo=@Tipo,
												Estado=@Estado
											where CodUsuario=@CodUsuario
											select CodError=0,Mensaje='Registro del USUARIO actualizado exitosamente'

										end
										ELSE select CodError=1,Mensaje='El campo  ESTADO no debe estar vacio'
									end
									ELSE select CodError=1,Mensaje='El campo  TIPO no debe estar vacio'
								end
								ELSE select CodError=1,Mensaje='El campo de TELEFONO no debe estar vacio'
						end
						ELSE select CodError=1,Mensaje='El campo de EDAD no debe estar vacio'
					end 
					ELSE select CodError=1,Mensaje='El campo de NOMBRE no debe estar vacio'
				end
				ELSE select CodError=1,Mensaje='El campo de	DNI no debe estar vacio'
			end
			ELSE select CodError=1,Mensaje='El campo de	CONTRASEÑA no debe estar vacio'
	end
	ELSE select CodError=1,Mensaje='El CODIGO USUARIO no puede estar vacio o ya existe este codigo'
end
go
--------------------------------- lista general para la tabla TUsuario--------------------------
create procedure spuTUsuario_ListaGeneral
as 
begin
	select * from TUsuario
end 
go
--------------------------------------------------------------------------------------------------


/*********************************************************************************************************************/
/**************************************			LOGIN		**********************************************************/
/*********************************************************************************************************************/
---------------------------------------------------------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name ='spuLogin')
	drop procedure spuLogin
go
CREATE PROCEDURE spuLogin
	@CodUsuario varchar(10),
	@Contraseña varchar (20)
as 
begin
	select Tipo,CodUsuario,Nombre
		from TUsuario U
		where U.CodUsuario=@CodUsuario and U.Contraseña=@Contraseña
end 
go


/*********************************************************************************************************************/
/**************************************			CLIENTE		**********************************************************/
/*********************************************************************************************************************/
-------------------------------------   INSERTAR UN CLIENTE ----------------------------------------- */

if exists (select * from dbo.sysobjects where name ='spu_TCliente_Insertar')
	drop procedure spu_TCliente_Insertar
go
CREATE PROCEDURE spu_TCliente_Insertar
	@CodCliente TCodCliente,
	@DNI varchar(8),
	@Nombres varchar(40),
	@Direccion varchar(50),
	@Email varchar(30),
	@Telefono varchar(9)
as
begin
-- validar codigo del cliente
	IF (@CodCliente!='' and not exists (select * from TCliente where CodCliente=@CodCliente))
	begin
		-- validar nombres
		IF (@Nombres!='')
		begin
			insert into TCliente values (@CodCliente,@DNI,@Nombres,@Direccion,@Email,@Telefono)
			select CodError=0,Mensaje='Registro del CLIENTE insertado exitosamente'
		end
		ELSE select CodError=1,Mensaje='El campo de NOMBRES no debe estar vacio'
	end
	ELSE select  CodError=1,Mensaje='El CODIGO DEL CLIENTE no puede estar vacio o ya existe este codigo'
END
go 


-------------------------------------   ACTUALIZAR UN CLIENTE ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TCliente_Actualizar')
	drop procedure spu_TCliente_Actualizar
go
CREATE PROCEDURE spu_TCliente_Actualizar
	@CodCliente TCodCliente,
	@DNI varchar(8),
	@Nombres varchar(40),
	@Direccion varchar(50),
	@Email varchar(30),
	@Telefono varchar(9)
as
begin
-- validar codigo del cliente
	IF (@CodCliente!='' and  exists (select * from TCliente where CodCliente=@CodCliente))
	begin
		-- validar nombres
		IF (@Nombres!='')
		begin
			update TCliente set
				 DNI=@DNI,
				 Nombres=@Nombres,
				 Direccion=@Direccion,
				 Email=@Email,
				 Telefono=@Telefono
			where CodCliente=@CodCliente
			select CodError=0,Mensaje='el CLIENTE ha sido actualizado exitosamente'
		end
		ELSE select CodError=1,Mensaje='El campo de NOMBRES no debe estar vacio'
	end
	ELSE select  CodError=1,Mensaje='El CODIGO DEL CLIENTE no puede estar vacio o ya existe este codigo'
END
go 
--------------------------------- lista general para la tabla TCliente--------------------------
if exists (select * from dbo.sysobjects where name ='spuTCliente_ListaGeneral')
	drop procedure spuTCliente_ListaGeneral
go
CREATE PROCEDURE spuTCliente_ListaGeneral
as 
begin
	select * from TCliente
end 
go
--------------------------------------------------------------------------------------------------

-----------Buscar CodCliente por DNI-------------------
----Procedimiento que devuelve el codigo de un cliente a partir de su DNI
if exists (select * from dbo.sysobjects where name='spu_BuscarDNI')
	drop procedure spu_BuscarDNI
go
create procedure spu_BuscarDNI
	@DNI varchar(8)
as 
begin
	select CodCliente
		from TCliente
		where DNI=@DNI
end
go
-------------
exec spu_BuscarDNI '111111'


/*********************************************************************************************************************/
/**************************************			PRODUCTO		******************************************************/
/*********************************************************************************************************************/
-------------------------------------   INSERTAR UN PRODUCTO ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TProducto_Insertar')
	drop procedure spu_TProducto_Insertar
go
CREATE PROCEDURE spu_TProducto_Insertar
	@CodProducto TCodProducto,
	@Producto varchar (20),
	@Descripcion varchar(50), 
	@Marca	varchar (15),
	@Modelo varchar (15),
	@Stock int,
	@PrecioUnitario float
as
begin
  --validar el codigo
  IF(@CodProducto!='' and not exists (select * from TProducto where CodProducto=@CodProducto))
	begin
		-- validar Producto 
		IF (@Producto!='')
			begin
				-- VALIDAR MARCA
				IF (@Descripcion!='')
				begin
					-- VALIDAR UNIDAD DE MEDIDA
					IF (@Marca!='')
					begin
					-- VALIDAR MODELO
						IF (@Modelo!='')
						begin
							
									-- VALIDAR PRECIO UNITARIO 
									IF (@PrecioUnitario>0)
									begin
										insert into TProducto values(@CodProducto,@Producto,@Descripcion,@Marca,@Modelo,@Stock,@PrecioUnitario)
										select CodError=0,Mensaje='Registro del PRODUCTO insertado exitosamente'
									end
									ELSE select CodError=1,Mensaje='El PRECIO UNITARIO debe ser  mayor a 0' 
							
						end
						ELSE select CodError=1,Mensaje='El campo de MODELO no debe estar vacio'
					end 
					ELSE select CodError=1,Mensaje='El campo de MAARCA no debe estar vacio'
				end
				ELSE select CodError=1,Mensaje='El campo de	DESCRIPCION no debe estar vacio'
			end
			ELSE select CodError=1,Mensaje='El campo de	NOMBRE DEL PRODUCTO no debe estar vacio'
	end
	ELSE select CodError=1,Mensaje='El CODIGO PRODUCTO no puede estar vacio o ya existe este codigo'
end
go
--caso de prueba
exec spu_TProducto_Insertar 'P001','TV','LG DE 55 PULG','LG','UJ-53000',1,2.3
insert into TSerieProducto values('P001','UE15161614');
GO

-------------------------------------   ACTUALIZAR UN PRODUCTO ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TProducto_Actualizar')
	drop procedure spu_TProducto_Actualizar
go
CREATE PROCEDURE spu_TProducto_Actualizar
@CodProducto TCodProducto,
	@Producto varchar (20),
	@Descripcion varchar(50), 
	@Marca	varchar (15),
	@Modelo varchar (15),
	@Stock float,
	@PrecioUnitario float
as
begin
--validar el codigo
  IF(@CodProducto!='' and  exists (select * from TProducto where CodProducto=@CodProducto))
	begin
		-- validar Producto 
		IF (@Producto!='')
			begin
				-- VALIDAR MARCA
				IF (@Descripcion!='')
				begin
					-- VALIDAR UNIDAD DE MEDIDA
					IF (@Marca!='')
					begin
					-- VALIDAR MODELO
						IF (@Modelo!='')
						begin
								
									-- VALIDAR PRECIO UNITARIO 
									IF (@PrecioUnitario>0)
									begin
										update TProducto set
											Producto=@Producto,
											Descripcion=@Descripcion, 
											Marca=@Marca,	
											Modelo=@Modelo,  
											Stock=@Stock, 
											PrecioUnitario=@PrecioUnitario
										where CodProducto=@CodProducto
										select CodError=0,Mensaje='el PRODUCTO ha sido actualizado exitosamente'
									end
									ELSE select CodError=1,Mensaje='El PRECIO UNITARIO debe ser  mayor a 0' 
							
						end
						ELSE select CodError=1,Mensaje='El campo de MODELO no debe estar vacio'
					end 
					ELSE select CodError=1,Mensaje='El campo de MAARCA no debe estar vacio'
				end
				ELSE select CodError=1,Mensaje='El campo de	DESCRIPCION no debe estar vacio'
			end
			ELSE select CodError=1,Mensaje='El campo de	NOMBRE DEL PRODUCTO no debe estar vacio'
	end
	ELSE select CodError=1,Mensaje='El CODIGO PRODUCTO no puede estar vacio o ya existe este codigo'
end
go
GO
-------------------------------------   ACTUALIZAR UN PRODUCTO ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TProducto_Eliminar')
	drop procedure spu_TProducto_Eliminar
go 
CREATE PROCEDURE spu_TProducto_Eliminar	
	@CodProducto TCodProducto
as
begin
	--validar el codigo
	IF(@CodProducto!='' and exists (select * from TProducto where CodProducto=@CodProducto))
	begin
		delete from TProducto
		where CodProducto=@CodProducto
		select CodError=0,Mensaje='el PRODUCTO ha sido eliminado exitosamente'
	end
	ELSE select CodError=1,Mensaje='el PRODUCTO no debe estar vacio o ingrese un PRODUCTO existente'
end
go

GO

-------------------------------------   insertar una serie PRODUCTO ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TSerieProducto_Insertar')
	drop procedure spu_TSerieProducto_Insertar
go 
CREATE PROCEDURE spu_TSerieProducto_Insertar	
	@CodProducto TCodProducto,
	@Serie varchar(30)
as
begin
	--validar el codigo
	IF(@CodProducto!='' and exists (select * from TProducto where CodProducto=@CodProducto))
	begin
		insert into TSerieProducto values(@CodProducto,@Serie)
		select CodError=0,Mensaje='La serie fue añadida exitosamente'
	end
	ELSE select CodError=1,Mensaje='Error la serie es vacia o no existe el Codigo del Producto' 
end
go
GO
--------------------------------- lista general para la tabla TCliente--------------------------
if exists (select * from dbo.sysobjects where name ='spuTProducto_ListaGeneral')
	drop procedure spuTProducto_ListaGeneral
go
CREATE PROCEDURE spuTProducto_ListaGeneral
as 
begin
	select * from TProducto
end 
go
/*********************************************************************************************************************/
/**************************************		SERIE DE UN PROUDUCTO  ***************************************************/
/*********************************************************************************************************************/
-------------------------------------   insertar una serie PRODUCTO ----------------------------------------- */
if exists (select * from dbo.sysobjects where name ='spu_TSerieProducto_Eliminar')
	drop procedure spu_TSerieProducto_Eliminar
go 
CREATE PROCEDURE spu_TSerieProducto_Eliminar	
	@CodProducto TCodProducto,
	@Serie varchar(30)
as
begin
	--validar el codigo
	IF(@CodProducto!='' and exists (select * from TProducto where CodProducto=@CodProducto))
	begin
		delete from TSerieProducto where CodProducto=@CodProducto and Serie=@Serie
		select CodError=0,Mensaje='La serie fue eliminada exitosamente'
	end
	ELSE select CodError=1,Mensaje='Error la serie es vacia o no existe el Codigo del Producto' 
end
go


/*********************************************************************************************************************/
/**************************************		DOC VENTA		    ******************************************************/
/*********************************************************************************************************************/
-------------------------------------------------------------------------------------------------------------
--------------------------Ultima Boleta o Factura Vendida -------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_UltimoNroDocVenta')
	drop procedure spu_UltimoNroDocVenta
go
create procedure spu_UltimoNroDocVenta
	@Tipo varchar(12)
as 
begin
	select top 1 (substring(NroDocVenta,0,7)+convert(varchar(10),(convert(int,substring(NroDocVenta,5,len(NroDocVenta)))+1))) as Nro 
	from TDocVenta 
	where Tipo=@Tipo
	order by NroDocVenta desc
end
go

-----------------------------------------------------------------------------------------------------
--------------TDocVenta Insertar --------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name ='spu_TDocVenta_Insertar')
	drop procedure spu_TDocVenta_Insertar
go
CREATE PROCEDURE spu_TDocVenta_Insertar
	@NroDocVenta varchar(10),
	@Fecha varchar(10),
	@Tipo varchar(12),
	@TipoPago varchar(12),
	@CodCliente varchar(6),
	@CodUsuario varchar(10)
as
begin
-- validar codigo del cliente
	IF (@NroDocVenta!='' and not exists (select * from TDocVenta where NroDocVenta=@NroDocVenta))
	begin
		-- validar nombres
		IF (@Fecha!='')
		begin
			if(@Tipo!='')
			begin
				if(@TipoPago!='')
				begin
					if(@CodCliente!='')
					begin
						if(@CodUsuario!='')
						begin
							insert into TDocVenta values (@NroDocVenta,@Fecha,@Tipo,@TipoPago,@CodCliente,@CodUsuario)
							select CodError=0,Mensaje='Registro de Documento Venta insertado exitosamente'
						end
						else select CodError=1,Mensaje='El campo de Codigo del Usuario no debe estar vacio'
					end
					else select CodError=1,Mensaje='El campo de Codigo del Cliente no debe estar vacio'
				end
				else select CodError=1,Mensaje='El campo de Tipo de pago no debe estar vacio'
			end
			else select CodError=1,Mensaje='El campo de Tipo no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El campo de fecha no debe estar vacio'
	end
	ELSE select  CodError=1,Mensaje='El NroDocVenta no puede estar vacio o ya existe este codigo'
END
go 
----------------------------------------------------------------------------------------
-------------------TDetalleVenta Insertar ---------------------------------------
-----------------------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name ='spu_TDetalleVenta_Insertar')
	drop procedure spu_TDetalleVenta_Insertar
go
CREATE PROCEDURE spu_TDetalleVenta_Insertar
	@NroDocVenta varchar(10),
	@CodProducto varchar(5),
	@Serie varchar(30),
	@Cantidad int,
	@PrecioUnitario float
as
begin
-- validar codigo del cliente
	IF (@NroDocVenta!='' and exists (select * from TDocVenta where NroDocVenta=@NroDocVenta))
	begin
		-- validar nombres
		IF (@CodProducto!='')
		begin
			if(@Cantidad>0)
			begin
				if(@PrecioUnitario>0)
				begin
					insert into TDetalleVenta values (@NroDocVenta,@CodProducto,@Serie,@Cantidad,@PrecioUnitario)
					select CodError=0,Mensaje='Registro de Detalle de Venta insertado exitosamente'
				end
				else select CodError=1,Mensaje='El campo de PrecioUnitario no debe estar vacio'
			end
			else select CodError=1,Mensaje='El campo de cantidad no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El campo de codproducto no debe estar vacio'
	end
	ELSE select  CodError=1,Mensaje='El NroDocVenta no puede estar vacio o no existe este codigo'
END
go
----------------------------------------------------------------------------------------
-------------------TDetalleVenta Listar por Codigo ---------------------------------------
-----------------------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name ='spuTDetalleVenta_ListaPorCodigo')
	drop procedure spuTDetalleVenta_ListaPorCodigo
go
CREATE PROCEDURE spuTDetalleVenta_ListaPorCodigo
	@NroDocVenta varchar(10)
as
begin
-- validar codigo del cliente
	IF (@NroDocVenta!='' and exists (select * from TDocVenta where NroDocVenta=@NroDocVenta))
	begin
		select A.CodProducto,A.Cantidad,B.Producto,B.Marca,B.Modelo,A.Serie,A.PrecioUnitario,(cast(Cantidad as int )*cast(A.PrecioUnitario as float))as SubTotal
		from TDetalleVenta A inner join TProducto B on A.CodProducto=B.CodProducto 
		where NroDocVenta=@NroDocVenta
	end
END
go
/*********************************************************************************************************************/
/**************************************		DOCVENTACREDITO    ******************************************************/
/*********************************************************************************************************************/
--------------------------------	Insertar Docventacredito	------------------------------------

if exists (select * from dbo.sysobjects where name ='spu_TDocVentaCredito_Insertar')
	drop procedure spu_TDocVentaCredito_Insertar
go
CREATE PROCEDURE spu_TDocVentaCredito_Insertar
	@NroDocVentaCredito varchar(10),
	@NroDocVenta varchar(10),
	@NroCuotas int,
	@FechaPago varchar(10),
	@Observaciones varchar(50),
	@Estado varchar(20)
as
begin
-- validar codigo del cliente
	IF (@NroDocVentaCredito!='' and not exists (select * from TDocVentaCredito where NroDocVentaCredito=@NroDocVentaCredito))
	begin
		-- validar NroDocVenta
		IF (@NroDocVenta!='')
		begin
			-- validar @NroCuotas
			if(@NroCuotas>0)
			begin
				if(@FechaPago!='')
				begin
						if(@Estado!='')
						begin
							insert into TDocVentaCredito values(@NroDocVentaCredito,@NroDocVenta,@NroCuotas,@FechaPago,@Observaciones,@Estado)
							select CodError=0,Mensaje='Registro de la VENTA DE CREDITO insertado exitosamente'
						end
						else select CodError=1,Mensaje='El campo de Estado no debe estar vacio'
				end
				else select CodError=1,Mensaje='El campo de @FechaPago no debe estar vacio'
			end
			else select CodError=1,Mensaje='El campo de @NroCuotas no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El campo de @NroDocVenta no debe estar vacio'
	end
	ELSE select  CodError=1,Mensaje='El @NroDocVentaCredito no puede estar vacio o ya existe este codigo'
END
go

--------------------------------	Actualizar Docventacredito	------------------------------------
if exists (select * from dbo.sysobjects where name ='spu_TDocVentaCredito_Actualizar')
	drop procedure spu_TDocVentaCredito_Actualizar
go
CREATE PROCEDURE spu_TDocVentaCredito_Actualizar
	@NroDocVentaCredito varchar(10),
	@NroDocVenta varchar(10),
	@NroCuotas int,
	@FechaPago varchar(10),
	@Observaciones varchar(50),
	@Estado varchar(20)
as
begin
-- validar codigo del cliente
	IF (@NroDocVentaCredito!='' and not exists (select * from TDocVentaCredito where NroDocVentaCredito=@NroDocVentaCredito))
	begin
		-- validar NroDocVenta
		IF (@NroDocVenta!='')
		begin
			-- validar @NroCuotas
			if(@NroCuotas>0)
			begin
				if(@FechaPago!='')
				begin
						if(@Estado!='')
						begin
							update TDocVentaCredito set
							NroDocVenta= @NroDocVenta,
							NroCuotas= @NroCuotas,
							FechaPago= @FechaPago,
							Observaciones= @Observaciones,
							Estado= @Estado
							where NroDocVentaCredito=@NroDocVentaCredito
							select CodError=0,Mensaje='Registro de la VENTA DE CREDITO actualizado exitosamente'
						end
						else select CodError=1,Mensaje='El campo de Estado no debe estar vacio'
				end
				else select CodError=1,Mensaje='El campo de @FechaPago no debe estar vacio'
			end
			else select CodError=1,Mensaje='El campo de @NroCuotas no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El campo de @NroDocVenta no debe estar vacio'
	end
	ELSE select  CodError=1,Mensaje='El @NroDocVentaCredito no puede estar vacio o ya existe este codigo'
END
go

--------------------------Ultima Nro de venta credito -------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_UltimoNroDocVentaCredito')
	drop procedure spu_UltimoNroDocVentaCredito
go
create procedure spu_UltimoNroDocVentaCredito
as 
begin
	select top 1 (substring(NroDocVentaCredito,0,7)+convert(varchar(10),(convert(int,substring(NroDocVentaCredito,5,len(NroDocVentaCredito)))+1))) as Nro 
	from TDocVentaCredito
	order by NroDocVentaCredito desc
end
go

--------------------------------	Listar VentaCredito	------------------------------------

if exists (select * from dbo.sysobjects where name ='spu_TDocVentaCredito_Listar')
	drop procedure spu_TDocVentaCredito_Listar
go
CREATE PROCEDURE spu_TDocVentaCredito_Listar
	@NroDocVentaCredito varchar (10)
as
begin
	select * 
		from TDocVentaCredito 
		where NroDocVentaCredito=@NroDocVentaCredito
END
go
/*********************************************************************************************************************/
/**************************************		DOCVENTACREDITODETALLE   ******************************************************/
/*********************************************************************************************************************/

--------------------------------	Insertar DocventacreditoDetalle	------------------------------------
if exists (select * from dbo.sysobjects where name ='spu_TDetalleVentaCredito_Insertar')
	drop procedure spu_TDetalleVentaCredito_Insertar
go
CREATE PROCEDURE spu_TDetalleVentaCredito_Insertar
	@NroDocVentaCredito varchar(10),
	@CuotaActual int,
	@Fecha varchar(10),
	@CodUsuario varchar(10),
	@MontoPagado float
as 
begin
	IF (@NroDocVentaCredito!='' and exists (select * from TDetalleVentaCredito where NroDocVentaCredito=@NroDocVentaCredito))
	begin
		-- validar nombres
		IF (@CuotaActual>0)
		begin
			if(@Fecha!='')
			begin
				if(@CodUsuario!='' and exists (select * from TUsuario where CodUsuario=@CodUsuario))
				begin
					if(@MontoPagado>0)
					begin
						insert into TDetalleVentaCredito values (@NroDocVentaCredito,@CuotaActual,@Fecha,@CodUsuario,@MontoPagado)
						select CodError=0,Mensaje='Registro del DETALLE VENTA CREDITO insertado exitosamente'
					END
					ELSE select CodError=1,Mensaje='El campo de MontoPagado debe ser mayor a 0'
				end 
				ELSE select CodError=1,Mensaje='El campo de CodUsuario no debe estar vacio o no se enuentra'
			end
			ELSE select CodError=1,Mensaje='El campo de	@Fecha no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El campo de	@CuotaActual no debe estar vacio'
	end
	ELSE select CodError=1,Mensaje='El @NroDocVentaCredito no puede estar vacio o no  ya existe este codigo'
end
go

--------------------------------	Actualizar DocventacreditoDetalle	------------------------------------
if exists (select * from dbo.sysobjects where name ='spu_TDetalleVentaCredito_Actualizar')
	drop procedure spu_TDetalleVentaCredito_Actualizar
go
CREATE PROCEDURE spu_TDetalleVentaCredito_Actualizar
	@NroDocVentaCredito varchar(10),
	@CuotaActual int,
	@Fecha varchar(10),
	@CodUsuario varchar(10),
	@MontoPagado float
as 
begin
	IF (@NroDocVentaCredito!='' and exists (select * from TDetalleVentaCredito where NroDocVentaCredito=@NroDocVentaCredito))
	begin
		-- validar nombres
		IF (@CuotaActual>0)
		begin
			if(@Fecha!='')
			begin
				if(@CodUsuario!='' and exists (select * from TUsuario where CodUsuario=@CodUsuario))
				begin
					if(@MontoPagado>0)
					begin
						update TDetalleVentaCredito set
							CuotaActual=@CuotaActual,
							Fecha=@Fecha,
							CodUsuario=@CodUsuario,
							MontoPagado=@MontoPagado
						where NroDocVentaCredito=@NroDocVentaCredito
						select CodError=0,Mensaje='Registro del DETALLE VENTA DE CREDITO actualizado exitosamente'
					END
					ELSE select CodError=1,Mensaje='El campo de MontoPagado debe ser mayor a 0'
				end 
				ELSE select CodError=1,Mensaje='El campo de CodUsuario no debe estar vacio o no se enuentra'
			end
			ELSE select CodError=1,Mensaje='El campo de	@Fecha no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El campo de	@CuotaActual no debe estar vacio'
	end
	ELSE select CodError=1,Mensaje='El @NroDocVentaCredito no puede estar vacio o no  ya existe este codigo'
end
go

--------------------------------	Listar DocventacreditoDetalle	------------------------------------
if exists (select * from dbo.sysobjects where name ='spu_TDetalleVentaCredito_Listar')
	drop procedure spu_TDetalleVentaCredito_Listar
go
CREATE PROCEDURE spu_TDetalleVentaCredito_Listar
	@NroDocVentaCredito varchar(10)
as
begin
	select *
		from TDetalleVentaCredito
		where NroDocVentaCredito=@NroDocVentaCredito 
end
go

/*********************************************************************************************************************/
/**************************************		Arqueo de Caja    ******************************************************/
/*********************************************************************************************************************/
-----------------------------------------------------------------------------------------------------------------------
--------------------------Ultima Arqueo de caja -------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_UltimoArqueoDeCaja')
	drop procedure spu_UltimoArqueoDeCaja
go
create procedure spu_UltimoArqueoDeCaja
as 
begin
	select top 1 (substring(NroArqueoCaja,0,7)+convert(varchar(10),(convert(int,substring(NroArqueoCaja,5,len(NroArqueoCaja)))+1))) as Nro 
	from TArqueoCaja
	order by NroArqueoCaja desc
end
go
-----------------------------------------------------------------------------------------------------------------------
--------------------------Verificar Arqueo de caja -------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_VerificarrqueoDeCaja')
	drop procedure spu_VerificarArqueoCaja
go
create procedure spu_VerificarArqueoCaja
	@CodUsuario varchar (10)
as 
begin
	select *
		from TArqueoCaja T
		where T.Fecha=CONVERT(VARCHAR(10), GETDATE(), 103) and T.CodUsuario=@CodUsuario
end
go
exec spu_VerificarArqueoCaja 'U0001'
------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------- Cargar Datos de Arqueo de caja ----------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_CargarDatosContadoArqueoCaja')
	drop procedure spu_CargarDatosContadoArqueoCaja
go
create procedure spu_CargarDatosContadoArqueoCaja
	@CodUsuario varchar (10)
as 
begin
	select D.NroDocVenta,Fecha,Tipo,TipoPago,sum(D.Cantidad*D.PrecioUnitario)as Total
		from TDocVenta T inner join TDetalleVenta D on D.NroDocVenta=t.NroDocVenta
		where T.Fecha=CONVERT(VARCHAR(10), GETDATE(), 103) and T.CodUsuario=@CodUsuario and T.TipoPago='CONTADO'
		group by D.NroDocVenta,Fecha,Tipo,TipoPago
end
go
------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------- Cargar Datos de Arqueo de caja ----------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_CargarDatosCreditoArqueoCaja')
	drop procedure spu_CargarDatosCreditoArqueoCaja
go
create procedure spu_CargarDatosCreditoArqueoCaja
	@CodUsuario varchar (10)
as 
begin
	select T.NroDocVentaCredito ,T.NroDocVenta,D.Fecha,T.NroCuotas,D.CuotaActual,D.MontoPagado Total
		from TDocVentaCredito T left outer join  TDetalleVentaCredito D on D.NroDocVentaCredito=T.NroDocVentaCredito
		where D.Fecha=CONVERT(VARCHAR(10), GETDATE(), 103)  and D.CodUsuario=@CodUsuario
end
go
-----------------------------------------------------------------------------------------------------
--------------TArqueoCaja Insertar --------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name ='spu_TArqueoCaja_Insertar')
	drop procedure spu_TArqueoCaja_Insertar
go
CREATE PROCEDURE spu_TArqueoCaja_Insertar
	@NroArqueoCaja varchar(10),
	@Fecha varchar (10),
	@TotalSolesInicio float,
	@TotalSolesFinal float,
	@CodUsuario varchar(10)
as
begin
-- validar codigo del cliente
	IF (@NroArqueoCaja!='' and not exists (select * from TArqueoCaja where NroArqueoCaja=@NroArqueoCaja))
	begin
		-- validar nombres
		IF (@Fecha!='')
		begin
			if(@TotalSolesInicio>0)
			begin
				if(@TotalSolesFinal>0)
				begin
					if(@CodUsuario!='' and  exists (select * from TUsuario where CodUsuario=@CodUsuario))
						begin
							insert into TArqueoCaja values (@NroArqueoCaja,@Fecha,@TotalSolesInicio,@TotalSolesFinal,@CodUsuario)
							select CodError=0,Mensaje='Registro de Arqueo de caja insertado exitosamente'
						end
						select CodError=1,Mensaje='El campo de Codigo del Usuario no debe estar vacio'
				end
				else select CodError=1,Mensaje='El campo de Total soles final  no debe estar vacio'
			end
			else select CodError=1,Mensaje='El campo de total soles inicial no debe estar vacio'
		end
		ELSE select CodError=1,Mensaje='El campo de fecha no debe estar vacio'
	end
	ELSE select  CodError=1,Mensaje='El NroArqueo de Caja no puede estar vacio o ya existe este codigo'
END
go 

------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------- Cargar Datos de Arqueo de caja ----------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_IrCargarDatosContadoArqueoCaja')
	drop procedure spu_IrCargarDatosContadoArqueoCaja
go
create procedure spu_IrCargarDatosContadoArqueoCaja
	@NroArqueoCaja varchar(10),
	@CodUsuario varchar (10)
as 
begin
	select *
		from TArqueoCaja A
		where A.CodUsuario=@CodUsuario and A.NroArqueoCaja=@NroArqueoCaja
end
go
------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------- Cargar Datos de Arqueo de caja ----------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_RecuperarCargarDatosContadoArqueoCaja')
	drop procedure spu_RecuperarCargarDatosContadoArqueoCaja
go
create procedure spu_RecuperarCargarDatosContadoArqueoCaja
	@Fecha varchar (10),
	@CodUsuario varchar (10)
as 
begin
	select D.NroDocVenta,Fecha,Tipo,TipoPago,sum(D.Cantidad*D.PrecioUnitario)as Total
		from TDocVenta T inner join TDetalleVenta D on D.NroDocVenta=t.NroDocVenta
		where T.Fecha=@Fecha and T.CodUsuario=@CodUsuario and T.TipoPago='CONTADO'
		group by D.NroDocVenta,Fecha,Tipo,TipoPago
end
go
------------------------------------------------------------------------------------------------------------------------------------------------
--------------------------------- Cargar Datos de Arqueo de caja ----------------------------------------------------------------------------
if exists (select * from dbo.sysobjects where name='spu_RecuperarCargarDatosCreditoArqueoCaja')
	drop procedure spu_RecuperarCargarDatosCreditoArqueoCaja
go
create procedure spu_RecuperarCargarDatosCreditoArqueoCaja
	@Fecha varchar (10),
	@CodUsuario varchar (10)
as 
begin
	select T.NroDocVentaCredito ,T.NroDocVenta,D.Fecha,T.NroCuotas,D.CuotaActual,D.MontoPagado Total
		from TDocVentaCredito T left outer join  TDetalleVentaCredito D on D.NroDocVentaCredito=T.NroDocVentaCredito
		where D.Fecha=@Fecha  and D.CodUsuario=@CodUsuario
end
go
-----------------SPUs de los Resportes ----------------------
--------------------------------------------------------------
-----SPU para saber que productos estan sin stock-------------
if exists (select * from dbo.sysobjects where name='spuProductosSinStock')
	drop procedure spuProductosSinStock
go
create procedure spuProductosSinStock
as 
begin
	select *
	from TProducto
	where Stock=0
end
go
--------SPU para saber los Productos han sido los mas vendidos
if exists (select * from dbo.sysobjects where name='spuProductosMasVendidos')
	drop procedure spuProductosMasVendidos
go
create procedure spuProductosMasVendidos
as 
begin
	select  COUNT(A.CodProducto) as Vendidos, B.Descripcion,B.Producto,B.Marca,B.Modelo
	from TDetalleVenta A inner join TProducto B on A.CodProducto=B.CodProducto
	group by B.Descripcion,B.Producto,B.Marca,Modelo
	order by Vendidos desc
	
end
go

exec spuProductosMasVendidos
--------SPU para saber los Productos han sido los menos Vendidos
if exists (select * from dbo.sysobjects where name='spuProductosMenosVendidos')
	drop procedure spuProductosMenosVendidos
go
create procedure spuProductosMenosVendidos
as 
begin
	select  COUNT(A.CodProducto) as Vendidos, B.Descripcion,B.Producto,B.Marca,B.Modelo
	from TDetalleVenta A inner join TProducto B on A.CodProducto=B.CodProducto
	group by B.Descripcion,B.Producto,B.Marca,Modelo
	order by Vendidos 
	
end
go

exec spuProductosMenosVendidos

--------SPU para saber los dias con mas ventas
if exists (select * from dbo.sysobjects where name='spuDiasMasVendidos')
	drop procedure spuDiasMasVendidos
go
create procedure spuDiasMasVendidos
as 
begin
	select sum(Cantidad*PrecioUnitario) as Ventas,D.NroDocVenta,D.Fecha
	into #Aux
	from TDocVenta D inner join TDetalleVenta B on D.NroDocVenta=B.NroDocVenta
	group by D.NroDocVenta,D.Fecha

	select Fecha,sum(Ventas) as venta
	from #Aux
	group by Fecha 
	order by venta desc
	
end
go
exec spuDiasMasVendidos
--------SPU para saber los clientes que gastan mas dentro de la tienda xdxdxd
if exists (select * from dbo.sysobjects where name='spuClientesEstrella')
	drop procedure spuClientesEstrella
go
create procedure spuClientesEstrella
as 
begin
	select sum(Cantidad*PrecioUnitario) as Ventas,D.NroDocVenta,D.CodCliente
	into #Aux
	from TDocVenta D inner join TDetalleVenta B on D.NroDocVenta=B.NroDocVenta
	group by D.NroDocVenta,D.Fecha,D.CodCliente

	select A.CodCliente,b.Nombres,b.Email,b.Telefono,sum(Ventas) as ventaCliente
	from #Aux A inner join TCliente B on A.CodCliente=B.CodCliente
	group by A.CodCliente,b.Nombres,b.Email,b.Telefono
	order by ventaCliente desc
	
end
go
exec spuClientesEstrella
/*********************************************************************************************************************/
/**************************************		PRUEBAS     	    ******************************************************/
/*********************************************************************************************************************/
-----------------Usuario ---------------------------
------Los tipo pueden ser Vendedor,Adminitrador y Gerente ----------
------Pero ssolo puede haber un administrador y Genrente-------
insert into TUsuario values('U0001','1234','73874898','JOSE RODRIGUEZ','32','998524398','VENDEDOR','HABIL')
insert into TUsuario values('U0002','1234','34884658','ANDRES GARCIA','30','964829345','VENDEDOR','HABIL')
insert into TUsuario values('U0003','1234','73145986','DIEGO PEREZ','37','996657893','ADMINISTRADOR','HABIL')
insert into TUsuario values('U0004','1234','56574893','MARIO GOMEZ','38','922347856','GERENTE','HABIL')


----------------Producto --------------------------------
insert into TProducto values('P0001','FREIDORA','Freidora AF1400','IMACO','AF1400',4,599)
insert into TProducto values('P0002','OLLA ARROCERA','Olla cocción lenta 6,5L','iMACO','SLC065',5,200)
insert into TProducto values('P0003','PARRILLA','Grill Panini','IMACO','IG2923',2,500)
insert into TProducto values('P0004','LAVADORA','Lavadora de carga superior 22 kg','LG','TS2200DPSB',1,1000)
insert into TProducto values('P0005','Cupcake Maker','Cupcake Maker','Blanik','BCCM012',0,100)
insert into TProducto values('P0006','LAVADORA','Lavadora de carga superior 7 kg','LG','TS2600DPSB',0,600)
insert into TProducto values('P0011','Sarten','Sartén eléctrica','Imaco','PES280',1,90)
insert into TProducto values('P0007','Cocedor de Huevos','Cocedor de Huevos','Thomas','TH 80',0,80)
insert into TProducto values('P0008','Máquina de Pop Corn','Máquina de Pop Corn Coca-Cola','Nostalgia','RHP310COKE',0,60)
insert into TProducto values('P0009','Yogurt Maker','Yogurt Maker Pro','Blanik','BYMP048',0,100)
insert into TProducto values('P0010','Blender','Mini Blender','Blanik','BMB044',0,100)
insert into TProducto values('P0012','Pimer','Minipimer RMIN-989W','Recco','RMIN-989W',0,100)
insert into TProducto values('P0014','TV','TV FULL HD','LG','LGTY56199',5,5245)
insert into TProducto values('P0015','TV','TV 4K ULTRA HD','LG','LGTY56179',8,6000)
insert into TProducto values('P0016','TV','TV HD','LG','LGTY56139',6,4560)

---------------Series de lo productos--------------
---------Los se debe relacionar el codigo de los productos con sus respectiva serie 
-------Tambien puede haber haber productos sin serie por lo cual no habria registro---
-----de dicho producto en el sgte tabla y ademas cada producto puede tener varias series---------
insert into TSerieProducto values('P0001','231784221562')
insert into TSerieProducto values('P0001','679051264646')
insert into TSerieProducto values('P0001','254785212345')
insert into TSerieProducto values('P0001','452343378923')
insert into TSerieProducto values('P0002','781745587863')
insert into TSerieProducto values('P0002','671785221562')
insert into TSerieProducto values('P0002','756551264646')
insert into TSerieProducto values('P0002','451785212345')
insert into TSerieProducto values('P0002','752345678923')
insert into TSerieProducto values('P0003','341745587863')
insert into TSerieProducto values('P0003','746554677789')
insert into TSerieProducto values('P0011','442455266647')

insert into TSerieProducto values('P0004','766555678930')
insert into TSerieProducto values('P0014','442455016647')
insert into TSerieProducto values('P0014','442455026647')
insert into TSerieProducto values('P0014','442455036647')
insert into TSerieProducto values('P0014','442455046647')
insert into TSerieProducto values('P0014','442455056647')

insert into TSerieProducto values('P0015','806555678930')
insert into TSerieProducto values('P0015','816555678930')
insert into TSerieProducto values('P0015','826555678930')
insert into TSerieProducto values('P0015','836555678930')
insert into TSerieProducto values('P0015','846555678930')
insert into TSerieProducto values('P0015','856555678930')
insert into TSerieProducto values('P0015','866555678930')
insert into TSerieProducto values('P0015','876555678930')
insert into TSerieProducto values('P0016','441015266647')
insert into TSerieProducto values('P0016','761025678930')
insert into TSerieProducto values('P0016','441035266647')
insert into TSerieProducto values('P0016','761045678930')
insert into TSerieProducto values('P0016','441055266647')
insert into TSerieProducto values('P0016','761065678930')


--------------Clientes--------------------------------------
insert into TCliente values('C00001','45782311','CHIMUELO PEREZ','JR YUPANQUI','ejemplo@gmail.com','988574521')
insert into TCliente values('C00002','20323250','LA TIENDA DE DON PEPE','AV. CULTURA 1022','DONPEPE@gmail.com','987639834')
insert into TCliente values('C00003','23445452','PLAZA VEA','AV. CULTURA 1312','PLAZAVEA@gmail.com','934352346')
insert into TCliente values('C00004','34568452','TOTTUS','AV. CULTURA 1790','TOTTUS@gmail.com','987234452')
insert into TCliente values('C00005','56778452','ORION','AV. CULTURA 4012','ORION@gmail.com','943734123')
insert into TCliente values('C00006','45473452','LA CANASTA','AV. LA CULTURA 2312','LA_CANASTA@gmail.com','934523123')
insert into TCliente values('C00007','12323456','EL SOL','AV. LOS INCAS 2312','ELSOL@gmail.com','982131344')
insert into TCliente values('C00008','54535472','OXXO','SAN SEBASTIAN  U-2312','OXXO@gmail.com','934123424')
insert into TCliente values('C00009','20194628','GATOS MARKET','AV. LOS INCAS 7012','GATOS@gmail.com','945233424')
insert into TCliente values('C00010','20302132','ECONOMAX','AV. TUPAC AMARU 22','ECONOMAX@gmail.com','923454728')
insert into TCliente values('C00011','20345645','EL TAMBO','AV. LIMACPAMPA 1223','EL_TAMBO@gmail.com','976236215')
insert into TCliente values('C00012','20234456','HIPER','AV. CULTURA 1112','HIPER@gmail.com','982631122')
insert into TCliente values('C00013','22323423','MINIMARKET','AV. LOS INCAS 223','MINIMARKET@gmail.com','967340921')

--------------TDocVenta -----------------------------------------
--------tipo puede ser factura o Boleta y tipi de pago puede ser contado o credito
insert into TDocVenta values('BV-000001','03/03/2018','BOLETA','CONTADO','C00007','U0001')
insert into TDocVenta values('BV-000002','24/05/2018','BOLETA','CREDITO','C00006','U0002')
insert into TDocVenta values('BV-000003','07/06/2018','BOLETA','CONTADO','C00001','U0001')
insert into TDocVenta values('BV-000004','28/06/2018','BOLETA','CREDITO','C00002','U0002')
insert into TDocVenta values('BV-000005','01/07/2018','BOLETA','CREDITO','C00003','U0002')
insert into TDocVenta values('BV-000006','24/08/2018','BOLETA','CONTADO','C00005','U0001')
insert into TDocVenta values('BV-000007','12/09/2018','BOLETA','CONTADO','C00006','U0001')
insert into TDocVenta values('BV-000008','01/10/2018','BOLETA','CONTADO','C00008','U0002')
insert into TDocVenta values('BV-000009','12/11/2018','BOLETA','CREDITO','C00010','U0001')
insert into TDocVenta values('FV-000010','23/11/2018','FACTURA','CONTADO','C00011','U0002')
insert into TDocVenta values('FV-000011','05/12/2018','FACTURA','CONTADO','C00012','U0002')
insert into TDocVenta values('BV-000012','31/12/2018','BOLETA','CREDITO','C00005','U0001')
insert into TDocVenta values('BV-000013','20/01/2018','BOLETA','CONTADO','C00006','U0001')
insert into TDocVenta values('BV-000014','24/01/2018','BOLETA','CREDITO','C00006','U0002')
insert into TDocVenta values('BV-000015','27/01/2018','BOLETA','CONTADO','C00007','U0001')

-------------TDetalleVenta-------------
-----------Debe estar el codigo del producto con su rspectiva serie---------
insert into TDetalleVenta values('BV-000001','P0006','451785221562',2,600)
insert into TDetalleVenta values('BV-000001','P0002','679051264646',2,599)
insert into TDetalleVenta values('BV-000002','P0003','254785212345',3,5000)
insert into TDetalleVenta values('BV-000002','P0005','781745587863',1,500)
insert into TDetalleVenta values('BV-000002','P0011','442455266647',2,700)
insert into TDetalleVenta values('BV-000003','P0008','752345678923',2,600)
insert into TDetalleVenta values('BV-000004','P0007','451785212345',2,5000)
insert into TDetalleVenta values('BV-000005','P0003','254785212345',2,4000)
insert into TDetalleVenta values('BV-000006','P0014','236554677789',3,600)
insert into TDetalleVenta values('BV-000007','P0005','781745587863',3,2000)
insert into TDetalleVenta values('BV-000008','P0011','442455266647',3,200)
insert into TDetalleVenta values('BV-000009','P0014','236554677789',1,100)
insert into TDetalleVenta values('FV-000010','P0007','451785212345',2,100)
insert into TDetalleVenta values('FV-000011','P0003','254785212345',1,4000)
insert into TDetalleVenta values('BV-000012','P0005','781745587863',4,300)
insert into TDetalleVenta values('BV-000013','P0014','236554677789',3,800)
insert into TDetalleVenta values('BV-000014','P0007','451785212345',1,700)
insert into TDetalleVenta values('BV-000015','P0011','442455266647',4,400)
insert into TDetalleVenta values('BV-000015','P0003','254785212345',1,500)
insert into TDetalleVenta values('BV-000015','P0007','451785212345',7,120)

------------TDocVentaCredito--------------------------------
------------El estado puede ser activo,cancelado,congelado(suspendido)----------
------------Las observacion pueden estar en blanco y si tienen contenido deben ---------
------Decir por ejemplo : El docVenta esat congelado porque el cliente tubo un accidente-----
------y no podra pagar las letras correspondienetes-----------
insert into TDocVentaCredito values('BC-00007','BV-000002','3','11/02/2019','','ACTIVO')
insert into TDocVentaCredito values('BC-00005','BV-000005','2','07/02/2019','','ACTIVO')
insert into TDocVentaCredito values('BC-00004','BV-000004','3','05/02/2019','','ACTIVO')
insert into TDocVentaCredito values('BC-00009','BV-000009','2','11/01/2019','','ACTIVO')
insert into TDocVentaCredito values('BC-00012','BV-000012','3','17/01/2019','','ACTIVO')
insert into TDocVentaCredito values('BC-00014','BV-000014','2','21/02/2019','','ACTIVO')


------------TDetalleVentaCredito --------------------------------------
---El Numero de datos a insertar debe coincidir con el nro de cuotas de la tabla anterior---------
---es decir si el numero de cuotas es 6 debe haber como maximo 6 registros en esta tabla y como minimo 1 ------
insert into TDetalleVentaCredito values('BC-00007','1','11/02/2019','U0001','254')
insert into TDetalleVentaCredito values('BC-00005','1','07/02/2019','U0002','100')
insert into TDetalleVentaCredito values('BC-00004','1','05/02/2019','U0002','80')
insert into TDetalleVentaCredito values('BC-00009','1','11/01/2019','U0001','120')
insert into TDetalleVentaCredito values('BC-00012','1','17/01/2019','U0001','110')
insert into TDetalleVentaCredito values('BC-00014','1','21/02/2019','U0002','50')




------------TARQUEO DE CAJA ----------
---Debe tener relacion con todas la ventas hechas sin importar el tipo -----
----------de una determinada fecha por ejemplo:todas las ventas de 12/01/2018----
----deben recuadar una cantidad que sumada mas los soles de inicio deben dar solesfinal----------
insert into TArqueoCaja values('AC-00001','20/01/2018',2400,2440,'U0001')
insert into TArqueoCaja values('AC-00002','24/01/2018',100,3547,'U0002')
insert into TArqueoCaja values('AC-00003','27/01/2018',100,3547,'U0001')
insert into TArqueoCaja values('AC-00005','03/03/2018',100,3547,'U0001')
insert into TArqueoCaja values('AC-00006','07/06/2018',100,3547,'U0001')
insert into TArqueoCaja values('AC-00007','28/06/2018',100,3547,'U0002')
insert into TArqueoCaja values('AC-00008','01/07/2018',100,3547,'U0002')
insert into TArqueoCaja values('AC-00009','24/08/2018',100,3547,'U0001')
insert into TArqueoCaja values('AC-00010','12/09/2018',100,3547,'U0001')
insert into TArqueoCaja values('AC-00011','01/10/2018',100,3547,'U0002')
insert into TArqueoCaja values('AC-00012','12/11/2018',100,3547,'U0001')
insert into TArqueoCaja values('AC-00013','23/11/2018',100,3547,'U0002')
insert into TArqueoCaja values('AC-00014','05/12/2018',100,3547,'U0002')
insert into TArqueoCaja values('AC-00015','31/12/2018',100,3547,'U0001')
