using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Database
{
    public class ContatosDatabase
    {
        Models.agendaContext ctx = new Models.agendaContext();
        Utils.ContatosUtils conversor = new Utils.ContatosUtils();

        public List<Models.TbContato> listacontatos(){

            List<Models.TbContato> res = ctx.TbContatos.ToList();
            return res;
        }

        public Models.TbContato inserircontato(Models.Request.ContatoRequest req){

            Models.TbContato mod = conversor.converterRequest(req);

            ctx.TbContatos.Add(mod);
            ctx.SaveChanges();

            return mod;
        }
    }
}