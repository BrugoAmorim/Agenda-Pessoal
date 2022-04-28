using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        Utils.ContatosUtils conversores = new Utils.ContatosUtils();

        [HttpGet("buscar-ctt/{idusuario}")]
        public ActionResult<List<Models.Response.ContatosResponse>> ctts(int idusuario){

            try{
                Business.BuscarContatosBusiness validar = new Business.BuscarContatosBusiness();

                List<Models.TbContato> lst = validar.seuscontatos(idusuario);
                List<Models.Response.ContatosResponse> res = conversores.converterListaTB(lst);

                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPost("novo-ctt/{idusuario}")]
        public ActionResult<Models.Response.ContatosResponse> inserircontato(Models.Request.ContatoRequest req, int idusuario){

            try{
                Business.NovoContatoBusiness validar = new Business.NovoContatoBusiness();

                Models.TbContato mod = validar.nvcontato(req, idusuario);
                Models.Response.ContatosResponse res = conversores.conversorTB(mod);

                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPut("editar-ctt/{idctt}")]
        public ActionResult<Models.Response.ContatosResponse> editarinfo(Models.Request.ContatoRequest informacoes, int idctt){

            try{
                Business.EditarContatoBusiness validar = new Business.EditarContatoBusiness();

                Models.TbContato caixote = validar.validarupdate(idctt, informacoes);
                Models.Response.ContatosResponse res = conversores.conversorTB(caixote);
                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpDelete("del-ctt/{idcontato}")]
        public ActionResult<string> apagarcontato(int idcontato){

            try{

                Business.ApagarContatoBusiness validar = new Business.ApagarContatoBusiness();
                validar.validardelete(idcontato);

                return "O contato foi deletado!";
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }
    }
}