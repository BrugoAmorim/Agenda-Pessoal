
import { retornarObjeto } from './comprimir.js';

let conjunto = document.getElementById("Conjunto");

window.onload = async () => {

    let url = "http://localhost:5000/Categorias";

    const api = await fetch(url,{
        method: 'GET',
        mode: 'cors'
    });

    let res = api.json();
    res.then(res => {
        res.map(function(x){
            
            let objeto = retornarObjeto(x);

            // div que inseri no html as informacoes do objeto
            conjunto.appendChild(objeto);
        })
    })
}