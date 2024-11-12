using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NcDeviceSystem
{
    internal class Laptop : Device, IWirelessConnectable
    {
        public Laptop(string name) : base(name)
        {

        }

        public void Connect()
        {
            Connected = true;
            Console.WriteLine($"Laptop '{Name}' successfully connected to wireless network");
        }

        public void ConnectScanner(Scanner scanner)
        {
            scanner.Connected = true;
            Console.WriteLine($"Scanner '{scanner.Name}' successfully connected");
        }

    }
}
