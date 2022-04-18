
// metodo que permiti eu excluir uma tarefa da minha lista
async function excluirTarefa(idcategoria, idtarefa){

    let url = "http://localhost:5000/Tarefas/delete-tarefa/" + idcategoria + "/" + idtarefa;

    const conexao = await fetch(url, {

        mode: 'cors',
        method: 'DELETE'
    });

    let res = conexao.json();
    res.then(res => {

        if(res.codigo == 200)
            swal(res.mensagem, "", "success");
        else if(res.codigo == 400)
            swal("Algo deu errado!", res.mensagem, "error");
    });
}

export function confirmarExcluimento(idcategoria, idtarefa){

    swal("Aviso!", "Você está prestes a excluir esta tarefa, quer continuar?", "warning", {
        buttons: {
            cancel: "Não",
            catch: {
                text: "Sim",
                value: "Confirmar"
            }
        }
    }).then((value) => {
        switch(value){

            case "Confirmar":
                excluirTarefa(idcategoria, idtarefa);
                break;

            default:
                break;
        }
    });
}