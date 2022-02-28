using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class NovoContatoBusiness
    {
        Database.ContatosDatabase salvar = new Database.ContatosDatabase();

        public Models.TbContato nvcontato(Models.Request.ContatoRequest req){

            if(string.IsNullOrEmpty(req.nome))
                throw new ArgumentException("É necessário preencher o nome do contato");

            if(req.celular.Length != 12 && req.celular.Length != 13 && req.celular != "")
                throw new ArgumentException("Número de celular inválido");

            if(req.telefone.Length != 8 && req.telefone.Length != 9 && req.telefone != "")
                throw new ArgumentException("Número de telefone inválido");

            Models.TbContato obj = salvar.inserircontato(req);   
            return obj;
        }
    }
}