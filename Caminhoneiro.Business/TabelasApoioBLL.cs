using Caminhoneiro.DTO.Shared;
using Caminhoneiro.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caminhoneiro.Business
{
    public class TabelasApoioBLL
    {
        public RetornoGenericoDTO<List<TabelaApoioDTO>> ListarSeguradoras(FiltroGenericoDTO filtro)
        {
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { Mensagem = "Falha ao Processar", Item = new List<TabelaApoioDTO>(), ID = -1 };
            try
            {
                retorno.Item = Seguradoras.GetSeguradoras().ToList();
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
                retorno.Item = QdadeViagens.GetViagens().ToList();
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
                retorno.Item = RendasLiquidas.GetRendas().ToList();
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
                retorno.Item = Sindicatos.GetSindicatos().ToList();
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
                retorno.Item = VeiculoProprio.GetVeiculosProprios().ToList();
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
                retorno.Item = Veiculos.GetVeiculos().ToList();
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
