using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Database
{
    public class TarefasDatabase
    {
        Models.agendaContext ctx = new Models.agendaContext();
        public Models.TbTarefa inserir(Models.Request.TarefasRequest req, int id){

            Utils.TarefasUtils conversor = new Utils.TarefasUtils();

            Models.TbTarefa obj = conversor.converterReq(req, id);
            ctx.TbTarefas.Add(obj);
            ctx.SaveChanges();

            return obj;
        }

        public List<Models.TbTarefa> listarTarefas(int idcategoria){

            List<Models.TbTarefa> lst = ctx.TbTarefas.Where(x => x.IdCategoria == idcategoria).ToList();

            return lst;
        }
    }
}