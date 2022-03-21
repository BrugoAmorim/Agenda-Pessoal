using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Response
{
    public class SuccessResponse
    {
        public string Mensagem {get;set;}
        public int Codigo {get;set;}

        public SuccessResponse(string mensagem, int codigo)
        {
            Mensagem = mensagem;
            Codigo = codigo;
        }
    }
}