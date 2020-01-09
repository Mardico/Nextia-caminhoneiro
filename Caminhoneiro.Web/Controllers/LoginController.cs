using Caminhoneiro.DTO.Usuario;
using Caminhoneiro.Util;
using Caminhoneiro.ViewModel.Shared;
using Caminhoneiro.ViewModel.Usuario;
using System.Web.Mvc;
using AutoMapper;
using Caminhoneiro.DTO.Shared;
using System.Web.Security;
using System.Web;
using System;

namespace Caminhoneiro.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(FiltroLoginViewModel login)
        {
            logar.Debug("Inicio Logar");
            RetornoGenericoViewModel<UsuarioViewModel> retorno = new RetornoGenericoViewModel<UsuarioViewModel>(0, "Falha");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<UsuarioDTO>>())
            {
                FiltroLoginDTO filtroDTO = new FiltroLoginDTO();
                Mapper.Map<FiltroLoginViewModel, FiltroLoginDTO>(login);
                RetornoGenericoDTO<UsuarioDTO> retDTO = client.Post("Usuario/Login", filtroDTO);
                retorno = Mapper.Map<RetornoGenericoDTO<UsuarioDTO>, RetornoGenericoViewModel<UsuarioViewModel>>(retDTO);
                ViewBag.Mensagem = retorno.Mensagem;
                if (retorno.ID > 0)
                {
                    HttpCookie authCookie = FormsAuthentication.GetAuthCookie(retorno.Item.Token, true);
                    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                    FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddDays(1), ticket.IsPersistent, FormsAuthentication.FormsCookiePath);
                    authCookie.Value = FormsAuthentication.Encrypt(newTicket);
                    Response.Cookies.Add(authCookie);
                    return RedirectToAction("Index", "Apolice");
                }
                return View();
            }
        }
    }
}