using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_abstraction
{
    internal abstract class Device
    {
        public string Name { get; set; }

        public bool Connected { get; set; }

        public Device(string name)
        {
            Name = name;
            Connected = false;
        }
    }
}
