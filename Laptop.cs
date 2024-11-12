namespace NcDeviceSystem
{
    internal class Laptop : Device, IWirelessConnectable
    {
        public Laptop(string name) : base(name)
        {
            InstalledApps.Add(new Operation("Install Peripheral", $"Installing peripheral on {this.Name}...", false));
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
