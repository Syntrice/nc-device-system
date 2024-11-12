namespace NcDeviceSystem
{
    internal class Operation : IRunnable
    {
        public string Name { get; set; }

        public bool RequiresConnection { get; set; }

        private readonly string operation;

        public Operation(string name, bool requiresConnection, string operation)
        {
            Name = name;
            RequiresConnection = requiresConnection;
            this.operation = operation;
        }

        public void Run(bool connected)
        {
            throw new NotImplementedException();
        }
    }
}
