using Caminhoneiro.DTO.Cliente;
using System.Collections.Generic;

namespace Caminhoneiro.DTO.Apolice
{
    public class ApoliceDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Vinculo { get; set; }
        public int VinculoId { get; set; }
        public string Usuario { get; set; }
        public int UsuarioId { get; set; }
        public ApoliceDadosProdutoDTO DadosProduto { get; set; }
        public int DadosProdutoId { get; set; }
        public ClienteDTO DadosCliente { get; set; }
        public int DadosClienteId { get; set; }
        public List<ApoliceDadosDependenteDTO> DadosDependente { get; set; }
        public int DadosVeiculoId { get; set; }
        public ApoliceDadosVeiculoDTO DadosVeiculo { get; set; }
        public int DadosPagamentoId { get; set; }
        public int StatusId { get; set; }
        public ApoliceDadosPagamentoDTO DadosPagamento { get; set; }
    }
}
