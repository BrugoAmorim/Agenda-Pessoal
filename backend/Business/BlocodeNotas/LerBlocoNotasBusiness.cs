using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class LerBlocoNotasBusiness
    {
        Database.BlocoNotasDatabase banco = new Database.BlocoNotasDatabase();
        public List<Models.TbBlocoNotas> validarconsulta(){

            List<Models.TbBlocoNotas> tb = banco.buscaranotacoes();

            if(tb.Count == 0)
                throw new ArgumentException("Você ainda não adicionou nenhuma anotação");

            return tb;
        }
    }
}