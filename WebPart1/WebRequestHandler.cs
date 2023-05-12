using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPart1
{
    public class WebRequestHandler : IMakeRequest
    {
        HttpClient httpClient = new();
        private string? responseString;

        // Constructor
        public WebRequestHandler(string url)
        {
            try
            {
                httpClient.BaseAddress = new Uri(url);
            }
            catch (UriFormatException)
            {
                Console.WriteLine("Exception - Invalid URL");
            }
            catch (Exception)
            {
            }
        }

        public async Task<string> MakeRequest()
        {
            // Tries to get an response from a website, catches if operation is invalid or other reasons

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(httpClient.BaseAddress);
                responseString = await response.Content.ReadAsStringAsync();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Error making request", ex);
            }
            catch (Exception)
            {
            }
            finally
            {
                httpClient.Dispose();
            }
            return responseString;
        }
    }
}
