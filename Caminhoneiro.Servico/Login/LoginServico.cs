using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Caminhoneiro.Models.Login;
using Caminhoneiro.Servico.Util;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Caminhoneiro.Servico.Login
{
    public class LoginServico
    {
        public RetornoLoginModel autenticacaoLogin(string clientId, string apiKey, string apiVersion, string login, string senha)
        {
            RetornoLoginModel ret = new RetornoLoginModel();
            try
            {              
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Constantes.GPROXS_CONNECTOR_URI + "aplicacao/login");
                    client.DefaultRequestHeaders.Add(Constantes.HEADER_PARAM_CLIENTID, clientId);
                    client.DefaultRequestHeaders.Add(Constantes.HEADER_PARAM_APIKEY, apiKey);
                    client.DefaultRequestHeaders.Add(Constantes.HEADER_PARAM_API_VERSION, apiVersion);

                    LoginDTO dto = new LoginDTO()
                    {
                        usuario = login,
                        senha = senha
                    };

                    Task<HttpResponseMessage> postTask = client.PostAsJsonAsync<LoginDTO>("login", dto);
                    postTask.Wait();
                    HttpResponseMessage result = postTask.Result;


                    var log = result.Content.ReadAsStringAsync().Result;
                    ret = new JavaScriptSerializer().Deserialize<RetornoLoginModel>(log);
                    return ret;
                }
            }
            catch
            {
                ret.token = null;
                return ret;
            }
        }

       
    }
}