using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable
namespace backend.Business
{
    public class LoginBusiness
    {
        Database.UsuariosDatabase banco = new Database.UsuariosDatabase();

        public Models.TbUsuario validarUsuario(string userOrmail, string password){

            List<Models.TbUsuario> usuarios = banco.buscarUsuarios();
            Models.TbUsuario user = banco.infoUser(userOrmail);

            if(string.IsNullOrEmpty(userOrmail))
                throw new ArgumentException("Voce não informou seu usuário");

            if(string.IsNullOrEmpty(password))
                throw new ArgumentException("Voce nao informou sua senha");

            if(password.Length < 8)
                throw new ArgumentException("Senha inválida");

            if(usuarios.Any(x => x.NmUsuario == userOrmail || x.DsEmail == userOrmail) == false)
                throw new ArgumentException("Este usuário nao foi encontrado");

            if(user.DsSenha != password)
                throw new ArgumentException("Senha incorreta");

            return user;
        }
    }
}