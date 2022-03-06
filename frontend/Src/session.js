
// Funções de Exportação

// funcao que criará um localstorage para cada informacao do contato
export function salvarinfotemporarias(modelo){

    localStorage.setItem("id",modelo.idctt);
    localStorage.setItem("nm", modelo.nome);
    localStorage.setItem("cel", modelo.celular);
    localStorage.setItem("tel", modelo.telefone);
    localStorage.setItem("mail", modelo.email);
    localStorage.setItem("city", modelo.cidade);
    localStorage.setItem("est", modelo.estado);
    localStorage.setItem("notas", modelo.anotacoes);

    window.location.href = "../EditarContato/index.html";
}

// esta funcao busca as informacoes de um contato salvo pelo localstorage, e depois retorna todas juntas em um unico modelo
export function buscarinfotemporarias(){

    let obj = {
        "id":localStorage.getItem("id"),
        "nome":localStorage.getItem("nm"),
        "celular":localStorage.getItem("cel"),
        "fone":localStorage.getItem("tel"),
        "email":localStorage.getItem("mail"),
        "cidade":localStorage.getItem("city"),
        "estado":localStorage.getItem("est"),
        "notas":localStorage.getItem("notas")
    };

    return obj;
}

// funcao para apagar estas informacoes criadas temporariamente, depois de apagadas o usuario sera redirecionado para a pagina anterior
export function apagarinfotemporarias(){

    localStorage.removeItem("id")
    localStorage.removeItem("nm")
    localStorage.removeItem("cel")
    localStorage.removeItem("tel")
    localStorage.removeItem("mail")
    localStorage.removeItem("city")
    localStorage.removeItem("est")
    localStorage.removeItem("notas")

    window.location.href = "../Contatos/index.html";
}