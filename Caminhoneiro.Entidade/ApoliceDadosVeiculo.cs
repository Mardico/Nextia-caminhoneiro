using Caminhoneiro.DTO.Apolice;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public static class ApoliceDadosVeiculo
    {
        public static List<ApoliceDadosVeiculoDTO> ListaApoliceVeiculos()
        {
            var retorno = new List<ApoliceDadosVeiculoDTO>();
            for (int i = 0; i < 100; i++)
            {
                int SeguradoraId = 0;
                bool Segurado = Convert.ToBoolean(new Random().Next(0, 1));
                if (Segurado) {
                    SeguradoraId = Seguradoras.GetSeguradoras()[new Random().Next(0, 99)].Id;
                }
                int VeiculoProprioId = new Random().Next(1, 2);
                int QdadeViagensId = new Random().Next(0, 4);
                int TipoEntregaId = new Random().Next(0, 2);
                int RendaLiquidaId =  new Random().Next(0, 3);
                var oVeiculo = Veiculos.GetVeiculos()[new Random().Next(1, 15)];
                bool SolicitouServApolice = Convert.ToBoolean(new Random().Next(0, 1));
                retorno.Add(new ApoliceDadosVeiculoDTO() { Id = i, Codigo =oVeiculo.Codigo, VeiculoID = oVeiculo.Id, QdadeViagensId = QdadeViagensId, VeiculoProprioId = VeiculoProprioId, RendaLiquidaId = RendaLiquidaId, Segurado =Segurado, SeguradoraId = SeguradoraId, TipoEntregaId =TipoEntregaId, SolicitouServApolice = SolicitouServApolice  });
            }
            return retorno;
        }
    }
}
