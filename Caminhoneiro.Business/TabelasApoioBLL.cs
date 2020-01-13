using Caminhoneiro.DTO;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caminhoneiro.Business
{
    public class TabelasApoioBLL
    {
        public TabelasApoioBLL()
        {

        }
        public RetornoGenericoDTO<List<TabelaApoioDTO>> ListarSeguradoras(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { Mensagem = "Falha ao Processar", Item = new List<TabelaApoioDTO>(), ID = -1 };
            try
            {
                retorno.Item = Seguradoras.Itens().ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<TabelaApoioDTO>> ListarQdadeViagens(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { Mensagem = "Falha ao Processar", Item = new List<TabelaApoioDTO>(), ID = -1 };
            try
            {
                retorno.Item = QdadeViagens.Itens().ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<TabelaApoioDTO>> ListarRendasLiquidas(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { Mensagem = "Falha ao Processar", Item = new List<TabelaApoioDTO>(), ID = -1 };
            try
            {
                retorno.Item = RendasLiquidas.Itens().ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<TabelaApoioDTO>> ListarSindicatos(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { Mensagem = "Falha ao Processar", Item = new List<TabelaApoioDTO>(), ID = -1 };
            try
            {
                retorno.Item = Sindicatos.Itens().ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<TabelaApoioDTO>> ListarVeiculoProprio(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { Mensagem = "Falha ao Processar", Item = new List<TabelaApoioDTO>(), ID = -1 };
            try
            {
                retorno.Item = VeiculoProprio.Itens().ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }

        public RetornoGenericoDTO<List<TabelaApoioDTO>> ListarVeiculos(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { Mensagem = "Falha ao Processar", Item = new List<TabelaApoioDTO>(), ID = -1 };
            try
            {
                retorno.Item = Veiculos.Itens().ToList();
                retorno.ID = retorno.Item.Count;
                retorno.Mensagem = "Sucesso ao Processar";
            }
            catch (Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            return retorno;
        }
    }
}
