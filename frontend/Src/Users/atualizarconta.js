
import { lerInfoUsuario } from "./session.js";
import { CriaModeloData } from '../BlocoNotas/exportar.js';

let user = document.getElementById("nmUsuario");
let email = document.getElementById("MeuEmail");
let senha = document.getElementById("MinhaSenha");
let dtcriado = document.getElementById("DataCriado");

window.onload = () => {

    let obj = lerInfoUsuario();
    let myPass = localStorage.getItem('myPass');

    user.appendChild(document.createTextNode(obj.usuario));
    email.value = obj.email;
    senha.value = myPass;

    let modeloDt = CriaModeloData(new Date(obj.criado), "datacompleta");
    dtcriado.appendChild(document.createTextNode(modeloDt));
}

let verSenha = document.getElementById("btnVerSenha");
let contador = 0;
verSenha.onclick = () => {

    if(contador % 2 == 0){
        senha.type = "text";
        contador++
    }
    else if(contador % 2 == 1){
        senha.type = "password";
        contador++
    }
}