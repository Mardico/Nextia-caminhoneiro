using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceDadosBeneficiarioViewModel
    {
        public string Nome { get; set; }
        public string NDocumento { get; set; }
        public DateTime DataNasc { get; set; }
        public string Sexo { get; set; }
        public int SexoId { get; set; }
        public int Parentescoid { get; set; }
        public string Parentesco { get; set; }
        public float Porcentagem { get; set; }
    }
}
