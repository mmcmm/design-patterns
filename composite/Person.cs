﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Person : IParty
    {
        public string Name { get; set; }
        public int Gold { get; set; }
        
        public void Stats()
        {
            Console.WriteLine("{0} has {1} gold coins.", Name, Gold);
        }
    }
}
