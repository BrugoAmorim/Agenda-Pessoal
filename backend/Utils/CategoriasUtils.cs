using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Utils
{
    public class CategoriasUtils
    {
        
        public Models.Response.CategoriasResponse converterTb(Models.TbCategoria req){

            Models.Response.CategoriasResponse res = new Models.Response.CategoriasResponse();
            res.idcategoria = req.IdCategoria;
            res.categoria = req.NmCategoria;
            res.descricao = req.DsCategoria;

            return res;
        }

        public List<Models.Response.CategoriasResponse> converterLista(List<Models.TbCategoria> lst)
        {

            List<Models.Response.CategoriasResponse> caixote = new List<Models.Response.CategoriasResponse>();

            foreach(Models.TbCategoria item  in lst){

                caixote.Add(converterTb(item));
            }

            return caixote;
        }
    }
}