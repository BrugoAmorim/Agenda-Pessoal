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
    }
}