using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Models.Request
{
    public class AtualizarTarefaRequest
    {
        public string tarefa {get;set;}
        public int prioridade {get;set;}
        public bool concluida {get;set;}
    }
}