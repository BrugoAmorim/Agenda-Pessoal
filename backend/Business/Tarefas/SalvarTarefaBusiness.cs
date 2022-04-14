using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Business
{
    public class SalvarTarefaBusiness
    {
        Database.TarefasDatabase bancotarefa = new Database.TarefasDatabase();
        Database.CategoriasDatabase bancocategoria = new Database.CategoriasDatabase();
        public Models.TbTarefa validarinsert(Models.Request.TarefasRequest req, int id){

            Models.TbCategoria caixote = bancocategoria.buscarobjid(id);

            if(caixote == null)
                throw new ArgumentException("Nao encontramos esta categoria");

            if(req.prioridade != 1 && req.prioridade != 2 && req.prioridade != 3 && req.prioridade != 4 && req.prioridade != 5)
                throw new ArgumentException("Nível de prioridade inválido");

            if(string.IsNullOrEmpty(req.tarefa))
                throw new ArgumentException("Voce nao pode criar uma tarefa sem dizer qual é a tarefa");

            Models.TbTarefa obj = bancotarefa.inserir(req, id);
            return obj;   
        }
    }
}