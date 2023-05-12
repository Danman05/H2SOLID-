using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPart1
{
    public class WebResult
    {
        /// <summary>
        /// Gets the web request result
        /// </summary>
        /// <param name="webHandler"></param>
        /// <returns></returns>
        public string GetResult(WebRequestHandler webHandler)
        {
            return webHandler.MakeRequest().Result;
        }
    }
}
