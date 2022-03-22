
import { BuscarInfoTemporarias, RemoverInfoTemporarias, CriaModeloData } from "./exportar.js";

let nmBloco = document.getElementById("inpNome");
let txtBloco = document.getElementById("txtConteudo");
let atualizado = document.getElementById("dtAtualizado");
let criado = document.getElementById("dtCriado");

// modelo que contem as informacoes do arquivo
let obj = BuscarInfoTemporarias();    

// metodo que cria um modelo da data de criacao
let registro = new Date(obj.criado);

// metodo que cria um modelo da data de atualizacao
let ultimaalteracao = new Date(obj.atualizado);

window.onload = () =>{

    // valores iniciais do arquivo
    nmBloco.value = obj.nome;
    txtBloco.value = obj.texto;

    // metodo que exibe a data de criacao
    criado.innerHTML = "Criado às " + CriaModeloData(registro);
    // metodo que exibe a data de atualizacao
    atualizado.innerHTML = "Atualizado às " + CriaModeloData(ultimaalteracao);
}

let btnAtualizar = document.getElementById("Atualizar");

btnAtualizar.onclick = async () => {

    let url = "http://localhost:5000/BlocoNotas/editar-bloco/" + obj.idbloco;

    let req = {
        nome: nmBloco.value, 
        texto: txtBloco.value
    };

    const chamaapi = await fetch(url, {
        
        mode:'cors',
        method:'PUT',
        headers:{
            'Content-Type':'application/json'
        },
        body: JSON.stringify(req)
    });

    let res = chamaapi.json();
    res.then(res => {
    
        if(res.codigo == 400)
            swal("Algo deu errado", res.mensagem, "error");
        else
            swal("Alterado com sucesso!", "O seu registro já foi atualizado.", "success");
    });
}

let btnVoltar = document.getElementById("Voltar");

btnVoltar.onclick = () => {
    RemoverInfoTemporarias();
}