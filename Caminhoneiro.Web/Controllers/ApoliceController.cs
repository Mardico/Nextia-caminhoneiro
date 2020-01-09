using System.Web.Mvc;

namespace Caminhoneiro.Web.Controllers
{
    public class ApoliceController : BaseController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Adesao()
        {
            return View();
        }

        public ActionResult ListaTodos()
        {
            return View();
        }

        public ActionResult EditarApolice()
        {
            return View();
        }

        public ActionResult Pagamento()
        {
            return View();
        }
        public ActionResult ConsultarApolice()
        {
            return View();
        }

        public ActionResult Historico()
        {
            return View();
        }

    }
}