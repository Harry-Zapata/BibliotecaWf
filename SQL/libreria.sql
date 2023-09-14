CREATE Database Libreria
GO

USE Libreria
GO

CREATE TABLE Libros 
(

idlibro varchar(20) NOT NULL,

titulolibro varchar(150) NOT NULL,

editorial varchar(50)NULL,

pais varchar(20) NULL,

año int NULL,

nPag int NULL,

existencia int NOT NULL,

CONSTRAINT PK_MAT_BIBLIO_idlibro PRIMARY KEY (idlibro)

)

GO

CREATE TABLE PRESTAMO
(

codPrestamo int IDENTITY(1,1),

idlibro varchar(20) NOT NULL,

fechaP date NOT NULL,

fechaD date NOT NULL,

CONSTRAINT PK_PRESTAMO_codOper PRIMARY KEY (codPrestamo),

CONSTRAINT FK_PRESTAMO_idlibro FOREIGN KEY (idlibro) REFERENCES Libros(idlibro)

)

GO

CREATE TABLE AUTOR
(

idAutor char(4) NOT NULL,

nomAutor varchar(50)NOT NULL,

CONSTRAINT PK_AUTOR_idAutor PRIMARY KEY(idAutor),

)

GO

CREATE TABLE LIBROS_AUTOR
(

idLibro varchar(20) NOT NULL,

idAutor char(4) NOT NULL,

CONSTRAINT PK__MB_AUTOR_idlibro_idAutor PRIMARY KEY(idlibro,idAutor),

CONSTRAINT FK_MB_AUTOR_idLIBRO FOREIGN KEY(idlibro) REFERENCES Libros(idlibro),

CONSTRAINT FK_MB_AUTOR_idAutor FOREIGN KEY(idAutor) REFERENCES AUTOR(idautor),

)

GO

Insert Into Libros(idlibro,titulolibro,editorial,pais,año,nPag,existencia) Values ('A0001','La Nacion','Comercio','Bolibia','1996','22','5')
Insert Into Libros(idlibro,titulolibro,editorial,pais,año,nPag,existencia) Values ('A0002','Liderasgo','USP','Peru','2010','50','10')
Insert Into Libros(idlibro,titulolibro,editorial,pais,año,nPag,existencia) Values ('A0003','Ciudad de los perros','Navarrete','Peru','1980','101','6')
Insert Into Libros(idlibro,titulolibro,editorial,pais,año,nPag,existencia) Values ('A0004','Macroeconomia','UNT','Argentina','2010','101','5')
Insert Into Libros(idlibro,titulolibro,editorial,pais,año,nPag,existencia) Values ('A0005','Matematicas I','La Republica','Chile','1996','50','5')


Insert Into AUTOR(idAutor,nomAutor) Values ('B001','El Comercio')
Insert Into AUTOR(idAutor,nomAutor) Values ('B002','Hernando Soto')
Insert Into AUTOR(idAutor,nomAutor) Values ('B003','Vargas LLosa')
Insert Into AUTOR(idAutor,nomAutor) Values ('B004','Peru 21')
Insert Into AUTOR(idAutor,nomAutor) Values ('B005','Felipe Calderon')

Insert Into PRESTAMO(idlibro,fechaP,fechaD) Values ('A0003','05/12/2014','05/31/2014')
Insert Into PRESTAMO(idlibro,fechaP,fechaD) Values ('A0001','02/12/2015','03/28/2015')
Insert Into PRESTAMO(idlibro,fechaP,fechaD) Values ('A0004','01/20/2016','02/10/2016')
Insert Into PRESTAMO(idlibro,fechaP,fechaD) Values ('A0002','02/10/2016','02/20/2016')
Insert Into PRESTAMO(idlibro,fechaP,fechaD) Values ('A0005','03/01/2016','03/30/2016')

select * from PRESTAMO

select * from AUTOR

select * from Libros



-- Procedimientos almacenados

-- CREACION DE PROCEDIMIENTO insertar_libros
create procedure inserar_libros

@idlibro varchar(20),
@titulolibro varchar(150),
@editorial varchar(50),
@pais varchar(20),
@año int,
@nPag int,
@existencia int
as
Insert into Libros(idlibro,titulolibro,editorial,pais,año,nPag,existencia)
values(@idlibro,@titulolibro,@editorial,@pais,@año,@nPag,@existencia)
set @idlibro=@@IDENTITY

go

-- CREACION DE PROCEDIMIENTO Actualizar_libros
create procedure Actualizar_libros

@idlibro varchar(20),
@titulolibro varchar(150),
@editorial varchar(50),
@pais varchar(20),
@año int,
@nPag int,
@existencia int
as
update Libros
set
titulolibro=@titulolibro,
editorial=@editorial,
pais=@pais,
año=@año,
nPag=@nPag,
existencia=@existencia
where idlibro = @idlibro

go

-- CREACION DE PROCEDIMIENTO Eliminar_libro
create procedure Eliminar_libro
@idlibro varchar(20)
as 
delete Libros where idlibro = @idlibro

go

-- CREACION DE PROCEDIMIENTO listar_libros
create procedure listar_libros
as
select * from Libros

go

-- CREACION DE PROCEDIMIENTO Consultar_libro_Idlibro
create procedure Consultar_libro_Idlibro
@idlibro varchar(20)
as
select * from Libros where idlibro=@idlibro

go

-- CREACION DE PROCEDIMIENTO llenar_Autor
create procedure llenar_Autor
as
select * from AUTOR

go

-- CREACION DE PROCEDIMIENTO insertarlibro_Autor
create procedure insertarlibro_Autor
@idlibro varchar(20),
@idAutor char(4)
as
Insert into Libros_autor(idlibro,idAutor)
values(@idlibro,@idAutor)

go

-- CREACION DE PROCEDIMIENTO Actualizar_libro_Autor
create procedure Actualizar_libro_Autor
@idlibro varchar(20),
@idAutor char(4)
as
update Libros_autor
set
idAutor=@idAutor
where idlibro=@idlibro

go

-- Verificación de procedimientos almacenados
EXECUTE inserar_libros 'A0010','La Nacion','Comercio','Bolibia','1996','22','5'
EXECUTE Actualizar_libros 'A0001','La Nacion','Comercio','Bolibia','1996','22','5'
EXECUTE Eliminar_libro 'A0001'
EXECUTE listar_libros
EXECUTE Consultar_libro_Idlibro 'A0001'
EXECUTE llenar_Autor