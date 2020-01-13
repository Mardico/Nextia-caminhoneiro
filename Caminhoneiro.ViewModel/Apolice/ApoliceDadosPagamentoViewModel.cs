using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceDadosPagamentoViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int MeioPgtoId { get; set; }
        public string Conta { get; set; }
        public string NomeResponsavel { get; set; }
        public DateTime DataExpiracao { get; set; }
        public string CVV { get; set; }
        public int NParcelasId { get; set; }
    }
}
