using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class AtualizarContaBusiness
    {
        Database.UsuariosDatabase banco = new Database.UsuariosDatabase();
        Business.ValidarEmailBusiness validaremail = new ValidarEmailBusiness();

        public Models.TbUsuario validarupdate(int idconta, string email, string senha){

            Models.TbUsuario info = banco.buscarUserId(idconta);
            Models.TbUsuario user = banco.infoUser(email);

            if(info == null)
                throw new ArgumentException("Usuario não encontrado");

            if(user != null && user.IdUsuario != idconta)
                throw new ArgumentException("Este email já foi cadastrado");
                
            if(validaremail.ValidarEmail(email) == false)
                throw new ArgumentException("Este email é inválido");

            if(senha.Length < 8)
                throw new ArgumentException("A senha precisa ter no minímo 8 caracteres");
        
            Models.TbUsuario conta = banco.updateConta(idconta, email, senha);
            return conta;
        }   
    }
}