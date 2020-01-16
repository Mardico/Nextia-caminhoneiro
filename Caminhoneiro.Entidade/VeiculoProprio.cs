using Caminhoneiro.DTO;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public class VeiculoProprio
    {
        public VeiculoProprio()
        {
            GetVeiculosProprios();
        }
        internal static  List<TabelaApoioDTO> _Itens = null;
        public static List<TabelaApoioDTO> Itens() { return _Itens; }
        internal void GetVeiculosProprios()
        {
            _Itens =  new List<TabelaApoioDTO>() {
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="Próprio" },
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Fianciado"}
            };
        }
    }
}
