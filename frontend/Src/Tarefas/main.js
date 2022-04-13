
import { criarObjeto } from "./session.js";

let blocoTarefas = document.getElementById("sub-bloco-tarefas");
let btnNvTarefa = document.getElementById("novaTarefa");

btnNvTarefa.onclick = () => {

    while(blocoTarefas.firstChild)
        blocoTarefas.removeChild(blocoTarefas.firstChild);

    let obj = criarObjeto();
    blocoTarefas.appendChild(obj);

    buscarTarefas();
}

async function buscarTarefas(idcategoria){

    let url = "http://localhost:5000/Tarefas/buscar-tarefas/" + 1;

    const chamaapi = await fetch(url, {

        method: 'GET',
        mode: 'cors'
    });

    let res = chamaapi.json();
    res.then(res =>{
        res.map(function(obj){

            let modelo = criarObjeto(obj);
            blocoTarefas.appendChild(modelo);
        })
    })
}

window.onload = buscarTarefas();