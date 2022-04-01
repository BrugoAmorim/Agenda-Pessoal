using System;
using System.Collections.Generic;

#nullable disable
namespace backend.Models
{
    public partial class TbTarefa
    {
        public int IdTarefa { get; set; }
        public string DsTarefa { get; set; }
        public bool BlConcluida { get; set; }
        public int VlPrioridade { get; set; }
        public DateTime DtAdicionado { get; set; }
        public int IdCategoria { get; set; }

        public virtual TbCategoria IdCategoriaNavigation { get; set; }
    }
}
