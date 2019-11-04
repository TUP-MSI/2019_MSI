create database festival
use festival


create table dia_festival(
id_dia int identity(1,1),
fecha varchar(50),
hora_inicio varchar(50),
constraint pk_dia_festival primary key clustered (id_dia)
)

create table presentaciones (
id_presentacion int identity (1,1),
id_dia int,
id_artista int,
hora_inicio_aprox varchar(10),
duracion_hs float,
constraint pk_presentaciones primary key clustered (id_presentacion),
constraint fk_artistas_presentaciones foreign key (id_artista) references artistas (id_artista),
constraint fk_dia_presentaciones foreign key (id_dia) references dia_festival (id_dia),
)

create table artistas (
id_artista int identity(1,1),
nombre varchar(50),
integrantes varchar(50),
precio_hora float,
constraint pk_artistas primary key clustered (id_artista)
)

insert into artistas (nombre, integrantes, precio_hora) values ('Lopez',8, 1500)

select * from artistas
select * from dia_festival
select * from presentaciones

delete from artistas
delete from dia_festival 

--consulta para la grilla
select fecha, nombre, hora_inicio_aprox, duracion_hs 
from presentaciones p join artistas a  on p.id_artista = a.id_artista
				join dia_festival d on p.id_dia = d.id_dia
order by d.fecha asc, duracion_hs





