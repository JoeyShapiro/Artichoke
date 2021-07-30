using System;
using System.Collections.Generic;
using System.Text;

namespace Artichoke.Models
{
    class Grocery : Item
    {
        public string Department { get; set; }
        public int Amount { get; set; }
        public string Requestor { get; set; }
    }
}
