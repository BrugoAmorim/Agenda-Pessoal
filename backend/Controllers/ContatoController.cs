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

        [HttpGet("buscar-ctt")]
        public ActionResult<List<Models.Response.ContatosResponse>> ctts(){

            try{
                Business.BuscarContatosBusiness validar = new Business.BuscarContatosBusiness();

                List<Models.TbContato> lst = validar.seuscontatos();
                List<Models.Response.ContatosResponse> res = conversores.converterListaTB(lst);

                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPost("novo-ctt")]
        public ActionResult<Models.Response.ContatosResponse> inserircontato(Models.Request.ContatoRequest req){

            try{
                Business.NovoContatoBusiness validar = new Business.NovoContatoBusiness();

                Models.TbContato mod = validar.nvcontato(req);
                Models.Response.ContatosResponse res = conversores.conversorTB(mod);

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