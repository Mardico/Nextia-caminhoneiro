using Caminhoneiro.Business;
using Caminhoneiro.DTO.Shared;
using Caminhoneiro.DTO.Usuario;
using System.Web.Http;
using System.Web.Http.Results;

namespace Caminhoneiro.API.Controllers
{
    public class Usuario : ApiController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<UsuarioDTO>> Logar(FiltroLoginDTO filtro)
        {
            logar.Debug("Inicio Logar");
            RetornoGenericoDTO<UsuarioDTO> retorno = new RetornoGenericoDTO<UsuarioDTO>();
            try
            {
                UsuarioBLL oUsuario = new UsuarioBLL();
                retorno = oUsuario.Logar(filtro);
            }
            catch (System.Exception ex)
            {
                retorno.Mensagem = ex.Message;
                logar.Error(ex);
            }
            logar.Debug("Termino Logar");
            return Json(retorno);
        }

        [HttpPost]
        public JsonResult<RetornoGenericoDTO<UsuarioDTO>> Item(FiltroGenericoDTO filtro)
        {
            logar.Debug("Inicio Item");
            RetornoGenericoDTO<UsuarioDTO> retorno = new RetornoGenericoDTO<UsuarioDTO>();
            try
            {
                UsuarioBLL oUsuario = new UsuarioBLL();
                retorno = oUsuario.Usuario(filtro);
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