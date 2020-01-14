namespace Caminhoneiro.DTO
{
    public class ApoliceDadosProdutoDTO
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public int CampanhaId { get; set; }
        public string Campanha { get; set; }
        public float Valor { get; set; }
        public string Agente { get; set; }

    }
}
