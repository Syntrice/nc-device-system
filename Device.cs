namespace NcDeviceSystem
{
    internal abstract class Device
    {
        public string Name { get; set; }

        public bool Connected { get; set; }

        public List<IRunnable> InstalledApps { get; set; }

        public Device(string name)
        {
            Name = name;
            Connected = false;
            InstalledApps = new List<IRunnable>();
        }
    }
}
