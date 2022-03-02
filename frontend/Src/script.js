
let corpo = document.getElementById("conteudo");

// quando a pagina carregar, os contatos do usuario serao mostrados
window.onload = async () => {

    let url = "http://localhost:5000/Contato/buscar-ctt";

    const api = await fetch(url,{

        method:'GET',
        mode:'cors'
    });

    let modelo = api.json();
    modelo.then(modelo =>{
        
        for(let i = 0; i < modelo.length; i++){

            // variaveis que guardam tags
            let container = document.createElement('tr');
            let nome = document.createElement('th');
            let cmpdeletar = document.createElement('td');
            let btndel = document.createElement('button');
            let imglixeira = document.createElement('img');

            let obj = modelo[i];

            nome.appendChild(document.createTextNode(obj.nome));
            
            imglixeira.src = "../../images/trash.png";
            imglixeira.height = 20;
            imglixeira.width = 20;

            btndel.appendChild(imglixeira);
            btndel.classList.add("eventodel");

            cmpdeletar.append(btndel);

            container.appendChild(nome);
            container.appendChild(cmpdeletar);

            corpo.appendChild(container);
        }
    });
}

let add = document.getElementById("btnAdicionar");

// funcao para o usuario adicionar seus contatos
add.onclick = async () => {

    let nm = document.getElementById("Nome");
    let mail = document.getElementById("Email");
    let tel = document.getElementById("Telefone");
    let cel = document.getElementById("Celular");
    let cid = document.getElementById("Cidade");
    let est = document.getElementById("Estado");    
    let ant = document.getElementById("Notas");

    // modelo json do request
    let objeto = {
        nome: nm.value,
        celular: cel.value,
        telefone: tel.value,
        email: mail.value,
        cidade: cid.value,
        estado: est.value,
        anotacoes: ant.value
    };

    let url = "http://localhost:5000/Contato/novo-ctt";

    const chamaapi = await fetch(url, {
        
        mode: 'cors',
        method: 'POST',
        headers: {
            'Content-Type':'application/json'
        },

        body: JSON.stringify(objeto) 
    });

    let res = chamaapi.json();
    res.then(res => {
        
        if(res.codigo == 400)
            swal("Ops! Algo deu Errado", res.mensagem, "error");   
        else 
            swal("Contato Salvo!", "Atualize a página para o novo contato ser exibido", "success");
    
    })
}

let recarregar = document.getElementById("Recarregarpag");

// funcao para atualizar a lista de contatos
recarregar.onclick = async () =>{

    while(corpo.firstChild)
        corpo.removeChild(corpo.firstChild);

    let url = "http://localhost:5000/Contato/buscar-ctt";

    const api = await fetch(url,{

        method:'GET',
        mode:'cors'
    });

    let modelo = api.json();
    modelo.then(modelo =>{
        
        for(let i = 0; i < modelo.length; i++){

            // variaveis que guardam tags
            let container = document.createElement('tr');
            let nome = document.createElement('th');
            let cmpdeletar = document.createElement('td');
            let btndel = document.createElement('button');
            let imglixeira = document.createElement('img');

            let obj = modelo[i];

            nome.appendChild(document.createTextNode(obj.nome));
            
            imglixeira.src = "../../images/trash.png";
            imglixeira.height = 20;
            imglixeira.width = 20;

            btndel.appendChild(imglixeira);
            btndel.classList.add("eventodel");

            cmpdeletar.append(btndel);

            container.appendChild(nome);
            container.appendChild(cmpdeletar);

            corpo.appendChild(container);
        }
    });
}