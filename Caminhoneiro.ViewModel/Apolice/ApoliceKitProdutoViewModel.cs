namespace Caminhoneiro.ViewModel
{
    public class ApoliceKitProdutoViewModel
    {
        public int ApoliceId { get; set; }
        public int UsuarioId { get; set; }
        public int EnviadoPorId { get; set; }
        public bool EnviarApolice { get; set; }
        public bool EnviarCartao { get; set; }
    }
}
