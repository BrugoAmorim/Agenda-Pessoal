
export function retornarObjeto(param){

    let objeto = document.createElement('div');
    let info = document.createElement('div');
    let titulo = document.createElement('div');
    let desc = document.createElement('div');
    let eventos = document.createElement('div');
    let containereventos = document.createElement('div');

    let inpTitulo = document.createElement('input');
    inpTitulo.classList.add('form-control');
    inpTitulo.value = param.categoria;

    let txtareaDesc = document.createElement('textarea');
    txtareaDesc.classList.add('form-control');
    txtareaDesc.value = param.descricao;

    let btnVer = document.createElement('button');
    let btnSalvar = document.createElement('button');
    let btnApagar = document.createElement('button');

    let imgVer = document.createElement('img');
    let imgSalvar = document.createElement('img');
    let imgApagar = document.createElement('img');

    // imagem da lixeira, com tamanho de 35em
    imgApagar.src = "../../Images/icone-apagar.png";
    imgApagar.alt = "possivel imagem de uma lixeira";
    imgApagar.height = '35';
    // o botao apagar inseri a img lixeira dentro de seu escopo
    btnApagar.appendChild(imgApagar);
    btnApagar.classList.add('evento-apagar');

    // imagem de salvar, com tamanho de 35em
    imgSalvar.src = "../../Images/icone-salvar.png";
    imgSalvar.alt = "imagem de um disquete";
    imgSalvar.height = '35';
    // o botao salvar inseri esta imagem dentro de seu escopo
    btnSalvar.appendChild(imgSalvar);
    btnSalvar.classList.add('evento-salvar');

    // o container pega esses dois eventos e os inseri dentro de seu escopo
    containereventos.appendChild(btnSalvar);
    containereventos.appendChild(btnApagar);
    containereventos.classList.add('container-eventos');

    // icone ver, com o tamaho de 35em
    imgVer.src = "../../Images/icone-ver.png";
    imgVer.alt = "possivelmente uma imagem de um olho";
    imgVer.height = '35';
    // o botao ver, inseri dentro de seu escopo o icone ver
    btnVer.appendChild(imgVer);
    btnVer.classList.add('evento-ver');

    // div que contem todos os eventos do objeto
    eventos.appendChild(btnVer);
    eventos.appendChild(containereventos);
    eventos.classList.add('eventos');

    // div titulo inseri o input de 'nome da categoria'
    titulo.appendChild(inpTitulo);
    titulo.classList.add('titulo-categoria');
    // div descricao inseri o textarea, responsavel pela descricao da categoria
    desc.appendChild(txtareaDesc);
    desc.classList.add('desc-categoria');

    // a classe informacoes inseri as 3 divs que contem as expecificacoes da lista de tarefas
    info.appendChild(titulo);
    info.appendChild(desc);
    info.appendChild(eventos);
    info.classList.add('informacoes');

    // por fim o objeto que inseri a div que contem todas as informacoes
    objeto.appendChild(info);
    objeto.classList.add('objeto');

    return objeto;
}