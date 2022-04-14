
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