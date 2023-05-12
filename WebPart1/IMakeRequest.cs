using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPart1
{
    /// <summary>
    /// Interface for items making requests
    /// </summary>
    interface IMakeRequest
    {
        Task<string> MakeRequest();
    }
}
