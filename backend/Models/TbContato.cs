using System;
using System.Collections.Generic;

#nullable disable

namespace backend.Models
{
    public partial class TbContato
    {
        public int IdContato { get; set; }
        public string NmContato { get; set; }
        public string DsCelular { get; set; }
        public string DsTelefone { get; set; }
        public string DsEmail { get; set; }
        public string DsCidade { get; set; }
        public string DsEstado { get; set; }
        public string DsNotas { get; set; }
    }
}
