using System;
using System.Collections.Generic;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceViewModel
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Vinculo { get; set; }
        public int VinculoId { get; set; }
        public string Usuario { get; set; }
        public int UsuarioId { get; set; }
        public ApoliceDadosProdutoViewModel DadosProduto { get; set; }
        public int DadosProdutoId { get; set; }
        public ClienteViewModel DadosCliente { get; set; }
        public int DadosClienteId { get; set; }
        public List<ApoliceDadosDependenteViewModel> DadosDependente { get; set; }
        public int DadosVeiculoId { get; set; }
        public ApoliceDadosVeiculoViewModel DadosVeiculo { get; set; }
        public int DadosPagamentoId { get; set; }
        public int Endosso { get; set; }
        public DateTime DataInicio { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public ApoliceDadosPagamentoViewModel DadosPagamento { get; set; }
    }
}
