using Caminhoneiro.MapViewModelDTO;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Caminhoneiro.Web
{
    /// <summary>
    /// Classe Application do Site
    /// </summary>
    public class MvcApplication : System.Web.HttpApplication
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            logar.Debug("Inicio Application_Start");
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            ViewModelDTOConfig.ResgistrarMap();
            logar.Debug("Termino Application_Start");
        }
        /// <summary>
        /// Método utilizado para rastremento de erros do IIS
        /// </summary>
        protected void Application_Error()
        {
            var ex = Server.GetLastError();
            logar.Warn(ex);
        }
    }
}
