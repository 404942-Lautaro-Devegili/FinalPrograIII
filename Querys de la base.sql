--create database finalprogiii;
use finalprogiii;

select * from Configuraciones;
select * from Provincias;
select * from Sucursales;
update sucursales
set FechaAlta = '2024-01-02'
where Ciudad = 'Saltisima2221';
--Provincia--
ID - Provincia
AD82B082-EB91-4FBB-8218-6FCFAC0F91EF	Buenos Aires
B9D686F4-4CD2-4382-BDD6-A39803FC31B3	Salta
39720254-CA8E-4AAF-A70C-B445850E8C23	Córdoba
--Tipo Sucursal--
ID - Nombre
F861C32F-8264-483C-B63A-40433BAA55DE	Pequeña
19154042-35AB-4533-8B3B-7D02F69721E4	Grande
insert into Sucursales (Id, Nombre, Ciudad, IdTipo, IdProvincia, Telefono, NombreTitular, ApellidoTitular, FechaAlta)
VALUES
(NEWID(),
'Sucursal Cordoba Capital',
'Cordoba Capital',
'19154042-35AB-4533-8B3B-7D02F69721E4',
'39720254-CA8E-4AAF-A70C-B445850E8C23',
'3517776423',
'Juanito',
'Perez',
'2024-01-01')

INSERT INTO Sucursales (Id, Nombre, Ciudad, IdTipo, IdProvincia, Telefono, NombreTitular, ApellidoTitular, FechaAlta)
VALUES
(NEWID(), 'Sucursal Buenos Aires Centro', 'Buenos Aires', 'F861C32F-8264-483C-B63A-40433BAA55DE', 'AD82B082-EB91-4FBB-8218-6FCFAC0F91EF', '0112345678', 'Carlos', 'Gomez', '2024-07-01'),

(NEWID(), 'Sucursal Salta Capital', 'Salta', 'F861C32F-8264-483C-B63A-40433BAA55DE', 'B9D686F4-4CD2-4382-BDD6-A39803FC31B3', '0387456789', 'Ana', 'Martinez', '2024-07-02'),

(NEWID(), 'Sucursal Córdoba Centro', 'Córdoba Capital', '19154042-35AB-4533-8B3B-7D02F69721E4', '39720254-CA8E-4AAF-A70C-B445850E8C23', '0351456789', 'Luis', 'Fernandez', '2024-07-03'),

(NEWID(), 'Sucursal Buenos Aires Norte', 'San Fernando', 'F861C32F-8264-483C-B63A-40433BAA55DE', 'AD82B082-EB91-4FBB-8218-6FCFAC0F91EF', '0118765432', 'Sofia', 'Lopez', '2024-07-04'),

(NEWID(), 'Sucursal Salta Norte', 'Salta', '19154042-35AB-4533-8B3B-7D02F69721E4', 'B9D686F4-4CD2-4382-BDD6-A39803FC31B3', '0387654321', 'Pedro', 'Ramirez', '2024-07-05'),

(NEWID(), 'Sucursal Córdoba Sur', 'Río Cuarto', 'F861C32F-8264-483C-B63A-40433BAA55DE', '39720254-CA8E-4AAF-A70C-B445850E8C23', '0358456789', 'Laura', 'Mendoza', '2024-07-06')
delete sucursales;