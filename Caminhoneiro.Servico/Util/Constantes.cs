using System.Configuration;

namespace Caminhoneiro.Servico.Util
{
    public class Constantes
    {
        public static string HEADER_PARAM_CLIENTID = "Client_ID";
        public static string HEADER_PARAM_APIKEY = "API_Key";
        public static string HEADER_PARAM_API_VERSION = "api-version";
        public static string TOKEN_CLAIM_USERID = "ID_USER";

        public static string GPROXS_CONNECTOR_URI = ConfigurationManager.AppSettings["GProxsConnectorURI"];
        public static string clientId = ConfigurationManager.AppSettings["clientId"];
        public static string apiKey = ConfigurationManager.AppSettings["apiKey"];
        public static string apiVersion = ConfigurationManager.AppSettings["apiVersion"];
    }
}