using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Caminhoneiro.ViewModel
{
    public class ApoliceViewModel
    {
        public  ApoliceViewModel()
        {
            this.DadosPagamento = new ApoliceDadosPagamentoViewModel();
            this.DadosProduto = new ApoliceDadosProdutoViewModel();
            this.DadosCliente = new ClienteViewModel();
            this.DadosDependente = new List<ApoliceDadosDependenteViewModel>();
            this.DadosVeiculo = new ApoliceDadosVeiculoViewModel();
            this.DadosBeneficiario= new List<ApoliceDadosBeneficiarioViewModel>();
        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Vinculo { get; set; }
        public int VinculoId { get; set; }
        public string Usuario { get; set; }
        public int UsuarioId { get; set; }
        public List<ApoliceDadosBeneficiarioViewModel> DadosBeneficiario { get; set; }
        public ApoliceDadosProdutoViewModel DadosProduto { get; set; }
        public int DadosProdutoId { get; set; }
        public ClienteViewModel DadosCliente { get; set; }
        public int DadosClienteId { get; set; }
        public List<ApoliceDadosDependenteViewModel> DadosDependente { get; set; }
        public int DadosVeiculoId { get; set; }
        public ApoliceDadosVeiculoViewModel DadosVeiculo { get; set; }
        public int DadosPagamentoId { get; set; }
        public int Endosso { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? DataInicio { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public ApoliceDadosPagamentoViewModel DadosPagamento { get; set; }
    }
}
