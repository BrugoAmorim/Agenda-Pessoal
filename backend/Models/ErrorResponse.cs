using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable
namespace backend.Models
{
    public class ErrorResponse
    {
        public string mensagem {get;set;}
        public int codigo {get;set;}

        public ErrorResponse(string mensagem, int codigo){

            this.mensagem = mensagem;
            this.codigo = codigo;
        }
    }
}