CREATE DATABASE GimnasioDB;
GO

USE GimnasioDB;
GO

-- Tabla de Miembros
CREATE TABLE Miembros (
    IDMiembro INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    Telefono NUMERIC,
    Fecha_nacimiento DATE,
    Fecha_Registro DATE DEFAULT GETDATE(),
    Estado_Membresia VARCHAR(20),
    Contrasena VARCHAR(100)
);

-- Tabla de Instructores
CREATE TABLE Instructores (
    IDInstructor INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(50),
    Apellido VARCHAR(50),
    Especialidad VARCHAR(20),
    Horario DATE,
    Estado VARCHAR(20)
);

-- Tabla de Clases
CREATE TABLE Clases (
    IDClase INT IDENTITY(1,1) PRIMARY KEY,
    nombre_clase VARCHAR(50),
    Descripcion VARCHAR(50),
    Duracion_min INT,
    Dificultad VARCHAR(20),
    Capacidad INT
);

