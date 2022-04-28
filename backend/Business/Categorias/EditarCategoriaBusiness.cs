using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class EditarCategoriaBusiness
    {
        Database.CategoriasDatabase banco = new Database.CategoriasDatabase();

        public Models.TbCategoria confirmaredicoes(Models.Request.CategoriaRequest req, int idCat, int idUser){

            List<Models.TbCategoria> caixote = banco.listarcategorias(idUser);
            Models.TbCategoria modelo = banco.buscarobjid(idCat);

            if(modelo == null)
                throw new ArgumentException("Não encontramos esta categoria");

            if(caixote.Any(x => x.NmCategoria == req.categoria && x.IdCategoria != idCat) == true)
                throw new ArgumentException("Não é permitido criar categorias com o mesmo nome");

            if(string.IsNullOrEmpty(req.categoria))
                throw new ArgumentException("É necessário inserir um nome para a categoria");

            if(string.IsNullOrEmpty(req.descricao))
                throw new ArgumentException("Você precisa adicionar uma descrição");

            Models.TbCategoria obj = banco.salvarupdate(req, idCat);
            return obj;
        }
    }
}