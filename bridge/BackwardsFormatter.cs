using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class BackwardsFormatter : IFormatter
    {
        public string Format(string key, string value)
        {
            return $"{key}: {new string(value.Reverse().ToArray())}";
        }
    }
}
