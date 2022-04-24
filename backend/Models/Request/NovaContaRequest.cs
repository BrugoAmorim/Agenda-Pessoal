using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models.Request
{
    public class NovaContaRequest
    {
        public string usuario { get;set; }
        public string email { get;set; }
        public string senha { get;set; }
    }   
}