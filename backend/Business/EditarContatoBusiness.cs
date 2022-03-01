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

            if(req.celular.Length != 12 && req.celular.Length != 13 && req.celular != "")
                throw new ArgumentException("Número de celular inválido");

            if(req.telefone.Length != 8 && req.telefone.Length != 9 && req.telefone != "")
                throw new ArgumentException("Número de telefone inválido");

            Models.TbContato obj = banco.atualizarinfo(req, id);
            return obj;
        }
    }
}