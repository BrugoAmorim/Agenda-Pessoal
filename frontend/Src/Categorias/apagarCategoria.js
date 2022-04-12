async function apagarCategoria(id){

    let url = "http://localhost:5000/Categorias/apagar-categoria/" + id;

    const API = await fetch(url, {

        method: 'DELETE',
        mode: 'cors'
    });

    let res = API.json();
    res.then(res => {

        if(res.codigo == 400){
            swal("Algo deu errado! 😵", res.mensagem, "error");
        }
        else
            swal(res.mensagem + "🤩", "Atualize a página para ver as alterações", "success");
    })
}

export function confirmarExclusao(idCategoria){

    swal("Aviso! Você está prestes a excluir está categoria", "Todas as tarefas dentro dela serão perdidas, tem certeza que quer continuar?", "warning", {
        buttons: {
            cancel: "Não",
            catch: {
                text: "Sim",
                value: "Confirmar",
            },
        },
    }).then((value) => {
        switch(value){

            case "Confirmar":
                apagarCategoria(idCategoria);
                break;

            default:
                break;
        }
    });

}