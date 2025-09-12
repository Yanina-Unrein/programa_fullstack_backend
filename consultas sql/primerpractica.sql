ALTER TABLE dbo.Cuentas 
ADD Nombre VARCHAR(50);

ALTER TABLE dbo.Cuentas 
ALTER COLUMN Nombre VARCHAR(70);

ALTER TABLE dbo.Transacciones 
ADD DescripcionMotivo VARCHAR(100) NOT NULL;

ALTER TABLE dbo.Transacciones
DROP COLUMN DescripcionMotivo;

INSERT INTO dbo.Cuentas (Descripcion, Saldo, Nombre)
VALUES 
('Cuenta Corriente', 1500.00, 'Juan Pérez'),
('Caja de Ahorro', 2500.50, 'María Gómez'),
('Inversiones', 10000.75, 'Juan Perez');

UPDATE Cuentas
SET Descripcion = 'Cuenta Corriente Personal'
WHERE ID = 1;


DELETE FROM Cuentas
WHERE ID = 3;

SELECT * FROM Cuentas;

