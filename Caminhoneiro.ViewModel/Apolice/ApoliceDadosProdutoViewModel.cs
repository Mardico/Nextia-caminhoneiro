using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.ViewModel.Apolice
{
    public class ApoliceDadosProdutoViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int CampanhaID { get; set; }
        public float Valor { get; set; }
        public string Agente { get; set; }

    }
}
