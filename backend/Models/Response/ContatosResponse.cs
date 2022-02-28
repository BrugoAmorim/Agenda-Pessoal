using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Models.Response
{
    public class ContatosResponse
    {
        public int idctt {get;set;}
        public string nome {get;set;}
        public string celular {get;set;}
        public string telefone {get;set;}
        public string email {get;set;}
        public string cidade {get;set;}
        public string estado {get;set;}
        public string anotacoes {get;set;}
    }
}