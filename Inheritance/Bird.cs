using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public string Size { get; set; }
        public bool DoesMigrate { get; set; }
        public string ChirpSound { get; set; }
        public string FeatherColor { get; set; }
    }
}
