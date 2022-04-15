
// metodo para salvar uma nova tarefa
export async function salvarTarefa(req, idcategoria){

    let modelo = {

        tarefa: req.objetivo.value,
        prioridade: req.prioridade.value
    };

    let url = "http://localhost:5000/Tarefas/nova-tarefa/" + idcategoria;

    const api = await fetch(url, {

        method: 'POST',
        mode: 'cors',
        headers: {
            'Content-Type': 'application/json'
        },

        body: JSON.stringify(modelo)
    });

    let res = api.json();
    res.then(res => {

        if(res.codigo == 400)
            swal("Algo deu errado! 😵", res.mensagem, "error");
        else
            swal("Tarefa Salva! 🤩", "", "success");

    })
}

// evento que permiti atualizar uma tarefa ja existente
export async function atualizarTarefa(idcategoria, idtarefa, req){

    let url = "http://localhost:5000/Tarefas/edit-tarefa/" + idcategoria + "/" + idtarefa;

    let modeloReq = {
        tarefa: req.tarefa.value,
        prioridade: req.prioridade.value,
        concluida: req.feito.checked
    };

    const conexao = await fetch(url, {

        mode: 'cors',
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(modeloReq)
    });

    let res = conexao.json();
    res.then(res => {

        if(res.codigo == 400)
            swal("Algo deu errado! 😵", res.mensagem, "error");
        else
            swal("A tarefa foi atualizada com exito! 🤩", "", "success");
    })
}