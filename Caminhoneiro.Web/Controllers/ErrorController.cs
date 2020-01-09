using System.Web.Mvc;

namespace Caminhoneiro.Web.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            ViewBag.Mensagem = "Erro ao consultar Serviço!";
            return View();
        }
    }
}