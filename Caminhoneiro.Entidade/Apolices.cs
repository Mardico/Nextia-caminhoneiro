using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public class Apolices
    {
        public Apolices()
        {
            GetApolices();
        }
        internal static List<ApoliceDTO> _Itens = null;
        public static List<ApoliceDTO> Itens() { return _Itens; }
        internal void GetApolices()
        {
            _Itens = new List<ApoliceDTO>();
            foreach (ClienteDTO oCliente in Clientes.Itens())
            {
                bool randombool = Convert.ToBoolean(new Random().Next(-1, 1));
                if (1==1)
                {
                    int randomNumber2 = new Random().Next(0, 5);
                    var oAgente = Usuarios.Itens()[new Random().Next(1, 11)];
                    ApoliceDadosProdutoDTO oProduto = ApoliceDadosProduto.Itens()[new Random().Next(0, 99)];
                    ApoliceDadosVeiculoDTO oVeiculo = ApoliceDadosVeiculo.Itens()[new Random().Next(0, 99)];
                    ApoliceDadosPagamentoDTO oPagamento = ApoliceDadosPagamento.Itens()[new Random().Next(0, 99)];
                    List<ApoliceDadosDependenteDTO> oDependentes = new List<ApoliceDadosDependenteDTO>();
                    if (randomNumber2 > 0)
                        oDependentes = ApoliceDadosDependente.Itens().GetRange(new Random().Next(0, 90), new Random().Next(0, 4));
                    else
                        oDependentes = new List<ApoliceDadosDependenteDTO>();
                    string Codigo = new Random().Next(0, 99).ToString().PadLeft(8, '0');
                    ApoliceStatusDTO oStatus = ApoliceStatus.Itens()[new Random().Next(1, 5)];
                    DateTime dataini = new DateTime();
                    DateTime start = new DateTime(1995, 1, 1);
                    _Itens.Add(new ApoliceDTO()
                    {
                        Id = oCliente.Id + 100,
                        Codigo = Codigo,
                        VinculoId = oAgente.Vinculos[0].Id,
                        Vinculo = oAgente.Vinculos[0].Nome,
                        Usuario = oAgente.Nome,
                        UsuarioId = oAgente.Id,
                        Endosso = randomNumber2,
                        StatusId = oStatus.Id,
                        Status = oStatus.Nome,
                        DataInicio = dataini.AddDays(new Random().Next((DateTime.Today - start).Days)),
                        DadosProduto = oProduto,
                        DadosProdutoId = oProduto.Id,
                        DadosPagamentoId = oPagamento.Id,
                        DadosPagamento = oPagamento,
                        DadosVeiculoId = oVeiculo.Id,
                        DadosVeiculo = oVeiculo,
                        DadosCliente = oCliente,
                        DadosClienteId = oCliente.Id,
                        DadosDependente = oDependentes
                    });
                }
            }
        }
    }
}
