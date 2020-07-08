create database examen2quiros

USE examen2quiros
create table categoria(
    id int  IDENTITY(1,1) PRIMARY KEY,
    nombre Nvarchar(50) NOT NULL
   
);


create table subCategoria(
    id nvarchar(50) PRIMARY KEY not null,
	idCategoria int , 
	nombre nvarchar(50)
 FOREIGN KEY (idCategoria) REFERENCES categoria(id)
);
drop table figura
create table figura(
id_figura int  IDENTITY(1,1) not null,
nombre_figura varchar (50) not null, 
marca_figura varchar(50) not null, 
imagen varchar (100),
precio float(10),
primary key(id_figura) 
)
drop table figura_categorias
create table figura_categorias(
idfg int identity(1,1) primary key not null,
id_figura int FOREIGN KEY REFERENCES figura(id_figura) not null,
id int FOREIGN KEY REFERENCES categoria(id) not null
)

create procedure insertCategoria (@nombre varchar(30))as begin
begin try
insert categoria (nombre) values (@nombre)
select CONCAT(@nombre,' registrada con exito')
end try
begin catch
select CONCAT('Ya existe la categoria ', @nombre)
end catch
end

create procedure insertSubCategoria (@idCategoria int,@nombre varchar(30), @id nvarchar(50))as begin
begin try
insert subCategoria(id,idCategoria, nombre) values (@id,@idCategoria,@nombre)
select CONCAT(@nombre,' registrada con exito')
end try
begin catch
select CONCAT('Ya existe la categoria ', @nombre)
end catch
end

select* from figura

create procedure sp_listar 
as begin
begin try
select * from categoria
end try
begin catch

end catch
end
create procedure sp_listarFiguras 
as begin
begin try
select * from figura
end try
begin catch

end catch
end
create procedure selectCategoria (@id nvarchar(50)) 
as begin
begin try
select * from categoria where id=@id
end try
begin catch

end catch
end


create procedure editCategoria (@id nvarchar(50), @nombre nvarchar(50)) 
as begin
begin try
UPDATE categoria
SET nombre = @nombre
WHERE id=@id;
end try
begin catch

end catch
end



create procedure eliminarCategoria(@id varchar(50)) 
as begin
begin try
delete from categoria
WHERE id=@id;
end try
begin catch

end catch
end
exec insertFigura 'asd','asd','asd',12
drop procedure insertFigura
create procedure insertFigura (@nombre varchar(30),@marca varchar(30),@imagen varchar(30),@precio float(10))as begin
begin try
insert figura (
nombre_figura , 
marca_figura , 
imagen ,
precio) values (@nombre ,@marca ,@imagen ,@precio)
end try
begin catch
select CONCAT('Ya existe la figura ', @nombre)
end catch
end

drop procedure insertCategoriaFigura

create procedure insertCategoriaFigura (@idCategoria int) as begin


declare @idFigura int
begin try
select @idFigura =@@IDENTITY from figura
insert figura_categorias(id_figura ,id) values (@idFigura ,@idCategoria)

end try
begin catch

end catch
end

create procedure insertCategoriaFigura (@idFigura nvarchar(50), @idCategoria int) as begin
begin try
insert figura_categorias(id_figura ,id) values (@idFigura ,@idCategoria)

end try
begin catch

end catch
end


create procedure ultimoInsert () as begin
begin try
select top 1 *
  from figura
 order by fecha desc

end try
begin catch

end catch
end

select top 1 *
  from tabla
 where nombre_ruta = 'valor_ruta'
 order by fecha desc