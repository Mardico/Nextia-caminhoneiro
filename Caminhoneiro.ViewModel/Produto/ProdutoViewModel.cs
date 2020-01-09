namespace Caminhoneiro.ViewModel.Produto
{
    public class ProdutoModel
    {
        public int Id { get; set; }
        public int CampanhaId { get; set; }
        public string Campanha { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
    }
}