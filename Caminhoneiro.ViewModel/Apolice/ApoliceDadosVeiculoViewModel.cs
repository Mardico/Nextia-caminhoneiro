using System.ComponentModel.DataAnnotations;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceDadosVeiculoViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int AnoVeiculoId { get; set; }
        public int AnoVeiculo { get; set; }
        public int VeiculoID { get; set; }
        public string Veiculo { get; set; }
        public string Segurado { get; set; }
        public char SeguradoraId { get; set; }
        public string Seguradora { get; set; }
        public char VeiculoProprioId { get; set; }
        public string VeiculoProprio { get; set; }
        public int QdadeViagensId { get; set; }
        public string QdadeViagens { get; set; }
        public int? TipoEntregaId { get; set; }
        public string TipoEntrega { get; set; }
        public int RendaLiquidaId { get; set; }
        public string RendaLiquida { get; set; }
        public int? SolicitouServApolice { get; set; }
    }
}
