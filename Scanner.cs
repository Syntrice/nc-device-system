using System.Security.Cryptography.X509Certificates;

namespace NcDeviceSystem
{
    internal class Scanner : Device
    {
        public Scanner(string name) : base(name)
        {

        }

        public override void InstallApp(App app)
        {
            Console.WriteLine($"Cannot install applications on scanner '{this.Name}'");
        }
    }
}
