
import { BuscarInfoTemporarias } from './exportar.js'

let obj = BuscarInfoTemporarias();
let btnExcluir = document.getElementById("Excluir");

btnExcluir.onclick = () => {
    
    let id = obj.idbloco;

    swal("Aviso!", "Você tem certeza que deseja excluir o arquivo?", "warning",{
        buttons: {
            cancel: "Não",
            catch:{
                text: "Sim",
                value: "acionarevento",
            },
        },
    }).then((value) => {
        switch(value){

        case "acionarevento":
            // se o usuario clicar em 'sim', a funcao de excluir será chamada e apagará o arquivo
            Excluir(id);
            break;

        default:
            break;
        }
    });
}

// metodo que exclui os arquivos do sistema
async function Excluir(idanotacao){

    let url = "http://localhost:5000/BlocoNotas/excluir-bloco/" + idanotacao;

    const API = await fetch(url, {

        method:'DELETE',
        mode:'cors'
    });

    let objeto = API.json();
    objeto.then(objeto => {

        if(objeto.codigo == 400)
            swal("Algo deu Errado!", objeto.mensagem, "error");
        else
            swal(objeto.mensagem, "", "success");
    })
}