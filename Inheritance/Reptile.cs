using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public string Size { get; set; }
        public bool HasTail { get; set; }
        public string Color { get; set; }
        public string Speed { get; set; }
    }
}
