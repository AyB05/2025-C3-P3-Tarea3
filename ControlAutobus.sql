go
CREATE DATABASE BusControlDB

go
use BusControlDB;

go
create table Choferes (
	ChoferID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    FechaNacimiento DATE,
    Cedula NVARCHAR(20)
)

go
create table Autobuses (
	AutobusID INT PRIMARY KEY IDENTITY(1,1),
    Marca NVARCHAR(50),
    Modelo NVARCHAR(50),
    Placa NVARCHAR(20),
    Color NVARCHAR(20),
    Ano INT
)

go
create table Rutas (
	RutaID INT PRIMARY KEY IDENTITY(1,1),
    NombreRuta NVARCHAR(50)
)

go
CREATE TABLE Asignaciones (
    AsignacionID INT PRIMARY KEY IDENTITY(1,1),
    ChoferID INT,
    AutobusID INT,
    RutaID INT,
    FOREIGN KEY (ChoferID) REFERENCES Choferes(ChoferID),
    FOREIGN KEY (AutobusID) REFERENCES Autobuses(AutobusID),
    FOREIGN KEY (RutaID) REFERENCES Rutas(RutaID),
    CONSTRAINT UC_Asignaciones UNIQUE (ChoferID, AutobusID, RutaID)
)

go
CREATE PROCEDURE sp_AgregarChofer
    @Nombre NVARCHAR(50),
    @Apellido NVARCHAR(50),
    @FechaNacimiento DATE,
    @Cedula NVARCHAR(20)
AS
BEGIN
    INSERT INTO Choferes (Nombre, Apellido, FechaNacimiento, Cedula)
    VALUES (@Nombre, @Apellido, @FechaNacimiento, @Cedula)
END;

go
CREATE PROCEDURE sp_AgregarAutobus
    @Marca NVARCHAR(50),
    @Modelo NVARCHAR(50),
    @Placa NVARCHAR(20),
    @Color NVARCHAR(20),
    @Ano INT
AS
BEGIN
    INSERT INTO Autobuses (Marca, Modelo, Placa, Color, Ano)
    VALUES (@Marca, @Modelo, @Placa, @Color, @Ano)
END;

go
CREATE PROCEDURE sp_AgregarRuta
    @NombreRuta NVARCHAR(50)
AS
BEGIN
    INSERT INTO Rutas (NombreRuta)
    VALUES (@NombreRuta)
END;

go
CREATE PROCEDURE sp_AsignarChoferAutobusRuta
    @ChoferID INT,
    @AutobusID INT,
    @RutaID INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Asignaciones WHERE ChoferID = @ChoferID OR AutobusID = @AutobusID OR RutaID = @RutaID)
    BEGIN
        THROW 50000, 'El chofer, autobus o ruta ya está asignado.', 1;
    END
    ELSE
    BEGIN
        INSERT INTO Asignaciones (ChoferID, AutobusID, RutaID)
        VALUES (@ChoferID, @AutobusID, @RutaID)
    END
END;


