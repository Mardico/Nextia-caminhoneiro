using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Caminhoneiro.Models.Login
{
    public class RetornoLoginModel
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string token { get; set; }
        public List<EmpresaS> empressas { get; set; }

    }

    public class EmpresaS
    {
        public string codigo { get; set; }
        public string nome { get; set; }

    }
}