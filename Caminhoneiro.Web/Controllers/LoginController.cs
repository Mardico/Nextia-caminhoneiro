using AutoMapper;
using Caminhoneiro.DTO;
using Caminhoneiro.Util;
using Caminhoneiro.ViewModel;
using System;
using System.Configuration;
using System.Web.Mvc;
using System.Web.Security;
using System.Linq;

namespace Caminhoneiro.Web.Controllers
{
    public class LoginController : BaseController
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FiltroLoginViewModel login)
        {
            logar.Debug("Inicio Logar");
            using (var client = new HttpClientUtil<RetornoGenericoDTO<UsuarioDTO>>())
            {
                FiltroLoginDTO filtroDTO = Mapper.Map<FiltroLoginViewModel, FiltroLoginDTO>(login);
                RetornoGenericoDTO<UsuarioDTO> retDTO = client.Post("Usuario/Logar", filtroDTO);
                if (Autenticar(retDTO))
                    return RedirectToAction("", "Segurado");
            }
            logar.Debug("Termino Logar");
            return View();
        }

        /// <summary>
        /// Controller da pagina solicitação de senha
        /// </summary>
        /// <param name="app">Codigo do aplicativo associado para redirecionamento, validação e construção de layout</param>
        /// <returns></returns>
        [AllowAnonymous]
        public ActionResult Esqueci(SolicitaAcessoViewModel filtro = null)
        {
            ViewBag.SiteKey = ConfigurationUtil.GoogleSitekey;
            if (Request.HttpMethod == "POST")
            {
                var encodedResponse = Request.Form["g-Recaptcha-Response"];
                var Captcha = ReCaptcha.Validate(encodedResponse);

                if (!Captcha.Success)
                {
                    ViewBag.Erro = "Falha ao Validar Recapcha";
                    if (Captcha.ErrorCodes != null)
                        if (Captcha.ErrorCodes.Count > 0)
                            ViewBag.Erro = string.Join("<br>", Captcha.ErrorCodes.ToArray());

                }
                else
                {
                    //Salva Solicitacao
                    using (var client = new HttpClientUtil<RetornoGenericoDTO<UsuarioDTO>>())
                    {
                        var listaDTO = client.Post("Usuario/SolicitaSenha", new FiltroGenericoDTO() { Texto = filtro.Usuario });
                        if ((listaDTO != null) && (listaDTO.ID > 0))
                        {
                            return RedirectToAction("Confirmacao", "Login");
                        }
                        else
                            return RedirectToAction("Error", "Error");
                    }
                }
            }
            return View();
        }

        [AllowAnonymous]
        public ActionResult Confirmacao()
        {
            return View();
        }
        public ActionResult Sair()
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            return View();
        }
    }
}