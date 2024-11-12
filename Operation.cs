namespace NcDeviceSystem
{
    internal class Operation : IRunnable
    {
        public string Name { get; set; }

        public bool RequiresConnection { get; set; }

        private readonly string operation;

        public Operation(string name, string operation, bool requiresConnection)
        {
            Name = name;
            RequiresConnection = requiresConnection;
            this.operation = operation;
        }

        public void Run(bool connected)
        {
            if (RequiresConnection && !connected) // if requires connection and not connected
            {
                Console.WriteLine($"Operation '{this.Name}' requires connection but no connection is available");
                return;
            }

            Console.WriteLine(operation);
            Console.WriteLine($"Operation '{this.Name}' run succesfully");
        }
    }
}
