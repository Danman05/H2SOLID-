using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebsitePartOne
{
    public class WebRequestHandler : IMakeRequest
    {
        HttpClient httpClient;
        public WebRequestHandler(string url)
        {
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(url),


            };
        }

        public async Task<HttpResponseMessage> makeRequest()
        {
            var response = await httpClient.GetAsync(httpClient.BaseAddress);
            return response;
        }
    }
}
