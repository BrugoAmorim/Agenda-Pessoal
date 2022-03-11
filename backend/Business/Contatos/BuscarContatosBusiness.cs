using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Business
{
    public class BuscarContatosBusiness
    {
        Database.ContatosDatabase banco = new Database.ContatosDatabase();
        public List<Models.TbContato> seuscontatos(){

            List<Models.TbContato> caixote = banco.listacontatos();

            if(caixote.Count == 0)
                throw new ArgumentException("você ainda não adicionou nenhum contato");

            return caixote;
        }
    }
}