using Caminhoneiro.DTO.Cliente;
using System.Web.Mvc;

namespace Caminhoneiro.Web.Controllers
{
    [Authorize]
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

            }
            return View();
        }
        public ActionResult KitProduto()
        {
            try
            {
            }
            catch
            {

            }
            return View();
        }

        public ActionResult EditarSegurado()
        {
            try
            {
            }
            catch
            {

            }
            return View();
        }
        public ActionResult DadosCadastrais()
        {
            try
            {
            }
            catch
            {

            }
            return View();
        }
    }
}