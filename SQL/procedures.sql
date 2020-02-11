
Use Universidad
go

Create procedure AgregarAlumno
(
	@Legajo varchar(50),
	@nombre varchar(50),
	@apellido varchar(50),
	@telefono varchar(50),
	@DNI varchar(50),
	@direccion varchar(50),
	@localidad varchar(50),
	@cp varchar(50),
	@pais varchar(50),
	@fecha smalldatetime,
	@especialidad varchar(50),
	@lugar varchar(50),
	@egresado varchar(50),
	@tutor varchar(50),
	@Cuatrimestre varchar(50)
) 
	AS
	insert into Alumnos
(
	Legajo,
	Nombre,
	Apellido,
	Telefono,
	DNI,
	Direccion,
	Localidad,
	Cod_Postal,
	Pais,
	Fecha_Nac,
	Especialidad,
	Lugar,
	Egresado,
	Tutor,
	Cuatrimestre	
)
	values 
(
	@Legajo,
	@nombre,
	@apellido,
	@telefono,
	@DNI,
	@direccion,
	@localidad,
	@cp,
	@pais,
	@fecha,
	@especialidad,
	@lugar,
	@egresado,
	@tutor,
	@Cuatrimestre
)
go
	
CREATE PROCEDURE AgregarAula
(
	@CodAula varchar(50),
	@Computadoras bit,
	@Capacidad varchar(50)
)
AS
insert into Aulas(
	Cod_Aula,
	Computadoras,
	Capacidad
)
values(
	@CodAula,
	@Computadoras,
	@Capacidad
)
go

CREATE PROCEDURE AgregarCarrera
(
@CodCarrera varchar(50),
@Nombre varchar(50)
)
AS
insert into Carrera(
Cod_Carrera,
Nombre
)
values(
@CodCarrera,
@Nombre
)
go

CREATE PROCEDURE AgregarDirectivo
(
@CodDirectivo varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Cargo varchar(50),
@Telefono varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@CP varchar(50),
@fecha smalldatetime,
@Pais varchar(50),
@CodCarrera varchar(50)
)
AS
insert into Directivos(
Cod_Directivo,
Nombre,
Apellido,
Cargo,
Telefono,
DNI,
Direccion,
Localidad,
[C.P],
Fecha_Nac,
Pais,
Cod_Carrera
)
values(
@CodDirectivo,
@Nombre,
@Apellido,
@Cargo,
@Telefono,
@DNI,
@Direccion,
@Localidad,
@CP,
@fecha,
@Pais,
@CodCarrera
)
go

CREATE PROCEDURE AgregarEmpleado
(
@CodEmpleado varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@CP varchar(50),
@pais varchar(50),
@fecha smalldatetime,
@Ocupacion varchar(50)
)
AS
insert into Empleados(
Cod_Empleado,
Nombre,
Apellido,
Telefono,
DNI,
Direccion,
Localidad,
[C.P],
pais,
Fecha_Nac,
Ocupacion
)
values(
@CodEmpleado,
@Nombre,
@Apellido,
@Telefono,
@DNI,
@Direccion,
@Localidad,
@CP,
@pais,
@fecha,
@Ocupacion
)
go

CREATE PROCEDURE AgregarHorario
(
@CodHorario varchar(50),
@Horario varchar(50),
@Turno varchar(50),
@Dia varchar(50)
)
AS
insert into Horarios(
Cod_Horario,
Horario,
Turno,
Dia
)
values(
@CodHorario,
@Horario,
@Turno,
@Dia
)
go

CREATE PROCEDURE AgregarMateria
(
@CodMateria varchar(50),
@Nombre varchar(50),
@CodEspecialidad varchar(50)
)
AS
Insert into Materia(
Cod_Materia,
nombre,
Cod_especialidad
)
values(
@CodMateria,
@Nombre,
@CodEspecialidad
)
go

CREATE PROCEDURE AgregarProfesor
(
@Legajo varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@CP varchar(50),
@Pais varchar(50),
@Fecha smalldatetime
)
AS
insert into Profesores(
Legajo,
Nombre,
Apellido,
Telefono,
DNI,
Direccion,
Localidad,
Cod_Postal,
Pais,
Fecha_Nac
)
values(
@Legajo,
@Nombre,
@Apellido,
@Telefono,
@DNI,
@Direccion,
@Localidad,
@CP,
@Pais,
@Fecha
)
go

CREATE PROCEDURE AgregarTutor
(
@CodTutor varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@cp varchar(50),
@telefono varchar(50),
@fecha smalldatetime,
@pais varchar(50)
)
AS
Insert into Tutor
(
Cod_Tutor,
Nombre,
Apellido,
DNI,
Direccion,
Localidad,
Cod_Postal,
Telefono,
Fecha_Nac,
Pais
)
values
(
@CodTutor,
@Nombre ,
@Apellido, 
@DNI ,
@Direccion, 
@Localidad ,
@cp ,
@telefono, 
@fecha ,
@pais 
)
go

CREATE procedure EliminarAlumno2
(
@DNI varchar(50)
) 
AS
DELETE FROM Alumnos  WHERE DNI=@DNI	
go

CREATE PROCEDURE EliminarAula
(
@CodAula varchar(50)
)
AS
delete from Aulas where Cod_Aula=@CodAula
go

CREATE PROCEDURE EliminarCarrera
(
@CodCarrera varchar(50)
)
AS
delete from Carrera where Cod_Carrera=@CodCarrera
go

CREATE PROCEDURE EliminarDirectivo
(
@CodDirectivo varchar(50)
)
AS
Delete from Directivos where Cod_Directivo=@CodDirectivo
go

CREATE PROCEDURE EliminarEmpleado
(
@CodEmpleado varchar(50)
)
AS
delete from Empleados where Cod_Empleado=@CodEmpleado
go

CREATE PROCEDURE EliminarHorario
(
@CodHorario varchar(50)
)
AS
delete from Horarios where Cod_Horario=@CodHorario
go

CREATE PROCEDURE EliminarMateria
(
@CodMateria varchar(50)
)
AS
delete from Materia where Cod_Materia=@CodMateria
go

CREATE PROCEDURE EliminarProfesor
(
@Legajo varchar(50)
)
as
delete from Profesores where Legajo=@Legajo
go

CREATE PROCEDURE EliminarTutor
(
@CodTutor varchar(50)
)
AS
DELETE from Tutor where Cod_Tutor = @CodTutor
go

CREATE PROCEDURE ModificarAlumnos
(
	@Legajo varchar(50),
	@nombre varchar(50),
	@apellido varchar(50),
	@telefono varchar(50),
	@DNI varchar(50),
	@direccion varchar(50),
	@localidad varchar(50),
	@cp varchar(50),
	@pais varchar(50),
	@fecha smalldatetime,
	@especialidad varchar(50),
	@lugar varchar(50),
	@egresado varchar(50),
	@tutor varchar(50),
	@Cuatrimestre varchar(50)
)
AS
UPDATE Alumnos
SET
Legajo=@Legajo,
Nombre=@nombre,
Apellido=@apellido,
Telefono=@telefono,
DNI=@DNI,
Direccion=@direccion,
Localidad=@localidad,
Cod_Postal=@cp,
Pais=@pais,
Fecha_Nac=@fecha,
Especialidad=@especialidad,
Lugar=@lugar,
Egresado=@egresado,
Tutor=@tutor,
Cuatrimestre=@Cuatrimestre
where
DNI=@DNI
go

CREATE PROCEDURE ModificarAula
(
@CodAula varchar(50),
@Computadoras bit,
@Capacidad varchar(50)
)
AS
update Aulas
set
Cod_Aula=@CodAula,
Computadoras=@Computadoras,
Capacidad=@Capacidad
where
Cod_Aula = @CodAula
go

CREATE PROCEDURE ModificarCarrera
(
@CodCarrera varchar(50),
@Nombre varchar(50)
)
AS
update Carrera
set
Cod_Carrera=@CodCarrera,
Nombre=@Nombre
where
Cod_Carrera = @CodCarrera
go

CREATE PROCEDURE ModificarDirectivo
(
@CodDirectivo varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Cargo varchar(50),
@Telefono varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@CP varchar(50),
@fecha smalldatetime,
@Pais varchar(50),
@CodCarrera varchar(50)
)
AS
update Directivos
set
Cod_Directivo=@CodDirectivo,
Nombre=@Nombre,
Apellido=@Apellido,
Cargo=@Cargo,
Telefono=@Telefono,
DNI=@DNI,
Direccion=@Direccion,
Localidad=@Localidad,
[C.P]=@CP,
Fecha_Nac=@fecha,
Pais=@Pais,
Cod_Carrera=@CodCarrera
where
Cod_Directivo=@CodDirectivo
go

CREATE PROCEDURE ModificarEmpleado
(
@CodEmpleado varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@CP varchar(50),
@pais varchar(50),
@fecha smalldatetime,
@Ocupacion varchar(50)
)
AS
Update Empleados
set
Cod_Empleado=@CodEmpleado,
Nombre=@Nombre,
Apellido=@Apellido,
Telefono=@Telefono,
DNI=@DNI,
Direccion=@Direccion,
Localidad=@Localidad,
[C.P]=@CP,
pais=@pais,
Fecha_Nac=@fecha,
Ocupacion=@Ocupacion
where
Cod_Empleado=@CodEmpleado
go

CREATE PROCEDURE ModificarHorario
(
@CodHorario varchar(50),
@Horario varchar(50),
@Turno varchar(50),
@Dia varchar(50)
)
AS
update Horarios
set
Cod_Horario=@CodHorario,
Horario=@Horario,
Turno=@Turno,
Dia=@Dia
where
Cod_Horario=@CodHorario
go

CREATE PROCEDURE ModificarMateria
(
@CodMateria varchar(50),
@Nombre varchar(50),
@CodEspecialidad varchar(50)
)
AS
Update Materia
set
Cod_Materia=@CodMateria,
nombre=@Nombre,
Cod_especialidad=@CodEspecialidad
where
Cod_Materia=@CodMateria
go

CREATE PROCEDURE ModificarProfesor
(
@Legajo varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@Telefono varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@CP varchar(50),
@Pais varchar(50),
@Fecha smalldatetime
)
AS
update Profesores
set
Legajo=@Legajo,
Nombre=@Nombre,
Apellido=@Apellido,
Telefono=@Telefono,
DNI=@DNI,
Direccion=@Direccion,
Localidad=@Localidad,
Cod_Postal=@CP,
Pais=@Pais,
Fecha_Nac=@Fecha
where
Legajo=@Legajo
go

CREATE PROCEDURE ModificarTutor
(
@CodTutor varchar(50),
@Nombre varchar(50),
@Apellido varchar(50),
@DNI varchar(50),
@Direccion varchar(50),
@Localidad varchar(50),
@cp varchar(50),
@telefono varchar(50),
@fecha smalldatetime,
@pais varchar(50)
)
AS
UPDATE Tutor
set
Cod_Tutor=@CodTutor,
Nombre=@Nombre,
Apellido=@Apellido,
DNI=@DNI,
Direccion=@Direccion,
Localidad=@Localidad,
Cod_Postal=@cp,
Telefono=@telefono,
Fecha_Nac=@fecha,
Pais=@pais
where
Cod_Tutor=@CodTutor
go

create procedure AsignarProfesor
(
@Legajo varchar(50),
@Cod_Materia varchar(50)
)
AS
insert into ProfxMat
(
Legajo,
Cod_Materia
)
values
(
@Legajo,
@Cod_Materia 
)
go

create procedure AsignarAlumno
(
@DNI varchar(50),
@Cod_Materia varchar(50),
@Cuatrimestre varchar(50)
)
AS
insert into AlumxMat
(
DNI_Alumno,
Cod_Materia,
Cuatrimestre
)
values
(
@DNI,
@Cod_Materia,
@Cuatrimestre
)
go

/*create procedure AsignarCarrera
(
@Cod_Directivo varchar(50),
@Cod_Carrera varchar(50)
)
AS
insert into DirxCarr
(
Cod_Directivo,
Cod_Carrera
)
values
(
@Cod_Directivo,
@Cod_Carrera 
)
go*/
