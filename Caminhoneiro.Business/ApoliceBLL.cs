using Caminhoneiro.DTO;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Caminhoneiro.Business
{
    public class ApoliceBLL
    {
        public ApoliceBLL()
        {

        }
        public RetornoGenericoDTO<List<ApoliceDTO>> Listar(ClienteDTO filtro)
        {
            RetornoGenericoDTO<List<ApoliceDTO>> retorno = new RetornoGenericoDTO<List<ApoliceDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ApoliceDTO>(), ID = -1 };
            try
            {
                retorno.Item = Apolices.Itens().Where(w => (!string.IsNullOrEmpty(filtro.CPF) && w.DadosCliente.CPF == filtro.CPF) || (filtro.Id > 0 && w.DadosCliente.Id == filtro.Id)).ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
        public RetornoGenericoDTO<ApoliceDTO> Salvar(ApoliceDTO filtro)
        {
            RetornoGenericoDTO<ApoliceDTO> retorno = new RetornoGenericoDTO<ApoliceDTO>() { Mensagem = "Falha ao Processar", Item = new ApoliceDTO(), ID = -1 };
            try
            {
                var Apolice = Apolices.Itens().Where(w => w.Id == filtro.Id).FirstOrDefault();
                if (Apolice != null)
                {
                    Apolices.Itens().Remove(Apolice);
                    Apolices.Itens().Add(filtro);
                }
                else
                {
                    var IdApolice = Apolices.Itens().Max(w => w.Id);
                    filtro.Id = IdApolice++;

                    if (filtro.DadosClienteId == 0)
                    {
                        var idCliente = 0;
                        var oCliente = Apolices.Itens().Where(w => w.DadosCliente.CPF == filtro.DadosCliente.CPF).FirstOrDefault();
                        if (oCliente != null)
                            idCliente = oCliente.Id;
                        else
                            idCliente = Apolices.Itens().Max(w => w.DadosClienteId);
                        filtro.DadosClienteId = idCliente++;
                        filtro.DadosCliente.Id = filtro.DadosClienteId;
                    }

                    if (filtro.DadosVeiculoId == 0)
                    {
                        var IdVeiculo = Apolices.Itens().Max(w => w.DadosVeiculoId);
                        filtro.DadosVeiculoId = IdVeiculo++;
                        filtro.DadosVeiculo.Id = filtro.DadosVeiculoId;
                    }

                    if (filtro.DadosProdutoId == 0)
                    {
                        var IdProduto = Apolices.Itens().Max(w => w.DadosProdutoId);
                        filtro.DadosProdutoId = IdProduto++;
                        filtro.DadosProduto.Id = filtro.DadosProdutoId;
                    }

                    if (filtro.DadosPagamentoId == 0)
                    {
                        var IdPagamento = Apolices.Itens().Max(w => w.DadosPagamentoId);
                        filtro.DadosPagamentoId = IdPagamento++;
                        filtro.DadosPagamento.Id = filtro.DadosPagamentoId;
                    }

                    if (filtro.DadosDependente.Count > 0)
                    {
                        var IdDepentende = Apolices.Itens().Max(w => w.DadosDependente.Max(e => e.Id));
                        foreach (var dependente in filtro.DadosDependente)
                        {
                            dependente.Id = IdDepentende++;
                        }
                    }

                    Apolices.Itens().Add(filtro);
                }
                retorno.ID = retorno.Item.Id;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<ApoliceDadosProdutoDTO> DadosProduto(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<ApoliceDadosProdutoDTO> retorno = new RetornoGenericoDTO<ApoliceDadosProdutoDTO>() { Mensagem = "Falha ao Processar", Item = new ApoliceDadosProdutoDTO(), ID = -1 };
            try
            {


                var oAgente = Usuarios.Itens().Where(w=> w.Id == filtro.Valor).FirstOrDefault();
                var oProduto = Produtos.Itens().Where(w => w.Id == filtro.ID).FirstOrDefault();
                retorno.Item = new ApoliceDadosProdutoDTO() { Id = 0, Agente = oAgente.Nome, CampanhaId = oProduto.CampanhaId, Campanha = oProduto.Campanha, ProdutoId = oProduto.Id, Valor = oProduto.ValorPrincipal, Codigo = oProduto.Codigo, Nome = oProduto.Nome };
                if (retorno.Item != null)
                    retorno.ID = 1;
                else
                    retorno.ID = 0;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<ApoliceDTO>> ApolicesPendentes(ClienteDTO filtro)
        {
            RetornoGenericoDTO<List<ApoliceDTO>> retorno = new RetornoGenericoDTO<List<ApoliceDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ApoliceDTO>(), ID = -1 };
            try
            {
                retorno.Item = Apolices.Itens().Where(w => (w.DadosCliente.CPF == filtro.CPF && w.StatusId == 0)).ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<ApolicePagamentoDTO>> ListarPagamento(ApoliceDTO filtro)
        {
            RetornoGenericoDTO<List<ApolicePagamentoDTO>> retorno = new RetornoGenericoDTO<List<ApolicePagamentoDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ApolicePagamentoDTO>(), ID = -1 };
            try
            {
                retorno.Item = ApolicePagamentos.Itens().Where(w => (filtro.Id > 0 && w.ApoliceId == filtro.Id)).ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
        public RetornoGenericoDTO<List<ApoliceHistoricoDTO>> ListarHistorico(ApoliceDTO filtro)
        {
            RetornoGenericoDTO<List<ApoliceHistoricoDTO>> retorno = new RetornoGenericoDTO<List<ApoliceHistoricoDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ApoliceHistoricoDTO>(), ID = -1 };
            try
            {
                retorno.Item = ApoliceHistorico.Itens().Where(w => (filtro.Id > 0 && w.ApoliceId == filtro.Id)).ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
        public RetornoGenericoDTO<bool> SolicitarKitProduto(ApoliceKitProdutoDTO filtro)
        {
            RetornoGenericoDTO<bool> retorno = new RetornoGenericoDTO<bool>() { Mensagem = "Falha ao Processar", Item = false, ID = -1 };
            retorno.Item = true;
            if (retorno.Item)
                retorno.Mensagem = "Sucesso ao Solicitar";
            else
                retorno.ID = Convert.ToInt32(retorno.Item);

            return retorno;
        }
        public RetornoGenericoDTO<FileContentResult> Impressao(int filtro)
        {
            RetornoGenericoDTO<FileContentResult> retorno = new RetornoGenericoDTO<FileContentResult>();
            retorno.ID = 1;

            byte[] bytes = Encoding.ASCII.GetBytes("APENAS IM EXEMPLO DE DOCUMENTO");
            retorno.Item = new FileContentResult(bytes, "text/plain");
            retorno.Item.FileDownloadName = "Conteudo.txt";
            retorno.Mensagem = "Sucesso";
            return retorno;


        }
        public RetornoGenericoDTO<bool> Excluir(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<bool> retorno = new RetornoGenericoDTO<bool>() { Mensagem = "Falha ao Processar", Item = false, ID = -1 };
            try
            {
                var Apolice = Apolices.Itens().Where(w => w.Id == filtro.ID).FirstOrDefault();
                if (Apolice != null)
                {
                    Apolices.Itens().Remove(Apolice);
                }
                retorno.Item = true;
                retorno.ID = filtro.ID;
                retorno.Mensagem = "Sucesso ao Excluir";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
        public RetornoGenericoDTO<ApoliceDTO> Apolice(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<ApoliceDTO> retorno = new RetornoGenericoDTO<ApoliceDTO>() { Mensagem = "Falha ao Listar", Item = new ApoliceDTO(), ID = -1 };
            try
            {
                var Apolice = Apolices.Itens().Where(w => w.Id == filtro.ID || w.DadosCliente.CPF == filtro.Texto || w.Codigo == filtro.Texto).FirstOrDefault();
                if (Apolice != null)
                {
                    retorno.Item = Apolice;
                    retorno.ID = retorno.Item.Id;

                }

                retorno.Mensagem = "Sucesso ao Carregar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
    }
}
