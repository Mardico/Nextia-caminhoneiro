using Caminhoneiro.DTO.Shared;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public static class VeiculoProprio
    {
        public static List<TabelaApoioDTO> GetVeiculosProprios()
        {
            return new List<TabelaApoioDTO>() {
                new TabelaApoioDTO() {Id =1, Codigo = "0001", Texto="Não Informado"},
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="Próprio" },
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Fianciado"}
            };
        }
    }
}
