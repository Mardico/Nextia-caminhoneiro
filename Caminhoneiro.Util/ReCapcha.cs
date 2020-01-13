using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace Caminhoneiro.Util
{
    public class ReCaptcha
    {
        public bool Success { get; set; }
        public List<string> ErrorCodes { get; set; }
        public static ReCaptcha Validate(string encodedResponse)
        {
            ReCaptcha reCaptcha = new ReCaptcha() { Success = false, ErrorCodes = new List<string>() };
            if (!string.IsNullOrEmpty(encodedResponse))
            {
                using (var client = new WebClient())
                {
                    try
                    {
                        if (!string.IsNullOrEmpty(ConfigurationUtil.PROXY_URL))
                        {
                            client.Proxy = new WebProxy(ConfigurationUtil.PROXY_URL, true)
                            {
                                Credentials = new NetworkCredential(
                                         ConfigurationUtil.PROXY_USER,
                                         ConfigurationUtil.PROXY_PASS)
                            };
                        }

                        var secret = ConfigurationUtil.GoogleSecret;
                        var URL = ConfigurationUtil.GoogleURL;

                        if (!string.IsNullOrEmpty(secret))
                        {
                            var googleReply = client.DownloadString(string.Format(URL + "?secret={0}&response={1}", secret, encodedResponse));
                            var serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                            reCaptcha = serializer.Deserialize<ReCaptcha>(googleReply);
                        }
                        else
                        {
                            reCaptcha.ErrorCodes.Add("Palavra chave não informada");
                        }
                    }
                    catch (Exception ex)
                    {
                        reCaptcha.ErrorCodes = new List<string>();
                        if (ex.InnerException != null)
                            reCaptcha.ErrorCodes.Add(ex.InnerException.Message);
                        else
                            reCaptcha.ErrorCodes.Add(ex.Message);
                    }
                }
            }
            else
            {
                reCaptcha.ErrorCodes.Add("Falha ao obter o recapcha");
            }
            return reCaptcha;
        }
    }
}
