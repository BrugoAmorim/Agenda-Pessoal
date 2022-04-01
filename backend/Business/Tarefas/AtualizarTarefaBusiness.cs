using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Business
{
    public class AtualizarTarefaBusiness
    {
        Database.CategoriasDatabase bancoCategoria = new Database.CategoriasDatabase();
        Database.TarefasDatabase bancoTarefa = new Database.TarefasDatabase();
        public Models.TbTarefa validaratualizacao(int idcat, int idtar, Models.Request.AtualizarTarefaRequest req){

            Models.TbCategoria categoria = bancoCategoria.buscarobjid(idcat);
            Models.TbTarefa tarefa = bancoTarefa.buscartarefa(idtar);

            if(categoria == null)
                throw new ArgumentException("Está categoria não foi encontrada");

            if(tarefa == null)
                throw new ArgumentException("Não encontramos está tarefa");

            if(tarefa.IdCategoria != categoria.IdCategoria)
                throw new ArgumentException("Esta tarefa não faz parte dessa categoria");

            if(string.IsNullOrEmpty(req.tarefa))
                throw new ArgumentException("Você precisa escrever uma tarefa");

            if(req.prioridade != 1 && req.prioridade != 2 && req.prioridade != 3 && req.prioridade != 4 && req.prioridade != 5 )
                throw new ArgumentException("Voce precisa definir uma prioridade válida");

            Models.TbTarefa salvo = bancoTarefa.salvarupdate(req, idtar);
            return salvo;
        }
    }
}