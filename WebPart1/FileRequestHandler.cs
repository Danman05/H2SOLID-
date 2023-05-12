using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebPart1
{
    public class FileRequestHandler : IMakeRequest
    {
        private string? _fileString;
        private string? _fileContent;

        // Constructor
        public FileRequestHandler(string path)
        {
                _fileString = path;
        }

        public async Task<string> MakeRequest()
        {
            // Tries to read a file, catches if File is not found or other reasons
            try
            {
                _fileContent = File.ReadAllText(_fileString);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (Exception)
            {
            }
            finally
            {
                
            }
            return _fileContent;
        }
    }
}
