using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Utils
{
    public class UsuariosUtils
    {
        public Models.TbUsuario converterReq(Models.Request.NovaContaRequest req){

            Models.TbUsuario user = new Models.TbUsuario();
            user.NmUsuario = req.usuario;
            user.DsEmail = req.email;
            user.DsSenha = req.senha;
            user.DtCriacao = DateTime.Now;

            return user;
        }   

        public Models.Response.ContaResponse converterTb(Models.TbUsuario tb){

            Models.Response.ContaResponse caixa = new Models.Response.ContaResponse();
            caixa.iduser = tb.IdUsuario;
            caixa.email = tb.DsEmail;
            caixa.usuario = tb.NmUsuario;
            caixa.senha = tb.DsSenha;
            caixa.criado = tb.DtCriacao;

            return caixa;
        }
    }
}