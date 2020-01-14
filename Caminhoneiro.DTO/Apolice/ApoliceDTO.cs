using System;
using System.Collections.Generic;

namespace Caminhoneiro.DTO
{
    public class ApoliceDTO
    {
        public ApoliceDTO()
        {
            this.DadosPagamento = new ApoliceDadosPagamentoDTO();
            this.DadosProduto = new ApoliceDadosProdutoDTO();
            this.DadosCliente = new ClienteDTO();
            this.DadosDependente = new List<ApoliceDadosDependenteDTO>();
            this.DadosVeiculo = new ApoliceDadosVeiculoDTO();
            this.DadosBeneficiario = new List<ApoliceDadosBeneficiarioDTO>();

        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Vinculo { get; set; }
        public int VinculoId { get; set; }
        public string Usuario { get; set; }
        public int UsuarioId { get; set; }
        public List<ApoliceDadosBeneficiarioDTO> DadosBeneficiario { get; set; }
        public ApoliceDadosProdutoDTO DadosProduto { get; set; }
        public int DadosProdutoId { get; set; }
        public ClienteDTO DadosCliente { get; set; }
        public int DadosClienteId { get; set; }
        public List<ApoliceDadosDependenteDTO> DadosDependente { get; set; }
        public int DadosVeiculoId { get; set; }
        public ApoliceDadosVeiculoDTO DadosVeiculo { get; set; }
        public int DadosPagamentoId { get; set; }
        public int Endosso { get; set; }
        public DateTime DataInicio { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public ApoliceDadosPagamentoDTO DadosPagamento { get; set; }
    }
}
