using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UsuariosController : ControllerBase
    {
        Utils.UsuariosUtils conversor = new Utils.UsuariosUtils();

        [HttpPost("criar-conta")]
        public ActionResult<Models.Response.ContaResponse> novaConta(Models.Request.NovaContaRequest req){

            try
            {
                Business.CriarContaBusiness conferir = new Business.CriarContaBusiness();
                
                Models.TbUsuario caixote = conferir.Criarconta(req);
                Models.Response.ContaResponse res = conversor.converterTb(caixote);
                return res;
            }
            catch (System.Exception msg)
            {
                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpGet]
        public List<Models.TbUsuario> listar(){

            Models.agendaContext db = new Models.agendaContext();
            return db.TbUsuarios.ToList();
        }
    }
}