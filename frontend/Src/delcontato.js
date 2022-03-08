
import { lerinfotemporarias, apagarinfotemporarias } from "./session.js";

let nomectt = document.getElementById("Name");
let email = document.getElementById("Mail");
let cel = document.getElementById("Cell");
let tel = document.getElementById("Phone");

// quando a pagina for carregada as informacoes do contato serao mostradas
window.onload = () => {

    // obj que pega as informacoes do localstorage    
    let modelo = lerinfotemporarias();

    // inputs que recebem esses valores que vinheram do localstorage
    nomectt.value = modelo.nome;
    email.value = modelo.email;
    cel.value = modelo.celular;
    tel.value = modelo.fone;
}

let btnExcluir = document.getElementById("Excluir");

// funcao de excluir o contato
btnExcluir.onclick = async () => {

    let modelo = lerinfotemporarias();
    let url = "http://localhost:5000/Contato/del-ctt/" + modelo.id;

    fetch(url,{

        method:'DELETE',
        mode: 'cors'
    });

    swal("O Contato foi deletado!", "", "success");
}

let btnVoltar = document.getElementById("Voltar");

// caso o usuario retorne para a pagina anterior, as informacoes salvas temporiaramente serao excluidas
btnVoltar.onclick = () =>{

    apagarinfotemporarias();
}