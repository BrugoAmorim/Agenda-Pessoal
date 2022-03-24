
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
nm_bloco varchar(50) not null,
ds_conteudo varchar(500),
dt_criacao datetime not null,
dt_atualizado datetime not null
);

create table tb_categoria(
id_categoria int primary key auto_increment,
nm_categoria varchar(100) not null,
ds_categoria varchar(300) not null
);

create table tb_tarefa(
id_tarefa int primary key auto_increment,
ds_tarefa varchar(200) not null,
bl_concluida bool not null,
vl_prioridade int not null,
dt_adicionado datetime not null,
id_categoria int not null,

foreign key (id_categoria) references tb_categoria(id_categoria)
);

select * from tb_categoria;
select * from tb_tarefa;
select * from tb_bloco_nota;
select * from tb_contato;

/* inserções na tabela categoria */
insert into tb_categoria(nm_categoria, ds_categoria)
values("Estudos", "Algumas coisas que seria bom eu estudar, conteudo que preciso rever para a prova e trabalhos escolares");

insert into tb_categoria(nm_categoria, ds_categoria)
values("Mercado", "Lista das compras que farei no mercado este ano.");

/* inserções na tabela tarefa */

/* inserindo registros na tabela tarefa, na categoria Estudos */
insert into tb_tarefa(ds_tarefa, bl_concluida, vl_prioridade, dt_adicionado, id_categoria)
values('Estuda NodeJs', false, 2, '2022-03-10', 1);

insert into tb_tarefa(ds_tarefa, bl_concluida, vl_prioridade, dt_adicionado, id_categoria)
values('Rever a Materia de ingles', false, 1, '2022-02-01', 1);

/* inserindo registros na tabela tarefa, na categoria Mercado */
insert into tb_tarefa(ds_tarefa, bl_concluida, vl_prioridade, dt_adicionado, id_categoria)
values('Compras do Mes: Arroz, feijao, carne, temperos, e verduras', true, 1, '2022-02-01', 2);

insert into tb_tarefa(ds_tarefa, bl_concluida, vl_prioridade, dt_adicionado, id_categoria)
values('Ingredientes Receita do Bolo: ovos, leite, fermento e farinha', false, 4, '2022-01-09', 2);


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
