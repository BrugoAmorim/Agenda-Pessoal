
import { carregarListas } from './main.js';
import { salvarCategoria } from './inserirEatualizar.js'

let btnAdicionar = document.getElementById("btnAdicionar");
let conjunto = document.getElementById("Conjunto");

btnAdicionar.onclick = () => {

    while(conjunto.firstChild){
        conjunto.removeChild(conjunto.firstChild);
    }

    window.onload = carregarListas();
    
    let Categoria = IncrementarObjeto();
    conjunto.appendChild(Categoria.formato);

    // metodo que vai permitir salvar novas categorias, a propriedade 'eventoSalvar' existe apenas para novos registro e portanto registros já existentes não conseguem acessar essa propriedade
    Categoria.eventoSalvar.onclick = () => {

        let titulo = Categoria.nome;
        Categoria.nome.value = titulo.value;

        let descricao = Categoria.desc;
        Categoria.desc.value = descricao.value;

        let caixote = salvarCategoria(titulo.value, descricao.value);
        caixote.then(x => {

            if(x.codigo == 400)
                swal("Algo deu errado! 😵", x.mensagem, "error");
            else
                swal("Registro Salvo! 🤩", "A categoria '" + x.categoria + "' já foi salva", "success");
        })

    }
}

export function IncrementarObjeto(param){

    let objeto = document.createElement('div');
    let info = document.createElement('div');
    let titulo = document.createElement('div');
    let desc = document.createElement('div');
    let eventos = document.createElement('div');
    let containereventos = document.createElement('div');

    let inpTitulo = document.createElement('input');
    inpTitulo.classList.add('form-control');
    inpTitulo.placeholder = "Nome da Categoria"

    let txtareaDesc = document.createElement('textarea');
    txtareaDesc.classList.add('form-control');
    txtareaDesc.placeholder = "Eu preciso fazer...";
    
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


    let ComponentesObj = {
        nome: inpTitulo,
        desc: txtareaDesc,
        formato: objeto
    };

    // caso haja algum parametro fornecido, este codigo instaciará atributos ao objeto que contem estes valores
    if(param != undefined){

        ComponentesObj.id = param.idcategoria;
        ComponentesObj.nome.value = param.categoria;
        ComponentesObj.desc.value = param.descricao;
        ComponentesObj.eventoAtualizar = btnSalvar;
    }
    else{
        ComponentesObj.eventoSalvar = btnSalvar;
    }

    return ComponentesObj;
}
