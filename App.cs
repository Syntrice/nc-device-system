namespace NcDeviceSystem
{
    internal class App : IRunnable
    {
        public string Name { get; set; }
        public ApplicationFunctions Function { get; set; }
        public bool RequiresConnection { get; set; }
        public Device Device { get; set; }

        public App(string name, ApplicationFunctions function, bool requiresConnection)
        {
            Name = name;
            Function = function;
            RequiresConnection = requiresConnection;
        }

        public void SetDevice(Device device)
        {
            Device = device;
        }

        public void Run(bool connected)
        {
            if (!Device.InstalledApps.Contains(this)) // if app not installed on device
            {
                Console.WriteLine($"App '{this.Name}' is not installed on device '${Device.Name}'");
                return;
            }

            if (RequiresConnection && !connected) // if requires connection and not connected
            {
                Console.WriteLine($"App '{this.Name}' requires connection but no connection is available");
                return;
            }

            Functionality.ExecuteFunction(Function);
            Console.WriteLine($"App '{this.Name}' run succesfully");

        }

        public static List<App> Apps { get; }

        static App()
        {
            Apps = new List<App>
            {
                new App("WELCOME", ApplicationFunctions.WELCOME, false),
                new App("DATA", ApplicationFunctions.DATA, true),
                new App("BACKUP", ApplicationFunctions.BACKUP, true),
                new App("RENDER", ApplicationFunctions.RENDER, false)
            };
        }

        public static App? GetApp(string name)
        {
            name = name.ToUpper();
            foreach (App app in Apps)
            {
                if (app.Name.ToUpper() == name) return app;
            }

            Console.WriteLine($"App {name} not found.");
            return null;
        }

        
    }
}
