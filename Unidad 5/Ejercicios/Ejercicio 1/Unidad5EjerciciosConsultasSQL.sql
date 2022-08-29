--TEMATICA EJERCICIOS: CONSULTAS SQL
--
--A partir de la base de datos DISCOS_DB te propongo que realices 
--las siguientes consultas SQL a modo de práctica:

--1. Traer todos los discos con su respectivo estilo. La consulta debe mostrar: 
--Nombre de disco, Fecha de lanzamiento, Estilo (no el id, sino la descripción).
select D.Titulo, D.FechaLanzamiento, E.Descripcion From DISCOS D, ESTILOS E
where D.IdEstilo = E.Id

--2. Insertar al menos dos estilos nuevos y un tipo de edición de disco.
--Hecho

--3. Insertar al menos dos discos nuevos cargando correctamente su información.
insert DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa) values ('Pescado Rabioso 2', '1973-13-01', 18, 'https://1.bp.blogspot.com/-m5UfTSYIlDI/XaBX76GD9LI/AAAAAAAANR0/R71Vtmaa4pgsqVoIf2N1-n-VS_NETanJQCLcBGAsYHQ/w1200-h630-p-k-no-nu/pescado-rabioso-2-lp-vinilo-doble-.jpg')
insert DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values ('Apostrophe', '22-03-1974', 9, 'http://1.bp.blogspot.com/_pzGHk_cLqsg/S8T2g2ZrRCI/AAAAAAAAAIk/P1yx4AB_6ro/s1600/Apostrophe-no-text_20080320_121325.jpg', 3, 3)
update DISCOS set Titulo = 'Apostrophe(´)' where id = 11

--4. Actualizar al menos un disco modificando la cantidad de canciones y la 
--fecha de lanzamiento. No te olvides del Where.
update DISCOS set CantidadCanciones = 9 where id = 11
update DISCOS set FechaLanzamiento = '1974-22-03' where id = 11

--5. Borrar un disco a elección.
delete From DISCOS where id = 1

--6. Traer todos los estilos que estén asociados a algún disco.
select E.Descripcion From ESTILOS E, DISCOS D
where D.IdEstilo = E.Id

--7. Traer todos los discos con el siguiente formato:
--Titulo, Estilo, Edición (todo texto).
Select D.Titulo, E.Descripcion, T.Descripcion From DISCOS D, ESTILOS E, TIPOSEDICION T
where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id

--8. Traer todos los discos que contengan en su nombre la sílaba "ho".
select D.Titulo From DISCOS D
where D.Titulo like '%ho%'
