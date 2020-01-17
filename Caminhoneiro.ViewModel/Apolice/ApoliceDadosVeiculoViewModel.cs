namespace Caminhoneiro.ViewModel
{
    public class ApoliceDadosVeiculoViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int VeiculoID { get; set; }
        public string Veiculo { get; set; }
        public bool Segurado { get; set; }
        public int SeguradoraId { get; set; }
        public string Seguradora { get; set; }
        public int VeiculoProprioId { get; set; }
        public string VeiculoProprio { get; set; }
        public int QdadeViagensId { get; set; }
        public string QdadeViagens { get; set; }
        public int? TipoEntregaId { get; set; }
        public string TipoEntrega { get; set; }
        public int RendaLiquidaId { get; set; }
        public string RendaLiquida { get; set; }
        public bool SolicitouServApolice { get; set; }
    }
}
