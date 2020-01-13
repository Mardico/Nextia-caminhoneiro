using System.Configuration;

namespace Caminhoneiro.Util
{
    public static class ConfigurationUtil
    {
        public static string GProxsConnectorURI
        {
            get
            {
                return ConfigurationManager.AppSettings["GProxsConnectorURI"];
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
        public static string GoogleSecret
        {
            get
            {
                return ConfigurationManager.AppSettings["Google.ReCaptcha.Secret"];
            }
        }
        public static string GoogleSitekey
        {
            get
            {
                return ConfigurationManager.AppSettings["Google.ReCaptcha.Sitekey"];
            }
        }
        public static string GoogleURL
        {
            get
            {
                return ConfigurationManager.AppSettings["Google.ReCaptcha.URL"];
            }
        }

        public static string PROXY_URL
        {
            get
            {
                return ConfigurationManager.AppSettings["PROXY_URL"];
            }
        }
        public static string PROXY_USER
        {
            get
            {
                return ConfigurationManager.AppSettings["PROXY_USER"];
            }
        }
        public static string PROXY_PASS
        {
            get
            {
                return ConfigurationManager.AppSettings["PROXY_PASS"];
            }
        }
    }
}
