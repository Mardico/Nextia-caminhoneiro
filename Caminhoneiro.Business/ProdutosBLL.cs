using Caminhoneiro.DTO;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caminhoneiro.Business
{
    public class ProdutosBLL
    {
        public ProdutosBLL()
        {

        }

        public RetornoGenericoDTO<List<ProdutoDTO>> Listar(UsuarioDTO filtro)
        {
            RetornoGenericoDTO<List<ProdutoDTO>> retorno = new RetornoGenericoDTO<List<ProdutoDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ProdutoDTO>(), ID = -1 };
            try
            {
                var Vinculo = filtro.Vinculos.FirstOrDefault();
                if ((Vinculo != null) && (Vinculo.Codigo != "0001")) //Libera Produtos para CallCenter
                    retorno.Item = Produtos.Itens().Where(w => w.Vinculo.Any(a => a.Codigo == Vinculo.Codigo)).ToList();
                else
                    retorno.Item = Produtos.Itens().ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Listar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<ProdutoDTO> Produto(ProdutoDTO filtro)
        {
            RetornoGenericoDTO<ProdutoDTO> retorno = new RetornoGenericoDTO<ProdutoDTO>() { Mensagem = "Falha ao Processar", Item = new ProdutoDTO(), ID = -1 };
            try
            {
                retorno.Item = Produtos.Itens().Where(w => w.Id == filtro.Id).FirstOrDefault();
                if (retorno.Item != null)
                    retorno.ID = retorno.Item.Id;
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
