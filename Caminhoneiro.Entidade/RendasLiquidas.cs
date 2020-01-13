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
                new TabelaApoioDTO() {Id =0, Codigo = "0000", Texto="Não Informado"},
                new TabelaApoioDTO() {Id =1, Codigo = "0001", Texto="Até 5000"},
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="De 5001 até 10000" },
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Acima 10000" }
            };
        }
    }
}
