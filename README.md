# Agenda-Pessoal
Agenda Pessoal, sistema feito para organizar a rotina de seus usuários

Projeto feito para fixar conhecimentos já aprendidos. Neste sistema eu pretendo ir adicionando mais coisas a longo prazo, é pra realmente ser uma agenda pessoal,
aonde o usuário poderá salvar contatos, escrever textos em blocos de notas e criar listas de tarefas. Cada usuário terá sua agenda própria necessitando logar no sistema, isso 
será adicionado futuramente, enquanto isso vou fazendo uma parte de cada vez.

## Ferramentas Utilizadas:

- Utilizando banco de dados Mysql
- Usando C#/ .Net Core 5 para backend
- Usando HTML5 e CSS3
- Usando Javascript para frontend
- Frameworks frontend: <strong>Bootstrap</strong> e <strong>SweetAlert</strong>

## Home

<strong> Tela inicial -</strong> Aqui o usuário poderá escolher em qual das funcionalidades do sistema ele irá entrar.

<div align="center" display="flex">
   <img src=https://user-images.githubusercontent.com/87936511/158595026-b3d50beb-4add-41c7-837a-270448259388.png />
</div>

## Parte 1 - Agenda de contatos

<strong> Ver Contatos </strong>- aqui o usuário pode ver seus contatos salvos e caso queira adicionar mais um, ele faria nesta mesma tela. O sistema não permite que o usuário salve contatos sem antes preencher o campo do nome, este é o único campo que realmente é obrigatório ser preenchido. Junto deste campo temos: um campo para adicionar email, N° telefone, N° celular, estado da onde este contato é, sua cidade e por fim um bloco de notas, que serve para fazer uma breve descrição do contato.

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/158595114-8f0d6096-a5f1-4e55-8ab3-1c9d7b7d89c1.png />
</div>
  
###
  
<strong>Editar Informações </strong>- aqui é possível ver as informações do contato, se o usuário quiser, o mesmo pode editar os detalhes por aqui, assim como é obrigátorio
preencher o campo de nome para adicionar um contato, aqui também é a mesma coisa, você pode deixar todos os outros campos vazios, menos o nome do contato.

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/158595040-3fa4c5c1-111d-4dfb-9a06-a5c1f020024e.png />
</div>

###

<strong>Apagar Contato -</strong> com está tela o usuário tem a opção de apagar o contato desejado, aqui apenas é possivel ver as informações do contato, sem a possibilidade de
alteração, a tela mostra apenas os detalhes que realmente sao relevantes na hora de adicionar um contato, como: nome, email, telefone e celular. 

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/158595102-a9071863-1506-499a-a076-16176c8f71bd.png />
</div>

## Protótipo

Um pequeno rascunho de como eu planejo desenvolver as telas da primeira parte do sistema; A versão final pode estar diferente dessa.

<div align="center">
  <img height="700em" width="900em" src=https://user-images.githubusercontent.com/87936511/156570187-e43e2921-996f-40e0-99f0-866c426ae089.png />
</div>

## Parte 2 - Bloco de notas

<strong> Ver Anotações -</strong> Aqui o usuário pode ver seus textos criados, na tela é possível apenas criar um novo registro, se o usuário quiser alterar um arquivo já criado, basta apenas clicar sobre o nome de um, que assim será redirecionado para uma outra tela.

<div align="center" display="flex">
   <img src=https://user-images.githubusercontent.com/87936511/158595116-8ecb02ec-95c7-4ea2-b6b7-85698d1e8698.png />
</div>

###

<strong> Criar Bloco de Texto -</strong> Quando o usuário clicar em "Novo", o mesmo será redirecionado para está tela aonde poderá criar suas anotações, é necessário apenas que o usuário dê um nome para o texto, para assim poder salvá-lo.

<div align="center" display="flex">
   <img src=https://user-images.githubusercontent.com/87936511/158595072-54a32cf7-8fe8-41ef-acd2-6fef9566ff34.png />
</div>

###

<strong> Editar Bloco de Texto -</strong> Quando o usuário clicar sobre um dos registros, ele será redirecionado para está tela, aonde será possível a edição do arquivo, aqui nos é mostrado informações como: o nome do arquivo, o contéudo do arquivo, suas datas de criação e ultima atualização. Apenas é obrigátorio prencher o campo 'nome' para salvar o arquivo.

<div align="center" display="flex">
   <img src=https://user-images.githubusercontent.com/87936511/159139377-deca3bd0-96fa-4a61-b4b1-0aa9d988f4c6.png />
</div>

## Protótipo

Rascunho das telas que terá no sistema de bloco de notas, apenas para terem uma noção de como eu planejo desenvolver está parte do sistema; A versão final pode estar diferente dessa.

<div align="center">
  <img height="700em" width="900em" src=https://user-images.githubusercontent.com/87936511/157888870-1e493a40-34be-4239-8789-e62635366832.png />
</div>
