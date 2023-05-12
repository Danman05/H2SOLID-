using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPart1
{
    public class FileResult
    {
        /// <summary>
        /// Gets the file request result
        /// </summary>
        /// <param name="webHandler"></param>
        /// <returns></returns>
        public string GetResult(FileRequestHandler path)
        {
            return path.MakeRequest().Result;
        }
    }
}
