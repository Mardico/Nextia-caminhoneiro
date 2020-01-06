using Caminhoneiro.Models.Produto;
using Caminhoneiro.Servico.Produto;
using Caminhoneiro.Servico.Util;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Caminhoneiro.Web.Controllers
{
    public class ApoliceController : Controller
    {
        
        public ActionResult Index()
        {
            try
            {
                ProdutoServico _produtoServico = new ProdutoServico();
                List<RetornoProdutoModel> ret = new List<RetornoProdutoModel>();
                if(validarSessao()==true)
                {
                    ret = _produtoServico.getProdutos(Constantes.clientId, Constantes.apiKey, Constantes.apiVersion,
                    Session["Token"].ToString(), "1", "2");
                    if (ret != null)
                    {
                        return View(ret);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Error");
                    }
                }
                else
                {
                    return RedirectToAction("Login", "Login");
                }
                
            }
            catch (Exception ex)
            {
                string mensagem = ex.Message.ToString();
                return View();
            }
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

        public bool validarSessao()
        {
            if (Session["Token"] != null)
                return true;
            else
                return false;

        }


    }
}