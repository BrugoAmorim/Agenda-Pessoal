using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Utils
{
    public class ContatosUtils
    {
        public Models.Response.ContatosResponse conversorTB(Models.TbContato req){

            Models.Response.ContatosResponse caixote = new Models.Response.ContatosResponse();

            caixote.idctt = req.IdContato;
            caixote.nome = req.NmContato;
            caixote.telefone = req.DsTelefone;
            caixote.celular = req.DsCelular;
            caixote.email = req.DsEmail;
            caixote.estado = req.DsEstado;
            caixote.cidade = req.DsCidade;
            caixote.anotacoes = req.DsNotas;

            return caixote;
        }

        public List<Models.Response.ContatosResponse> converterListaTB(List<Models.TbContato> req){

            List<Models.Response.ContatosResponse> lst = new List<Models.Response.ContatosResponse>();

            foreach(Models.TbContato item in req){

                lst.Add(conversorTB(item));
            }

            return lst;
        }

        public Models.TbContato converterRequest(Models.Request.ContatoRequest req, int iduser){

            Models.TbContato tb = new Models.TbContato();

            tb.NmContato = req.nome;
            tb.DsEmail = req.email;
            tb.DsCelular = req.celular;
            tb.DsTelefone = req.telefone;
            tb.DsEstado = req.estado;
            tb.DsCidade = req.cidade;
            tb.DsNotas = req.anotacoes;
            tb.IdUsuario = iduser;

            return tb;
        }
    }
}