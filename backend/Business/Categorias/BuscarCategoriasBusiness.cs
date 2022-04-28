using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Business
{
    public class BuscarCategorias
    {        
        Database.UsuariosDatabase bancoUser = new Database.UsuariosDatabase();
        Database.CategoriasDatabase db = new Database.CategoriasDatabase();

        public List<Models.TbCategoria> validarbusca(int id){

            List<Models.TbCategoria> colecao = db.listarcategorias(id);

            if(bancoUser.buscarUserId(id) == null)
                throw new ArgumentException("Este usuario nao foi encontrado");

            if(colecao.Count == 0)
                throw new ArgumentException("Voce nao registrou um categoria.");

            return colecao;
        }
    }
}