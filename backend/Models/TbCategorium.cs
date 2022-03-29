using System;
using System.Collections.Generic;

#nullable disable
namespace backend.Models
{
    public partial class TbCategoria
    {
        public TbCategoria()
        {
            TbTarefas = new HashSet<TbTarefa>();
        }

        public int IdCategoria { get; set; }
        public string NmCategoria { get; set; }
        public string DsCategoria { get; set; }

        public virtual ICollection<TbTarefa> TbTarefas { get; set; }
    }
}
