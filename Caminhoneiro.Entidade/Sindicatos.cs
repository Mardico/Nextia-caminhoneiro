using Caminhoneiro.DTO.Shared;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public static class Sindicatos
    {
        public static List<TabelaApoioDTO> GetSindicatos()
        {
            return new List<TabelaApoioDTO>() {
                new TabelaApoioDTO() {Id =1, Codigo = "0001", Texto="Sem Sindicato"},
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="Sindicato 01"},
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Sindicato 02"},
                new TabelaApoioDTO() { Id = 4, Codigo = "0004", Texto="Sindicato 03"},
                new TabelaApoioDTO() { Id = 5, Codigo = "0005", Texto="Sindicato 04"},
                new TabelaApoioDTO() { Id = 6, Codigo = "0006", Texto="Sindicato 05"},
                new TabelaApoioDTO() { Id = 7, Codigo = "0007", Texto="Sindicato 06"}
            };
        }
    }
}
