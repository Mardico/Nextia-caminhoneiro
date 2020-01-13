using AutoMapper;
using Caminhoneiro.DTO;
using Caminhoneiro.ViewModel;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Caminhoneiro.Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            base.Initialize(requestContext);
            ViewBag.Title = "Plug - Caminhoneiro";
            if (Session["Usuario"] == null && !requestContext.HttpContext.Request.Url.ToString().Contains("Login"))
            {
                FormsAuthentication.SignOut();
                FormsAuthentication.RedirectToLoginPage();
            }
        }
        public UsuarioViewModel UsuarioAtual
        {
            get
            {
                if (Session["Usuario"] != null)
                    return (UsuarioViewModel)Session["Usuario"];
                else
                    return new UsuarioViewModel();
            }
        }
        public bool Autenticar(RetornoGenericoDTO<UsuarioDTO> retDTO)
        {
            RetornoGenericoViewModel<UsuarioViewModel> retorno = new RetornoGenericoViewModel<UsuarioViewModel>(-1, "Falha ao Acessar API");
            try
            {
                if (retDTO != null)
                {
                    if (retDTO.Item != null && retDTO.ID > 0)
                    {
                        retorno = Mapper.Map<RetornoGenericoDTO<UsuarioDTO>, RetornoGenericoViewModel<UsuarioViewModel>>(retDTO);
                        ViewBag.Mensagem = retorno.Mensagem;
                        HttpCookie authCookie = FormsAuthentication.GetAuthCookie(retorno.Item.Token, true);
                        FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                        FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddDays(1), ticket.IsPersistent, FormsAuthentication.FormsCookiePath);
                        authCookie.Value = FormsAuthentication.Encrypt(newTicket);
                        Response.Cookies.Add(authCookie);
                        Session.Add("Usuario", retorno.Item);
                        logar.Debug("Termino Logar");
                        return true;
                    }
                    ViewBag.Mensagem = retDTO.Mensagem;
                }
                else
                    ViewBag.Mensagem = retorno.Mensagem;
            }
            catch (Exception ex)
            {
                ViewBag.Mensagem = ex.Message;
            }
            return false;
        }
    }
}