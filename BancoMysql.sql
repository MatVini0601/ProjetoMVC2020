create database ProjetoMVCD33;
use ProjetoMVCD33;

create table tbl_clienteD33(
id_cliente int(11) not null,
nome_cliente varchar(45) not null,
sobrenome_cliente varchar(45) not null,
email_cliente varchar(50) not null,
senha_cliente varchar(45) not null,
cpf_cliente varchar(14) not null,
nome_mae varchar(50) not null,
tp_usuario int(1) default null,
primary key(id_cliente)
);
select * from tbl_clienteD33;