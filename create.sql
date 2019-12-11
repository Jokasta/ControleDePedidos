use master

create database jokasta_bd

use jokasta_bd

create table andamento_pedido(
	id int identity(1,1) not null,
	descricao varchar(100) not null,
	constraint pk_andamento_pedido primary key(id)
)

insert into andamento_pedido values('Andamento')
insert into andamento_pedido values('Pronto')
insert into andamento_pedido values('Entregue')
insert into andamento_pedido values('Cancelado')

create table pedidos(
	id int identity(1,1) not null,
	mesa int not null,
	nomeCliente varchar(200) not null,
	comida varchar(200) not null,
	qtd_comida int not null,
	bebida varchar(200) not null,
	qtd_bebida int not null,
	[status] int not null,
	constraint fk_andamento_pedido_andamento_pedido foreign key([status]) references andamento_pedido(id)
)
