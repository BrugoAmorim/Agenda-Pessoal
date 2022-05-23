# Agenda-Pessoal
Agenda Pessoal, sistema feito para organizar a rotina de seus usuários

Sistema feito para botar meu conhecimento em prática, o site permite com que o usuário organize sua rotina diaria da forma mais eficaz e intuitiva possível, o sistema conta com contas individuais, aonde cada um poderá ter a sua propria agenda, o sistema conta com 3 funcionalidades: Agenda de contatos, Bloco de notas e Lista de Tarefas. Eu pensei nessas três funcionalidades, pois são as que eu mais utilizo(a agenda nem tanto) e portanto eu achei que seria legal eu mesmo criar um sistema que suprisse está minha necessidade.

### Como Utilizar ou Testar?

- Você precisará ter o <em>Mysql</em> instalado em sua máquina - banco de dados utilizado neste sistema. Caso queira, você pode utilizar um script que deixei na pasta <em> Analise-requisitos>Banco-de-Dados </em>, ele contem o registro de dois usuarios cadastrados no banco com registros já inseridos nas outras funcionalidades do sistema

- Será necessario voce ter instalado em sua máquina o <em>.NET Core 5</em> - Framework utilizado na criação de API's, fornecido pela microsoft(em poucas palavras)

- Após ter baixado o projeto em sua máquina, você abrirá a pasta(backend) que possui os arquivos da API, entrará no terminal e digitará "dotnet run", para assim rodar a api.

- Por fim, você pode entrar na pasta que contém as páginas do sistema(frontend), entre na pasta Public>Home e clique no link chamado <em>home</em>, após isso, será aberto uma guia em seu navegador com o sistema já funcionando 

## Usuário

<strong> Home </strong>- A primeira vez que o usuário entrar no sistema, ele verá está tela, aqui ele pode logar no sistema, caso ele seja novo, o mesmo pode criar uma nova conta. Nesta parte o site também fornece uma breve descrição sobre o sistema.

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/169721466-ac2e7b03-3084-4a8f-8aab-df6f22a63f75.png />
</div>

## Menu
Aqui o usuário poderá escolher em qual das funcionalidades do sistema ele irá entrar. O sistema conta com 3 ferramentas que auxiliaram o usuário na organização da sua rotina 

<div align="center" display="flex">
    <video src=https://user-images.githubusercontent.com/87936511/169720461-051aa579-993e-47d7-a0e6-183b47a2ce0d.mp4 height="50%" width="50%" controls></video>
</div>

## Agenda de Contatos

<strong> Ver Contatos </strong>- aqui o usuário pode ver seus contatos salvos e caso queira adicionar mais um, ele faria nesta mesma tela. O sistema não permite que o usuário salve contatos sem antes preencher o campo do nome, este é o único campo que realmente é obrigatório ser preenchido. Junto deste campo temos: um campo para adicionar email, N° telefone, N° celular, estado da onde este contato é, sua cidade e por fim um bloco de notas, que serve para fazer uma breve descrição do contato.

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/169719328-98a863dc-a3dc-49fe-b50b-2f2495e43a90.png />
</div>
  
###
  
<strong>Editar Informações </strong>- aqui é possível ver as informações do contato, se o usuário quiser, o mesmo pode editar os detalhes por aqui, assim como é obrigátorio
preencher o campo de nome para adicionar um contato, aqui também é a mesma coisa, você pode deixar todos os outros campos vazios, menos o nome do contato.

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/169719325-09bd2109-ef25-415c-abc1-7458d3a9f817.png />
</div>

###

<strong>Apagar Contato -</strong> com está tela o usuário tem a opção de apagar o contato desejado, aqui apenas é possivel ver as informações do contato, sem a possibilidade de
alteração, a tela mostra apenas os detalhes que realmente sao relevantes na hora de adicionar um contato, como: nome, email, telefone e celular. 

<div align="center" display="flex">
  <img src=https://user-images.githubusercontent.com/87936511/169719331-6118bdf4-b09b-4291-9882-4236c5cdfc48.png />
</div>

## Bloco de Notas

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

## Lista de Tarefas

<strong> Tela Categorias -</strong> Nesta tela o usuário pode ver todas as categorias que estão em seu sistema. As categorias funcionam como especies de grupos, aonde cada uma pode conter diferentes tipos de tarefas, como a categoria 'Estudos Web', ela agruparia todas as coisas que o usuário precisa fazer em relação aos seus estudos.

Está tela também contêm as opções de: adicionar categoria, excluir categorias já existentes, editar as informações e salvá-las clicando sobre o icone de disquete e por fim, você pode ver as tarefas que estão nesse grupo, para isso basta apenas clicar sobre o icone do olho que você será redirecionado para outra página que tem essas informações.

<div align="center">
  <img src=https://user-images.githubusercontent.com/87936511/164012180-7702b869-8a1b-4939-9e1b-65088d5e7d49.png />
</div>

## Editar e Excluir

Quando o usuário preenche todos os campos corretamente e depois salva o arquivo, uma mensagem é retornada. Se o usuário quiser excluir uma categoria, basta apenas clicar sobre o icone de lixeira, um aviso será mostrado perguntando se ele quer continuar, clicando em 'sim' a categoria é excluída junto com suas tarefas.

<div style="flex-direction: row;" display="flex" align="center">
  <img height="400em" width="530em" src=https://user-images.githubusercontent.com/87936511/163070291-188525bd-98e1-482e-bdff-4a2658a7346f.PNG />
  <img height="400em" width="470em" src=https://user-images.githubusercontent.com/87936511/163070467-99af5f1b-0764-45f4-ac64-fb50a1676d8a.PNG />
</div>

## Tratamento de Erros

Caso o cliente tente salvar uma nova categoria que não possui nome e nem descrição, um erro é retornado ao usuário. E se ele tentar salvar as alterações de uma categoria já existente sem preencher os campos nome e descrição da categoria, a aplicação manda um erro.

<div display="flex" align="center">
  <img height="400em" width="500em" src=https://user-images.githubusercontent.com/87936511/163068900-2c5db62e-5efd-4735-b22c-0f980152084d.PNG />
</div>

###

<strong> Tela Minhas Tarefas -</strong> Quando o usuário clicar sobre o icone de ver, ele será mandado para está tela, aqui contêm o titulo da categoria, sua descrição e as funcionalidades de editar, apagar, inserir e ordenar tarefas. Quando o cliente cria uma nova tarefa é possível definir seu nível de prioridade(1 até 5), quanto maior o numero mais importante é a tarefa. 

É possível ver que as tarefas contam com uma data que, representa o dia em que essa tarefa foi inserida na categoria, quando o usuário conclui-lá, ele pode marcar a meta como feita atráves do checkbox, caso ele veja que não é mais necessário deixar essa tarefa na lista, ele pode simplesmente exclui-lá e por fim, se ele quiser editar o objetivo, para salvar basta apenas clicar sobre a imagem do disquete.

<div align="center">
  <img src=https://user-images.githubusercontent.com/87936511/164012496-99328f42-8a5d-4aaf-a9c7-11ae82dc39a3.png />
</div>

###

Se o usuário tentar salvar uma nova tarefa com um campo vazio, um erro é retornado ao cliente, o mesmo acontece se ele for editar uma tarefa já existente e deixar o campo nulo.

<div align="center">
  <img src=https://user-images.githubusercontent.com/87936511/164013309-aa2f15bd-4730-44d2-a062-3d47de768fe6.PNG />
</div>

## Protótipos:

A <em> Agenda de Contatos </em> possuirá 3 telas, nelas terão todo o crud do sistema; este é um rascunho, então a versão final pode estar diferente dessa.

<div align="center">
  <img height="700em" width="900em" src=https://user-images.githubusercontent.com/87936511/156570187-e43e2921-996f-40e0-99f0-866c426ae089.png />
</div>

##

Funcionalidades do sistema <em> Bloco de Notas </em>, o sistema conta com 3 telas que contem todo o crud do gerenciador, a tela que mostra o contéudo da anotação possibilita o usuário de editar e apagar o texto escrito.

<div align="center">
  <img height="700em" width="900em" src=https://user-images.githubusercontent.com/87936511/157888870-1e493a40-34be-4239-8789-e62635366832.png />
</div>

##

A funcionalidade <em> Lista de Tarefas </em> terá apenas duas telas e essas telas terão todo o crud do sistema. A parte de categorias refere-se a tipos de tarefas expecificas, seja coisas que eu preciso fazer em casa ou coisas que preciso fazer no trabalho, assim facilita a organização do usuário.

<div align="center">
  <img height="500em" width="990em" src=https://user-images.githubusercontent.com/87936511/159939312-0b840fce-1e5e-4e3c-855c-3b93698557b5.png />
</div>

## Estrutura do Banco de Dados:

<div align="center">
  <img height="500em" src=https://user-images.githubusercontent.com/87936511/169720956-cefb9e35-e14d-43ce-9426-c51a141f2712.png />
</div>

## Ferramentas Utilizadas:

- Utilizando banco de dados Mysql
- Usando C#/ .Net Core 5 para backend
- Usando HTML5 e CSS3
- Frameworks frontend: <strong>Bootstrap</strong> e <strong>SweetAlert</strong>
