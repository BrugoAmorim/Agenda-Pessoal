using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Business
{
    public class DeletarCategoria
    {
        Database.CategoriasDatabase banco = new Database.CategoriasDatabase();        
        public void confirmardelete(int id){

            Models.TbCategoria caixote = banco.buscarobjid(id);

            if(caixote == null)
                throw new ArgumentException("Não encontramos esta categoria");

            banco.excluir(id);
        }
    }
}