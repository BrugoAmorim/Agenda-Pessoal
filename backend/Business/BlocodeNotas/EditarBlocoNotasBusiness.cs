using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class EditarBlocoNotasBusiness
    {
        Database.BlocoNotasDatabase banco = new Database.BlocoNotasDatabase();
        public Models.TbBlocoNotas validarupdate(Models.Request.BlocodeNotasRequest req, int id){

            Models.TbBlocoNotas modelo = banco.buscararquivo(id);

            if(string.IsNullOrEmpty(req.nome))
                throw new ArgumentException("É necessário preencher o campo nome");

            if(modelo == null)
                throw new ArgumentException("Este arquivo não foi encontrado");

            Models.TbBlocoNotas obj = banco.confirmaralteracao(req, id);
            return obj;
        }
    }
}