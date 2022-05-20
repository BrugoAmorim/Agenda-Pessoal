
import { lerInfoUsuario, deletarConta } from "./session.js";
import { CriaModeloData } from '../BlocoNotas/exportar.js';

let user = document.getElementById("nmUsuario");
let email = document.getElementById("MeuEmail");
let senha = document.getElementById("MinhaSenha");
let dtcriado = document.getElementById("DataCriado");

// obj JSON com as informacoes do usuario
let obj = lerInfoUsuario();

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

// metodo que permite o usuario alterar as informacoes da sua conta
let btnAtualizar = document.getElementById("Atualizarconta");
btnAtualizar.onclick = async () => {

    let url = "http://localhost:5000/Usuarios/editar-conta/" + obj.id + "?email=" + email.value + "&senha=" + senha.value;

    const api = await fetch(url, {

        mode: 'cors',
        method: 'PUT'
    });

    let res = api.json();
    res.then((data) => {
        
        if(data.codigo == 400)
            swal("Algo deu Errado! 😵", data.mensagem, 'error')
        else{
            swal("Informações atualizadas! 🤩", "", 'success');
        }
    })
}

let btnExcluir = document.getElementById("Excluirconta");
btnExcluir.onclick = async () => {

    swal("Excluir conta!", "Voce está prestes a excluir sua conta, todas as informações serão perdidas", 'warning', {
        buttons: {
            cancel: 'Voltar',

            catch: {
                text: 'Continuar',
                value: 'apagar'
            }
        }
    }).then((value) => {

        switch(value){
            case 'apagar':
                deletarConta(obj.id);          
                break;

            default:
                break;
        }
    })    
}

window.onload = () => {

    let myPass = localStorage.getItem('myPass');

    user.appendChild(document.createTextNode(obj.usuario));
    email.value = obj.email;
    senha.value = myPass;

    let modeloDt = CriaModeloData(new Date(obj.criado), "datacompleta");
    dtcriado.appendChild(document.createTextNode(modeloDt));
}
