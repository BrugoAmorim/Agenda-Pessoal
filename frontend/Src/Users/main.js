
import { infoUsuario } from './session.js';

let btnEntrar = document.getElementById("Entrar");
let inpUser = document.getElementById("User");
let inpSenha = document.getElementById("Senha");

btnEntrar.onclick = async function(){

    let url = "http://localhost:5000/Usuarios/login?userOrmail=" + inpUser.value + "&password=" + inpSenha.value;

    const api = await fetch(url, {
        
        mode: 'cors',
        method: 'POST',       
    });

    let res = api.json();
    res.then(res =>{ 

        if(res.codigo == 400){

            swal("Algo deu errado! 😵" , res.mensagem, "error")
        }
        else
            infoUsuario(res);
    });
}