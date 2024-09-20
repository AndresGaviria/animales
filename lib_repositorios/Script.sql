CREATE DATABASE db_animales
Go
USE db_animales
GO

CREATE TABLE Mascotas
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Fecha] SMALLDATETIME NOT NULL,
	[Activo] BIT
);
GO

CREATE TABLE Propietarios
(
	[Id] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Nombre] NVARCHAR(50) NOT NULL,
	[Animal] INT REFERENCES [Mascotas] ([Id]),
	[Activo] BIT
);
GO

INSERT INTO [Mascotas] ([Nombre],[Fecha],[Activo])
VALUES ('Lorito lepe', GETDATE(), 1);
INSERT INTO [Mascotas] ([Nombre],[Fecha],[Activo])
VALUES ('Perrita luna', GETDATE(), 0);

SELECT * FROM [Mascotas];

INSERT INTO [Propietarios] ([Nombre],[Animal],[Activo])
VALUES ('Pepito perez', 1, 1);

SELECT * 
FROM [Propietarios] P 
	INNER JOIN [Mascotas] M ON P.Animal = M.Id;

