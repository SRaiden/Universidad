
create database Universidad
go

Use Universidad
go

Create table Tutor
(
	Cod_Tutor varchar(50) Primary key not null,
	Nombre varchar(50) NULL,
	Apellido varchar(50) NULL,
	DNI varchar(50) NULL,
	Direccion varchar(50) NULL,
	Localidad varchar(50) NULL,
	Cod_Postal varchar(50) NULL,
	Telefono varchar(50) NULL,
	Fecha_Nac smalldatetime NULL,
	Pais varchar(50) NULL
)

create table Horarios
(
	Cod_Horario varchar(50) Primary Key NOT NULL,
	Horario varchar(50) NULL,
	Turno varchar(50) NULL,
	Dia varchar(50) NULL
)

--drop table Horarios

create table Empleados
(
	Cod_Empleado varchar(50) Primary Key NOT NULL,
	Nombre varchar(50) NULL,
	Apellido varchar(50) NULL,
	Telefono varchar(50) NULL,
	DNI varchar(50) NULL,
	Direccion varchar(50) NULL,
	Localidad varchar(50) NULL,
	[C.P] varchar(50) NULL,
	pais varchar(50) NULL,
	Fecha_Nac smalldatetime NULL,
	Ocupacion varchar(50) NULL
)

--drop table Empleados

create table Profesores
(
	Legajo varchar(50) Primary Key NOT NULL,
	Nombre varchar(50) NULL,
	Apellido varchar(50) NULL,
	Telefono varchar(50) NULL,
	DNI varchar(50) NULL,
	Direccion varchar(50) NULL,
	Localidad varchar(50) NULL,
	Cod_Postal varchar(50) NULL,
	Pais varchar(50) NULL,
	Fecha_Nac varchar(50) NULL
)

create table Aulas
(
	Cod_Aula varchar(50) Primary Key NOT NULL,
	Computadoras bit NULL,
	Capacidad varchar(50) NULL
)

--drop table Alumnos

create table Carrera
(
	Cod_Carrera varchar(50) primary key NOT NULL,
	Nombre varchar(50) NULL ,
)

create table Alumnos
(
	Legajo varchar(50) NOT NULL,
	Nombre varchar(50) NOT NULL,
	Apellido varchar(50) NOT NULL,
	Telefono varchar(50) NULL,
	DNI varchar(50) Primary key NOT NULL,
	Direccion varchar(50) NOT NULL,
	Localidad varchar(50) NOT NULL,
	Cod_Postal varchar(50) NULL,
	Pais varchar(50) NULL,
	Fecha_Nac smalldatetime NOT NULL,
	Especialidad varchar(50) NOT NULL,
	Lugar varchar(50) NULL,
	Egresado varchar(50) NOT NULL,
	Tutor varchar(50) NULL,
	Cuatrimestre varchar(50) NULL,
	constraint FK_Alumnos foreign key(Tutor) references Tutor (Cod_Tutor)
)

create table Directivos
(
	Cod_Directivo varchar(50) primary key NOT NULL,
	Nombre varchar(50) NULL,
	Apellido varchar(50) NULL,
	Cargo varchar(50) NULL,
	Telefono varchar(50) NULL,
	DNI varchar(50) NULL,
	Direccion varchar(50) NULL,
	Localidad varchar(50) NULL,
	[C.P] varchar(50) NULL,
	Fecha_Nac smalldatetime NULL,
	Pais varchar(50) NULL,
	Cod_Carrera varchar(50) NULL,
	constraint FK_Directivos foreign key(Cod_Carrera) references Carrera (Cod_Carrera)
)

create table Materia
(
	Cod_Materia varchar(50) primary key NOT NULL,
	nombre varchar(50) NULL ,
	Cod_especialidad varchar(50) NOT NULL,
	constraint FK_Materia foreign key (Cod_especialidad) references Carrera (Cod_Carrera),
)

create table ProfxMat
(
	Legajo varchar(50) NOT NULL,
	Cod_Materia varchar(50) NOT NULL,
	constraint PK_ProfxMat primary key(Legajo,Cod_Materia),
	constraint FK_ProfxMat foreign key (Legajo) references Profesores (Legajo),
	constraint FK_ProfxMat2 foreign key (Cod_Materia) references Materia (Cod_Materia)
)

create table HorxMat
(
	Cod_hor varchar(50) NOT NULL,
	cod_mat varchar(50) NOT NULL,
	cod_aula varchar(50) NOT NULL,
	constraint PK_HorxMat primary key(Cod_hor,cod_mat),
	constraint FK_HorxMat foreign key(Cod_hor) references Horarios (Cod_Horario),
	constraint FK_HorxMat2 foreign key(cod_mat) References Materia (Cod_Materia),
	constraint FK_HorxMat3 foreign key(cod_aula) references Aulas (Cod_Aula)
)

create table AlumxMat
(
	DNI_Alumno varchar(50) NOT NULL,
	Cod_Materia varchar(50) NOT NULL,
	Cuatrimestre varchar(50) NOT NULL,
	constraint PK_AlumxMat primary key(DNI_Alumno,Cod_Materia),
	constraint FK_AlumxMat foreign key(DNI_Alumno) references Alumnos (DNI),
	constraint FK_AlumxMat2 foreign key(Cod_Materia) references Materia (Cod_Materia)
)

INSERT INTO Tutor (Cod_Tutor,Nombre,Apellido,DNI,Direccion,Localidad,Cod_Postal,Telefono,Fecha_Nac,Pais) 
values (103,'Pedro', 'Picapiedra',39784526,'Sarmiento 456','San Miguel',1668,02320458756,'17-02-1990','Argentina') 
INSERT INTO Tutor (Cod_Tutor,Nombre,Apellido,DNI,Direccion,Localidad,Cod_Postal,Telefono,Fecha_Nac,Pais) 
values (104,'Francisco','Guzman',39856458,'Paternal 456','Pacheco',1668,111526459978,'12-4-1985','Argentina')
INSERT INTO Tutor (Cod_Tutor,Nombre,Apellido,DNI,Direccion,Localidad,Cod_Postal,Telefono,Fecha_Nac,Pais) 
values (105,'Natanael','Gomez',39478567,'Bruguetti 250','Jose C Paz',1665,11153993670,'21-9-1989','Argentina')

Insert into Profesores(Legajo,Apellido,Cod_Postal,Direccion,DNI,Fecha_Nac,Localidad,Nombre,Pais,Telefono)
values (103,'Picapiedra',1668,'Sarmiento 456',39784526,'15-07-1991','San Miguel','Pedro','Argentina',02320458756)
Insert into Profesores(Legajo,Apellido,Cod_Postal,Direccion,DNI,Fecha_Nac,Localidad,Nombre,Pais,Telefono)
values (104,'Guzman',1668,'Paternal 456',39856458,'31-12-1990','Pacheco','Francisco','Argentina',111526459978)
Insert into Profesores(Legajo,Apellido,Cod_Postal,Direccion,DNI,Fecha_Nac,Localidad,Nombre,Pais,Telefono)
values (105,'Gomez',1665,'Bruguetti 250',39478567,'15-05-1996','Jose C. Paz','Natanael','Argentina',11153993670)
Insert into Profesores(Legajo,Apellido,Cod_Postal,Direccion,DNI,Fecha_Nac,Localidad,Nombre,Pais,Telefono)
values (115,'Sanchez',1665,'Peron 452',39740786,'17-04-1998','Jose C. Paz','Juan','Argentina',111547892563)
Insert into Profesores(Legajo,Apellido,Cod_Postal,Direccion,DNI,Fecha_Nac,Localidad,Nombre,Pais,Telefono)
values (120,'Gimenez',1542,'Valparaiso 478',39452126,'01-01-1990','Valparaiso','German','Chile',111547258963)

INSERT INTO Alumnos(Legajo,Nombre,Apellido,Telefono,DNI,Direccion,Localidad,Cod_Postal,Pais,Fecha_Nac,Especialidad,Lugar,Egresado,Tutor,Cuatrimestre)
values (001,'pablo','gomez',02320145689,39856789,'Hola 123','Jose C Paz',1665,'Argentina','15-7-1996','TSP','Casa','IEES',103,1)
INSERT INTO Alumnos(Legajo,Nombre,Apellido,Telefono,DNI,Direccion,Localidad,Cod_Postal,Pais,Fecha_Nac,Especialidad,Lugar,Egresado,Tutor,Cuatrimestre)
values (002,'Javier','Perez',111548775986,39754126,'Alvear 154','Pacheco',4562,'Argentina','21-8-1996','TSSI','Casa','Escuela Nº54',103,2)
INSERT INTO Alumnos(Legajo,Nombre,Apellido,Telefono,DNI,Direccion,Localidad,Cod_Postal,Pais,Fecha_Nac,Especialidad,Lugar,Egresado,Tutor,Cuatrimestre)
values (003,'lucas','Guzman',0232045125,39856256,'Bolivar 147','Grand Bourg',4578,'Argentina','15-1-1996','Automovilismo','Departamento','Escuela San Martin',103,3)
INSERT INTO Alumnos(Legajo,Nombre,Apellido,Telefono,DNI,Direccion,Localidad,Cod_Postal,Pais,Fecha_Nac,Especialidad,Lugar,Egresado,Tutor,Cuatrimestre)
values (004,'Franco','Salinas',0232045126,39856425,'San Martin 785','Pilar',1256,'Argentina','4-3-1996','Diseñador Grafico','Departamento','IEES',103,4)
INSERT INTO Alumnos(Legajo,Nombre,Apellido,Telefono,DNI,Direccion,Localidad,Cod_Postal,Pais,Fecha_Nac,Especialidad,Lugar,Egresado,Tutor,Cuatrimestre)
values (005,'Agustin','Zordan',111568445920,39784125,'Martinez 458','Jose C Paz',1258,'Argentina','15-2-1996','Educacion Fisica','Casa','IEES',104,5)

INSERT INTO	Aulas(Cod_Aula,Computadoras,Capacidad)
values (201,1,52)
INSERT INTO	Aulas(Cod_Aula,Computadoras,Capacidad)
values (202,0,50)
INSERT INTO	Aulas(Cod_Aula,Computadoras,Capacidad)
values (203,0,40)
INSERT INTO	Aulas(Cod_Aula,Computadoras,Capacidad)
values (204,0,42)
INSERT INTO	Aulas(Cod_Aula,Computadoras,Capacidad)
values (205,1,25)

INSERT INTO Horarios(Cod_Horario,Horario,Turno,Dia)
values (1,'8:00-10:00','Mañana','Lunes')
INSERT INTO Horarios(Cod_Horario,Horario,Turno,Dia)
values (2,'10:00-12:00','Mañana','Martes')
INSERT INTO Horarios(Cod_Horario,Horario,Turno,Dia)
values (3,'20:00-22:00','Noche','Miercoles')
INSERT INTO Horarios(Cod_Horario,Horario,Turno,Dia)
values (4,'18:00-20:00','Noche','Jueves')
INSERT INTO Horarios(Cod_Horario,Horario,Turno,Dia)
values (5,'8:00-9:00','Mañana','Viernes')


INSERT INTO Carrera(Cod_Carrera,Nombre)
values (1,'TSP')
INSERT INTO Carrera(Cod_Carrera,Nombre)
values (2,'Diseñador Grafico')
INSERT INTO Carrera(Cod_Carrera,Nombre)
values (3,'TSSI')
INSERT INTO Carrera(Cod_Carrera,Nombre)
values (4,'Automovilismo')
INSERT INTO Carrera(Cod_Carrera,Nombre)
values (5,'Educacion Fisica')


INSERT INTO Materia(Cod_Materia,Cod_especialidad,nombre)
values (1,1,'Matematica')
INSERT INTO Materia(Cod_Materia,Cod_especialidad,nombre)
values (2,5,'Anatomia')
INSERT INTO Materia(Cod_Materia,Cod_especialidad,nombre)
values (3,3,'Programacion')
INSERT INTO Materia(Cod_Materia,Cod_especialidad,nombre)
values (4,2,'Photoshop')
INSERT INTO Materia(Cod_Materia,Cod_especialidad,nombre)
values (5,4,'Armado')

INSERT INTO HorxMat(cod_hor,cod_mat,Cod_aula)
values (1,3,201)
INSERT INTO HorxMat(cod_hor,cod_mat,Cod_aula)
values (2,1,201)
INSERT INTO HorxMat(cod_hor,cod_mat,Cod_aula)
values (3,5,203)
INSERT INTO HorxMat(cod_hor,cod_mat,Cod_aula)
values (4,1,204)
INSERT INTO HorxMat(cod_hor,cod_mat,Cod_aula)
values (5,4,205)
INSERT INTO HorxMat(cod_hor,cod_mat,Cod_aula)
values (3,2,202)

INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(1,39784125,1)
INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(2,39784125,2)
INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(3,39784125,3)
INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(4,39784125,4)
INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(5,39784125,5)
INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(1,39856256,1)
INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(2,39856256,3)
INSERT INTO AlumxMat(Cod_Materia,DNI_Alumno,Cuatrimestre)
values(3,39856256,5)

INSERT INTO Empleados(Cod_Empleado, Nombre, Apellido, DNI, Direccion, Localidad,[C.P],pais, Telefono, Fecha_Nac , Ocupacion)
values(1,'Roberto','Chavez',39153657,'Italia 478','Tigre',1648,'Argentina',47448985,'15-12-1960','LavaPlatos')
INSERT INTO Empleados(Cod_Empleado, Nombre, Apellido, DNI, Direccion, Localidad,[C.P],pais, Telefono, Fecha_Nac , Ocupacion)
values(2,'Carlos','Perez',38125469,'Constitucion 1457','San Fernardo',1876,'Argentina',47152375,'02-4-1976','Mantenimiento')
INSERT INTO Empleados(Cod_Empleado, Nombre, Apellido, DNI, Direccion, Localidad,[C.P],pais, Telefono, Fecha_Nac , Ocupacion)
values(3,'Federico','Arias',38456187,'Ituzaingo 14782','San Fernardo',1845,'Argentina',47152386,'15-4-1959','Limpieza')
INSERT INTO Empleados(Cod_Empleado, Nombre, Apellido, DNI, Direccion, Localidad,[C.P],pais, Telefono, Fecha_Nac , Ocupacion)
values(4,'Erik','Ariel',37456982,'Neuquen 414','Tigre',1436,'Argentina',47125698,'27-2-1990','Secretaria')
INSERT INTO Empleados(Cod_Empleado, Nombre, Apellido, DNI, Direccion, Localidad,[C.P],pais, Telefono, Fecha_Nac , Ocupacion)
values(5,'Luciana','Pereyro',39412657,'Libertador 10368','San Isidro',2046,'Argentina',49126478,'29-11-1984','Enfermeria')

INSERT INTO Directivos(Cod_Directivo,Nombre,Apellido,DNI,Direccion,Localidad,Telefono,[C.P],Fecha_Nac,Cargo,Pais,Cod_Carrera)
values(1,'Eugenio Bruno','Ricciolini',37456741,'Bernardo 1687','Quilmes',47126537,5236,'17-5-1948','Decano','Argentina',1)
INSERT INTO Directivos(Cod_Directivo,Nombre,Apellido,DNI,Direccion,Localidad,Telefono,[C.P],Fecha_Nac,Cargo,Pais,Cod_Carrera)
values(2,'Maria Dolores','Gomez',38451211,'Urquiza 1414','Tigre',47146398,4781,'2-12-1975','Directora','Argentina',2)
INSERT INTO Directivos(Cod_Directivo,Nombre,Apellido,DNI,Direccion,Localidad,Telefono,[C.P],Fecha_Nac,Cargo,Pais,Cod_Carrera)
values(3,'Juan Alfonso','Fructuoso',38745126,'Cordero 1978','San Fernardo',47152244,1256,'14-10-1984','Ingeniero','Argentina',3)
INSERT INTO Directivos(Cod_Directivo,Nombre,Apellido,DNI,Direccion,Localidad,Telefono,[C.P],Fecha_Nac,Cargo,Pais,Cod_Carrera)
values(4,'Angeles','Piedad',37452611,'Limba 788','Tigre',47253314,1245,'9-8-1979','Directora de Administracion','Argentina',4)
INSERT INTO Directivos(Cod_Directivo,Nombre,Apellido,DNI,Direccion,Localidad,Telefono,[C.P],Fecha_Nac,Cargo,Pais,Cod_Carrera)
values(5,'Marcelo','Canzian',38456714,'Tortugas 1456','Ciudad de Tortugas',47236578,1546,'12-10-1971','Secretario de ciencias y tegnologia','Argentina',5)

INSERT INTO ProfxMat(Legajo,Cod_Materia)
values(103,1)
INSERT INTO ProfxMat(Legajo,Cod_Materia)
values(103,2)
INSERT INTO ProfxMat(Legajo,Cod_Materia)
values(103,3)
INSERT INTO ProfxMat(Legajo,Cod_Materia)
values(104,1)
INSERT INTO ProfxMat(Legajo,Cod_Materia)
values(104,4)
INSERT INTO ProfxMat(Legajo,Cod_Materia)
values(105,5)
INSERT INTO ProfxMat(Legajo,Cod_Materia)
values(105,3)

-- DIRECTIVOS POR CARRERA
--select Directivos.Nombre, Directivos.Apellido, Directivos.Cargo, Directivos.NombreCarrera from Directivos inner join DirxCarr on DirxCarr.Cod_Directivo=Directivos.Cod_Directivo
--inner join Carrera on Carrera.Cod_Carrera=DirxCarr.Cod_Carrera where Carrera.Nombre='TSP'