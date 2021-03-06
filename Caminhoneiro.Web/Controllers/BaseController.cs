﻿using AutoMapper;
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
            retorno.DadosCliente.ContactarPorId = null;
            retorno.DadosCliente.EstadoCivilId = null;
            retorno.DadosCliente.SexoId = null;
            retorno.DadosVeiculo.TipoEntregaId = null;
            retorno.DadosVeiculo.Segurado = null;
            retorno.DadosPagamento.MeioPgtoId = 0;
            retorno.DadosVeiculo.SolicitouServApolice = null;
            if (Apolice != null)
            {
                if (Apolice.DadosProduto.ProdutoId > 0 && Apolice.Id == 0)
                {
                    retorno.DadosCliente.CPF = Apolice.Codigo;
                    using (var client = new HttpClientUtil<RetornoGenericoDTO<ApoliceDadosProdutoDTO>>())
                    {
                        FiltroGenericoDTO filtro = new FiltroGenericoDTO() { ID = Apolice.DadosProduto.ProdutoId, Valor = UsuarioAtual.Id };
                        RetornoGenericoDTO<ApoliceDadosProdutoDTO> retDTO = client.Post("Apolice/DadosProduto", filtro);
                        if (retDTO != null && retDTO.ID > 0)
                        {
                            var oItem = Mapper.Map<RetornoGenericoDTO<ApoliceDadosProdutoDTO>, RetornoGenericoViewModel<ApoliceDadosProdutoViewModel>>(retDTO);
                            retorno.DadosProduto = oItem.Item;
                        }
                    }
                }

                if ((Apolice.DadosClienteId > 0 || !string.IsNullOrEmpty(Apolice.Codigo)) && Apolice.Id == 0)
                {
                    using (var client = new HttpClientUtil<RetornoGenericoDTO<ClienteDTO>>())
                    {
                        ClienteDTO filtro = new ClienteDTO() { Id = Apolice.DadosClienteId, CPF = Apolice.Codigo };
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
                        FiltroGenericoDTO filtro = new FiltroGenericoDTO() { ID = Apolice.Id };
                        RetornoGenericoDTO<ApoliceDTO> retDTO = client.Post("Apolice/Item", filtro);
                        if (retDTO != null && retDTO.ID > 0)
                        {
                            var oItem = Mapper.Map<RetornoGenericoDTO<ApoliceDTO>, RetornoGenericoViewModel<ApoliceViewModel>>(retDTO);
                            retorno = oItem.Item;
                            Apolice.DadosProdutoId = oItem.Item.DadosProdutoId;
                            Apolice.DadosClienteId = oItem.Item.DadosClienteId;
                        }
                    }
                }
                else
                {
                    if (UsuarioAtual.Vinculos != null && UsuarioAtual.Vinculos.FirstOrDefault() != null)
                        retorno.VinculoId = UsuarioAtual.Vinculos.FirstOrDefault().Id;
                }
            }

            //Carrega combos
            ViewBag.SimNao = new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "0", Text = "Não" }, new SelectListItem() { Value = "1", Text = "Sim" } };

            ViewBag.Segurado = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "N", Text = "Não" }, new SelectListItem() { Value = "S", Text = "Sim" } }, "Value", "Text", retorno.DadosVeiculo.Segurado);
            ViewBag.SolicitouServApolice = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "0", Text = "Não" }, new SelectListItem() { Value = "1", Text = "Sim" } }, "Value", "Text", retorno.DadosVeiculo.SolicitouServApolice);
            ViewBag.Contactar = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "0", Text = "WhatsApp" }, new SelectListItem() { Value = "1", Text = "E-mail" } }, "Value", "Text", retorno.DadosCliente.ContactarPorId);
            ViewBag.EstadoCivil = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "C", Text = "Casada(o)" }, new SelectListItem() { Value = "D", Text = "Desquitada(o)" }, new SelectListItem() { Value = "I", Text = "Divorciada(o)" }, new SelectListItem() { Value = "V", Text = "Viúva(o)" }, new SelectListItem() { Value = "O", Text = "Outros" } }, "Value", "Text", retorno.DadosCliente.EstadoCivilId);
            ViewBag.Sexo = new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "M", Text = "Masculino" }, new SelectListItem() { Value = "F", Text = "Feminino" } };
            ViewBag.GrauDependencia = new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "1", Text = "Cônjugue" }, new SelectListItem() { Value = "2", Text = "Filho(a)" }, new SelectListItem() { Value = "3", Text = "Enteado(a)" }, new SelectListItem() { Value = "4", Text = "Pai" }, new SelectListItem() { Value = "5", Text = "Mãe" }, new SelectListItem() { Value = "6", Text = "Agregado" }, new SelectListItem() { Value = "7", Text = "Irmão(ã)" } };

            ViewBag.MeioPgto = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "0", Text = "Cartão de Crédito" }, new SelectListItem() { Value = "1", Text = "Conta Digital" } }, "Value", "Text", retorno.DadosPagamento.MeioPgtoId);
            ViewBag.Cargas = new SelectList(new List<SelectListItem>() { new SelectListItem() { Value = "", Text = ":: Selecione ::" }, new SelectListItem() { Value = "0", Text = "Municipal" }, new SelectListItem() { Value = "1", Text = "Intermunicipal" } }, "Value", "Text", retorno.DadosVeiculo.TipoEntregaId);

            var oProduto = CarregaProduto(Apolice.DadosProdutoId);
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
                        retorno.Insert(0, new TabelaApoioViewModel() { ID = null, Codigo = "", Texto = ":: Selecione ::" });
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
                ProdutoDTO filtro = new ProdutoDTO() { Id = ProdutoID };
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