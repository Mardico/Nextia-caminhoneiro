using Caminhoneiro.DTO.Shared;
using System.Collections.Generic;

namespace Caminhoneiro.DTO.Produto
{
    public class ProdutoDTO
    {
        public int Id { get; set; }
        public string Codigo { 
            get { 
                return Id.ToString().PadLeft(4, '0'); 
            } 
        }
        public int CampanhaId { get; set; }
        public string Campanha { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }

        public int VinculoID { get; set; }
        public List<TabelaApoioDTO> Vinculo { get; set; }
    }
}