using Caminhoneiro.Business;
using Caminhoneiro.DTO;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace Caminhoneiro.API.Controllers
{
    public class ApoliceController : ApiController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<ApoliceDTO>>> Listar(ClienteDTO filtro)
        {
            logar.Debug("Inicio Listar");
            RetornoGenericoDTO<List<ApoliceDTO>> retorno = new RetornoGenericoDTO<List<ApoliceDTO>>() {ID=-1, Mensagem="Falha ao Requisitar"};
            try
            {
                ApoliceBLL oApolice = new ApoliceBLL();
                retorno = oApolice.Listar(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }
            logar.Debug("Termino Listar");
            return Json(retorno);
        }

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<ApoliceDTO>> Item(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio Item");
            RetornoGenericoDTO<ApoliceDTO> retorno = new RetornoGenericoDTO<ApoliceDTO>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ApoliceBLL oApolice = new ApoliceBLL();
                retorno = oApolice.Apolice(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }
            logar.Debug("Termino Item");
            return Json(retorno);
        }

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<ApoliceDTO>> Salvar(ApoliceDTO filtro)
        {
            logar.Debug("Inicio Salvar");
            RetornoGenericoDTO<ApoliceDTO> retorno = new RetornoGenericoDTO<ApoliceDTO>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ApoliceBLL oApolice = new ApoliceBLL();
                retorno = oApolice.Salvar(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }
            logar.Debug("Termino Salvar");
            return Json(retorno);
        }

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<bool>> Excluir(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio Excluir");
            RetornoGenericoDTO<bool> retorno = new RetornoGenericoDTO<bool>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ApoliceBLL oApolice = new ApoliceBLL();
                retorno = oApolice.Excluir(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }

            logar.Debug("Termino Excluir");
            return Json(retorno);
        }


        [HttpPost]
        public JsonResult<RetornoGenericoDTO<bool>> SolicitarKitProduto(ApoliceKitProdutoDTO filtro)
        {
            logar.Debug("Inicio Excluir");
            RetornoGenericoDTO<bool> retorno = new RetornoGenericoDTO<bool>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ApoliceBLL oApolice = new ApoliceBLL();
                retorno = oApolice.SolicitarKitProduto(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }

            logar.Debug("Termino Excluir");
            return Json(retorno);
        }

        public JsonResult<RetornoGenericoDTO<System.Web.Mvc.FileContentResult>> Impressao(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio Excluir");
            RetornoGenericoDTO<System.Web.Mvc.FileContentResult> retorno = new RetornoGenericoDTO<System.Web.Mvc.FileContentResult>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ApoliceBLL oApolice = new ApoliceBLL();
                retorno = oApolice.Impressao(filtro.ID);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }

            logar.Debug("Termino Excluir");
            return Json(retorno);
        }

    }
}