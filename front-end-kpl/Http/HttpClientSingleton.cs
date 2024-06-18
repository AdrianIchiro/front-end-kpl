using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace front_end_kpl.Http
{
    public class HttpClientSingleton
    {
        private static readonly HttpClient _httpClient;

        static HttpClientSingleton()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, sslPolicyErrors) => { return true; };

            _httpClient = new HttpClient(handler);
        }

        public static HttpClient Instance
        {
            get { return _httpClient; }
        }
    }
}
