using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriasController : ControllerBase
    {
        Utils.CategoriasUtils conversor = new Utils.CategoriasUtils();

        [HttpGet("buscar/{idusuario}")]
        public ActionResult<List<Models.Response.CategoriasResponse>> listarcategorias(int idusuario){

            try{
                Business.BuscarCategorias validar = new Business.BuscarCategorias();

                List<Models.TbCategoria> caixote = validar.validarbusca(idusuario);
                List<Models.Response.CategoriasResponse> res = conversor.converterLista(caixote);

                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPost("criar-categoria/{idusuario}")]
        public ActionResult<Models.Response.CategoriasResponse> novaCategoria(Models.Request.CategoriaRequest req, int idusuario){
            
            try{
                Business.SalvarCategorias validar = new Business.SalvarCategorias();
                Models.TbCategoria caixote = validar.conferircategoria(req, idusuario);

                Models.Response.CategoriasResponse res = conversor.converterTb(caixote);
                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpPut("editar-categoria/{idusuario}/{idcategoria}")]
        public ActionResult<Models.Response.CategoriasResponse> modificar(Models.Request.CategoriaRequest req, int idcategoria, int idusuario){

            try{
                Business.EditarCategoriaBusiness validar = new Business.EditarCategoriaBusiness();
                Models.TbCategoria obj = validar.confirmaredicoes(req, idcategoria, idusuario);

                Models.Response.CategoriasResponse res = conversor.converterTb(obj);
                return res;
            }
            catch(System.Exception msg){

                return new BadRequestObjectResult(
                    new Models.ErrorResponse(msg.Message, 400)
                );
            }
        }

        [HttpDelete("apagar-categoria/{idcategoria}")]
        public ActionResult<Models.Response.SuccessResponse> apagarcategoria(int idcategoria){

            try{
                Business.DeletarCategoria validar = new Business.DeletarCategoria();
                validar.confirmardelete(idcategoria);

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