using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Caminhoneiro.Entidade
{
    public class Produtos
    {
        public Produtos()
        {
            GetProdutos();
        }
        internal static List<ProdutoDTO> _Itens = null;
        public static List<ProdutoDTO> Itens() { return _Itens; }
        internal void GetProdutos()
        {
            var Vinculos = Sindicatos.Itens();
            _Itens = new List<ProdutoDTO>() { 
                new ProdutoDTO() {Id =1, Nome="RODOCARDMED", Cor="bg-gradient-blue", ValorPrincipal=89.90F, Valores = new List<float>(){89.90F}, Campanha="Global", CampanhaId=44 , Vinculo = Vinculos}
                //new ProdutoDTO() { Id = 2, Nome = "BASICO", Cor="bg-gradient-warning",ValorPrincipal = 60, Valores = new List<float>(){60, 80, 100}, Campanha = "Global", CampanhaId = 44 , Vinculo = Vinculos},
                //new ProdutoDTO() { Id = 3, Nome = "EMPRESA", Cor="bg-gradient-danger",ValorPrincipal = 120, Valores = new List<float>(){120, 90}, Campanha = "SEGMENTO1", CampanhaId = 1, Vinculo = Vinculos},
                //new ProdutoDTO() { Id = 4, Nome = "AVANCADO", Cor="bg-gradient-green", ValorPrincipal = 300, Valores = new List<float>(){300, 800, 500}, Campanha = "SEGMENTO2", CampanhaId = 2, Vinculo = Vinculos},
            };
        }
    }
}
