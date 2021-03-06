﻿using AutoMapper;
using Caminhoneiro.DTO;
using Caminhoneiro.Util;
using Caminhoneiro.ViewModel;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
namespace Caminhoneiro.Web.Controllers
{
    [Authorize]
    public class SeguradoController : BaseController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ActionResult Index()
        {
            if (TempData["Mensagem"] != null)
                ViewBag.Mensagem = TempData["Mensagem"];
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
        public ActionResult KitProduto(ClienteApoliceViewModel FiltroApolice)
        {
            ViewBag.Produto = "";
            if (FiltroApolice.ApoliceId > 0)
            {
                using (var client = new HttpClientUtil<RetornoGenericoDTO<ApoliceDTO>>())
                {
                    FiltroGenericoDTO filtro = new FiltroGenericoDTO() {ID = FiltroApolice.ApoliceId };
                    RetornoGenericoDTO<ApoliceDTO> retDTO = client.Post("Apolice/Item", filtro);
                    if (retDTO != null)
                    {
                        var retorno = Mapper.Map<RetornoGenericoDTO<ApoliceDTO>, RetornoGenericoViewModel<ApoliceViewModel>>(retDTO);
                        if (retorno.ID > 0)
                            ViewBag.Produto = retorno.Item.DadosProduto;
                    }
                }
            }
            return View(FiltroApolice);
        }
        public ActionResult DadosCadastrais(ClienteApoliceViewModel FiltroCliente)
        {
            RetornoGenericoViewModel<ClienteViewModel> retorno = new RetornoGenericoViewModel<ClienteViewModel>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<ClienteDTO>>())
            {
                ClienteDTO filtro = Mapper.Map<ClienteApoliceViewModel, ClienteDTO>(FiltroCliente);
                RetornoGenericoDTO<ClienteDTO> retDTO = client.Post("Cliente/Item", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<ClienteDTO>, RetornoGenericoViewModel<ClienteViewModel>>(retDTO);
                    if (retorno.ID > 0)
                        return View(retorno.Item);
                }
            }
            return RedirectToAction("Index", new { retorno.Mensagem });

        }
        public ActionResult ListaTodos(ClienteViewModel Cliente)
        {
            RetornoGenericoViewModel<List<ClienteViewModel>> retorno = new RetornoGenericoViewModel<List<ClienteViewModel>>(-1, "Falha ao Acessar API");
            ViewData["Filtro"] = Cliente;
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<ClienteDTO>>>())
            {
                ClienteDTO filtro = Mapper.Map<ClienteViewModel, ClienteDTO>(Cliente);
                RetornoGenericoDTO<List<ClienteDTO>> retDTO = client.Post("Cliente/Listar", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<List<ClienteDTO>>, RetornoGenericoViewModel<List<ClienteViewModel>>>(retDTO);
                    if (retorno.ID > -1)
                        return View(retorno.Item);

                }
            }
            if (retorno.ID < 0)
                ViewBag.Mensagem = retorno.Mensagem;
            return View();
        }
        public JsonResult SolicitarKitProduto(ApoliceKitProdutoViewModel dados = null)
        {
            logar.Debug("Inicio KitProduto");
            RetornoGenericoViewModel<bool> retorno = new RetornoGenericoViewModel<bool>(0, "Falha");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<bool>>())
            {
                try
                {
                    var filtroDTO = Mapper.Map<ApoliceKitProdutoViewModel, ApoliceKitProdutoDTO>(dados);
                    var retornoDTO = client.Post("Apolice/SolicitarKitProduto", filtroDTO);
                    retorno = Mapper.Map<RetornoGenericoDTO<bool>, RetornoGenericoViewModel<bool>>(retornoDTO);
                    retornoDTO = null;
                }
                catch (System.Exception ex)
                {
                    retorno.Mensagem = ex.Message;
                }

            }
            logar.Debug("Termino KitProduto");
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ConsultaSegurados(ClienteViewModel FiltroCliente)
        {
            RetornoGenericoViewModel<List<ClienteViewModel>> retorno = new RetornoGenericoViewModel<List<ClienteViewModel>>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<List<ClienteDTO>>>())
            {
                ClienteDTO filtro = Mapper.Map<ClienteViewModel, ClienteDTO>(FiltroCliente);
                RetornoGenericoDTO<List<ClienteDTO>> retDTO = client.Post("Cliente/Listar", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<List<ClienteDTO>>, RetornoGenericoViewModel<List<ClienteViewModel>>>(retDTO);
                    retorno.Item = retorno.Item.Take(2).ToList();
                }
            }
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ConsultaDadosSegurado(ClienteViewModel FiltroCliente)
        {
            RetornoGenericoViewModel<ClienteViewModel> retorno = new RetornoGenericoViewModel<ClienteViewModel>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<ClienteDTO>>())
            {
                ClienteDTO filtro = Mapper.Map<ClienteViewModel, ClienteDTO>(FiltroCliente);
                RetornoGenericoDTO<ClienteDTO> retDTO = client.Post("Cliente/Item", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<ClienteDTO>, RetornoGenericoViewModel<ClienteViewModel>>(retDTO);
                    retorno.Item = retorno.Item;
                    retorno.ID = retorno.Item.Id;
                    if (retorno.ID == 0)
                        retorno.Mensagem = "Usuário não localizado";

                }
            }
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
        public JsonResult ConsultaCEP(FiltroGenericoViewModel Filtro)
        {
            RetornoGenericoViewModel<ClienteViewModel> retorno = new RetornoGenericoViewModel<ClienteViewModel>(-1, "Falha ao Acessar API");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<ClienteDTO>>())
            {
                FiltroGenericoDTO filtro = Mapper.Map<FiltroGenericoViewModel, FiltroGenericoDTO>(Filtro);
                RetornoGenericoDTO<ClienteDTO> retDTO = client.Post("Cliente/BuscaCEP", filtro);
                if (retDTO != null)
                {
                    retorno = Mapper.Map<RetornoGenericoDTO<ClienteDTO>, RetornoGenericoViewModel<ClienteViewModel>>(retDTO);
                    retorno.Item = retorno.Item;
                }
            }
            return Json(retorno, JsonRequestBehavior.AllowGet);
        }
    }
}