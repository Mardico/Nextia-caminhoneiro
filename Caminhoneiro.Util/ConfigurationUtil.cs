using System.Configuration;

namespace Caminhoneiro.Util
{
    public static class ConfigurationUtil
    {
        public static string BaseUrlServicos
        {
            get
            {
                return ConfigurationManager.AppSettings["URLBASEKEEP"];
            }
        }
    }
}
