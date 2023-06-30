create table Cargo (
	id int primary key identity(1,1) not null,
	descripcion nvarchar(50) not null,
	salario decimal null
)

create table Empresa (
	id int primary key identity(1,1) not null,
	razon_social nvarchar(250) not null,
)

create table Empleado (
	id int primary key identity(1,1) not null,
	nombre nvarchar(50) not null,
	id_empresa int foreign key references Empresa(id) not null,
	id_cargo int foreign key references Cargo(id) not null
)