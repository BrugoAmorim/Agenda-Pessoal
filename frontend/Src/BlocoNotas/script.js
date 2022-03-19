
import { CriarInfoTemporarias } from './exportar.js'

let corpotable = document.getElementById("informacoes");

window.onload = async function(){

    let url = "http://localhost:5000/BlocoNotas/buscar";

    const consumirapi = await fetch(url, {

        method:'GET',
        mode:'cors'
    });

    let res = consumirapi.json();
    res.then(res => {

        for(let item = 0; item < res.length; item++){
            
            let valores = res[item];

            let info = document.createElement('tr');
            let nome = document.createElement('td');
            
            nome.appendChild(document.createTextNode(valores.nome));

            info.appendChild(nome);
            corpotable.appendChild(info);

            if(info.addEventListener("click", function(){
                CriarInfoTemporarias(valores);
            }));
        }
    });
}