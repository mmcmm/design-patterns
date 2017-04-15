using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    internal class StandardFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {value}";
        }
    }
}
