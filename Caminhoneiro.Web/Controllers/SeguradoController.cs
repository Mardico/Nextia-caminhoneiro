using Caminhoneiro.DTO.Cliente;
using System.Web.Mvc;

namespace Caminhoneiro.Web.Controllers
{
    public class SeguradoController : BaseController
    {


        public ActionResult ConsultarSegurado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConsultarSegurado(ClienteDTO cliDTO)
        {
            try
            {
            }
            catch
            {
                //implementar mensagem de erro ao consultar Serviço

            }
            return View();
        }
        public ActionResult KitProduto()
        {
            return View();
        }

        public ActionResult EditarSegurado()
        {
            return View();
        }
        public ActionResult DadosCadastrais()
        {
            return View();
        }
    }
}