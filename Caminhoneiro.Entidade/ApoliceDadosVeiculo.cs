using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public class ApoliceDadosVeiculo
    {
        public ApoliceDadosVeiculo()
        {
            ListaApoliceVeiculos();
        }
        public static List<ApoliceDadosVeiculoDTO> _Itens = null;
        public static List<ApoliceDadosVeiculoDTO> Itens() { return _Itens; }
        internal void ListaApoliceVeiculos()
        {
            _Itens = new List<ApoliceDadosVeiculoDTO>();
            for (int i = 0; i < 100; i++)
            {
                int SeguradoraId = 0;
                string SeguradoraNome = "";
                bool Segurado = Convert.ToBoolean(new Random().Next(-1, 1));
                if (Segurado) {
                    var oSeguradora = Seguradoras.Itens()[new Random().Next(0, 99)];
                    SeguradoraId = oSeguradora.Id;
                    SeguradoraNome = oSeguradora.Texto;
                }
                TabelaApoioDTO oVeiculoProprio = VeiculoProprio.Itens()[ new Random().Next(1, 2)];
                TabelaApoioDTO oQdadeViagens = QdadeViagens.Itens()[ new Random().Next(0, 4)];
                int TipoEntregaId = new Random().Next(0, 2);
                TabelaApoioDTO oRendaLiquida = RendasLiquidas.Itens()[new Random().Next(0, 3)];
                var oVeiculo = Veiculos.Itens()[new Random().Next(1, 15)];
                bool SolicitouServApolice = Convert.ToBoolean(new Random().Next(-1, 1));
                _Itens.Add(new ApoliceDadosVeiculoDTO() { Id = i, Codigo = oVeiculo.Codigo, 
                    VeiculoID = oVeiculo.Id, Veiculo= oVeiculo.Texto, 
                    QdadeViagensId = oQdadeViagens.Id, QdadeViagens = oQdadeViagens.Texto, 
                    VeiculoProprioId = oVeiculoProprio.Id, VeiculoProprio = oVeiculoProprio.Texto, 
                    RendaLiquidaId = oRendaLiquida.Id, RendaLiquida = oRendaLiquida.Texto,
                    Segurado =Segurado, 
                    SeguradoraId = SeguradoraId, Seguradora = SeguradoraNome,
                    TipoEntregaId =TipoEntregaId, 
                    TipoEntrega = (TipoEntregaId==1)?"Municipal":"Estadual",
                    SolicitouServApolice = SolicitouServApolice  });
            }
        }
    }
}
