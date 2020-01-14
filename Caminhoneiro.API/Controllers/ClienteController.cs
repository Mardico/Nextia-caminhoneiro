using Caminhoneiro.Business;
using Caminhoneiro.DTO;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;

namespace Caminhoneiro.API.Controllers
{
    public class ClienteController : ApiController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<List<ClienteDTO>>> Listar(ClienteDTO filtro)
        {
            logar.Debug("Inicio Listar");
            RetornoGenericoDTO<List<ClienteDTO>> retorno = new RetornoGenericoDTO<List<ClienteDTO>>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ClienteBLL oCliente = new ClienteBLL();
                retorno = oCliente.Listar(filtro);
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
        public JsonResult<RetornoGenericoDTO<ClienteDTO>> Item(ClienteDTO filtro)
        {
            logar.Debug("Inicio Item");
            RetornoGenericoDTO<ClienteDTO> retorno = new RetornoGenericoDTO<ClienteDTO>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ClienteBLL oCliente = new ClienteBLL();
                retorno = oCliente.Cliente(filtro);
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
        public JsonResult<RetornoGenericoDTO<ClienteDTO>> Salvar(ClienteDTO filtro)
        {
            logar.Debug("Inicio Salvar");
            RetornoGenericoDTO<ClienteDTO> retorno = new RetornoGenericoDTO<ClienteDTO>() { ID = -1, Mensagem = "Falha ao Requisitar" };
            try
            {
                ClienteBLL oCliente = new ClienteBLL();
                retorno = oCliente.Salvar(filtro);
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
                ClienteBLL oCliente = new ClienteBLL();
                retorno = oCliente.Excluir(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }

            logar.Debug("Termino Excluir");
            return Json(retorno);
        }
        
        [HttpGet]
        public JsonResult<RetornoGenericoDTO<List<ClienteDTO>>> Todos()
        {
            logar.Debug("Inicio Item");
            RetornoGenericoDTO<List<ClienteDTO>> retorno = new RetornoGenericoDTO<List<ClienteDTO>>();
            try
            {
                retorno.Item = Entidade.Clientes.Itens();
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }
            logar.Debug("Termino Item");
            return Json(retorno);
        }
    }
}