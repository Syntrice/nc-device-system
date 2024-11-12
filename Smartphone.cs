namespace NcDeviceSystem
{
    internal class Smartphone : Device
    {
        public Smartphone(string name) : base(name)
        {

        }

        public void Connect()
        {
            Connected = true;
            Console.WriteLine($"Smartphone '{Name}' successfully connected to wireless network");
        }

    }
}
