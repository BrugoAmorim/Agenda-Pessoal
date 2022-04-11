
import { atualizarCategoria } from './inserirEatualizar.js'
import { IncrementarObjeto } from './session.js'

let conjunto = document.getElementById("Conjunto");

export async function carregarListas(){

    let url = "http://localhost:5000/Categorias";

    const api = await fetch(url,{
        method: 'GET',
        mode: 'cors'
    });

    let res = api.json();
    res.then(res => {
        res.map(function(param){
                    
            let obj = IncrementarObjeto(param);
            conjunto.appendChild(obj.formato);

            // eu crio uma variavel que pegará as propriedades do input titulo
            let titulo = obj.nome;
            // logo após eu chamo o obj com o atributo nome que copiará o valor da variavel titulo
            obj.nome = titulo.value;

            // instacio uma variavel que atribui as propriedades do atributo descricao, contido no obj
            let descricao = obj.desc;
            // apos isso, o obj chama o atributo que contem o valor do input desc que, acaba copiando os valores da variavel descricao
            obj.desc = descricao.value;

            obj.evento.addEventListener("click", function(){
                
                let caixote = atualizarCategoria(obj.id, titulo.value, descricao.value);
                caixote.then(cxt => {

                    if(cxt.codigo == 400)
                        swal("Algo deu errado!", cxt.mensagem, "error");
                    else
                        swal("Atualizado com Sucesso!", "", "success");
                })
            })

        })
    })
}
 
window.onload = carregarListas();

