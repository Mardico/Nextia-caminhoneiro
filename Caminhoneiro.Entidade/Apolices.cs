using Caminhoneiro.DTO.Apolice;
using Caminhoneiro.DTO.Cliente;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public static class Apolices
    {
        public static List<ApoliceDTO> GetApolices()
        {
            var retorno = new List<ApoliceDTO>();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = new Random().Next(0, 99);
                int randomNumber2 = new Random().Next(0, 5);
                var oAgente = Usuarios.GetUsuario()[randomNumber];
                ClienteDTO oCliente = Clientes.GetClientes()[randomNumber];
                ApoliceDadosProdutoDTO oProduto = ApoliceDadosProduto.ListaApoliceProdutos()[randomNumber];
                ApoliceDadosVeiculoDTO oVeiculo = ApoliceDadosVeiculo.ListaApoliceVeiculos()[randomNumber];
                ApoliceDadosPagamentoDTO oPagamento = ApoliceDadosPagamento.GetApoliceDadosPagamento()[randomNumber];
                List<ApoliceDadosDependenteDTO> oDependentes = new List<ApoliceDadosDependenteDTO>();
                if (randomNumber2 > 0)
                    oDependentes = ApoliceDadosDependente.ListaDependentes().GetRange(randomNumber, randomNumber + randomNumber2);

                string Codigo = new Random().Next(0, 99).ToString().PadLeft(8, '0');

                retorno.Add(new ApoliceDTO()
                {
                    Id = i,
                    Codigo = Codigo,
                    VinculoId = oAgente.Vinculos[0].Id,
                    Vinculo = oAgente.Vinculos[0].Nome,
                    Usuario = oAgente.Nome,
                    UsuarioId = oAgente.Id,
                    DadosProduto = oProduto,
                    DadosProdutoId = oProduto.Id,
                    DadosPagamentoId = oPagamento.Id,
                    DadosPagamento = oPagamento,
                    DadosVeiculoId = oVeiculo.Id,
                    DadosVeiculo = oVeiculo
                });
            }
            return retorno;
        }
    }
}
