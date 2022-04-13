
export let criarObjeto = (param) => {

    // variavel que guarda a div principal, nome 'objeto-tarefa', ela guarda as variaveis 'entradas' e 'expecificacoes' 
    let objetoTarefa = document.createElement('div');
    objetoTarefa.classList.add("objeto-tarefa");

    // div com o nome 'entradas'
    let entradas = document.createElement('div');
    entradas.classList.add("entradas");

    let checkbox = document.createElement('input');
    checkbox.classList.add("form-check-input");
    checkbox.type = "checkbox";

    let textarea = document.createElement('textarea');
    textarea.placeholder = "Eu preciso fazer...";
    textarea.classList.add("form-control");
    textarea.rows = "5";

    // div com o nome 'expecificacoes'
    let expecificacoes = document.createElement('div');
    expecificacoes.classList.add("expecificacoes");

    // div com o nome 'informacoes'
    let informacoes = document.createElement('div');
    informacoes.classList.add("informacoes");

    // div com o nome 'prioridade-salvar'
    let PrioridadeSalvar = document.createElement('div');
    PrioridadeSalvar.classList.add("prioridade-salvar");

    let prioridade = document.createElement('div');
    prioridade.classList.add("prioridade");

    let Nivel = document.createElement('select');
    Nivel.classList.add("form-select");

    // metodo para adicionar os niveis de prioridade na variavel 'Nivel'
    for(let i = 1; i <= 5; i++){

        let opcao = document.createElement('option');
        opcao.appendChild(document.createTextNode(i));
        opcao.value = i;

        Nivel.appendChild(opcao);
    }

    let btnSalvar = document.createElement('button');
    btnSalvar.classList.add("btn-salvar");

    let imgDisquete = document.createElement('img');
    imgDisquete.src = "../../Images/icone-salvar.png";
    imgDisquete.alt = "imagem de disquete";
    imgDisquete.height = "45";

    // div com o nome 'dtcriado-excluir'
    let dtCriadoExcluir = document.createElement('div');
    dtCriadoExcluir.classList.add("dtcriado-excluir");

    let dtCriado = document.createElement('div');
    dtCriado.classList.add("dtcriado");
    dtCriado.appendChild(document.createTextNode("01/01/0001"));

    let Excluir = document.createElement('div');
    Excluir.classList.add("excluir");

    let btnExcluir = document.createElement('button');
    btnExcluir.classList.add("btn-excluir");

    let imgExcluir = document.createElement('img');
    imgExcluir.src = "../../Images/icone-apagar.png";
    imgExcluir.alt = "icone de lixeira";
    imgExcluir.height = "35";

    // tags inserindo tags, começando das mais importantes, até as menos relevantes
    
    objetoTarefa.appendChild(entradas);
    objetoTarefa.appendChild(expecificacoes);

    entradas.appendChild(checkbox);
    entradas.appendChild(textarea);

    expecificacoes.appendChild(informacoes);

    informacoes.appendChild(PrioridadeSalvar);
    informacoes.appendChild(dtCriadoExcluir);
    
    PrioridadeSalvar.appendChild(prioridade);
    PrioridadeSalvar.appendChild(btnSalvar);
    
    prioridade.appendChild(Nivel);
    btnSalvar.appendChild(imgDisquete);

    dtCriadoExcluir.appendChild(dtCriado);
    dtCriadoExcluir.appendChild(Excluir);
    
    Excluir.appendChild(btnExcluir);
    btnExcluir.appendChild(imgExcluir);

    return objetoTarefa;
}
