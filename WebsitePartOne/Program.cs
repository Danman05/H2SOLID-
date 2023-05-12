
using System.Net;

namespace WebsitePartOne
{
    public class Program
    {

        static async void Main(string[] args)
        {

            Console.Write("Enter Url: ");
            string? url = Console.ReadLine();

            WebRequestHandler requestHandler = new WebRequestHandler(url);
            Console.WriteLine($"Making request to {url}");
            HttpResponseMessage message = await requestHandler.makeRequest();

            Console.WriteLine($"Status code {(int)message.StatusCode} / {message.StatusCode}");


            Console.Read();
        }
    }
}