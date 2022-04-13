
// funcao para ser usada em BlocodeNotas, cria informacoes temporarias e leva o usuario para a pagina de editar bloco
export function CriarInfoTemporarias(mod){

    localStorage.setItem("idnotas", mod.idnotas);
    localStorage.setItem("nome", mod.nome);
    localStorage.setItem("conteudo", mod.texto);
    localStorage.setItem("criado", mod.criado);
    localStorage.setItem("atualizado", mod.atualizado);

    window.location.href = "../InfoAnotacao/index.html";
}

// funcao para ser usada em InfoAnotacao
export function BuscarInfoTemporarias(){

    let obj = {
        "idbloco":localStorage.getItem("idnotas"),
        "nome":localStorage.getItem("nome"),
        "texto":localStorage.getItem("conteudo"),
        "criado":localStorage.getItem("criado"),
        "atualizado":localStorage.getItem("atualizado")
    };

    return obj;
}

// funcao para apagar as informacoes temporarias, depois disso o usario será levado para a pagina BlocodeNotas
export function RemoverInfoTemporarias(){

    localStorage.removeItem("idnotas");
    localStorage.removeItem("nome");
    localStorage.removeItem("conteudo");
    localStorage.removeItem("criado");
    localStorage.removeItem("atualizado");

    window.location.href = "../BlocodeNotas/index.html";
}

export function ConversorMes(data){

    let modelo;

    if(data.getMonth() == 0) // Janeiro
        modelo = "01"
    
    else if(data.getMonth() == 1) // Fevereiro
        modelo = "02"
    
    else if(data.getMonth() == 2) // Março
        modelo = "03"
    
    else if(data.getMonth() == 3) // Abril
        modelo = "04"
    
    else if(data.getMonth() == 4) // Maio
        modelo = "05"
    
    else if(data.getMonth() == 5) // Junho
        modelo = "06"
    
    else if(data.getMonth() == 6) // Julho
        modelo = "07"
    
    else if(data.getMonth() == 7) // Agosto
        modelo = "08"
    
    else if(data.getMonth() == 8) // Setembro
        modelo = "09"
    
    else if(data.getMonth() == 9) // Outubro
        modelo = "10"
    
    else if(data.getMonth() == 10) // Novembro
        modelo = "11"
    
    else if(data.getMonth() == 11) // Dezembro
        modelo = "12"

    let caixote = data.getDate() + "/" + modelo + "/" + data.getFullYear();
    // ex: caixote -> 01/01/0001
    return caixote;
}

export function CriaModeloData(datetime){

    let modelo = ConversorMes(datetime);

    let res = datetime.getHours() + ":" + datetime.getMinutes() + " - " + modelo.substring(0,modelo.lastIndexOf("/")); 
    // ex: res -> '01:00 - 01/01'
    return res;
}