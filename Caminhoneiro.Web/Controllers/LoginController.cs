using Caminhoneiro.Servico.Login;
using Caminhoneiro.Servico.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Caminhoneiro.Models;
using Caminhoneiro.Models.Login;
using Caminhoneiro.Web.Models;
using System.Web.Security;

namespace Caminhoneiro.Web.Controllers
{
    public class LoginController : Controller
    {

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModels login)
        {
             try { 
                     LoginServico _loginS = new LoginServico();
                     RetornoLoginModel ret= 
                    _loginS.autenticacaoLogin(Constantes.clientId,Constantes.apiKey,Constantes.apiVersion,login.usuario, login.senha);
                     if(ret.token!=null)
                     {
                        Session["NomeUsuario"] = ret.nome.Substring(0,ret.nome.IndexOf(" "));
                        Session["Token"] = ret.token;

                        HttpCookie authCookie = FormsAuthentication.GetAuthCookie(ret.nome, true);
                        FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authCookie.Value);
                        FormsAuthenticationTicket newTicket = new FormsAuthenticationTicket(ticket.Version, ticket.Name, DateTime.Now, DateTime.Now.AddDays(1), 
                           ticket.IsPersistent, FormsAuthentication.FormsCookiePath);
                        authCookie.Value = FormsAuthentication.Encrypt(newTicket);

                        Response.Cookies.Add(authCookie);


                        return RedirectToAction("Index", "Apolice");
                     }
                     else
                     {
                            ViewBag.Mensagem = "Usuário não encontrado!";
                            return View();
                     }

             }
             catch
             {
                ViewBag.Mensagem = "Erro ao conectar no serviço de Login!";
                return View();
             }
        }

        public ActionResult Sair()
        {
            Session.Remove("Token");
            return RedirectToAction("Login","Login");
        }
    }
}