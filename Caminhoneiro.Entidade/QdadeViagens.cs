using Caminhoneiro.DTO.Shared;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public static class QdadeViagens
    {
        public static List<TabelaApoioDTO> GetViagens()
        {
            return new List<TabelaApoioDTO>() {
                new TabelaApoioDTO() {Id =0, Codigo = "0000", Texto="Não Informado"},
                new TabelaApoioDTO() {Id =1, Codigo = "0001", Texto="Até 5"},
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="5 a 10" },
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Acima de 10" }
            };
        }
    }
}
