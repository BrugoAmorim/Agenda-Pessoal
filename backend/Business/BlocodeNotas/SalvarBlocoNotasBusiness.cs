using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class SalvarBlocoNotasBusiness
    {   
        Database.BlocoNotasDatabase banco = new Database.BlocoNotasDatabase();
        Utils.BlocoNotasUtils conversor = new Utils.BlocoNotasUtils();

        public Models.TbBlocoNotas validarinsert(Models.Request.BlocodeNotasRequest req){

            if(string.IsNullOrEmpty(req.nome))
                throw new ArgumentException("É necessário você preencher o campo nome");

            Models.TbBlocoNotas caixa = banco.adicionarbloco(conversor.converterReq(req));
            return caixa;
        }
    }
}