using Caminhoneiro.Entidade;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Caminhoneiro.API
{
    /// <summary>
    /// Classe Application do WebAPI
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Metodo Disparado na Inicialização do Site
        /// </summary>
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            //AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            InicializaDB();
        }
        /// <summary>
        /// Método utilizado para rastremento de erros do IIS
        /// </summary>
        protected void Application_Error()
        {
            var ex = Server.GetLastError();
            logar.Warn(ex);
        }

        private void InicializaDB()
        {
            Seguradoras oSeguradoras = new Seguradoras();
            QdadeViagens oQdadeViagens = new QdadeViagens();
            RendasLiquidas oRendasLiquidas = new RendasLiquidas();
            Sindicatos oSindicatos = new Sindicatos();
            VeiculoProprio oVeiculoProprio = new VeiculoProprio();
            Veiculos oVeiculos = new Veiculos();
            Usuarios oUsuarios = new Usuarios();
            Produtos oProdutos = new Produtos();
            Clientes oClientes = new Clientes();
            ApoliceDadosProduto oApoliceDadosProduto = new ApoliceDadosProduto();
            ApoliceDadosVeiculo oApoliceDadosVeiculo = new ApoliceDadosVeiculo();
            ApoliceDadosPagamento oApoliceDadosPagamento = new ApoliceDadosPagamento();
            ApoliceDadosDependente oApoliceDadosDependente = new ApoliceDadosDependente();
            ApoliceStatus oApoliceStatus = new ApoliceStatus();
            Apolices oApolices = new Apolices();

        }
    }
}
