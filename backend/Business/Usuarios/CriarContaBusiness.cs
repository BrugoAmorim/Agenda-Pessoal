using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace backend.Business
{
    public class CriarContaBusiness
    {
        Database.UsuariosDatabase banco = new Database.UsuariosDatabase();
        Business.ValidarEmailBusiness validarEmail = new Business.ValidarEmailBusiness();
        Utils.UsuariosUtils conversor = new Utils.UsuariosUtils();
        
        public Models.TbUsuario Criarconta(Models.Request.NovaContaRequest req){

            List<Models.TbUsuario> usuarios = banco.buscarUsuarios();
            Models.Request.NovaContaRequest xx = req;

            if(usuarios.Any(x => x.DsEmail == req.email) == true)
                throw new ArgumentException("Já criaram uma conta utilizando este email, por favor tente outro");
            
            if(usuarios.Any(x => x.NmUsuario == req.usuario) == true)
                throw new ArgumentException("Esse nome já esta sendo utilizando, por favor tente outro");

            if(req.senha.Length < 8)
                throw new ArgumentException("Não é permitido senhas com menos de 8 digítos");

            if(string.IsNullOrEmpty(req.email))
                throw new ArgumentException("É necessario inserir um email");            

            if(string.IsNullOrEmpty(req.usuario))
                throw new ArgumentException("É necessario inserir um nome de usuario");

            if(req.usuario.Length < 6 || req.usuario.Contains(" "))
                throw new ArgumentException("Este nome de usuario é inválido!");

            if(validarEmail.ValidarEmail(req.email) == false)
                throw new ArgumentException("Este email é inválido!");

            Models.TbUsuario caixote = banco.salvar(conversor.converterReq(req));
            return caixote;
        }
    }
}