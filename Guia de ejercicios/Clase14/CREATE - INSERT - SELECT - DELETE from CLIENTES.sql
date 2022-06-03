
--Agregar un registro de un cliente
INSERT INTO DBO.CLIENTES (NOMBRE, DIRECCION) VALUES
/*Primer corrida('Jorge', 'Calle Falsa 123'),*//*Segunda Corrida('Camila','Calle False 123'),('Nicolas','Mitre 123')*/
/*Tercer Corrida*/('Maria','Sarmiento 1234'), ('Juan','Independencia 750')

--Leer el nombre de un cliente
SELECT NOMBRE
FROM DBO.CLIENTES

--Leer todos los datos de un cliente
SELECT *
FROM DBO.CLIENTES

--Leer todas las columnas de un cliente por id

SELECT *
FROM DBO.CLIENTES
WHERE 1=1
AND ID = 1
OR ID = 2

--Modificar un cliente por el id
UPDATE CLIENTES SET NOMBRE = 'Jorge' WHERE ID = 1

UPDATE CLIENTES SET NOMBRE = 'Jorge' where NOMBRE = 'jorge'

--Eliminar por ID
DELETE FROM CLIENTES
WHERE CLIENTES.ID IN (2,3)

--Eliminar LIKE
DELETE FROM CLIENTES
WHERE CLIENTES.NOMBRE LIKE ('%o%')

--Eliminar LIKE
DELETE FROM CLIENTES
WHERE CLIENTES.NOMBRE LIKE ('_a%')


