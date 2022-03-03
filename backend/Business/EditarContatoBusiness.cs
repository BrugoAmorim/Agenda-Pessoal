using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class EditarContatoBusiness
    {
        Database.ContatosDatabase banco = new Database.ContatosDatabase();
        public Models.TbContato validarupdate(int id, Models.Request.ContatoRequest req){

            Models.TbContato buscarinfo = banco.validarcontato(id);

            if(buscarinfo == null)
                throw new ArgumentException("Este contato não existe");

            if(string.IsNullOrEmpty(req.nome))
                throw new ArgumentException("É necessário preencher o nome do contato");

            Models.TbContato obj = banco.atualizarinfo(req, id);
            return obj;
        }
    }
}