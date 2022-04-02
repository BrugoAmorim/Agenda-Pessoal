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

        // metodo que retorna uma lista de tarefas atraves do id de uma categoria
        public List<Models.TbTarefa> listarTarefas(int idcategoria){

            List<Models.TbTarefa> lst = ctx.TbTarefas.Where(x => x.IdCategoria == idcategoria).ToList();

            return lst;
        }   

        // busca uma tarefa atraves de seu id
        public Models.TbTarefa buscartarefa(int idtarefa){

            Models.TbTarefa obj = ctx.TbTarefas.FirstOrDefault(x => x.IdTarefa == idtarefa);
            return obj;
        }

        public Models.TbTarefa salvarupdate(Models.Request.AtualizarTarefaRequest req, int idtar){

            Models.TbTarefa tarefa = ctx.TbTarefas.First(x => x.IdTarefa == idtar);
            tarefa.DsTarefa = req.tarefa;
            tarefa.BlConcluida = req.concluida;
            tarefa.VlPrioridade = req.prioridade;

            ctx.SaveChanges();
            return tarefa;
        }

        public void excluirTarefa(int idtarefa){

            Models.TbTarefa tarefa = ctx.TbTarefas.First(x => x.IdTarefa == idtarefa);
            
            ctx.TbTarefas.Remove(tarefa);
            ctx.SaveChanges();
        }
    }
}