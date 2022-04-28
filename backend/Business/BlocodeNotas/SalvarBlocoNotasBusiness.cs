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

        public Models.TbBlocoNotas validarinsert(Models.Request.BlocodeNotasRequest req, int id){

            List<Models.TbBlocoNotas> lst = banco.buscaranotacoes(id);

            if(string.IsNullOrEmpty(req.nome))
                throw new ArgumentException("É necessário você preencher o campo nome");

            if(lst.Any(x => x.NmBloco == req.nome) == true)
                throw new ArgumentException("Um arquivo já está usando este nome, por favor tente outro");

            Models.TbBlocoNotas caixa = banco.adicionarbloco(conversor.converterReq(req, id));
            return caixa;
        }
    }
}