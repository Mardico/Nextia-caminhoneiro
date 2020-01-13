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
            _Itens = new List<ApoliceDadosProdutoDTO>();
            for (int i = 0; i < 100; i++)
            {
                var oAgente = Usuarios.Itens()[new Random().Next(1, 11)];
                var oProduto = Produtos.Itens()[new Random().Next(1, 4)];
                _Itens.Add(new ApoliceDadosProdutoDTO() { Id = i, Agente = oAgente.Nome, CampanhaId = oProduto.CampanhaId, ProdutoId = oProduto.Id, Valor = oProduto.ValorPrincipal, Codigo = oProduto.Codigo, Nome = oProduto.Nome });
            }
        }
    }
}
