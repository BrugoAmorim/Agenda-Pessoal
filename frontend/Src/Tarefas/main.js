
import { criarObjeto } from "./session.js";

let blocoTarefas = document.getElementById("sub-bloco-tarefas");
let btnNvTarefa = document.getElementById("novaTarefa");

btnNvTarefa.onclick = () => {

    while(blocoTarefas.firstChild)
        blocoTarefas.removeChild(blocoTarefas.firstChild);

    let obj = criarObjeto();
    blocoTarefas.appendChild(obj);
}
