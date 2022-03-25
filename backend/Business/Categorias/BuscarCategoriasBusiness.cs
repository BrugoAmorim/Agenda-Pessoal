using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Business
{
    public class BuscarCategorias
    {        
        Database.CategoriasDatabase db = new Database.CategoriasDatabase();

        public List<Models.TbCategoria> validarbusca(){

            List<Models.TbCategoria> colecao = db.listarcategorias();

            if(colecao.Count == 0)
                throw new ArgumentException("Voce nao registrou um categoria.");

            return colecao;
        }
    }
}