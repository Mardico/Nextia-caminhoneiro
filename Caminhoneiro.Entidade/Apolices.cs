using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

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
            Random r = new Random();
            _Itens = new List<ApoliceDTO>();
            foreach (ClienteDTO oCliente in Clientes.Itens())
            {
                if (oCliente.CPF == "197.612.188-48")
                    continue;

                bool randombool = Convert.ToBoolean(r.Next(-1, 1));
                if (1 == 1)
                {
                    int randomNumber2 = r.Next(0, 9);
                    int randomNumber3 = r.Next(0, 2);
                    var oAgente = Usuarios.Itens()[r.Next(1, 11)];
                    ApoliceDadosProdutoDTO oProduto = ApoliceDadosProduto.Itens()[r.Next(0, 99)];
                    ApoliceDadosVeiculoDTO oVeiculo = ApoliceDadosVeiculo.Itens()[r.Next(0, 99)];
                    ApoliceDadosPagamentoDTO oPagamento = ApoliceDadosPagamento.Itens()[r.Next(0, 99)];
                    
                    List<ApoliceDadosDependenteDTO> oDependentes = new List<ApoliceDadosDependenteDTO>();
                    if (randomNumber2 > 0)
                        oDependentes = ApoliceDadosDependente.Itens().GetRange(r.Next(0, 90), r.Next(0, 4));
                    else
                        oDependentes = new List<ApoliceDadosDependenteDTO>();

                    List<ApoliceDadosBeneficiarioDTO> oBeneficiarios = new List<ApoliceDadosBeneficiarioDTO>();
                    if (randomNumber3 > 0)
                        oBeneficiarios = ApoliceDadosBeneficiario.Itens().GetRange(r.Next(1, 80), r.Next(0, 4));
                    else
                        oBeneficiarios = new List<ApoliceDadosBeneficiarioDTO>();
                    
                    string Codigo = new Random().Next(0, 99).ToString().PadLeft(8, '0');
                    ApoliceStatusDTO oStatus = ApoliceStatus.Itens()[r.Next(0, 4)];
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
                        DadosProdutoId = oProduto.ProdutoId,
                        DadosPagamentoId = oPagamento.Id,
                        DadosPagamento = oPagamento,
                        DadosVeiculoId = oVeiculo.Id,
                        DadosVeiculo = oVeiculo,
                        DadosCliente = oCliente,
                        DadosClienteId = oCliente.Id,
                        DadosDependente = oDependentes,
                        DadosBeneficiario = oBeneficiarios
                    });
                }
            }
        }
    }
}
