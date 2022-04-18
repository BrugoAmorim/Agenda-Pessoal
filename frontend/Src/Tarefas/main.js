
import { criarObjeto } from "./session.js";
import { salvarTarefa, atualizarTarefa } from './postAndupdate.js';
import { confirmarExcluimento } from './delete.js';

let idLista = localStorage.getItem("idcategoria");

let blocoTarefas = document.getElementById("sub-bloco-tarefas");
let btnNvTarefa = document.getElementById("novaTarefa");
let selectPrioridade = document.getElementById("Prioridade");

btnNvTarefa.onclick = () => {

    while(blocoTarefas.firstChild)
        blocoTarefas.removeChild(blocoTarefas.firstChild);

    let obj = criarObjeto();
    blocoTarefas.appendChild(obj.formato);

    obj.salvar.addEventListener("click", function(){

        let tarefa = obj.info.tarefa;
        obj.info.tarefa = tarefa.value;

        let nivel = obj.info.prioridade;
        obj.info.prioridade = nivel.value;

        let req = {
            objetivo: tarefa,
            prioridade: nivel
        };

        salvarTarefa(req, idLista);
    });

    buscarTarefas(idLista, selectPrioridade.value);
}

// esta funcionalidade lista as tarefas sem se basear em nada, mandando uma lista na ordem em que foi adicionada as tarefas, das mais antigas para as mais novas
async function buscarTarefas(idcategoria, prioridade){

    let url = "http://localhost:5000/Tarefas/buscar-tarefas/" + idcategoria + "?prioridade=" + prioridade;

    const chamaapi = await fetch(url, {

        method: 'GET',
        mode: 'cors'
    });

    let res = chamaapi.json();
    res.then(res =>{
        res.map(function(obj){

            let modelo = criarObjeto(obj);
            blocoTarefas.appendChild(modelo.formato);

            // quando o usuario for atualizar a sua tarefa, este evento será acionado
            modelo.salvar.addEventListener("click", function(){

                atualizarTarefa(idLista, modelo.info.idtarefa, modelo.info);
            })

            // se o cliente for excluir uma tarefa, este evento será chamado
            modelo.excluir.addEventListener("click", function(){

                confirmarExcluimento(idLista, modelo.info.idtarefa);
            })
        })
    })
}

// Se o select for utilizado ele ordernará as tarefas baseada no seu nivel de prioridade
selectPrioridade.onclick = () => {

    while(blocoTarefas.firstChild)
    blocoTarefas.removeChild(blocoTarefas.firstChild);

    buscarTarefas(idLista, selectPrioridade.value);
}

let btnVoltar = document.getElementById("Voltar");
btnVoltar.onclick = () => {

    localStorage.removeItem("idcategoria");
    localStorage.removeItem("titulo");
    localStorage.removeItem("descricao");

    window.location.href = "../../Pages/Categorias/index.html";
}

window.onload = () => {

    let titulo = localStorage.getItem("titulo");
    let desc = localStorage.getItem("descricao");

    let vlTitulo = document.getElementById('tituloCategoria');
    let vlDesc = document.getElementById("descCategoria");

    vlTitulo.appendChild(document.createTextNode(titulo));
    vlDesc.appendChild(document.createTextNode(desc));

    buscarTarefas(idLista, selectPrioridade.value);
}