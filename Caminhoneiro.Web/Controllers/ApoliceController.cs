using AutoMapper;
using Caminhoneiro.DTO;
using Caminhoneiro.Util;
using Caminhoneiro.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Caminhoneiro.Web.Controllers
{
    [Authorize]
    public class ApoliceController : BaseController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public ActionResult Index()
        {
            RetornoGenericoViewModel<List<ProdutoViewModel>> retorno = new RetornoGenericoViewModel<List<ProdutoViewModel>>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<ProdutoDTO>>>())
            {
                UsuarioDTO filtro = Mapper.Map<UsuarioViewModel, UsuarioDTO>(UsuarioAtual);
                RetornoGenericoDTO<List<ProdutoDTO>> retDTO = client.Post("Produtos/ListaProdutos", filtro);
                if (retDTO != null)
                {
                    ViewBag.Mensagem = retDTO.Mensagem;
                    retorno = Mapper.Map<RetornoGenericoDTO<List<ProdutoDTO>>, RetornoGenericoViewModel<List<ProdutoViewModel>>>(retDTO);
                    if (retorno.ID > 0)
                        return View(retorno.Item);
                }
            }
            ViewBag.Mensagem = retorno.Mensagem;
            return View();
        }
        public ActionResult Adesao(ApoliceViewModel filtro)
        {

            ApoliceViewModel retorno = NovaAdesao(filtro);

            //Carrega combos
            ViewBag.SimNao = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Não" }, new SelectListItem() { Value = "1", Text = "Sim" } }, "Value", "Text", 0);
            ViewBag.Contactar = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "WhatsApp" }, new SelectListItem() { Value = "1", Text = "E-mail" } }, "Value", "Text", 0);
            ViewBag.Sexo = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Masculino" }, new SelectListItem() { Value = "1", Text = "Feminino" }, new SelectListItem() { Value = "1", Text = "Outro" } }, "Value", "Text", 0);
            ViewBag.EstadoCivil = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Casada(o)" }, new SelectListItem() { Value = "1", Text = "Divorciada(o)" }, new SelectListItem() { Value = "1", Text = "Solteira(o)" } }, "Value", "Text", 0);
            ViewBag.MeioPgto = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Cartão de Crédito" }, new SelectListItem() { Value = "1", Text = "Conta Digital" } }, "Value", "Text", 0);
            ViewBag.Cargas = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Municipal" }, new SelectListItem() { Value = "1", Text = "Intermunicipal" } }, "Value", "Text", 0);
            ViewBag.Parcelas = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "12x50" }, new SelectListItem() { Value = "1", Text = "12x80" }, new SelectListItem() { Value = "2", Text = "12x120" } }, "Value", "Text", 0);

            ViewBag.Seguradoras = new SelectList(CarregaLista("Apoio/ListarSeguradoras"), "Id", "Texto", 0);
            ViewBag.QdadeViagens = new SelectList(CarregaLista("Apoio/ListarQdadeViagens"), "Id", "Texto", 0);
            ViewBag.RendasLiquidas = new SelectList(CarregaLista("Apoio/ListarRendasLiquidas"), "Id", "Texto", 0);
            ViewBag.Sindicatos = new SelectList(CarregaLista("Apoio/ListarSindicatos"), "Id", "Texto", 0);
            ViewBag.VeiculoProprio = new SelectList(CarregaLista("Apoio/ListarVeiculoProprio"), "Id", "Texto", 0);
            ViewBag.Veiculos = new SelectList(CarregaLista("Apoio/ListarVeiculos"), "Id", "Texto", 0);
            return View(retorno);
        }
        public ActionResult ListaTodos(ClienteApoliceViewModel cliente)
        {
            RetornoGenericoViewModel<List<ApoliceViewModel>> retorno = new RetornoGenericoViewModel<List<ApoliceViewModel>>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<ApoliceDTO>>>())
            {
                var filtro = Mapper.Map<ClienteApoliceViewModel, ClienteDTO>(cliente);
                RetornoGenericoDTO<List<ApoliceDTO>> retDTO = client.Post("Apolice/Listar", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<List<ApoliceDTO>>, RetornoGenericoViewModel<List<ApoliceViewModel>>>(retDTO);
                    if (retorno.ID > -1)
                        return View(retorno.Item);
                }
                ViewBag.Mensagem = retorno.Mensagem;
            }
            if (retorno.ID > 0)
                return RedirectToAction("DadosSegurado", "Segurado", new { cliente.Id, cliente.CPF });
            else
                return RedirectToAction("Index", "Segurado", new { retorno.Mensagem });
        }
        public ActionResult EditarApolice()
        {
            return View();
        }
        public ActionResult Pagamento(ClienteApoliceViewModel cliente)
        {
            RetornoGenericoViewModel<List<ApolicePagamentoViewModel>> retorno = new RetornoGenericoViewModel<List<ApolicePagamentoViewModel>>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<ApolicePagamentoDTO>>>())
            {
                FiltroGenericoDTO filtro = new FiltroGenericoDTO() { ID = cliente.ApoliceId };
                RetornoGenericoDTO<List<ApolicePagamentoDTO>> retDTO = client.Post("Apolice/ListarPagamento", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<List<ApolicePagamentoDTO>>, RetornoGenericoViewModel<List<ApolicePagamentoViewModel>>>(retDTO);
                    if (retorno.ID > -1)
                        return View(retorno.Item);
                }
            }
            return RedirectToAction("Index", "Segurado", new { retorno.Mensagem });
        }
        public ActionResult ConsultarApolice(ClienteApoliceViewModel cliente)
        {
            RetornoGenericoViewModel<ApoliceViewModel> retorno = new RetornoGenericoViewModel<ApoliceViewModel>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<ApoliceDTO>>())
            {
                FiltroGenericoDTO filtro = new FiltroGenericoDTO() { ID = cliente.ApoliceId };
                RetornoGenericoDTO<ApoliceDTO> retDTO = client.Post("Apolice/Item", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<ApoliceDTO>, RetornoGenericoViewModel<ApoliceViewModel>>(retDTO);
                    if (retorno.ID > 0)
                        return View(retorno.Item);
                }
            }
            return RedirectToAction("Index", "Segurado", new { retorno.Mensagem });
        }
        public ActionResult Historico(ClienteApoliceViewModel cliente)
        {
            RetornoGenericoViewModel<List<ApoliceHistoricoViewModel>> retorno = new RetornoGenericoViewModel<List<ApoliceHistoricoViewModel>>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<ApoliceHistoricoDTO>>>())
            {
                FiltroGenericoDTO filtro = new FiltroGenericoDTO() { ID = cliente.ApoliceId };
                RetornoGenericoDTO<List<ApoliceHistoricoDTO>> retDTO = client.Post("Apolice/ListarHistorico", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<List<ApoliceHistoricoDTO>>, RetornoGenericoViewModel<List<ApoliceHistoricoViewModel>>>(retDTO);
                    if (retorno.ID > -1)
                        return View(retorno.Item);
                }
            }
            return RedirectToAction("Index", "Segurado", new { retorno.Mensagem });
        }
        public ActionResult Impressao(int id)
        {
            logar.DebugFormat("Inicio Impressao {0}", id);
            using (var client = new HttpClientUtil<RetornoGenericoDTO<FileContentResult>>())
            {
                RetornoGenericoDTO<FileContentResult> retDTO = client.Post("Apolice/Impressao", new FiltroGenericoDTO() { ID = id });
                if (retDTO != null)
                {
                    logar.DebugFormat("Fim Impressao {0}", id);
                    return File(retDTO.Item.FileContents, retDTO.Item.ContentType, retDTO.Item.FileDownloadName);
                }
            }
            logar.DebugFormat("Fim Impressao {0}", id);
            return null;
        }
        public JsonResult ProdutosUsuario()
        {
            RetornoGenericoViewModel<List<ProdutoViewModel>> retorno = new RetornoGenericoViewModel<List<ProdutoViewModel>>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<ProdutoDTO>>>())
            {
                UsuarioDTO filtro = Mapper.Map<UsuarioViewModel, UsuarioDTO>(UsuarioAtual);
                RetornoGenericoDTO<List<ProdutoDTO>> retDTO = client.Post("Produtos/ListaProdutos", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<List<ProdutoDTO>>, RetornoGenericoViewModel<List<ProdutoViewModel>>>(retDTO);
                }
            }
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Excluir(int Id)
        {
            RetornoGenericoViewModel<bool> retorno = new RetornoGenericoViewModel<bool>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<bool>>())
            {
                RetornoGenericoDTO<bool> retDTO = client.Post("Apolice/Excluir", new FiltroGenericoDTO() { ID = Id });
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<bool>, RetornoGenericoViewModel<bool>>(retDTO);
                }
            }
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
    }
}