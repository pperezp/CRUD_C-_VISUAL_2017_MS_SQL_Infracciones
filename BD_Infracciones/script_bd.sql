CREATE DATABASE bd_infracciones;
GO
USE bd_infracciones;
GO

CREATE TABLE sexo(
	id INT IDENTITY(1,1),
	nombre VARCHAR(10),
	PRIMARY KEY(id)
);

INSERT INTO sexo VALUES('Masculino');
INSERT INTO sexo VALUES('Femenino');

CREATE TABLE policia(
	id INT IDENTITY(1,1),
	rut VARCHAR(12),
	nombre VARCHAR(100),
	sexo INT,
	PRIMARY KEY(id),
	FOREIGN KEY(sexo) REFERENCES sexo(id)
);

CREATE TABLE marca(
	id INT IDENTITY(1,1),
	nombre VARCHAR(100),
	PRIMARY KEY(id)
);

INSERT INTO marca VALUES('Nissan'),('Chevrolet');

CREATE TABLE modelo(
	id INT IDENTITY(1,1),
	nombre VARCHAR(100),
	marca INT,
	PRIMARY KEY(id),
	FOREIGN KEY(marca) REFERENCES marca(id)
);

CREATE TABLE automovil(
	id INT IDENTITY(1,1),
	patente VARCHAR(8),
	modelo INT,
	PRIMARY KEY(id),
	FOREIGN KEY(modelo) REFERENCES modelo(id)
);

CREATE TABLE infraccion(
	id INT IDENTITY(1,1),
	policia INT,
	automovil INT,
	detalle VARCHAR(300),
	multa INT,
	PRIMARY KEY(id),
	FOREIGN KEY(policia) REFERENCES policia(id),
	FOREIGN KEY(automovil) REFERENCES automovil(id)
);

SELECT * FROM sexo;
SELECT * FROM policia;
SELECT * FROM marca;
SELECT * FROM modelo;
SELECT * FROM automovil;
SELECT * FROM infraccion;

/*--------- DROP DATABASE ----------*/
USE master;
DROP DATABASE bd_infracciones;
/*--------- DROP DATABASE ----------*/

