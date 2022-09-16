create database hotelbd;

use hotelbd;

create table tipo_habitacion
(
	id_tipo_habitacion int identity primary key,
	nombre varchar(30)
); 

create table pais
(
	id_pais int identity primary key,
	nombre varchar(30),
	iva float
);

create table categoria
(
	id_categoria int identity primary key,
	nombre varchar(30),
	estrellas int
);

create table hotel
(
	id_hotel int identity primary key,
	nombre varchar(30),
	direccion varchar(30),
	telefono varchar(30),
	anio_construccion int,
	id_pais int,
	id_categoria int
	constraint pais_fk foreign key(id_pais)
	references pais(id_pais),
	constraint catego_fk foreign key(id_categoria)
	references categoria(id_categoria)
);

create table habitacion
(
	id_habitacion varchar(5) primary key,
	piso int,
	num_puerta int,
	precio_dia float,
	id_tipo_habitacion int,
	id_hotel int,
	constraint tipo_hab_fk foreign key(id_tipo_habitacion)
	references tipo_habitacion(id_tipo_habitacion),
	constraint hotel_fk foreign key(id_hotel)
	references hotel(id_hotel)
);

create table cliente
(
	id_cliente int identity primary key,
	nombre varchar(30),
	direccion varchar(150),
	telefono varchar(15)
);

create table empleado
(
	id_empleado int identity primary key,
	nombre varchar(30),
	direccion varchar(150),
	telefono varchar(15)
);

create table reserva
(
	id_reserva int identity primary key,
	fecha_inicio date,
	fecha_fin date,
	huesped varchar(50),
	total float,
	id_habitacion varchar(5),
	id_cliente int,
	id_empleado int

	constraint habitacion_fk foreign key(id_habitacion)
	references habitacion(id_habitacion),
	constraint cliente_fk foreign key(id_cliente)
	references cliente(id_cliente),
	constraint empleado_fk foreign key(id_empleado)
	references empleado(id_empleado)
);