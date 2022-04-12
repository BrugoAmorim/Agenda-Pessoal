# Agenda-Pessoal
Agenda Pessoal, sistema feito para organizar a rotina de seus usuários

Projeto feito para fixar conhecimentos já aprendidos. Neste sistema eu pretendo ir adicionando mais coisas a longo prazo, é pra realmente ser uma agenda pessoal,
aonde o usuário poderá salvar contatos, escrever textos em blocos de notas e criar listas de tarefas. Cada usuário terá sua agenda própria necessitando logar no sistema, isso será adicionado futuramente, enquanto isso vou fazendo uma parte de cada vez.

## Ferramentas Utilizadas:

- Utilizando banco de dados Mysql
- Usando C#/ .Net Core 5 para backend
- Usando HTML5 e CSS3
- Usando Javascript para frontend
- Frameworks frontend: <strong>Bootstrap</strong> e <strong>SweetAlert</strong>

## Home

<strong> Tela inicial -</strong> Aqui o usuário poderá escolher em qual das funcionalidades do sistema ele irá entrar. Pretendo ir adicionando mais coisas ao longo do tempo.

<div align="center" display="flex">
   <img src=https://user-images.githubusercontent.com/87936511/162103493-7b6c4aae-bca3-4c8d-8d9b-5f1d10294651.png />
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

###

<strong> Deletar Bloco de Texto -</strong> Caso o usuário queira excluir o arquivo, basta clicar sobre o botão "Excluir" que uma mensagem aparecerá perguntando se ele
que confirmar está ação, clicando em "Sim" o arquivo sera excluído permanentemente.

<div align="center" display="flex">
   <img src=https://user-images.githubusercontent.com/87936511/159474444-6f538aa1-9aa6-4137-9551-c6665d8b2703.png />
</div>

## Protótipo

Rascunho das telas que terá no sistema de bloco de notas, apenas para terem uma noção de como eu planejo desenvolver está parte do sistema; A versão final pode estar diferente dessa.

<div align="center">
  <img height="700em" width="900em" src=https://user-images.githubusercontent.com/87936511/157888870-1e493a40-34be-4239-8789-e62635366832.png />
</div>

## Parte 3 - Lista de Tarefas

<strong> Tela Categorias -</strong> Nesta tela o usuário pode ver todas as categorias que estão em seu sistema. As categorias funcionam como especies de grupos, aonde cada uma pode conter diferentes tipos de tarefas, como a categoria estudos, ela agruparia todas as coisas que o usuário precisa fazer em relação aos seus estudos.

Está tela também contêm as opções de: adicionar categoria, excluir categorias já existentes, editar as informações e salvá-las clicando sobre o icone de disquete e por fim, você pode ver as tarefas que estão nesse grupo, para isso basta apenas clicar sobre o icone do olho que você será redirecionado para outra página que tem essas informações.

<div align="center">
  <img src=https://user-images.githubusercontent.com/87936511/163066954-0473f52d-38fe-49b6-a7ee-6a4521061f98.png />
</div>

## Editar e Excluir

Quando o usuário preenche todos os campos corretamente e depois salva o arquivo, uma mensagem é retornada. Se o usuário quiser excluir uma categoria, basta apenas clicar sobre o icone de lixeira, um aviso será mostrado perguntando se ele quer continuar, clicando em 'sim' a categoria é excluída junto com suas tarefas.

<div style="flex-direction: row;" display="flex">
  <img height="400em" width="530em" src=https://user-images.githubusercontent.com/87936511/163070291-188525bd-98e1-482e-bdff-4a2658a7346f.PNG />
  <img height="400em" width="470em" src=https://user-images.githubusercontent.com/87936511/163070467-99af5f1b-0764-45f4-ac64-fb50a1676d8a.PNG />
</div>

## Tratamento de Erros

Caso o cliente tente salvar uma nova categoria que não possui nome e nem descrição, um erro é retornado ao usuário. E se ele tentar salvar as alterações de uma categoria já existente sem preencher os campos nome e descrição da categoria, a aplicação manda um erro.

<div style="flex-direction: row;" display="flex">
  <img height="400em" width="500em" src=https://user-images.githubusercontent.com/87936511/163068900-2c5db62e-5efd-4735-b22c-0f980152084d.PNG />
  <img height="400em" width="500em" src=https://user-images.githubusercontent.com/87936511/163069989-01822b64-8a1e-46e4-8df7-0ef2afc39dff.PNG />
</div>

###

<strong> Tela Minhas Tarefas -</strong> Quando o usuário clicar sobre o icone de ver, ele será mandado para está tela, aqui contêm o titulo da categoria, sua descrição e as funcionalidades de consultar, editar, apagar, inserir e filtrar tarefas. Quando o cliente cria uma nova tarefa é possível definir seu nível de prioridade(1 até 5), quanto maior o numero mais importante é a tarefa. Além disso, o sistema conta com um meio de filtragem de tarefas, que filtra pelo nivel de sua prioridade. 

É possível ver que as tarefas contam com uma data que, representa o dia em que essa tarefa foi inserida na categoria, quando o usuário conclui-lá, ele pode marcar a meta como feita atráves do checkbox, caso ele veja que não é mais necessário deixar essa tarefa na lista, ele pode simplesmente exclui-lá e por fim, se ele quiser editar o objetivo, para salvar basta apenas clicar sobre a imagem do disquete

<div align="center">
  <img src=https://user-images.githubusercontent.com/87936511/163066960-4429ff74-c963-4c1f-a191-935639584d5e.png />
</div>

## Protótipo

como eu pretendo desenvolver as telas da parte 3, está funcionalidade tera apenas duas telas e essas telas terão todo o crud do sistema. A parte de categorias refere-se a tipos de tarefas expecificas, seja coisas que eu preciso fazer em casa ou coisas que preciso fazer no trabalho, assim facilita a organização do usuário.

<div align="center">
  <img height="500em" width="990em" src=https://user-images.githubusercontent.com/87936511/159939312-0b840fce-1e5e-4e3c-855c-3b93698557b5.png />
</div>


