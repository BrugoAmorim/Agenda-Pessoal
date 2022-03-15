
let corpotable = document.getElementById("informacoes");

window.onload = async function(){

    let url = "http://localhost:5000/BlocoNotas/buscar";

    const consumirapi = await fetch(url, {

        method:'GET',
        mode:'cors'
    });

    let res = consumirapi.json();
    res.then(res => {
        res.map(function(x){

            let conjunto = document.createElement('tr');
            let nomebl = document.createElement('td');
            
            nomebl.appendChild(document.createTextNode(x.nome));
            conjunto.appendChild(nomebl);

            corpotable.appendChild(conjunto);

            if(corpotable.addEventListener("click", function(){
                window.location.href = "#";
            }));
        });
    });
}