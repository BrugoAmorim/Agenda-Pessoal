
// metodo para salvar uma nova categoria
export async function salvarCategoria(nomeCategoria, desc){

    let obj = {
        categoria: nomeCategoria,
        descricao: desc
    };

    let url = "http://localhost:5000/Categorias/criar-categoria";

    const api = await fetch(url, {
        mode:'cors',
        method: 'POST',
        headers:{
            'Content-Type':'application/json'
        },
        body: JSON.stringify(obj)
    });

    let res = api.json();
    return res;
}

// funcao que atualiza as informacoes de uma das categorias
export async function atualizarCategoria(idCategoria, nomeCategoria, desc){

    let objeto = {
        categoria: nomeCategoria,
        descricao: desc
    };

    let url = "http://localhost:5000/Categorias/editar-categoria/" + idCategoria;

    const chamapi = await fetch(url, {
        mode:'cors',
        method:'PUT',
        headers:{
            'Content-Type': 'application/json'
        },

        body: JSON.stringify(objeto)
    });

    let res = chamapi.json();
    return res;
}
