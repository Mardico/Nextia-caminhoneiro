using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Caminhoneiro.Util
{
    public class HttpClientUtil<T> : IDisposable
        where T : class
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private HttpClient _client = new HttpClient();

        public HttpClientUtil()
        {
            _client.BaseAddress = new Uri(ConfigurationUtil.BaseUrlServicos);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.Timeout = new TimeSpan(0, 1, 0);
        }

        public HttpClientUtil(string _token) : this()
        {
            if (!string.IsNullOrEmpty(_token))
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _token);
        }

        public T Get(string url)
        {
            T retorno = null;

            try
            {
                using (HttpResponseMessage response = _client.GetAsync(url).Result)
                {
                    response.EnsureSuccessStatusCode();
                    if (response.IsSuccessStatusCode)
                    {
                        retorno = response.Content.ReadAsAsync<T>().Result;
                    }
                }
            }
            catch (Exception ex)
            {
                logar.ErrorFormat("Falha ao Carrega {0}, {1}", url, ex);
            }

            return retorno;
        }

        public T Post(string url, object obj = null)
        {
            T retorno = null;
            try
            {
                var json = JsonConvert.SerializeObject(obj);
                using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    using (HttpResponseMessage response = _client.PostAsync(url, content).Result)
                    {
                        response.EnsureSuccessStatusCode();
                        if (response.IsSuccessStatusCode)
                        {
                            retorno = response.Content.ReadAsAsync<T>().Result;
                        }
                    }
                }
                json = null;
            }
            catch (Exception ex)
            {
                logar.ErrorFormat("Falha ao Carrega {0}, {1}", url, ex);
            }
            return retorno;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_client != null)
                {
                    _client.Dispose();
                    _client = null;
                }
            }
        }
    }

    public class HttpClientUtil : IDisposable
    {
        private readonly log4net.ILog logar = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private HttpClient _client = new HttpClient();

        public HttpClientUtil(string _token) : this()
        {
            if (!string.IsNullOrEmpty(_token))
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", _token);
        }

        public HttpClientUtil()
        {
            _client.BaseAddress = new Uri(ConfigurationUtil.BaseUrlServicos);
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.Timeout = new TimeSpan(0, 1, 0);
        }

        public void Put(string url, object obj)
        {
            var json = JsonConvert.SerializeObject(obj);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            using (HttpResponseMessage response = _client.PostAsync(url, content).Result)
            {
                response.EnsureSuccessStatusCode();
            }
        }

        public string Post(string url, object obj = null)
        {
            string retorno = null;
            try
            {
                var json = JsonConvert.SerializeObject(obj);
                using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    using (HttpResponseMessage response = _client.PostAsync(url, content).Result)
                    {
                        response.EnsureSuccessStatusCode();
                        if (response.IsSuccessStatusCode)
                        {
                            retorno = response.Content.ReadAsAsync<string>().Result;
                        }
                    }
                }
                json = null;
            }
            catch (Exception ex)
            {
                logar.ErrorFormat("Falha ao Carrega {0}, {1}", url, ex);
            }

            return retorno;
        }

        public object PostObj(string url, object obj = null)
        {
            object retorno = null;
            try
            {
                string json = JsonConvert.SerializeObject(obj);
                using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    using (HttpResponseMessage response = _client.PostAsync(url, content).Result)
                    {
                        response.EnsureSuccessStatusCode();
                        if (response.IsSuccessStatusCode)
                        {
                            retorno = response.Content.ReadAsAsync<object>().Result;
                        }
                    }
                }
                json = null;

            }
            catch (Exception ex)
            {
                logar.ErrorFormat("Falha ao Carrega {0}, {1}", url, ex);
            }

            return retorno;
        }

        public void Delete(string url, int id)
        {
            string urlConcat = String.Format("{0}/{1}", url, id);

            using (HttpResponseMessage response = _client.DeleteAsync(urlConcat).Result)
            {
                response.EnsureSuccessStatusCode();
            }

        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_client != null)
                {
                    _client.Dispose();
                    _client = null;
                }
            }
        }
    }
}
