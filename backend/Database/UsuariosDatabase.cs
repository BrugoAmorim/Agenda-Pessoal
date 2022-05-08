using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable
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

        public Models.TbUsuario infoUser(string userOrmail){

            Models.TbUsuario usuario = bd.TbUsuarios.FirstOrDefault(x => x.NmUsuario == userOrmail || x.DsEmail == userOrmail);

            return usuario;
        }

        public Models.TbUsuario buscarUserId(int iduser){

            Models.TbUsuario info = bd.TbUsuarios.FirstOrDefault(x => x.IdUsuario == iduser);
            return info;
        }

        public void excluirconta(int id){

            Models.TbUsuario informacoes = bd.TbUsuarios.First(x => x.IdUsuario == id);
            bd.TbUsuarios.Remove(informacoes);
            bd.SaveChanges();
        }

        public Models.TbUsuario updateConta(int id, string email, string senha){

            Models.TbUsuario user = bd.TbUsuarios.First(x => x.IdUsuario == id);
            user.DsEmail = email;
            user.DsSenha = senha;

            bd.SaveChanges();
            return user;            
        }
    }
}