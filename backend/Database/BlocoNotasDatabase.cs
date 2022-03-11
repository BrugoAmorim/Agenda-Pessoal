using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Database
{
    public class BlocoNotasDatabase
    {
        Models.agendaContext ctx = new Models.agendaContext();

        public List<Models.TbBlocoNotas> buscaranotacoes(){

            List<Models.TbBlocoNotas> caixote = ctx.TbBlocoNota.ToList();
            return caixote;
        }

        public Models.TbBlocoNotas adicionarbloco(Models.TbBlocoNotas req){

            ctx.TbBlocoNota.Add(req);
            ctx.SaveChanges();

            return req;
        }
    }
}