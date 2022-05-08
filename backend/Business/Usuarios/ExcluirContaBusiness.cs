using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class ExcluirContaBusiness
    {
        Database.UsuariosDatabase banco = new Database.UsuariosDatabase();
        public void validarconta(int idconta){

            Models.TbUsuario user = banco.buscarUserId(idconta);

            if(user == null)
                throw new ArgumentException("Usuario não encontrado");

            banco.excluirconta(idconta);
        }
    }
}