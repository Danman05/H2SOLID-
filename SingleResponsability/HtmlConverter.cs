﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability
{
    public class HtmlConverter : IConverter
    {
        public string Convert(string plainText)
        {
            return "<body>" + plainText + "</body>";
        }
    }
}
