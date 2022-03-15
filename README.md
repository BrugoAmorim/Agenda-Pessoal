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
   <img src=https://user-images.githubusercontent.com/87936511/158087147-9ab3efc0-ed40-4334-b30c-24af3a24622c.png />
</div>

## Parte 1 - Agenda de contatos

<strong> Ver Contatos </strong>- aqui o usuário pode ver seus contatos salvos e caso queira adicionar mais um, ele faria nesta mesma tela. O sistema não permite que o usuário salve contatos sem antes preencher o campo do nome, este é o único campo que realmente é obrigatório ser preenchido. Junto deste campo temos: um campo para adicionar email, N° telefone, N° celular, estado da onde este contato é, sua cidade e por fim um bloco de notas, que serve para fazer uma breve descrição do contato.

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/157355935-c7f77c5f-690b-4383-8a71-46a77d34d640.png />
</div>

<strong>Editar Informações </strong>- aqui é possível ver as informações do contato, se o usuário quiser, o mesmo pode editar os detalhes por aqui, assim como é obrigátorio
preencher o campo de nome para adicionar um contato, aqui também é a mesma coisa, você pode deixar todos os outros campos vazios, menos o nome do contato.

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/157355685-5ab8a45f-5835-4ea1-a7c8-b5803aaa159b.png />
</div>

<strong>Apagar Contato -</strong> com está tela o usuário tem a opção de apagar o contato desejado, aqui apenas é possivel ver as informações do contato, sem a possibilidade de
alteração, a tela mostra apenas os detalhes que realmente sao relevantes na hora de adicionar um contato, como: nome, email, telefone e celular. 

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/157355672-8da221e4-3a4c-4105-a95d-f287a0098513.png />
</div>

## Protótipo

Um pequeno rascunho de como eu planejo desenvolver as telas da primeira parte do sistema; A versão final pode estar diferente dessa.

<div align="center">
  <img height="700em" width="900em" src=https://user-images.githubusercontent.com/87936511/156570187-e43e2921-996f-40e0-99f0-866c426ae089.png />
</div>

## Parte 2 - Bloco de notas

<strong> Ver Anotações -</strong> Aqui o usuário pode ver seus textos criados, se quiser, ele pode clicar sobre o botão de excluir, que o mesmo será levado a uma outra tela
para confirmar o excluimento, caso ele queira criar um novo bloco de texto, basta apenas clicar no botão "Novo".

<div align="center" display="flex">
   <img src=https://user-images.githubusercontent.com/87936511/158087153-4f1304cc-35cd-47f8-ba09-8c45968f9d04.png />
</div>

## Protótipo

Rascunho das telas que terá no sistema de bloco de notas, apenas para terem uma noção de como eu planejo desenvolver está parte do sistema; A versão final pode estar diferente dessa.

<div align="center">
  <img height="700em" width="900em" src=https://user-images.githubusercontent.com/87936511/157888870-1e493a40-34be-4239-8789-e62635366832.png />
</div>
