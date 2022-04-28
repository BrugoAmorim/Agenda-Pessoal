using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Utils
{
    public class BlocoNotasUtils
    {
        public Models.Response.NotasResponse converterTB(Models.TbBlocoNotas req){

            Models.Response.NotasResponse res = new Models.Response.NotasResponse();

            res.idnotas = req.IdBlocoNota;
            res.nome = req.NmBloco;
            res.texto = req.DsConteudo;
            res.criado = req.DtCriacao;
            res.atualizado = req.DtAtualizado;

            return res;
        }

        public List<Models.Response.NotasResponse> converterlistaTb(List<Models.TbBlocoNotas> req){

            List<Models.Response.NotasResponse> caixote = new List<Models.Response.NotasResponse>();

            foreach(Models.TbBlocoNotas item in req){

                caixote.Add(converterTB(item));
            };

            return caixote;
        } 

        public Models.TbBlocoNotas converterReq(Models.Request.BlocodeNotasRequest req, int iduser){

            Models.TbBlocoNotas tb = new Models.TbBlocoNotas();

            tb.DsConteudo = req.texto;
            tb.NmBloco = req.nome;
            tb.DtCriacao = DateTime.Now;
            tb.DtAtualizado = DateTime.Now;
            tb.IdUsuario = iduser;

            return tb;
        }
    
    }
}