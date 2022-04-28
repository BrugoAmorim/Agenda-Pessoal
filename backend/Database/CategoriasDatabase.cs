using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Database
{
    public class CategoriasDatabase
    {
        Models.agendaContext ctx = new Models.agendaContext();

        public List<Models.TbCategoria> listarcategorias(int id){

            List<Models.TbCategoria> colecao = ctx.TbCategoria.Where(x => x.IdUsuario == id).ToList();
            return colecao;
        }

        public Models.TbCategoria salvarCategoria(Models.Request.CategoriaRequest req, int iduser){

            Utils.CategoriasUtils conversor = new Utils.CategoriasUtils();
            Models.TbCategoria tb = conversor.converterReq(req, iduser);

            ctx.TbCategoria.Add(tb);
            ctx.SaveChanges();

            return tb;
        }

        public Models.TbCategoria buscarobjid(int id){

            Models.TbCategoria obj = ctx.TbCategoria.FirstOrDefault(x => x.IdCategoria == id);
            return obj;
        }

        public Models.TbCategoria salvarupdate(Models.Request.CategoriaRequest req, int id){

            Models.TbCategoria modelo = ctx.TbCategoria.First(x => x.IdCategoria == id);
            modelo.DsCategoria = req.descricao;
            modelo.NmCategoria = req.categoria;
        
            ctx.SaveChanges();
            return modelo;

        }

        public void excluir(int id){

            List<Models.TbTarefa> tfs = ctx.TbTarefas.Where(x => x.IdCategoria == id).ToList();
            foreach(Models.TbTarefa item in tfs){

                if(item.IdCategoria == id){
                    ctx.TbTarefas.Remove(item);
                    ctx.SaveChanges();
                }
                else
                    continue;
            }

            Models.TbCategoria obj = ctx.TbCategoria.First(x => x.IdCategoria == id);
            ctx.TbCategoria.Remove(obj);
            ctx.SaveChanges();
        }
    }
}