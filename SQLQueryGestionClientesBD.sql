
create database GestionClientesBD
go
use GestionClientesBD


create table Clientes
(
Id int primary key,
Nombre nvarchar (100),
Apellido nvarchar (100),
Edad int ,
Sexo nvarchar (10),
Direccion nvarchar (100)
)

insert into Clientes 
values
(1,'Pedro Juan','Torres Bolivar',20,'Masculino','carrera 8a # 42b-74'),
(2,'Antony de jesus','Vanegas Gutierrez',32,'Masculino','carrera 9a # 44b-79'),
(3,'Camila','Cervantes Laguna',20,'Femenino','calle 7a # 43-74'),
(4,'Arturo Andres','Vanegas Florez',21,'Masculino','carrera 10a # 57b-67'),
(5,'Juana Sofhia','Mendez Peres',34,'Femenino','carrera 5a # 56h-43'),
(6,'Jun Camilo','Angarita Pertuz',50,'Masculino','carrera 4a # 7-12'),
(7,'Alexandra','Saez Pacheco',51,'Femenino','carrera 3a # 52b-15'),
(8,'Alverto Mario','Venegas venegas',44,'Masculino','carrera 2a # 72b-10'),
(9,'Jesus Andres','Gonzales Salas',36,'Masculino','carrera 2a # 76b-24'),
(10,'Angely Gissel','Delgado Padron',57,'Femenino','carrera 1a # 67a-16'),
(11,'Sara','Torres Paris',45,'Femenino','carrera 5a # 67b-89')

------todos los clientes registrados 
SELECT * FROM  Clientes


--------Agrupar numero de clientes por sex

SELECT Sexo , count(*) AS Clientes
    FROM Clientes
GROUP BY Sexo


-----Todos los clientes mayores de 20 a�os
SELECT *
    FROM Clientes
WHERE Edad > 20
