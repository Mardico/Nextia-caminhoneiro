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
            Random r = new Random();
            _Itens = new List<ApoliceDadosVeiculoDTO>();
            for (int i = 0; i < 100; i++)
            {
                int SeguradoraId = 0;
                string SeguradoraNome = "";
                bool Segurado = Convert.ToBoolean(r.Next(-1, 1));
                if (Segurado) {
                    var oSeguradora = Seguradoras.Itens()[r.Next(0, 1)];
                    SeguradoraId = oSeguradora.Id;
                    SeguradoraNome = oSeguradora.Texto;
                }
                TabelaApoioDTO oVeiculoProprio = VeiculoProprio.Itens()[r.Next(0, 1)];
                TabelaApoioDTO oQdadeViagens = QdadeViagens.Itens()[r.Next(1, 3)];
                int TipoEntregaId = r.Next(0, 2);
                TabelaApoioDTO oRendaLiquida = RendasLiquidas.Itens()[r.Next(1, 3)];
                var oVeiculo = Veiculos.Itens()[r.Next(1, 15)];
                bool SolicitouServApolice = Convert.ToBoolean(r.Next(-1, 1));
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
