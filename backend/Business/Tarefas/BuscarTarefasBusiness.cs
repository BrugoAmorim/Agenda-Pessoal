using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class BuscarTarefasBusiness
    {
        Database.TarefasDatabase bancotarefa = new Database.TarefasDatabase();
        Database.CategoriasDatabase bancocategoria = new Database.CategoriasDatabase();

        public List<Models.TbTarefa> validarbusca(int id, int prioridade){

            Models.TbCategoria obj = bancocategoria.buscarobjid(id);
            List<Models.TbTarefa> colecao = bancotarefa.listarTarefas(id);

            if(obj == null)
                throw new ArgumentException("Esta categoria nao foi encontrada");

            if(colecao.Count == 0)
                throw new ArgumentException("Voce ainda não adicionou uma tarefa");

            if(prioridade != 0)
                colecao = colecao.OrderByDescending(x => x.VlPrioridade == prioridade).ToList();

            return colecao;
        }

    }
}