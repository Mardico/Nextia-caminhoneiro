using AutoMapper;
using Caminhoneiro.DTO;
using Caminhoneiro.ViewModel;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Caminhoneiro.Util;
using System.Collections.Generic;
using System.Linq;

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
        public ApoliceViewModel NovaAdesao(ApoliceViewModel Apolice)
        {
            ApoliceViewModel retorno = new ApoliceViewModel();
            if (Apolice != null)
            {
                if (Apolice.DadosProdutoId > 0 && Apolice.Id == 0)
                {
                    retorno.DadosCliente.CPF = Apolice.Codigo;
                    using (var client = new HttpClientUtil<RetornoGenericoDTO<ApoliceDadosProdutoDTO>>())
                    {
                        FiltroGenericoDTO filtro = new FiltroGenericoDTO() { ID = Apolice.DadosProdutoId, Valor = UsuarioAtual.Id};
                        RetornoGenericoDTO<ApoliceDadosProdutoDTO> retDTO = client.Post("Apolice/DadosProduto", filtro);
                        if (retDTO != null && retDTO.ID > 0)
                        {
                            var oItem = Mapper.Map<RetornoGenericoDTO<ApoliceDadosProdutoDTO>, RetornoGenericoViewModel<ApoliceDadosProdutoViewModel>>(retDTO);
                            retorno.DadosProduto = oItem.Item;
                        }
                    }
                }

                if (Apolice.DadosClienteId > 0 && Apolice.Id == 0)
                {
                    using (var client = new HttpClientUtil<RetornoGenericoDTO<ClienteDTO>>())
                    {
                        FiltroGenericoDTO filtro = new FiltroGenericoDTO() { ID = Apolice.DadosClienteId };
                        RetornoGenericoDTO<ClienteDTO> retDTO = client.Post("Cliente/Item", filtro);
                        if (retDTO != null && retDTO.ID > 0)
                        {
                            var oItem = Mapper.Map<RetornoGenericoDTO<ClienteDTO>, RetornoGenericoViewModel<ClienteViewModel>>(retDTO);
                            retorno.DadosCliente = oItem.Item;
                        }
                    }
                }

                if (Apolice.Id > 0)
                {
                    using (var client = new HttpClientUtil<RetornoGenericoDTO<ApoliceDTO>>())
                    {
                        FiltroGenericoDTO filtro = new FiltroGenericoDTO() {ID = Apolice.Id } ;
                        RetornoGenericoDTO<ApoliceDTO> retDTO = client.Post("Apolice/Item", filtro);
                        if (retDTO != null && retDTO.ID > 0)
                        {
                            var oItem = Mapper.Map<RetornoGenericoDTO<ApoliceDTO>, RetornoGenericoViewModel<ApoliceViewModel>>(retDTO);
                            retorno = oItem.Item;
                        }
                    }
                }
            }
            //Carrega combos
            ViewBag.SimNao = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Não" }, new SelectListItem() { Value = "1", Text = "Sim" } }, "Value", "Text", 0);
            ViewBag.Contactar = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "WhatsApp" }, new SelectListItem() { Value = "1", Text = "E-mail" } }, "Value", "Text", 0);
            ViewBag.EstadoCivil = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Casada(o)" }, new SelectListItem() { Value = "1", Text = "Divorciada(o)" }, new SelectListItem() { Value = "1", Text = "Solteira(o)" } }, "Value", "Text", 0);
            ViewBag.Sexo = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Masculino" }, new SelectListItem() { Value = "1", Text = "Feminino" }, new SelectListItem() { Value = "1", Text = "Outro" } }, "Value", "Text", 0);

            ViewBag.MeioPgto = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Cartão de Crédito" }, new SelectListItem() { Value = "1", Text = "Conta Digital" } }, "Value", "Text", retorno.DadosPagamentoId);
            ViewBag.Cargas = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "0", Text = "Municipal" }, new SelectListItem() { Value = "1", Text = "Intermunicipal" } }, "Value", "Text", retorno.DadosVeiculo.TipoEntregaId);

            var oProduto = CarregaProduto(Apolice.DadosProdutoId);
            var ListPgto = oProduto.Item.Valores.Select(s => new SelectListItem() { Value = s.ToString(), Text = "12x" + s.ToString()});
            ViewBag.Parcelas = new SelectList(ListPgto, "Value", "Text", 0);
            ViewBag.Seguradoras = new SelectList(CarregaLista("Apoio/ListarSeguradoras"), "Id", "Texto", retorno.DadosVeiculo.SeguradoraId);
            ViewBag.QdadeViagens = new SelectList(CarregaLista("Apoio/ListarQdadeViagens"), "Id", "Texto", retorno.DadosVeiculo.QdadeViagensId);
            ViewBag.RendasLiquidas = new SelectList(CarregaLista("Apoio/ListarRendasLiquidas"), "Id", "Texto", retorno.DadosVeiculo.RendaLiquidaId);
            ViewBag.Sindicatos = new SelectList(CarregaLista("Apoio/ListarSindicatos"), "Id", "Texto", retorno.VinculoId);
            ViewBag.VeiculoProprio = new SelectList(CarregaLista("Apoio/ListarVeiculoProprio"), "Id", "Texto", retorno.DadosVeiculo.VeiculoProprioId);
            ViewBag.Veiculos = new SelectList(CarregaLista("Apoio/ListarVeiculos"), "Id", "Texto", retorno.DadosVeiculo.VeiculoID);

            return retorno;
        }
        public List<TabelaApoioViewModel> CarregaLista(string Url)
        {
            List<TabelaApoioViewModel> retorno = new List<TabelaApoioViewModel>();
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<TabelaApoioDTO>>>())
            {
                RetornoGenericoDTO<List<TabelaApoioDTO>> retDTO = client.Post(Url, null);
                if (retDTO != null)
                {
                    var ret = Mapper.Map<RetornoGenericoDTO<List<TabelaApoioDTO>>, RetornoGenericoViewModel<List<TabelaApoioViewModel>>>(retDTO);
                    if (ret.ID > -1)
                    {
                        retorno = ret.Item;
                        retorno.Insert(0, new TabelaApoioViewModel() { ID = 0, Codigo = "", Texto = ":: Selecione ::" });
                    }
                }
            }
            return retorno;
        }
        public RetornoGenericoViewModel<ProdutoViewModel> CarregaProduto(int ProdutoID)
        {
            RetornoGenericoViewModel<ProdutoViewModel> retorno = new RetornoGenericoViewModel<ProdutoViewModel>();
            using (var client = new HttpClientUtil<RetornoGenericoDTO<ProdutoDTO>>())
            {
                ProdutoDTO filtro = new ProdutoDTO() {Id = ProdutoID };
                RetornoGenericoDTO<ProdutoDTO> retDTO = client.Post("Produtos/Item", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<ProdutoDTO>, RetornoGenericoViewModel<ProdutoViewModel>>(retDTO);
                }
            }
            return retorno;
        }
    }
}