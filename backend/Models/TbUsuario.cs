using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class TbUsuario
    {
        public TbUsuario()
        {
            TbBlocoNota = new HashSet<TbBlocoNotas>();
            TbCategoria = new HashSet<TbCategoria>();
            TbContatos = new HashSet<TbContato>();
        }

        public int IdUsuario { get; set; }
        public string NmUsuario { get; set; }
        public string DsEmail { get; set; }
        public string DsSenha { get; set; }
        public DateTime DtCriacao { get; set; }

        public virtual ICollection<TbBlocoNotas> TbBlocoNota { get; set; }
        public virtual ICollection<TbCategoria> TbCategoria { get; set; }
        public virtual ICollection<TbContato> TbContatos { get; set; }
    }
}
