namespace NcDeviceSystem
{
    internal class Smartphone : Device
    {
        public Smartphone(string name) : base(name)
        {
            InstalledApps.Add(new Operation("Scroll", $"{this.Name} is scrolling based on user input...", false));
        }

        public void Connect()
        {
            Connected = true;
            Console.WriteLine($"Smartphone '{Name}' successfully connected to wireless network");
        }

    }
}
