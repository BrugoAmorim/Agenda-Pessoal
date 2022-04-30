
let user = document.getElementById("inpNome");
let email = document.getElementById("inpEmail");
let senha = document.getElementById("inpSenha");
let confSenha = document.getElementById("inpConfirmarSenha");

let CriarConta = document.getElementById("btnCriar");

CriarConta.onclick = async function criarConta(){

    let url = "http://localhost:5000/Usuarios/criar-conta";

    if(senha.value == confSenha.value){

        let objReq = {
            usuario: "@" + user.value,
            email: email.value,
            senha: senha.value
        };

        const api = await fetch(url, {

            mode: 'cors',
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },

            body: JSON.stringify(objReq)
        });
        
        let res = api.json();
        res.then(res => {

            if(res.codigo == 400)
                swal("Algo deu errado!", res.mensagem, 'error');
            else{
                swal("Conta criada com sucesso!", "", 'success').then(function(){
                    user.value = "";
                    email.value = "";
                    senha.value = "";
                    confSenha.value = "";
                });
            }
        });
    }
    else{
        swal("As senhas não coincidem, arrume para continuar.", "", 'info');
    }
}