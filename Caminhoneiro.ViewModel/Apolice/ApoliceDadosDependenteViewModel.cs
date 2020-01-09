using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.ViewModel.Apolice
{
    public class ApoliceDadosDependenteViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
    }
}
