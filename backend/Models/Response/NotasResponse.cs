using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Response
{
    public class NotasResponse
    {
        public int idnotas {get;set;}
        public string nome {get;set;}
        public string texto {get;set;}
        public DateTime criado {get;set;}
        public DateTime atualizado {get;set;}
    }
}