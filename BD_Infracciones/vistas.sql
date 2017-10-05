USE bd_infracciones;
GO

/*-------------------------- VISTAS -------------------------*/
CREATE VIEW listadoModelos AS
SELECT 
	modelo.id as Id, 
	modelo.nombre AS Modelo, 
	marca.nombre AS Marca
FROM marca 
	INNER JOIN modelo ON marca.id = modelo.marca;

GO

CREATE VIEW listadoAutomoviles AS
SELECT 
	automovil.id AS ID, 
	automovil.patente AS Patente, 
	marca.nombre AS Marca, 
	modelo.nombre AS Modelo
FROM automovil 
	INNER JOIN modelo ON automovil.modelo = modelo.id 
	INNER JOIN marca ON modelo.marca = marca.id;

GO

CREATE VIEW listadoInfracciones AS
SELECT 
	infraccion.id AS ID, 
	policia.nombre AS Policia, 
	policia.rut AS [Rut Policia], 
	automovil.patente AS Patente, 
	marca.nombre AS Marca, 
	modelo.nombre AS Modelo, 
	infraccion.detalle AS Detalle, 
	infraccion.multa AS Multa
FROM infraccion 
	INNER JOIN policia ON infraccion.policia = policia.id 
	INNER JOIN automovil ON infraccion.automovil = automovil.id 
	INNER JOIN modelo ON automovil.modelo = modelo.id 
	INNER JOIN marca ON modelo.marca = marca.id;

GO

CREATE VIEW listadoPolicias AS
SELECT 
	policia.id AS Id, 
	policia.rut AS Rut, 
	policia.nombre AS Nombre, 
	sexo.nombre AS Sexo
FROM 
	policia 
	INNER JOIN sexo ON policia.sexo = sexo.id
/*-------------------------- VISTAS -------------------------*/
GO

SELECT * FROM listadoModelos;
SELECT * FROM listadoAutomoviles;
SELECT * FROM listadoInfracciones;
SELECT * FROM listadoPolicias;