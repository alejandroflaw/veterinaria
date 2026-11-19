CREATE DATABASE ControlMED;

USE ControlMED;

CREATE TABLE Sucursales (
    IdSucursal INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Medicamentos (
    IdMedicamento INT AUTO_INCREMENT PRIMARY KEY,
    Nombre VARCHAR(150) NOT NULL
);

CREATE TABLE Inventario (
    IdInventario INT AUTO_INCREMENT PRIMARY KEY,
    IdSucursal INT NOT NULL,
    IdMedicamento INT NOT NULL,
    Existencia INT NOT NULL DEFAULT 0,

    FOREIGN KEY (IdSucursal)
        REFERENCES Sucursales(IdSucursal),

    FOREIGN KEY (IdMedicamento)
        REFERENCES Medicamentos(IdMedicamento),

    UNIQUE (IdSucursal, IdMedicamento)
);