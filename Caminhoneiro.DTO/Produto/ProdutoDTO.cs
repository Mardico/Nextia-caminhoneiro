using System.Collections.Generic;

namespace Caminhoneiro.DTO
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Codigo { 
            get { 
                return Id.ToString().PadLeft(4, '0'); 
            } 
        }
        public string Cor { get; set; }
        public int CampanhaId { get; set; }
        public string Campanha { get; set; }
        public string Nome { get; set; }
        public float ValorPrincipal { get; set; }
        public List<float> Valores { get; set; }
        public int VinculoID { get; set; }
        public List<TabelaApoioDTO> Vinculo { get; set; }
    }
}