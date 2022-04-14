using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Utils
{
    public class TarefasUtils
    {
        public Models.TbTarefa converterReq(Models.Request.TarefasRequest req, int idcat){

            Models.TbTarefa obj = new Models.TbTarefa();
            obj.DsTarefa = req.tarefa;
            obj.BlConcluida = false;
            obj.DtAdicionado = DateTime.Now;
            obj.VlPrioridade = req.prioridade;
            obj.IdCategoria = idcat;

            return obj;
        }

        public Models.Response.TarefasResponse converterTb(Models.TbTarefa req){

            Models.Response.TarefasResponse modelo = new Models.Response.TarefasResponse();
            modelo.idtarefa = req.IdTarefa;
            modelo.idcategoria = req.IdCategoria;
            modelo.tarefa = req.DsTarefa;
            modelo.concluida = req.BlConcluida;
            modelo.adicionado = req.DtAdicionado;
            modelo.prioridade = req.VlPrioridade;

            return modelo;
        }

        public List<Models.Response.TarefasResponse> converterListaTb(List<Models.TbTarefa> req){

            List<Models.Response.TarefasResponse> caixote = new List<Models.Response.TarefasResponse>();

            foreach(Models.TbTarefa item in req){
                caixote.Add(converterTb(item));
            }

            return caixote;
        }
    }
}