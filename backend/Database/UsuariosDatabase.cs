using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Database
{
    public class UsuariosDatabase
    {
        Models.agendaContext bd = new Models.agendaContext();

        public Models.TbUsuario salvar(Models.TbUsuario req){

            bd.TbUsuarios.Add(req);
            bd.SaveChanges();

            return req;
        }

        public List<Models.TbUsuario> buscarUsuarios(){

            List<Models.TbUsuario> registros = bd.TbUsuarios.ToList();
            return registros;
        }
    }
}