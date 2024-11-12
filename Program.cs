namespace NcDeviceSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> devices = new List<Device>
            {
                new Scanner("YourScannerName"),
                new Laptop("YourLaptopName"),
                new Smartphone("YourSmartphoneName")
            };

            devices[1].Connected = true;

            devices[0].InstallApp(App.GetApp("WELCOME"));
            devices[1].InstallApp(App.GetApp("BACKUP"));
            devices[2].InstallApp(App.GetApp("BACKUP"));
            devices[1].InstallApp(App.GetApp("RENDER"));
            devices[2].InstallApp(App.GetApp("RENDER"));


            devices.ForEach(device => device.RunDevice());
        }
    }
}
