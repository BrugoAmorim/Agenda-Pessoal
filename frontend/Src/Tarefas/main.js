
import { criarObjeto } from "./session.js";
import { salvarTarefa } from './postAndupdate.js';

let id = localStorage.getItem("idcategoria");

let blocoTarefas = document.getElementById("sub-bloco-tarefas");
let btnNvTarefa = document.getElementById("novaTarefa");

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

        salvarTarefa(req, id);
    });

    buscarTarefas(id);
}

async function buscarTarefas(idcategoria){

    let url = "http://localhost:5000/Tarefas/buscar-tarefas/" + idcategoria;

    const chamaapi = await fetch(url, {

        method: 'GET',
        mode: 'cors'
    });

    let res = chamaapi.json();
    res.then(res =>{
        res.map(function(obj){

            let modelo = criarObjeto(obj);
            blocoTarefas.appendChild(modelo.formato);

            modelo.salvar.addEventListener("click", function(){

                window.alert(modelo.informacoes.tarefa.value);
            })

            modelo.excluir.addEventListener("click", function(){

                console.log("seu id é: " + modelo.info.idtarefa);
                console.log(modelo.info.prioridade.value);
            })  
        })
    })
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

    buscarTarefas(id);
}