using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Business
{
    public class ApagarTarefaBusiness
    {
        Database.CategoriasDatabase bancoCategoria = new Database.CategoriasDatabase();
        Database.TarefasDatabase bancoTarefa = new Database.TarefasDatabase();
        public void deletartarefa(int idtar, int idcat){
            
            Models.TbCategoria categoria = bancoCategoria.buscarobjid(idcat);
            Models.TbTarefa tarefa = bancoTarefa.buscartarefa(idtar);

            if(categoria == null)
                throw new ArgumentException("Está categoria não foi encontrada");

            if(tarefa == null)
                throw new ArgumentException("Não encontramos está tarefa");

            if(tarefa.IdCategoria != categoria.IdCategoria)
                throw new ArgumentException("Esta tarefa não faz parte dessa categoria");

            bancoTarefa.excluirTarefa(idtar);
        }
    }
}