
import { apagarInfoUsuario, lerInfoUsuario } from "./session.js";

let infoUser = lerInfoUsuario();
let nomeUser = document.getElementById("nmUser");

window.onload = () => {

    nomeUser.appendChild(document.createTextNode(infoUser.usuario));
}

// quando o usuario decidir fazer logoff, esta acao será executada
let btnSair = document.getElementById("btnSair");
btnSair.onclick = () => {

    apagarInfoUsuario();
}

// metodo que valida a identidade do usuario, ele pede que seja informado a senha antes de poder ir para a tela de editar informacoes da conta
import { validarIdentidade } from './session.js';
let conta = document.getElementById("btnconta");

conta.onclick = () => {

    swal("Por questões de segurança, insira a sua senha para continuar",
        {
            content: 'input'
        }
    ).then((value) => {
        validarIdentidade(infoUser.id, value);
    })
}
