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

        public virtual void InstallApp(App app)
        {
            app.SetDevice(this);
            InstalledApps.Add(app);
            Console.WriteLine($"Successfully installed app {app.Name}");
        }

        public void RunDevice()
        {
            foreach (IRunnable runnable in InstalledApps)
            {
                runnable.Run(Connected);
            }
        }
    }
}
