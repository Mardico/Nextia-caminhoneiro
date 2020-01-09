using Caminhoneiro.DTO.Apolice;
using System;
using System.Collections.Generic;

namespace Caminhoneiro.Entidade
{
    class ApoliceDadosProduto
    {
        public static List<ApoliceDadosProdutoDTO> ListaApoliceProdutos()
        {
            var retorno = new List<ApoliceDadosProdutoDTO>();
            for (int i = 0; i < 100; i++)
            {
                int randomNumber = new Random().Next(0, 99);
                var oAgente = Usuarios.GetUsuario()[randomNumber];
                var oProduto = Produtos.GetProdutos()[randomNumber];
                retorno.Add(new ApoliceDadosProdutoDTO() { Id = i, Agente = oAgente.Nome, CampanhaId = oProduto.CampanhaId, ProdutoId = oProduto.Id, Valor = oProduto.Valor, Codigo = oProduto.Codigo });
            }
            return retorno;
        }
    }
}
