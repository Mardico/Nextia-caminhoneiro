using Caminhoneiro.DTO.Usuario;
using Caminhoneiro.Util;
using Caminhoneiro.ViewModel.Shared;
using Caminhoneiro.ViewModel.Usuario;
using System.Web.Mvc;

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
            using (var client = new HttpClientUtil<UsuarioViewModel>())
            {
                FiltroLoginDTO filtroDTO = new FiltroLoginDTO(); //Mapper.Map<FiltroLoginViewModel, FiltroLoginDTO>(login);
                //var listaDTO = client.Post("Configuracao/ListarPaginado", filtroDTO);
                //retorno = listaDTO; //Mapper.Map<RetornoGenericoViewModel<UsuarioViewModel>, RetornoGenericoDTO<UsuarioDTO>>(listaDTO);
                //if (retorno.ID > 0)
                //{
                //    HttpCookie authCookie = FormsAuthentication.GetAuthCookie(retorno.Item.nome, true);
                //    FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                //    FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddDays(1), ticket.IsPersistent, FormsAuthentication.FormsCookiePath);
                //    authCookie.Value = FormsAuthentication.Encrypt(newTicket);
                //    Response.Cookies.Add(authCookie);
                //    return RedirectToAction("Index", "Apolice");
                //}
                //else
                //{
                //    ViewBag.Mensagem = "Erro ao conectar no serviço de Login!";
                //    return View();
                //}
            }
            return View();
        }
    }
}