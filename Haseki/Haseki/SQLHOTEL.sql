CREATE DATABASE Hotel_Paso 
USE Hotel_Paso
CREATE TABLE Administrador 
(
 Admin_Id VARCHAR(40) PRIMARY KEY, 
 Nombre VARCHAR(40) NOT NULL,
 Clave VARCHAR(40) NOT NULL
)
CREATE TABLE Tipo 
(
Tipo_Id VARCHAR(40) PRIMARY KEY, 
Comodidades VARCHAR(40) NOT NULL,
)
CREATE TABLE Habitacion
(
Numero_Habitacion VARCHAR(40) PRIMARY KEY, 
Tipo_Id VARCHAR(40), 
Disponibilidad BIT NOT NULL,
FOREIGN KEY (Tipo_Id) REFERENCES Tipo(Tipo_Id)
)
CREATE TABLE Cliente 
(
Cliente_Id VARCHAR(40) PRIMARY KEY, 
Nombre VARCHAR(40) NOT NULL, 
Correo VARCHAR(40) NOT NULL, 
Contraseña VARCHAR(40) NOT NULL,
Tarjeta VARCHAR(40)
)
CREATE TABLE Reserva 
(
Reserva_Id VARCHAR(40) PRIMARY KEY, 
Fecha_Inicio VARCHAR(40) NOT NULL,
Fecha_Salida VARCHAR(40),
Cantidad_Ocupantes VARCHAR(40) NOT NULL,
Uso_Estacionamiento BIT NOT NULL,
Numero_Habitacion VARCHAR(40), 
Cliente_Id VARCHAR(40), 
Estado BIT NOT NULL,
Num_Reser_Cli VARCHAR(40) NOT NULL,
FOREIGN KEY (Numero_Habitacion) REFERENCES Habitacion(Numero_Habitacion),
FOREIGN KEY (Cliente_Id) REFERENCES Cliente (Cliente_Id)
)
CREATE TABLE Producto 
(
Producto_Id VARCHAR(40) PRIMARY KEY, 
Descripcion VARCHAR(40) NOT NULL,
Tipo_Producto VARCHAR(40) NOT NULL,
Precio_Producto float NOT NULL
)
CREATE TABLE Factura 
(
Factura_Id VARCHAR(40) PRIMARY KEY,  
Reserva_Id VARCHAR(40), 
FOREIGN KEY (Reserva_Id) REFERENCES Reserva(Reserva_Id)
)
CREATE TABLE Detalle_Factura 
(
Factura_Id VARCHAR(40), 
Producto_Id VARCHAR(40), 
Cantidad_Por_Producto INT NOT NULL,
Precio float NOT NULL,
FOREIGN KEY (Factura_Id) REFERENCES Factura(Factura_Id),
FOREIGN KEY (Producto_Id) REFERENCES Producto(Producto_Id)
)
--SI ESTADO=0 RESERVA ELIMINADA
--SI ESTADO=1 RESERVA LISTA PARA QUE GENERE CONSUMO 
--SI ESTADO=3 RESERVA SOLO MUESTRA FACTURA
INSERT INTO Tipo VALUES 
('1','Plata'),
('2','Oro'),
('3','Diamante'),
('4','DLRR')
INSERT INTO Administrador VALUES 
('1','Esternocleido','1')
INSERT INTO Producto VALUES
('1','COCA-COLA','BEBIDA',3000),
('2','7UP','BEBIDA',4500),
('3','JUMBO','SNACK',6500),
('4','TODITO','SNACK',5500),
('5','AGUA CON GAS','BEBIDA',7000),
('6','DORITOS','SNACK',5300),
('7','NACHOS','SNACK',6000),
('8','LUBRICANTE STAR','SEXUAL',15000),
('9','CONDONES TODAY','SEXUAL',11000),
('10','EASTERN AERO','ACEITE',200000)
SELECT * FROM Administrador
SELECT * FROM Habitacion
SELECT * FROM producto
SELECT * FROM Cliente
SELECT * FROM Reserva
SELECT * FROM Detalle_Factura
SELECT * FROM Factura


