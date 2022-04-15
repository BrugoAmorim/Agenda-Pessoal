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
        public ActionResult<List<Models.Response.TarefasResponse>> buscarminhastarefas(int idcategoria, int prioridade){

            try{
                Business.BuscarTarefasBusiness buscarInfo = new Business.BuscarTarefasBusiness();
                List<Models.TbTarefa> lst = buscarInfo.validarbusca(idcategoria, prioridade);

                List<Models.Response.TarefasResponse> objetoRes = conversor.converterListaTb(lst);
                return objetoRes;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPut("edit-tarefa/{idcategoria}/{idtarefa}")]
        public ActionResult<Models.Response.TarefasResponse> atualizartarefa(int idcategoria, int idtarefa, Models.Request.AtualizarTarefaRequest req){

            try{
                Business.AtualizarTarefaBusiness validar = new Business.AtualizarTarefaBusiness();
                Models.TbTarefa tarefa = validar.validaratualizacao(idcategoria, idtarefa, req);

                Models.Response.TarefasResponse res = conversor.converterTb(tarefa);
                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpDelete("delete-tarefa/{idcategoria}/{idtarefa}")]
        public ActionResult<Models.Response.SuccessResponse> apagarTarefa(int idcategoria, int idtarefa){

            try{
                Business.ApagarTarefaBusiness validacoes = new Business.ApagarTarefaBusiness();
                validacoes.deletartarefa(idtarefa, idcategoria);

                return new Models.Response.SuccessResponse("Deletado com sucesso!", 200);
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }
    }
}