
import { buscarinfotemporarias, apagarinfotemporarias } from "./session.js";

let btnvoltar = document.getElementById("Voltar");

// quando o usuário quiser voltar para a pagina anterior, as informacoes que foram salvar temporariamente serao apagadas
btnvoltar.onclick = () => {

    apagarinfotemporarias();
}

let btnSalvar = document.getElementById("Salvar");

// cada variavel pegou o id de um input diferente
let nome = document.getElementById("Name");
let email = document.getElementById("Mail");
let cel = document.getElementById("Cell");
let tel = document.getElementById("Phone");
let est = document.getElementById("State");
let cid = document.getElementById("City");
let notas = document.getElementById("Notes");

window.onload = () =>{
    
    // esta variavel recebe as informacoes vindas da pagina anterior, elas sao salvas em um novo objeto
    let mod = buscarinfotemporarias();
    
    nome.value = mod.nome;
    email.value = mod.email;
    cel.value = mod.celular;
    tel.value = mod.fone;
    est.value = mod.estado;
    cid.value = mod.cidade;
    notas.value = mod.notas;
}

btnSalvar.onclick = async () =>{

    // esta variavel recebe as informacoes vindas da pagina anterior, elas sao salvas em um novo objeto
    let mod = buscarinfotemporarias();

    // url da api
    let url = "http://localhost:5000/Contato/editar-ctt/" + mod.id;

    // objeto que recebe os valores do inputs
    let obj = {
        nome: nome.value,
        celular: cel.value,
        telefone: tel.value,
        email: email.value,
        cidade: cid.value,
        estado: est.value,
        anotacoes: notas.value
    };

    const api = await fetch(url, {
        
        mode:'cors',
        method:'PUT',
        headers:{
            'Content-Type': 'application/json'
        },

        body: JSON.stringify(obj)
    });

    let res = api.json();
    res.then(res => {

        if(res.codigo == 400)
            swal("Um erro ocorreu! 😵", res.mensagem, 'error');
        else
            swal("Tudo nos conformes!", "as informações já foram salvas 😎", "success");
    })

}