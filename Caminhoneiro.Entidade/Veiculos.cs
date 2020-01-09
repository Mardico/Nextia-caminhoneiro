using Caminhoneiro.DTO.Shared;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public static class Veiculos
    {
        public static List<TabelaApoioDTO> GetVeiculos()
        {
            return new List<TabelaApoioDTO>() {
                new TabelaApoioDTO() {Id =1, Codigo = "0001", Texto="Volks 24250"},
                new TabelaApoioDTO() { Id = 2, Codigo = "0002", Texto="Volks 8150" },
                new TabelaApoioDTO() { Id = 3, Codigo = "0003", Texto="Mercedes 710"},
                new TabelaApoioDTO() { Id = 4, Codigo = "0004", Texto="Volvo-FH 460"},
                new TabelaApoioDTO() { Id = 5, Codigo = "0005", Texto="Scania 1313"},
                new TabelaApoioDTO() { Id = 6, Codigo = "0006", Texto="Scania 123"},
                new TabelaApoioDTO() { Id = 7, Codigo = "0007", Texto="GMC + Isuzu 190/220"},
                new TabelaApoioDTO() { Id = 8, Codigo = "0008", Texto="MB 1929, Teresona"},
                new TabelaApoioDTO() { Id = 9, Codigo = "0009", Texto="Ford – Sapão F14000"},
                new TabelaApoioDTO() { Id = 10, Codigo = "0010", Texto="VW 25370 Constellation"},
                new TabelaApoioDTO() { Id = 11, Codigo = "0011", Texto="Iveco 190"},
                new TabelaApoioDTO() { Id = 12, Codigo = "0012", Texto="Volvo 280"},
                new TabelaApoioDTO() { Id = 13, Codigo = "0013", Texto="MB 1928"},
                new TabelaApoioDTO() { Id = 14, Codigo = "0014", Texto="Alfa Romeu FNM"},
                new TabelaApoioDTO() { Id = 15, Codigo = "0015", Texto="MB 180"}
            };
        }
    }
}
