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

        [HttpPost("login")]
        public ActionResult<Models.Response.ContaResponse> loginSistema(string userOrmail, string password){

            try
            {
                Business.LoginBusiness validarUser = new Business.LoginBusiness();

                Models.TbUsuario user = validarUser.validarUsuario(userOrmail, password);
                Models.Response.ContaResponse res = conversor.converterTb(user);
                return res;
            }
            catch (System.Exception msg)
            {
                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpDelete("apagar-conta/{idconta}")]
        public ActionResult<Models.Response.SuccessResponse> deletarconta(int idconta){

            try{

                Business.ExcluirContaBusiness validar = new Business.ExcluirContaBusiness();
                validar.validarconta(idconta);
            
                return new Models.Response.SuccessResponse("Deletado com sucesso", 200);
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPut("editar-conta/{idconta}")]
        public ActionResult<Models.Response.ContaResponse> atualizarInfo(int idconta, string email, string senha){

            try{
                Business.AtualizarContaBusiness validarUpt = new Business.AtualizarContaBusiness();
                Models.TbUsuario conta = validarUpt.validarupdate(idconta, email, senha);

                Models.Response.ContaResponse caixote = conversor.converterTb(conta);
                return caixote;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        // funcionalidade apenas para buscas, nao tera no sistema
        [HttpGet]
        public List<Models.TbUsuario> listar(){

            Models.agendaContext db = new Models.agendaContext();
            return db.TbUsuarios.ToList();
        }
    }
}