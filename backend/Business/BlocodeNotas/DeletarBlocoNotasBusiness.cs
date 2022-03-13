using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class DeletarBlocoNotasBusiness
    {
        Database.BlocoNotasDatabase banco = new Database.BlocoNotasDatabase();
        public void validardelete(int id){

            Models.TbBlocoNotas notas = banco.buscararquivo(id);

            if(notas == null)
                throw new ArgumentException("Está anotação não foi encontrada");

            banco.excluir(id);
        }
    }
}