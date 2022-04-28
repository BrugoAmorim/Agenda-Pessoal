
import { apagarInfoUsuario, lerInfoUsuario } from "./session.js";

let nomeUser = document.getElementById("nmUser");
window.onload = () => {

    let infoUser = lerInfoUsuario();
    nomeUser.appendChild(document.createTextNode(infoUser.usuario));
    console.log(infoUser);
}

let btnSair = document.getElementById("btnSair");

btnSair.onclick = () => {

    apagarInfoUsuario();
}
