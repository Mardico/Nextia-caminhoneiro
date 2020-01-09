using Caminhoneiro.DTO.Produto;
using Caminhoneiro.DTO.Shared;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.Business
{
    public class ProdutosBLL
    {
        public RetornoGenericoDTO<List<ProdutoDTO>> Listar(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<ProdutoDTO>> retorno = new RetornoGenericoDTO<List<ProdutoDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ProdutoDTO>(), ID = -1 };
            try
            {
                retorno.Item = Produtos.GetProdutos().Where(w => w.Vinculo.Any(a => a.Codigo == filtro.Texto)).ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Listar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
    }
}
