using Caminhoneiro.DTO;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public class QdadeViagens
    {
        public QdadeViagens()
        {
            GetViagens();
        }

        internal static List<TabelaApoioDTO> _Itens = null;
        public static List<TabelaApoioDTO> Itens() { return _Itens; }

        internal void GetViagens()
        {
            _Itens = new List<TabelaApoioDTO>() {
                new TabelaApoioDTO() {Id =1, Codigo = "0001", Texto="Até 5"},
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="5 a 10" },
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Acima de 10" }
            };
        }
    }
}
