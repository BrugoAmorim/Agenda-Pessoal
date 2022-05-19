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

        public Models.TbUsuario updateConta(int id, string email, string senha){

            Models.TbUsuario user = bd.TbUsuarios.First(x => x.IdUsuario == id);
            user.DsEmail = email;
            user.DsSenha = senha;

            bd.SaveChanges();
            return user;            
        }

        public void excluirConta(int idconta){

            Models.TbUsuario user = bd.TbUsuarios.First(x => x.IdUsuario == idconta);

            List<Models.TbBlocoNotas> Notas = bd.TbBlocoNota.Where(x => x.IdUsuario == idconta).ToList();
            List<Models.TbContato> Contatos = bd.TbContatos.Where(x => x.IdUsuario == idconta).ToList();
            List<Models.TbCategoria> Categorias = bd.TbCategoria.Where(x => x.IdUsuario == idconta).ToList();

            foreach(Models.TbBlocoNotas item in Notas){
                bd.TbBlocoNota.Remove(item);
                bd.SaveChanges();
            }

            foreach(Models.TbContato item in Contatos){
                bd.TbContatos.Remove(item);
                bd.SaveChanges();
            }
            
            foreach(Models.TbCategoria item in Categorias){
                
                List<Models.TbTarefa> MinhasTarefas = bd.TbTarefas.Where(x => x.IdCategoria == item.IdCategoria)
                                                                  .ToList();
                foreach(Models.TbTarefa obj in MinhasTarefas){

                    bd.TbTarefas.Remove(obj);
                    bd.SaveChanges();
                }

                bd.TbCategoria.Remove(item);
                bd.SaveChanges();
            }

            bd.TbUsuarios.Remove(user);
            bd.SaveChanges();

        }
    }
}