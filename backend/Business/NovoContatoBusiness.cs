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

            Models.TbContato obj = salvar.inserircontato(req);   
            return obj;
        }
    }
}