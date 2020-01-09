using Caminhoneiro.DTO.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Caminhoneiro.Entidade
{
    public static class Produtos
    {
        public static List<ProdutoDTO> GetProdutos()
        {
            var Vinculos = Sindicatos.GetSindicatos();
            return new List<ProdutoDTO>() { 
                new ProdutoDTO() {Id =1, Nome="RODOMAX", Valor=89, Campanha="Global", CampanhaId=44 , Vinculo = Vinculos}, 
                new ProdutoDTO() { Id = 2, Nome = "BASICO", Valor = 60, Campanha = "Global", CampanhaId = 44 , Vinculo = Vinculos},
                new ProdutoDTO() { Id = 3, Nome = "EMPRESA", Valor = 120, Campanha = "SEGMENTO1", CampanhaId = 1, Vinculo = Vinculos},
                new ProdutoDTO() { Id = 4, Nome = "AVANCADO", Valor = 300, Campanha = "SEGMENTO2", CampanhaId = 2, Vinculo = Vinculos},
            };
        }
    }
}
