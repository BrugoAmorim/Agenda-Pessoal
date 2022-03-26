using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Database
{
    public class CategoriasDatabase
    {
        Models.agendaContext ctx = new Models.agendaContext();

        public List<Models.TbCategoria> listarcategorias(){

            List<Models.TbCategoria> colecao = ctx.TbCategoria.ToList();
            return colecao;
        }

        public Models.TbCategoria salvarCategoria(Models.Request.CategoriaRequest req){

            Utils.CategoriasUtils conversor = new Utils.CategoriasUtils();
            Models.TbCategoria tb = conversor.converterReq(req);

            ctx.TbCategoria.Add(tb);
            ctx.SaveChanges();

            return tb;
        }
    }
}