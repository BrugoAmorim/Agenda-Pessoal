using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class SalvarCategorias
    {
        Database.UsuariosDatabase bancoUsuario = new Database.UsuariosDatabase();
        Database.CategoriasDatabase banco = new Database.CategoriasDatabase();
        public Models.TbCategoria conferircategoria(Models.Request.CategoriaRequest req, int id){

            List<Models.TbCategoria> caixote = banco.listarcategorias(id);

            if(string.IsNullOrEmpty(req.categoria))
                throw new ArgumentException("É necessário inserir um nome para a categoria");

            if(string.IsNullOrEmpty(req.descricao))
                throw new ArgumentException("Você precisa adicionar uma descrição");

            if(caixote.Any(x => x.NmCategoria == req.categoria) == true)
                throw new ArgumentException("Não é permitido criar categorias com o mesmo nome");

            Models.TbCategoria obj = banco.salvarCategoria(req, id);
            return obj;
        }   
    }
}