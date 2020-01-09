using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.ViewModel.Apolice
{
    public class ApoliceDadosVeiculoViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int VeiculoID { get; set; }
        public bool Segurado { get; set; }
        public int SeguradoraId { get; set; }
        public int VeiculoProprioId { get; set; }
        public int QdadeViagensId { get; set; }
        public int TipoEntregaId { get; set; }
        public int RendaLiquidaId { get; set; }
        public bool SolicitouServApolice { get; set; }
    }
}
