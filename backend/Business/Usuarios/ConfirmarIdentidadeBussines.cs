using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class ConfirmarIdentidadeBussines
    {
        
        Database.UsuariosDatabase banco = new Database.UsuariosDatabase();

        public Models.TbUsuario validarIdentidade(int idconta, string senha)
        {
            Models.TbUsuario user = banco.buscarUserId(idconta);

            if(user == null)
                throw new ArgumentException("Este usuário não foi encontrado");

            if(user.DsSenha != senha)
                throw new ArgumentException("Senha incorreta");

            return user;
        }
    }
}