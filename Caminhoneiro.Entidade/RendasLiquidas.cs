using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.Entidade
{
    public class RendasLiquidas
    {
        public RendasLiquidas()
        {
            GetRendas();
        }
        internal static List<TabelaApoioDTO> _Itens = null;
        public static List<TabelaApoioDTO> Itens() { return _Itens; }
        internal void GetRendas()
        {
            _Itens = new List<TabelaApoioDTO>() {
                new TabelaApoioDTO() {Id =1, Codigo = "0001", Texto="Até R$ 5.000,00"},
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="De R$ 5.001,00 a R$ 10.000,00" },
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Acima de R$ 10.000,00" }
            };
        }
    }
}
