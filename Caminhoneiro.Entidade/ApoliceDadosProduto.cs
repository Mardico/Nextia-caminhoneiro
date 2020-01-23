using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    public class ApoliceDadosProduto
    {
        public ApoliceDadosProduto()
        {
            ListaApoliceProdutos();
        }
        public static List<ApoliceDadosProdutoDTO> _Itens = null;
        public static List<ApoliceDadosProdutoDTO> Itens() { return _Itens; }
        internal void ListaApoliceProdutos()
        {
            Random r = new Random();
            _Itens = new List<ApoliceDadosProdutoDTO>();
            for (int i = 0; i < 100; i++)
            {
                var oAgente = Usuarios.Itens()[r.Next(1, 11)];
                var oProduto = Produtos.Itens()[0];
                _Itens.Add(new ApoliceDadosProdutoDTO() { Id = i, Agente = oAgente.Nome, CampanhaId = oProduto.CampanhaId, Campanha= oProduto.Campanha, ProdutoId = oProduto.Id, Valor = oProduto.ValorPrincipal, Codigo = oProduto.Codigo, Nome = oProduto.Nome });
            }
        }
    }
}
