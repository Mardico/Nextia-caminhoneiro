using Caminhoneiro.Models.Cliente;
using Caminhoneiro.Servico.Cliente;
using Caminhoneiro.Servico.Util;
using Caminhoneiro.Web.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caminhoneiro.Web.Controllers
{
    public class SeguradoController : Controller
    {
        Validacoes _validacoes = new Validacoes();


        public ActionResult ConsultarSegurado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ConsultarSegurado(ClienteDTO cliDTO)
        {
            ClienteServico _clienteServico = new ClienteServico();
            RetornoClienteModel ret = new RetornoClienteModel();
            try
            {
                if (validarSessao() == true)
                {
                    bool valida = _validacoes.isCPFCNPJ(cliDTO.cpf, false);
                    if (valida == true)
                    {
                        ret = _clienteServico.getCliente(Constantes.clientId, Constantes.apiKey, Constantes.apiVersion,
                            Session["Token"].ToString(), cliDTO.cpf);
                        if (ret != null)
                        {
                            return RedirectToAction("DadosCadastrais", "Segurado");
                        }
                        else
                        {
                            ViewBag.Mensagem = "CPF não encontrado!";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Mensagem = "CPF incorreto! Verifique os dados";
                        return View();
                    }
                }
                else
                {
                    return RedirectToAction("Login", "Login");
                }
            }
            catch
            {
                //implementar mensagem de erro ao consultar Serviço
                return View();
            }

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

        public bool validarSessao()
        {
            if (Session["Token"] != null)
                return true;
            else
                return false;

        }
    }
}