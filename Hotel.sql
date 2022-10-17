use master;
create database DBHotel;
go

create table tblLogin(
	usuario varchar(50) primary key not null,
	contrasenia varchar(50) not null
);
go
--drop table login
create table tblReserva(
	nombrePersona varchar(100),
	numeroAdulto int,
	numeroNinios int
)
go
create procedure Inicio_sesion
@prUsuario varchar(50), 
@prContrasenia  varchar(50)
AS
BEGIN
	if exists (select usuario from tblLogin where tblLogin.usuario = @prUsuario and tblLogin.contrasenia = @prContrasenia) 
	begin 
		select 1 as Resp
	return 
end
	else 
	begin 
		select 0 as Resp
	return 
end
END
GO

--insert into tblLogin values ('mossas','12345')
exec Inicio_sesion mosssas, 12345
