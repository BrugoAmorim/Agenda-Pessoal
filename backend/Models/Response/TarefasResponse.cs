using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable
namespace backend.Models.Response
{
    public class TarefasResponse
    {
        public int idtarefa {get;set;}
        public string tarefa {get;set;}
        public bool concluida {get;set;}
        public int prioridade {get;set;}
        public DateTime adicionado {get;set;}   
        public int idcategoria {get;set;}
    }
}