using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class TbBlocoNotas
    {
        public int IdBlocoNota { get; set; }
        public string NmBloco { get; set; }
        public string DsConteudo { get; set; }
        public DateTime DtCriacao { get; set; }
        public DateTime DtAtualizado { get; set; }
    }
}
