using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#nullable disable

namespace backend.Database
{
    public class ContatosDatabase
    {
        Models.agendaContext ctx = new Models.agendaContext();
        Utils.ContatosUtils conversor = new Utils.ContatosUtils();

        public List<Models.TbContato> listacontatos(int iduser){

            List<Models.TbContato> res = ctx.TbContatos.Where(x => x.IdUsuario == iduser).ToList();
            return res;
        }

        public Models.TbContato inserircontato(Models.Request.ContatoRequest req, int id){

            Models.TbContato mod = conversor.converterRequest(req, id);

            ctx.TbContatos.Add(mod);
            ctx.SaveChanges();

            return mod;
        }

        public Models.TbContato validarcontato(int id){

            Models.TbContato ctt = ctx.TbContatos.FirstOrDefault(x => x.IdContato == id);
            return ctt;
        }

        public Models.TbContato atualizarinfo(Models.Request.ContatoRequest obj, int id){

            Models.TbContato modelo = ctx.TbContatos.First(x => x.IdContato == id);
            modelo.DsCelular = obj.celular;
            modelo.DsCidade = obj.cidade;
            modelo.NmContato = obj.nome;
            modelo.DsTelefone = obj.telefone;
            modelo.DsEstado = obj.estado;
            modelo.DsEmail = obj.email;
            modelo.DsNotas = obj.anotacoes;

            ctx.SaveChanges();

            return modelo;
        }

        public void delete(int id){

            Models.TbContato modelo = ctx.TbContatos.First(x => x.IdContato == id);

            ctx.TbContatos.Remove(modelo);
            ctx.SaveChanges(); 
        }
    }
}