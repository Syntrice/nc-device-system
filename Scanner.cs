namespace NcDeviceSystem
{
    internal class Scanner : Device
    {
        public Scanner(string name) : base(name)
        {
            InstalledApps.Add(new Operation("Scan", $"{this.Name} now scanning...", true));
        }

        public override void InstallApp(App app)
        {
            Console.WriteLine($"Cannot install applications on scanner '{this.Name}'");
        }
    }
}
