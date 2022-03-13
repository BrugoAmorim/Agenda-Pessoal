using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlocoNotasController : ControllerBase
    {
        Utils.BlocoNotasUtils conversor = new Utils.BlocoNotasUtils();

        [HttpGet("buscar")]
        public ActionResult<List<Models.Response.NotasResponse>> listartextos(){

            try{
                Business.LerBlocoNotasBusiness regras = new Business.LerBlocoNotasBusiness();
                List<Models.TbBlocoNotas> lst = regras.validarconsulta();

                List<Models.Response.NotasResponse> res = conversor.converterlistaTb(lst);
                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPost("adicionar-bloco")]
        public ActionResult<Models.Response.NotasResponse> salvarbloco(Models.Request.BlocodeNotasRequest req){

            try{
                Business.SalvarBlocoNotasBusiness validar = new Business.SalvarBlocoNotasBusiness();

                Models.TbBlocoNotas tb = validar.validarinsert(req);
                Models.Response.NotasResponse res = conversor.converterTB(tb);

                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPut("editar-bloco/{idtexto}")]
        public ActionResult<Models.Response.NotasResponse> editartexto(int idtexto, Models.Request.BlocodeNotasRequest req){

            try{
                Business.EditarBlocoNotasBusiness validar = new Business.EditarBlocoNotasBusiness();
                Models.TbBlocoNotas tb = validar.validarupdate(req, idtexto);

                Models.Response.NotasResponse res = conversor.converterTB(tb);
                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }
    }
}