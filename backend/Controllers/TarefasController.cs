using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefasController : ControllerBase
    {
        Utils.TarefasUtils conversor = new Utils.TarefasUtils();

        [HttpPost("nova-tarefa/{idcategoria}")]
        public ActionResult<Models.Response.TarefasResponse> inserirtarefa(Models.Request.TarefasRequest req, int idcategoria){

            try{
                Business.SalvarTarefaBusiness validar = new Business.SalvarTarefaBusiness();
                Models.TbTarefa obj = validar.validarinsert(req, idcategoria);

                Models.Response.TarefasResponse res = conversor.converterTb(obj);
                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpGet("buscar-tarefas/{idcategoria}")]
        public ActionResult<List<Models.Response.TarefasResponse>> buscarminhastarefas(int idcategoria){

            try{
                Business.BuscarTarefasBusiness buscarinfo = new Business.BuscarTarefasBusiness();
                List<Models.TbTarefa> lst = buscarinfo.validarbusca(idcategoria);

                List<Models.Response.TarefasResponse> objetores = conversor.converterListaTb(lst);
                return objetores;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }
    }
}