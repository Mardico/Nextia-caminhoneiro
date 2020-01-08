using Caminhoneiro.Models.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using Caminhoneiro.Servico.Util;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace Caminhoneiro.Servico.Produto
{
    public class ProdutoServico
    {
        public List<RetornoProdutoModel> getProdutos(string clientId, string apiKey, string apiVersion,string token, string empresa, string usuario)
        {
            List<RetornoProdutoModel> ret = new List<RetornoProdutoModel>();
            try
            {

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(Constantes.GPROXS_CONNECTOR_URI + "produto/");
                    client.DefaultRequestHeaders.Add(Constantes.HEADER_PARAM_CLIENTID, clientId);
                    client.DefaultRequestHeaders.Add(Constantes.HEADER_PARAM_APIKEY, apiKey);
                    client.DefaultRequestHeaders.Add(Constantes.HEADER_PARAM_API_VERSION, apiVersion);
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);

                    Task<HttpResponseMessage> getTask = client.GetAsync($"?empresa={1}&usuario={"6goD{FZM+["}");
                    getTask.Wait();
                    HttpResponseMessage result = getTask.Result;
                    
                    var log = result.Content.ReadAsStringAsync().Result;
                    JavaScriptSerializer js = new JavaScriptSerializer();
                    ret= JsonConvert.DeserializeObject<List<RetornoProdutoModel>>(log);

                }
                    return ret;
            }
            catch(Exception ex)
            {
                string erro = ex.Message;
                return ret;
            }

        }
    }
}