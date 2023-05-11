CREATE DATABASE bd_biblioteca
GO

USE bd_biblioteca
GO

CREATE TABLE cargos
(
  id INT IDENTITY (1,1),
  nombre VARCHAR(50)
  CONSTRAINT cargos_id_pk PRIMARY KEY (id)
)
GO

CREATE TABLE empleados
(
  id INT IDENTITY (1,1),
  nombre VARCHAR(50),
  apellido varchar(50),
  email VARCHAR(50),
  telefono VARCHAR(50),
  cedula VARCHAR(14),
  cargo_id INT,
  CONSTRAINT empleados_id_pk PRIMARY KEY (id),
  CONSTRAINT empleados_cargo_id_fk FOREIGN KEY (cargo_id) REFERENCES cargos(id)
)
GO

CREATE TABLE usuarios
(
  id INT IDENTITY (1,1),
  usuario VARCHAR(50),
  contrasena VARCHAR(50),
  empleado_id INT
  CONSTRAINT usuarios_id_pk PRIMARY KEY (id),
  CONSTRAINT usuarios_empleados_id_fk FOREIGN KEY (empleado_id) REFERENCES empleados(id)
)
GO

CREATE TABLE autores
(
  id INT IDENTITY (1,1),
  nombre VARCHAR(50)
  CONSTRAINT autores_id_pk PRIMARY KEY (id),
)
GO

CREATE TABLE categorias
(
  id INT IDENTITY (1,1),
  nombre VARCHAR(50)
  CONSTRAINT categoria_id_pk PRIMARY KEY (id),
)
GO

CREATE TABLE libros
(
  id INT IDENTITY (1,1),
  nombre VARCHAR(50),
  paginas INT,
  stock INT,
  categoria_id INT,
  autor_id INT,
  CONSTRAINT libros_id_pk PRIMARY KEY (id),
  CONSTRAINT libros_categoria_id_fk FOREIGN KEY (categoria_id) REFERENCES categorias (id),
  CONSTRAINT libros_autor_id_fk FOREIGN KEY (autor_id) REFERENCES autores (id)
)
GO

CREATE TABLE estudiantes
(
  id INT IDENTITY (1,1),
  nombre VARCHAR(50),
  email VARCHAR(50),
  telefono VARCHAR(8),
  direccion VARCHAR(50)
  CONSTRAINT estudiantes_id_pk PRIMARY KEY (id),
)
GO

CREATE TABLE prestamos (
  id INT IDENTITY (1,1),
  empleado_id INT,
  estudiante_id INT,
  libro_id INT,
  fecha_inicio DATE DEFAULT GETDATE(),
  fecha_fin DATE,
  estado VARCHAR(50) DEFAULT 'PENDIENTE',
  fecha_retorno DATE
  CONSTRAINT prestamos_id_pk PRIMARY KEY (id),
  CONSTRAINT prestamos_estudiante_id_fk FOREIGN KEY (estudiante_id) REFERENCES estudiantes(id),
  CONSTRAINT prestamos_empleado_id_fk FOREIGN KEY (empleado_id) REFERENCES empleados(id),
  CONSTRAINT prestamos_libro_id_fk FOREIGN KEY (libro_id) REFERENCES libros(id)
)
GO

/************************ INSERCIONES ALAS TABLAS ************************/

INSERT INTO cargos (nombre)
VALUES ('Administrador'), ('Bibliotecario')
GO

INSERT INTO empleados (nombre, apellido, email, telefono,cedula, cargo_id)
VALUES ('Camy', 'Hernandez', 'bismarck@gmail.com', '89450099','2812305981002B', 1)
GO

INSERT INTO usuarios (usuario, contrasena, empleado_id)
VALUES ('Camy', '1234', 1)


INSERT INTO autores (nombre)
VALUES ('Brandon Garcia'), ('Franklin Peralta'), ('Jordy Parajon')
GO

INSERT INTO categorias (nombre)
VALUES ('Horror'), ('Drama'), ('Fantasia'), ('Amor'), ('Medicina'), ('Programacion')
GO

INSERT INTO libros (nombre, paginas, stock, categoria_id, autor_id)
VALUES ('Java - Desde Cero', 340, 9, 6,1)
INSERT INTO libros (nombre, paginas, stock, categoria_id, autor_id)
VALUES ('C# - Desde Cero', 280, 8, 6,1)
GO

INSERT INTO estudiantes (nombre, email, telefono, direccion)
VALUES ('Justo Ramon', 'justo200@gmail.com' , '89349988', 'La paz Centro')
INSERT INTO estudiantes (nombre, email, telefono, direccion)
VALUES ('Noe Alexander', 'noe99@gmail.com', '89230099', 'Managua')
GO

INSERT INTO prestamos (empleado_id, estudiante_id, libro_id,fecha_fin, fecha_retorno)
VALUES (1,1,2,'2022-11-25', NULL )
INSERT INTO prestamos (empleado_id, estudiante_id, libro_id,fecha_fin, fecha_retorno)
VALUES (1,2,2,'2022-12-20', NULL )
GO

/***************** VISTAS PRETAMOS Y DETALLE PRESTAMOS *****************/
CREATE VIEW listar_prestamos AS
  SELECT p.id, em.nombre + ' ' + em.apellido as empleado, es.nombre AS estudiante, l.nombre AS  libro,
  p.fecha_inicio,  p.fecha_fin, estado, p.fecha_retorno FROM prestamos AS p
  INNER JOIN empleados AS em ON em.id = p.empleado_id
  INNER JOIN estudiantes AS es ON es.id = p.estudiante_id
  INNER JOIN libros AS l ON l.id = p.libro_id
GO

CREATE VIEW listar_libros AS
  SELECT l.id, l.nombre, l.paginas, l.stock, c.nombre AS categoria,
  u.nombre Autor
  FROM libros AS l
  INNER JOIN categorias AS c ON  c.id = l.categoria_id
  INNER JOIN autores AS u ON u.id = l.autor_id
GO
/***************************** FIN VISTAS *******************************/

/********************** PROCEDIMIENTOS ALMACENADOS **********************/
-----------------------------------------------PROCEDIMIENTOS PARA EMPLEADOS
CREATE PROC sp_empleados
  @op CHAR(1) = NULL,
  @id INT = NULL,
  @nombre VARCHAR(50) = NULL,
  @apellido VARCHAR(50) = NULL,
  @email VARCHAR(50) = NULL,
  @telefono VARCHAR(50) = NULL,
  @cedula VARCHAR(14) = NULL,
  @cargo_id INT = NULL
AS
  BEGIN
    IF (@op = 'L')
      BEGIN
        SELECT em.id, em.nombre, em.apellido, em.email, em.telefono,em.cedula, c.nombre AS cargo
        FROM empleados AS em
        INNER JOIN cargos AS c ON c.id = em.cargo_id
      END
    IF (@op = 'I')
      BEGIN
        INSERT INTO empleados (nombre,apellido, email, telefono,cedula, cargo_id)
        VALUES (@nombre,@apellido, @email, @telefono,@cedula, @cargo_id)
      END
    IF (@op = 'U')
      BEGIN
        UPDATE empleados SET nombre = @nombre, apellido = @apellido, email = @email, telefono = @telefono,cedula = @cedula,
          cargo_id = @cargo_id
        WHERE id = @id
      END
    IF (@op = 'C')
      BEGIN
         SELECT * FROM cargos
      END
   ------------------------------------------BUSCAR
	IF (@op = 'B')
      BEGIN
         SELECT * FROM empleados WHERE id = @id
      END
  END
GO

-----------------------------------------------PROCEDIMIENTOS PARA USUARIOS
CREATE PROC sp_usuarios
  @op VARCHAR(5) = NULL,
  @id INT = NULL,
  @usuario VARCHAR(50) = NULL,
  @contrasena VARCHAR(50) = NULL,
  @empleado_id INT = NULL
AS
  BEGIN
  ------------------------------------------LOGIN
    IF (@op = 'LOGIN')
      BEGIN
        SELECT em.id, em.nombre, em.apellido,c.nombre AS cargo,  em.email
        FROM usuarios AS u
        INNER JOIN empleados AS em ON em.id = u.empleado_id
        INNER JOIN cargos AS c ON c.id = em.cargo_id
        WHERE u.usuario = @usuario AND u.contrasena = @contrasena
      END
    IF (@op = 'L')
      BEGIN
        SELECT id, usuario, contrasena FROM usuarios;
      END
    IF (@op = 'I')
      BEGIN
        INSERT INTO usuarios (usuario, contrasena, empleado_id)
        VALUES (@usuario, @contrasena, @empleado_id)
      END
        IF (@op = 'U')
      BEGIN
        UPDATE usuarios SET usuario = @usuario, contrasena = @contrasena, empleado_id = @empleado_id
        WHERE id = @id
      END
  END
GO

-----------------------------------------------PROCEDIMIENTOS PARA LIBROS
CREATE PROC sp_libros
  @op CHAR(1) = NULL,
  @id INT = NULL ,
  @nombre VARCHAR(50) = NULL,
  @paginas INT = NULL ,
  @stock INT = NULL ,
  @categoria_id INT = NULL ,
  @autor_id INT = NULL
AS
  BEGIN
    IF(@op = 'L')
      BEGIN
        SELECT * FROM listar_Libros;
      END
	IF(@op = 'C')
      BEGIN
        SELECT * FROM categorias;
      END
    IF (@op = 'I')
      BEGIN
        INSERT INTO libros (nombre, paginas, stock, categoria_id, autor_id)
        VALUES (@nombre, @paginas, @stock, @categoria_id, @autor_id)
      END
    IF (@op = 'U')
      BEGIN
        UPDATE libros SET nombre = @nombre, paginas = @paginas, stock = stock + @stock,
        categoria_id = @categoria_id, autor_id = @autor_id
        WHERE id = @id
      END
  END
GO

-----------------------------------------------PROCEDIMIENTOS PARA ESTUDIANTES
CREATE PROC sp_autores
  @op CHAR(1) =  NULL,
  @id INT = NULL ,
  @nombre VARCHAR(50) = NULL
AS
  BEGIN
    IF(@op = 'L')
      BEGIN
        SELECT * FROM autores;
      END
    IF(@op = 'I')
      BEGIN
        INSERT INTO autores(nombre)
        VALUES (@nombre)
      END
    IF(@op = 'U')
      BEGIN
        UPDATE autores SET nombre = @nombre
        WHERE id = @id
      END
  END
GO

-----------------------------------------------PROCEDIMIENTOS PARA ESTUDIANTES
CREATE PROC sp_estudiantes
  @op CHAR(1) =  NULL,
  @id INT = NULL ,
  @nombre VARCHAR(50) = NULL,
  @email VARCHAR(50) = NULL,
  @telefono VARCHAR(8) = NULL,
  @direccion VARCHAR(50) = NULL
AS
  BEGIN
    IF(@op = 'L')
      BEGIN
        SELECT * FROM estudiantes;
      END
    IF(@op = 'I')
      BEGIN
        INSERT INTO estudiantes (nombre, email, telefono, direccion)
        VALUES (@nombre, @email, @telefono, @direccion)
      END
    IF(@op = 'U')
      BEGIN
        UPDATE estudiantes SET nombre = @nombre, email = @email, Telefono = @telefono, direccion = @direccion
        WHERE id = @id
      END
  END
GO

-----------------------------------------------PROCEDIMIENTOS PARA PRESTAMOS
CREATE PROC sp_prestamos
  @op CHAR(1) = NULL,
  @id INT = NULL,
  @empleado_id INT = NULL,
  @estudiante_id INT = NULL,
  @libro_id INT = NULL,
  @fecha_fin DATE = NULL,
  @fecha_retorno DATE = NULL
AS
  BEGIN
    IF(@op = 'L')
      BEGIN
        SELECT * FROM listar_prestamos where estado = 'PENDIENTE';
      END
    IF(@op = 'D')
      BEGIN
        SELECT * FROM listar_prestamos where estado = 'DEVUELTO';
      END
    IF(@op = 'I')
      BEGIN
        INSERT INTO prestamos (empleado_id, estudiante_id, libro_id, fecha_inicio, fecha_fin, fecha_retorno)
        VALUES (@empleado_id, @estudiante_id, @libro_id, convert(DATE, getdate(),103), @fecha_fin, NULL);
      END
    IF(@op = 'U')
      BEGIN
        UPDATE prestamos SET fecha_retorno = @fecha_retorno, estado= 'DEVUELTO'
        WHERE id = @id
      END
  END
GO

-----------------------------------------------SUMARIO DEL SISTEMA
CREATE PROC sp_sumario
@op CHAR(1)
AS
  BEGIN
  --LISTAR CANTIDAD DE LIBROS
      IF (@op = 'L')
        BEGIN
          SELECT count(*) FROM libros
        END
  --LISTAR CANTIDAD DE ESTUDIANTES
      IF (@op = 'T')
        BEGIN
          SELECT count(*) FROM estudiantes
        END
  --LISTAR CANTIDAD DE PRESTAMOS
      IF (@op = 'P')
        BEGIN
          SELECT count(*) FROM prestamos
		  WHERE estado = 'PENDIENTE'
        END
  --LISTAR CANTIDAD DE USUARIOS
      IF (@op = 'U')
        BEGIN
          SELECT count(*) FROM usuarios
        END
    END
GO


/********************** TRIGGERS **********************/

-----------------------------------------------TRIGGER PARA DESCONTRAR STOCK - LIBROS
CREATE TRIGGER tr_descontarLibros
ON prestamos FOR INSERT
AS
  BEGIN
    DECLARE @libro_id INT;
    SET @libro_id = (SELECT libro_id FROM inserted)

    UPDATE libros SET stock = stock - 1
    WHERE id = @libro_id
  END
GO

-----------------------------------------------TRIGGER PARA AUMENTAR STOCK - LIBROS
CREATE TRIGGER tr_aumentarLibros
ON prestamos FOR UPDATE
AS
  BEGIN
    DECLARE @libro_id INT;
    SET @libro_id = (SELECT libro_id FROM inserted)

    UPDATE libros SET stock = (stock + 1)
    WHERE id = @libro_id
  END
GO






