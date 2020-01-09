using System.Configuration;

namespace Caminhoneiro.Util
{
    public static class ConfigurationUtil
    {
        public static string GProxsConnectorURI
        {
            get
            {
                return ConfigurationManager.AppSettings["URLBASEKEEP"];
            }
        }

        public static string clientId
        {
            get
            {
                return ConfigurationManager.AppSettings["clientId"];
            }
        }

        public static string apiKey
        {
            get
            {
                return ConfigurationManager.AppSettings["apiKey"];
            }
        }

        public static string apiVersion
        {
            get
            {
                return ConfigurationManager.AppSettings["apiVersion"];
            }
        }
    }
}
