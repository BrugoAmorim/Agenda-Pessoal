
create database agenda;
use agenda;

create table tb_contato(
id_contato int primary key auto_increment,
nm_contato varchar(80) not null,
ds_celular varchar(14),
ds_telefone varchar(9),
ds_email varchar(80),
ds_cidade varchar(50),
ds_estado varchar(50),
ds_notas varchar(80)
);

create table tb_bloco_nota(
id_bloco_nota int primary key auto_increment,
nm_bloco varchar(50),
ds_conteudo varchar(500),
dt_criacao datetime,
dt_atualizado datetime
);

select * from tb_bloco_nota;
select * from tb_contato;

/* inserções na tabela contato */
insert into tb_contato(nm_contato, ds_celular, ds_telefone, ds_email, ds_cidade, ds_estado, ds_notas)
values('Kaio Junior', '11 9999-9999', '1111-2222', 'kkaio@gmail.com', 'sao paulo', 'sao paulo', 'amigo do trabalho');

insert into tb_contato(nm_contato, ds_celular, ds_telefone, ds_email, ds_cidade, ds_estado, ds_notas)
values('Gustavo Ribeiro', '81 9999-9999', '1111-2222', 'gust2022@outlook.com', 'belo horizonte', 'minas gerais', 'colega da facul');

insert into tb_contato(nm_contato, ds_celular, ds_telefone, ds_email, ds_cidade, ds_estado)
values('Plabo Sobral', '11 9999-9999', '1111-2222', 'pablinho@gmail.com', 'guarulhos', 'sao paulo');

insert into tb_contato(nm_contato, ds_celular, ds_telefone, ds_email, ds_cidade, ds_estado, ds_notas)
values('Luana Gomes', '11 9999-9999', '1111-2222', 'lullu@gmail.com', 'sao paulo', 'sao paulo', 'amiga do trabalho');

insert into tb_contato(nm_contato, ds_celular, ds_telefone, ds_email, ds_cidade, ds_estado, ds_notas)
values('Felipe Santos', '11 9999-9999', '1111-2222', 'felps2020@gmail.com', 'Recife', 'pernambuco', 'primo');

insert into tb_contato(nm_contato, ds_celular, ds_telefone, ds_cidade, ds_estado, ds_notas)
values('Victor Hugo', '11 9999-9999', '1111-2222', 'sao paulo', 'sao paulo', 'sobrinho');

/* inserções na tabela bloco de notas */
insert into tb_bloco_nota(nm_bloco, ds_conteudo, dt_criacao, dt_atualizado)
values('lista de compras', 'comprar carne e temperos', '2021-02-10', '2021-04-12');

insert into tb_bloco_nota(nm_bloco, ds_conteudo, dt_criacao, dt_atualizado)
values('trabalhos para fazer', 'trabalho de geo, trabalho de hist e trabalho de pt', '2022-02-08', '2022-02-12');
