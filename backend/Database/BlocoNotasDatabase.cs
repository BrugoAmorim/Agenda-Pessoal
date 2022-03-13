using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Database
{
    public class BlocoNotasDatabase
    {
        Models.agendaContext ctx = new Models.agendaContext();

        public List<Models.TbBlocoNotas> buscaranotacoes(){

            List<Models.TbBlocoNotas> caixote = ctx.TbBlocoNota.ToList();
            return caixote;
        }

        public Models.TbBlocoNotas adicionarbloco(Models.TbBlocoNotas req){

            ctx.TbBlocoNota.Add(req);
            ctx.SaveChanges();

            return req;
        }

        public Models.TbBlocoNotas buscararquivo(int id){

            Models.TbBlocoNotas obj = ctx.TbBlocoNota.FirstOrDefault(x => x.IdBlocoNota == id);
            return obj;
        }

        public Models.TbBlocoNotas confirmaralteracao(Models.Request.BlocodeNotasRequest req, int id){

            Models.TbBlocoNotas obj = ctx.TbBlocoNota.First(x => x.IdBlocoNota == id);

            obj.NmBloco = req.nome;
            obj.DsConteudo = req.texto;
            obj.DtAtualizado = DateTime.Now;

            ctx.SaveChanges();
            return obj;
        }

        public void excluir(int id){

            Models.TbBlocoNotas modelo = ctx.TbBlocoNota.First(x => x.IdBlocoNota == id);
            ctx.TbBlocoNota.Remove(modelo);
            ctx.SaveChanges();
        }
    }
}