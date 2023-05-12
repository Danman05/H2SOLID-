namespace WebPart1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // url and path
            string? _url = "https://jsonplaceholder.typicode.com/todos/3";
            string? _path = "test.txt";

            // new instances of objects
            WebResult webResult = new WebResult();
            FileResult fileResult = new FileResult();

            WebRequestHandler requestHandler = new WebRequestHandler(_url);
            FileRequestHandler fileHandler = new FileRequestHandler(_path);


            Console.WriteLine($"Making request to {_url}");

            // Get web result
            Console.WriteLine(webResult.GetResult(requestHandler));

            // Get file result
            Console.WriteLine(fileResult.GetResult(fileHandler));

            Console.Read();
        }
    }
}