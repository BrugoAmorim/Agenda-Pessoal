
import { lerInfoUsuario } from '../Users/session.js';
let infoUser = lerInfoUsuario();

let texto = document.getElementById("inpConteudo");
let titulo = document.getElementById("inpTitulo");

let salvar = document.getElementById("btnSalvar");

salvar.onclick = async () => {

    let obj = {
        nome: titulo.value,
        texto: texto.value
    };

    let url = "http://localhost:5000/BlocoNotas/adicionar-bloco/" + infoUser.id;

    const api = await fetch(url,{

        mode:'cors',
        method:'POST',
        headers:{
            'Content-Type':'application/json'
        },

        body: JSON.stringify(obj)
    });

    let caixote = api.json();
    caixote.then(caixote => {

        if(caixote.codigo == 400)
            swal("Algo deu errado!", caixote.mensagem, "error");
        else
            swal("Texto Criado!", "\"" + caixote.nome + "\"" + " Já foi Salvo!", "success");
    })
}