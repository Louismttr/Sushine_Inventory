--Trigger Actualiza Inventario
create TRIGGER ActualizarInventario
ON DetalleMov
AFTER INSERT
AS
    DECLARE @Cod_Prod CHAR(5), @CantidadDetMov TINYINT, @TipoMov INT;
    SELECT @Cod_Prod = Cod_Prod, 
           @CantidadDetMov = CantidadDetMov, 
           @TipoMov = TipoMov 
    FROM inserted;

    -- Verificar el tipo de movimiento
    IF @TipoMov = 2
    BEGIN
        -- Validar que haya suficiente cantidad en el inventario
        IF EXISTS (SELECT 1 FROM Inventario WHERE Cod_Prod = @Cod_Prod AND Cantidad >= @CantidadDetMov)
        BEGIN
            -- Restar del inventario
            UPDATE Inventario
            SET Cantidad = Cantidad - @CantidadDetMov
            WHERE Cod_Prod = @Cod_Prod;
        END
        ELSE
        BEGIN
            PRINT 'No hay suficiente cantidad en el inventario';
        END
    END
    ELSE IF @TipoMov = 1 
    BEGIN
        -- Sumar al inventario
        UPDATE Inventario
        SET Cantidad = Cantidad + @CantidadDetMov
        WHERE Cod_Prod = @Cod_Prod;
    END

/*METODOS DE CLASES*/	

/*--------------------------------Metodos de Clase Persona---------------------------*/
/*Actualizar Datos Personales*/
--Solo se pueden actualizar o modificar el dato Telefono 
create procedure ActualizarCell
    @Cedula CHAR(13),
    @NuevoCelular CHAR(8)
as
begin
    -- Verificar si la cédula existe en la tabla
    if exists (select 1 from Persona where Cedula = @Cedula)
    begin
        -- Actualizar el celular
        update Persona
        set Celular = @NuevoCelular
        where Cedula = @Cedula;
        print 'Celular actualizado correctamente';
    end
    else
    begin
        print 'La cédula no existe en la tabla';
    end
end


/*Dar de baja a Persona*/
create procedure DarBPersona
@IdPersona char(13)
as
declare @idpr as char(13)
set @idpr=(select Cedula from Persona where
Cedula=@IdPersona)
if(@IdPersona='')
begin
  print 'Ingrese una cedula valida'
end
else
begin
  if(@IdPersona=@idpr)
begin
  update Persona set EstadoPersona=0 where Cedula=@IdPersona
  and EstadoPersona=1
end
else
begin
   print 'Persona no Encontrada'
end
end
--Funcionamiento
exec DarBPersona '318476323314V'
select* from Persona

/*Obtener Información (Nombre Completo)*/
create procedure InfoPersona
@Cedula char(13)
as
begin
if exists (select 1 from Persona where Cedula=@Cedula)
begin
select p.PrimerNombre, p.SegundoNombre, p.PrimerApellido,p.SegundoApellido  from Persona p where Cedula=@Cedula
end
else
begin 
print 'Ingrese un numero de cedula valido'
end
end
--Funcionamiento
exec InfoPersona '123456789123G'
select * from Persona

/*Registrar Persona*/
--validar celular y validar sexo
create procedure InsertarPersona
    @Cedula char(13),
    @PrimerNombre nvarchar(15),
    @SegundoNombre nvarchar(15),
    @PrimerApellido nvarchar(15),
    @SegundoApellido nvarchar(15),
    @Celular char(8),
    @Sexo char(1)
as
begin
-- Verificar si la cédula ya existe
    if exists (select 1 from Persona where Cedula = @Cedula)
    begin
        print 'La cédula ya existe en la tabla.';
        return
    end

    -- Insertar el nuevo registro
    insert into Persona (Cedula, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido, Celular, Sexo)
    values (@Cedula, @PrimerNombre, @SegundoNombre, @PrimerApellido, @SegundoApellido, @Celular, @Sexo);

    print 'Persona insertada correctamente.';
end


/*-----------------------------------Métodos de Clase Empleado---------------------------------------*/

/*Dar de baja Empleado*/
create procedure DarBEmpleado
@IdEmpleado int
as
declare @ide as int
set @ide=(select IdEmpleado from Empleado where
IdEmpleado=@IdEmpleado)
begin
if(@IdEmpleado='')
begin
  print 'Ingrese una id de empleado valido'
end
else
begin
  if(@IdEmpleado=@ide)
begin
  update Empleado set EstadoEmpleado=0 where IdEmpleado=@IdEmpleado
  and EstadoEmpleado=1
end
else
begin
   print 'Empleado no encontrado'
end
end


--Funcionamiento
exec DarBEmpleado '2'
select * from Empleado

/*Modificar Puesto Empleado*/
create procedure ModPuestoE
@IdEm int,
@NuevoPuesto int
as
begin
    -- Verificar si existe el empleado
    if exists (select 1 from Empleado where IdEmpleado = @IdEm)
    begin
        -- Verificar si el nuevo puesto existe y está activo
        if exists (select 1 from Puesto where IdPuesto = @NuevoPuesto and EstadoPues = 1)
        begin
            -- Actualizar puesto
            update Empleado
            set Cod_Puesto = @NuevoPuesto
            where IdEmpleado = @IdEm
            print 'Puesto actualizado correctamente.';
        end
        else
        begin
            print 'El número de puesto ingresado no existe o no está activo.';
        end
    end
    else
    begin
        print 'Id no existe en la tabla.';
    end
end
--Funcionamiento


/*Registrar Empleado*/
--validar puesto siga existiendo o no este de baja
create procedure InsertarEmpleado
    @Cod_Persona char(13),
    @FechaCont date,
    @Cod_Puesto int
as
begin
    if not exists (select 1 from Persona where Cedula = @Cod_Persona and EstadoPersona = 1)
    begin
        print 'La persona no existe o no está activa.';
        return;
    end

    if not exists (select 1 from Puesto where IdPuesto = @Cod_Puesto and EstadoPues = 1)
    begin
        print 'El puesto no existe o no está activo en la tabla Puesto.';
        return;
    end
	
    -- Insertar
    insert into Empleado (FechaCont, Cod_Persona, Cod_Puesto)
    VALUES (@FechaCont, @Cod_Persona, @Cod_Puesto);
    PRINT 'Empleado insertado correctamente';
END

--Funcionamiento

/*--------------------------------Métodos Clase Puesto-----------------------------*/
/*Inserccion de Puesto*/
create procedure InsertarPuesto
    @NombrePuesto nvarchar(25),
    @DescripcionPuesto nvarchar(255)
as
begin
    insert into Puesto (NombrePuesto, DescripcionPuesto)
    values (@NombrePuesto, @DescripcionPuesto);
end
--Funcionamiento


/* Modificar un puesto*/
create procedure ModificarPuesto
    @IdPuesto int,
    @NombrePuesto nvarchar(25),
    @DescripcionPuesto nvarchar(255)
as
begin
if exists (select 1 from Puesto where IdPuesto=@IdPuesto and EstadoPues=1)
begin
    update Puesto
    set NombrePuesto = @NombrePuesto,
        DescripcionPuesto = @DescripcionPuesto
    where IdPuesto = @IdPuesto;
end
else
begin
print 'Ingrese un número de Puesto valido o Puesto dado de baja'
end
end
--Funcionamiento
/*Obtener Detalle Puesto*/
create procedure ObtenerDetallePuesto
    @IdP int
as
begin
if exists (select 1 from Puesto where IdPuesto=@IdP)
begin
    select IdPuesto, NombrePuesto, DescripcionPuesto
    from Puesto
    where IdPuesto = @IdP
end
else
begin
print 'Ingrese un #Puesto Valido'
end
end
--Funcionamiento
exec ObtenerDetallePuesto 10

/*-----------------------------------Metodos Clase Categoria--------------------------*/

/*Insertar Categoria*/
create procedure InsertarCategoria
    @NombreCategoria nvarchar(15),
    @DescripcionCategoria nvarchar(255)
as
begin
    insert into Categoria (NombreCategoria, DescripcionCategoria)
    values (@NombreCategoria, @DescripcionCategoria);
end


/*Modificar Categoria*/
create procedure ModificarCategoria
    @IdC int,
    @NombreCategoria nvarchar(15),
    @DescripcionCategoria nvarchar(255)
as
begin
if exists (select 1 from Categoria where IdCategoria=@IdC AND EstadoCat = 1)
begin
	update Categoria
    set NombreCategoria = @NombreCategoria,
        DescripcionCategoria = @DescripcionCategoria
    where IdCategoria = @IdC
end
else 
begin
print 'Ingrese un #Categoria valido o categoria dada de baja'
end
end
--Funcionamiento

/*Metodo Obtener Detalle Categoria*/
create procedure ObtenerDetalleCategoria
    @IdCategoria int
as
begin
    select IdCategoria, NombreCategoria, DescripcionCategoria
    from Categoria
    where IdCategoria = @IdCategoria;
end
--Funcionamiento

/*-------------------------------Métodos Clase DetMovimiento-----------------------------*/
/*Consultar Movimiento*/
--Procedimiento Ingresando fecha
create procedure ObtenerMovFecha
    @FechaMov datetime
as
begin
    SET NOCOUNT ON;

    select 
        IdDetMov,
        Cod_Prod,
        CodEmpleado,
        TipoMov,
        FechaMov,
        CantidadDetMov
    from 
        DetalleMov
    where 
        cast(FechaMov as date) = cast(@FechaMov as date); 
end
--Funcionamiento
exec ObtenerMovFecha '2024-04-21'


--Procedimiento ingresando IdMovimiento
create procedure ObtenerMovId
    @IdDetMov int
as
begin
    set nocount on;

    select 
        IdDetMov,
        Cod_Prod,
        CodEmpleado,
        TipoMov,
        FechaMov,
        CantidadDetMov
    from 
        DetalleMov
    where 
        IdDetMov = @IdDetMov;
end
--Funcionamiento
exec ObtenerMovId 46
DBCC CHECKIDENT ('DetalleMov', reseed,0)

select* from DetalleMov

/*Eliminar Movimiento*/
create procedure DarBDetalleMov
    @IdDetMov int
as
begin
    if not exists (select 1 from DetalleMov where IdDetMov = @IdDetMov and EstadoMov=1 ) 
    BEGIN
        print 'Ingrese un ID de detalle de movimiento válido o movimiento ya dado de baja';
        return
    END
    update DetalleMov
    set EstadoMov = 0
    where IdDetMov = @IdDetMov;
    print 'Detalle de movimiento dado de baja exitosamente.';
end
--Funcionamiento
exec DarBDetalleMov 46
select* from DetalleMov


/*Modificar Movimiento*/
create procedure ModificarDetalleMov
    @IdDetMov int,
    @Cod_Prod char(5),
    @CodEmpleado int,
    @TipoMov int,
    @FechaMov datetime,
    @CantidadDetMov tinyint
as
begin
    if exists (select 1 from DetalleMov where IdDetMov = @IdDetMov and EstadoMov = 1)
    begin
        -- Verificar si el producto está activo
        if not exists (select 1 from Producto where CodProducto = @Cod_Prod and Estado = 1)
        begin
            print 'El producto no existe o está dado de baja.';
            return;
        end

        -- Verificar si el empleado está activo
        if not exists (select 1 from Empleado where IdEmpleado = @CodEmpleado and EstadoEmpleado = 1)
        begin
            print 'El empleado no existe o está dado de baja.';
            return;
        end

        -- Actualizar el detalle de movimiento
        update DetalleMov
        set 
            Cod_Prod = @Cod_Prod,
            CodEmpleado = @CodEmpleado,
            TipoMov = @TipoMov,
            FechaMov = @FechaMov,
            CantidadDetMov = @CantidadDetMov
        where 
            IdDetMov = @IdDetMov;

        print 'Detalle de movimiento actualizado correctamente.';
    end
    else
    begin
        print 'Registro no existente o dado de baja.';
    end
end
--Funcionamiento

/*Hacer Inserccion en DetalleMov*/
alter PROCEDURE InsertarDetalleMov
    @Cod_Prod char(5),
    @CodEmpleado int,
    @TipoMov int,
    @CantidadDetMov tinyint
AS
begin
    declare @prod as char(5) set @prod = (SELECT CodProducto FROM Producto WHERE CodProducto = @Cod_Prod)
    declare @empleado as int set @empleado = (SELECT IdEmpleado FROM Empleado WHERE IdEmpleado = @CodEmpleado)
    declare @tipo as int set @tipo = (SELECT Id_TipoMov FROM TipoMovimiento WHERE Id_TipoMov = @TipoMov)
	declare @eEstado as bit set @eEstado=(select EstadoEmpleado from Empleado where IdEmpleado=@CodEmpleado)
	declare @ProEstado as bit set @ProEstado=(select Estado from Producto where CodProducto=@Cod_Prod)
    -- Validación del Código de Producto
    IF @Cod_Prod = ''
    BEGIN
        PRINT 'Ingrese un Código de Producto válido';
        RETURN;
    END
    ELSE IF @prod IS NULL
    BEGIN
        PRINT 'El Código de Producto no existe';
        RETURN;
    END
    -- Validación del Código de Empleado
    IF @CodEmpleado IS NULL OR @empleado IS NULL
    BEGIN
        PRINT 'Ingrese un Código de Empleado válido';
        RETURN;
    END
    -- Validación del Tipo de Movimiento
    IF @TipoMov IS NULL OR @tipo IS NULL
    BEGIN
        PRINT 'Ingrese un Tipo de Movimiento válido';
        RETURN;
    END
    -- Validación de la Cantidad
    IF @CantidadDetMov <= 0
    BEGIN
        PRINT 'La cantidad debe ser mayor que cero';
        RETURN;
    END
	if (@eEstado=0)
	begin
	print 'El empleado está dado de baja, ingrese otro'
	return
	end
	if(@ProEstado=0)
	begin
	print'El producto esta dado de baja ingrese otro'
	return
	end
    INSERT INTO DetalleMov (Cod_Prod, CodEmpleado, TipoMov, CantidadDetMov)
    VALUES (@Cod_Prod, @CodEmpleado, @TipoMov, @CantidadDetMov);
end
--Funcionamiento



/*---------------------------Métodos Clase Producto-----------------------------*/
/*Actualizar Estado Producto*/
create procedure ActEstadoProducto
    @CodProducto char(5),
    @Estado bit
as
begin

    update Producto
    set 
        Estado = @Estado
    where 
        CodProducto = @CodProducto;
end
--Funcionamiento
exec ActEstadoProducto '00001',1

/*Dar de baja Producto*/
create procedure DarBProducto
@CodProd char(5)
as
declare @idp as char(5)
set @idp=(select CodProducto from Producto where
CodProducto=@CodProd)
begin
if(@CodProd='')
begin
  print 'Ingrese una codigo de producto valido'
end
else
begin
  if(@CodProd=@idp)
begin
  update Producto set Estado=0 where CodProducto=@CodProd
  and Estado=1
end
else
begin
   print 'Producto no Encontrado'
end
end
end
--Funcionamiento
exec DarBProducto '00001'


/*Modificar Producto*/
alter procedure ModificarPro
    @Codp char(5),
    @CostoU money,
    @PrecioV money,
    @CodCat int
as
begin
    if not exists (select 1 from Producto where CodProducto = @Codp and Estado = 1)
    begin
        print 'El producto no existe o está dado de baja.';
        return;
    end

    if not exists (select 1 from Categoria where IdCategoria = @CodCat and EstadoCat = 1)
    begin
        print 'La categoría no existe o está dada de baja.';
        return;
    end

    -- Actualizar el producto
    update Producto
    set 
        CostoUnitario = @CostoU,
        PrecioVenta = @PrecioV,
        Cod_Categoria = @CodCat
    where 
        CodProducto = @Codp;

    print 'Producto actualizado correctamente.';
end

--Funcionamiento


/*Obtener Detalle de Producto*/
create procedure ObtDetProducto
@CodP char(5)
as
begin
 select 
        CodProducto,
        NombreProducto,
        CostoUnitario,
        PrecioVenta,
        Estado,
        Cod_Categoria
    from 
        Producto
    where 
        CodProducto = @CodP

end 

--Funcionamiento
exec ObtDetProducto '00001'
 
/*Inserccioin Producto*/
create procedure InsertarProducto
    @CodPro char(5),
    @NombreProducto nvarchar(50),
    @CostoUnitario money,
    @PrecioVenta money,
    @Cod_Categoria int
as
begin
    if not exists (select 1 from Categoria where IdCategoria = @Cod_Categoria and EstadoCat = 1)
    begin
        raiserror('La categoría con el código %d no existe o no está activa.', 16, 1, @Cod_Categoria);
        return;
    end

    -- Validar si el producto ya existe
    if EXISTS (select 1 from Producto where CodProducto = @CodPro)
    begin
        raiserror('El producto con el código %s ya existe.', 16, 1, @CodPro);
        return;
    end

    -- Insertar el nuevo producto
    insert into Producto (CodProducto, NombreProducto, CostoUnitario, PrecioVenta, Cod_Categoria)
    values (@CodPro, @NombreProducto, @CostoUnitario, @PrecioVenta, @Cod_Categoria);

    print 'Producto insertado correctamente.';
end

--Funcionamiento

/*----------------------------------------------Métodos clase Inventario---------------------------------*/
/*Consultar Stock de un Producto*/
alter procedure StockPro
    @Cod_Prod char(5)
as
begin
    if not exists (select 1 from Producto where CodProducto = @Cod_Prod and Estado = 1)
    begin
        print ' El producto no existe o esta dado de baja'
        return;
    end
    select 
        P.NombreProducto,
        I.Cod_Prod,
        I.Cantidad
    from 
        Inventario I
    INNER JOIN 
        Producto P on I.Cod_Prod = P.CodProducto
    where 
        I.Cod_Prod = @Cod_Prod;
end

--Funcionamiento

/*Método Insertar Inventario*/
create procedure InsertarInventario
    @Cod_Prod char(5),
    @Cantidad tinyint
as
begin
    if not exists (select 1 from Producto where CodProducto = @Cod_Prod)
    begin
        print 'Producto no está registrado';
        return;
    end

    if exists (select 1 from Inventario where Cod_Prod = @Cod_Prod)
    begin
        print 'El producto ya está registrado en el inventario.';
        return;
    end
    -- Insertar 
    insert into Inventario (Cod_Prod, Cantidad)
    values (@Cod_Prod, @Cantidad);

    print 'Producto insertado en el inventario correctamente.';
end

--Funcionamiento



/*------------------------------------Métodos Clase Usuario---------------------*/

/*Insertar Usuario*/
create procedure InsertarUsuario
    @NombreUsuario nvarchar(15),
    @CorreoElectronico varchar(255),
    @Contraseña varchar(255),
    @RolUsuario nvarchar(15),
    @FechaCreacion date,
    @Cod_Empleado int
as
declare @idem as int set @idem=(select EstadoEmpleado from Empleado where IdEmpleado=@Cod_Empleado)
begin
    if (@idem=0)
	begin
	print 'El empleado está dado de baja, ingrese otro'
	return
	end
    insert into Usuario (NombreUsuario, CorreoElectronico, Contraseña, RolUsuario, FechaCreacion, Cod_Empleado)
    values (@NombreUsuario, @CorreoElectronico, @Contraseña, @RolUsuario, @FechaCreacion, @Cod_Empleado);
end

--Funcionamiento


/*Modificar Usuario*/
create procedure ModificarUsuario
    @IdUsuario int,
    @NuevoNombreUsuario nvarchar(15),
    @NuevoCorreoElectronico varchar(255),
    @NuevaContraseña varchar(255),
    @NuevoRolUsuario nvarchar(15),
	@CodEmpleado int
as
declare @idee as int set @idee=(select EstadoEmpleado from Empleado where IdEmpleado=@CodEmpleado)

begin
    if (@idee=0)
	begin
	print 'El empleado está dado de baja, ingrese otro'
	return
	end

    update Usuario
    set 
        NombreUsuario = @NuevoNombreUsuario,
        CorreoElectronico = @NuevoCorreoElectronico,
        Contraseña = @NuevaContraseña,
        RolUsuario = @NuevoRolUsuario,
		Cod_Empleado =@CodEmpleado
    where IdUsuario = @IdUsuario;

END

--Funcionamiento

/*Eliminar Usuario*/

create procedure DarBUsuario
@IdUsuario int
as
declare @idu as int
set @idu=(select IdUsuario from Usuario where
IdUsuario=@IdUsuario)
begin
if(@IdUsuario='')
begin
  print 'Ingrese una id de usuario valido'
end
else
begin
  if(@IdUsuario=@idu)
begin
  update Usuario set EstadoUsuario =0 where IdUsuario= @IdUsuario
  and EstadoUsuario=1
end
else
begin
   print 'Usuario no encontrado'
end
end
end
--Funcionamiento

--Listar Movimiento
create procedure ListarDetMov
as
select 
    dm.FechaMov as Fecha,
    p.CodProducto as Producto,
    p.CostoUnitario as CostoUnitario,
    p.PrecioVenta as PrecioVenta,
	dm.CantidadDetMov as Cantidad,
	dm.CodEmpleado as Empleado,
    SUM(case when dm.TipoMov = 1 then dm.CantidadDetMov else 0 end) as NumeroEntradas,
    SUM(case when dm.TipoMov = 2 then dm.CantidadDetMov else 0 end) as NumeroSalidas,
	SUM(case when dm.TipoMov = 1 then dm.CantidadDetMov * p.PrecioVenta else 0 end) as TotalEntradas,
    SUM(case when dm.TipoMov = 2 then dm.CantidadDetMov * p.PrecioVenta else 0 end) as TotalSalidas
from 
    DetalleMov dm
JOIN 
    Producto p ON dm.Cod_Prod = p.CodProducto
group by 
 dm.FechaMov, p.CodProducto, p.CostoUnitario, p.PrecioVenta, dm.CantidadDetMov, dm.CodEmpleado
order by 
    dm.FechaMov, p.CodProducto
go

---Listar Producto
create procedure ListarProducto
as
select 
    CodProducto as CodigoProducto,
    NombreProducto as Nombre,
    CostoUnitario as CostoUnitario,
    PrecioVenta as PrecioVenta,
    Estado as Estado,
    Cod_Categoria as CodigoCategoria
from 
    Producto
where
Estado=1
go


--Listar Empleado
create procedure ListarEmpleado
as
select 
    IdEmpleado as IdentificacionEmpleado,
    EstadoEmpleado as Estado,
    FechaCont as FechaContratacion,
    Cod_Persona as CodigoPersona,
    Cod_Puesto as CodigoPuesto
from 
    Empleado
where
EstadoEmpleado=1
go


--Listar categoría
create procedure ListarCategoria
as
SELECT 
    IdCategoria as IdentificacionCategoria,
    NombreCategoria as Nombre,
    DescripcionCategoria as Descripcion,
    EstadoCat as Estado
FROM 
    Categoria
WHERE 
    EstadoCat = 1
	go

--Listar puesto
create procedure ListarPuesto
as
SELECT 
    IdPuesto as IdentificacionPuesto,
    NombrePuesto as Nombre,
    DescripcionPuesto as Descripcion,
    EstadoPues as Estado
FROM 
    Puesto
where
EstadoPues=1
go

--Listar Usuario
create procedure ListarU
as
SELECT 
    IdUsuario as IdentificacionUsuario,
    NombreUsuario as Nombre,
    CorreoElectronico as Correo,
    Contraseña as Contraseña,
    RolUsuario as Rol,
    FechaCreacion as FechaCreacion,
    Cod_Empleado as CodigoEmpleado,
    EstadoUsuario as Estado
FROM 
    Usuario
where
EstadoUsuario=1
go



----
alter PROCEDURE InsertarDetalleMov
    @Cod_Prod char(5),
    @CodEmpleado int,
    @TipoMov int,
    @CantidadDetMov tinyint
AS
begin
    declare @prod as char(5) set @prod = (SELECT CodProducto FROM Producto WHERE CodProducto = @Cod_Prod)
    declare @empleado as int set @empleado = (SELECT IdEmpleado FROM Empleado WHERE IdEmpleado = @CodEmpleado)
    declare @tipo as int set @tipo = (SELECT Id_TipoMov FROM TipoMovimiento WHERE Id_TipoMov = @TipoMov)
	declare @eEstado as bit set @eEstado=(select EstadoEmpleado from Empleado where IdEmpleado=@CodEmpleado)
	declare @ProEstado as bit set @ProEstado=(select Estado from Producto where CodProducto=@Cod_Prod)
    -- Validación del Código de Producto
    IF @Cod_Prod = ''
    BEGIN
        PRINT 'Ingrese un Código de Producto válido';
        RETURN;
    END
    ELSE IF @prod IS NULL
    BEGIN
        PRINT 'El Código de Producto no existe';
        RETURN;
    END
    -- Validación del Código de Empleado
    IF @CodEmpleado IS NULL OR @empleado IS NULL
    BEGIN
        PRINT 'Ingrese un Código de Empleado válido';
        RETURN;
    END
    -- Validación del Tipo de Movimiento
    IF @TipoMov IS NULL OR @tipo IS NULL
    BEGIN
        PRINT 'Ingrese un Tipo de Movimiento válido';
        RETURN;
    END
    -- Validación de la Cantidad
    IF @CantidadDetMov <= 0
    BEGIN
        PRINT 'La cantidad debe ser mayor que cero';
        RETURN;
    END
	if (@eEstado=0)
	begin
	print 'El empleado está dado de baja, ingrese otro'
	return
	end
	if(@ProEstado=0)
	begin
	print'El producto esta dado de baja ingrese otro'
	return
	end
    INSERT INTO DetalleMov (Cod_Prod, CodEmpleado, TipoMov, CantidadDetMov)
    VALUES (@Cod_Prod, @CodEmpleado, @TipoMov, @CantidadDetMov);
end

Exec ListarDetMov
