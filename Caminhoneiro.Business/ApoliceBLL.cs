﻿using Caminhoneiro.DTO.Apolice;
using Caminhoneiro.DTO.Shared;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.Business
{
    public class ApoliceBLL
    {
        public RetornoGenericoDTO<List<ApoliceDTO>> Listar(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<ApoliceDTO>> retorno = new RetornoGenericoDTO<List<ApoliceDTO>>() { Mensagem = "Falha ao Processar", Item = new List<ApoliceDTO>(), ID = -1 };
            try
            {
                retorno.Item = Apolices.GetApolices().Where(w => w.DadosCliente.CPF == filtro.Texto).ToList();
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
                var Apolice = Apolices.GetApolices().Where(w => w.Id == filtro.Id).FirstOrDefault();
                if (Apolice != null)
                {
                    Apolices.GetApolices().Remove(Apolice);
                    Apolices.GetApolices().Add(filtro);
                }
                else
                {
                    var IdApolice = Apolices.GetApolices().Max(w => w.Id);
                    filtro.Id = IdApolice++;

                    if (filtro.DadosClienteId == 0)
                    {
                        var idCliente = 0;
                        var oCliente = Apolices.GetApolices().Where(w => w.DadosCliente.CPF == filtro.DadosCliente.CPF).FirstOrDefault();
                        if (oCliente != null)
                            idCliente = oCliente.Id;
                        else
                            idCliente = Apolices.GetApolices().Max(w => w.DadosClienteId);
                        filtro.DadosClienteId = idCliente++;
                        filtro.DadosCliente.Id = filtro.DadosClienteId;
                    }

                    if (filtro.DadosVeiculoId == 0)
                    {
                        var IdVeiculo = Apolices.GetApolices().Max(w => w.DadosVeiculoId);
                        filtro.DadosVeiculoId= IdVeiculo++;
                        filtro.DadosVeiculo.Id = filtro.DadosVeiculoId;
                    }

                    if (filtro.DadosProdutoId ==0)
                    {
                        var IdProduto = Apolices.GetApolices().Max(w => w.DadosProdutoId);
                        filtro.DadosProdutoId = IdProduto++;
                        filtro.DadosProduto.Id = filtro.DadosProdutoId;
                    }

                    if (filtro.DadosPagamentoId == 0)
                    {
                        var IdPagamento = Apolices.GetApolices().Max(w => w.DadosPagamentoId);
                        filtro.DadosPagamentoId = IdPagamento++;
                        filtro.DadosPagamento.Id = filtro.DadosPagamentoId;
                    }

                    if (filtro.DadosDependente.Count > 0 )
                    {
                        var IdDepentende = Apolices.GetApolices().Max(w => w.DadosDependente.Max(e=>e.Id));
                        foreach (var dependente in filtro.DadosDependente)
                        {
                            dependente.Id = IdDepentende++;
                        }
                    }

                    Apolices.GetApolices().Add(filtro);
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

        public RetornoGenericoDTO<bool> Excluir(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<bool> retorno = new RetornoGenericoDTO<bool>() { Mensagem = "Falha ao Processar", Item = false, ID = -1 };
            try
            {
                var Apolice = Apolices.GetApolices().Where(w => w.Id == filtro.ID).FirstOrDefault();
                if (Apolice != null)
                {
                    Apolices.GetApolices().Remove(Apolice);
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
                var Apolice = Apolices.GetApolices().Where(w => w.Id == filtro.ID || w.DadosCliente.CPF == filtro.Texto || w.Codigo== filtro.Texto).FirstOrDefault();
                if (Apolice != null)
                {
                    retorno.Item = Apolice;
                }
                
                retorno.ID = filtro.ID;
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
