using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Business
{
    public class ApagarContatoBusiness
    {
        Database.ContatosDatabase funcoesbanco = new Database.ContatosDatabase(); 
        public void validardelete(int idct){

            Models.TbContato info = funcoesbanco.validarcontato(idct);

            if(info == null)
                throw new ArgumentException("Este contato não foi encontrado");

            funcoesbanco.delete(idct);
        }
    }
}