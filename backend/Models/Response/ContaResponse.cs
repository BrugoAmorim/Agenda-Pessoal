using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Response
{
    public class ContaResponse
    {
        public int iduser {get;set;}
        public string usuario {get;set;}
        public string email {get;set;}
        public DateTime criado {get;set;}
    }
}