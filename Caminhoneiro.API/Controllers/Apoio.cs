using Caminhoneiro.Business;
using Caminhoneiro.DTO.Apolice;
using Caminhoneiro.DTO.Shared;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace Caminhoneiro.API.Controllers
{
    public class Apoio : ApiController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<TabelaApoioDTO>>> ListarSeguradoras(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio ListarSeguradoras");
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                TabelasApoioBLL apoio = new TabelasApoioBLL();
                retorno = apoio.ListarSeguradoras(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino ListarSeguradoras");
            return Json(retorno);
        }
        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<TabelaApoioDTO>>> ListarQdadeViagens(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio ListarQdadeViagens");
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                TabelasApoioBLL apoio = new TabelasApoioBLL();
                retorno = apoio.ListarQdadeViagens(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino ListarQdadeViagens");
            return Json(retorno);
        }
        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<TabelaApoioDTO>>> ListarRendasLiquidas(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio ListarRendasLiquidas");
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                TabelasApoioBLL apoio = new TabelasApoioBLL();
                retorno = apoio.ListarRendasLiquidas(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino ListarRendasLiquidas");
            return Json(retorno);
        }
        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<TabelaApoioDTO>>> ListarSindicatos(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio ListarSindicatos");
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                TabelasApoioBLL apoio = new TabelasApoioBLL();
                retorno = apoio.ListarSindicatos(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino ListarSindicatos");
            return Json(retorno);
        }
        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<TabelaApoioDTO>>> ListarVeiculoProprio(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio ListarVeiculoProprio");
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                TabelasApoioBLL apoio = new TabelasApoioBLL();
                retorno = apoio.ListarVeiculoProprio(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino ListarVeiculoProprio");
            return Json(retorno);
        }
        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<TabelaApoioDTO>>> ListarVeiculos(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio ListarVeiculos");
            RetornoGenericoDTO<List<TabelaApoioDTO>> retorno = new RetornoGenericoDTO<List<TabelaApoioDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                TabelasApoioBLL apoio = new TabelasApoioBLL();
                retorno = apoio.ListarVeiculos(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
            }
            logar.Debug("Termino ListarVeiculos");
            return Json(retorno);
        }
    }
}