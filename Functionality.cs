namespace NcDeviceSystem
{
    public enum ApplicationFunctions
    {
        WELCOME,
        DATA,
        BACKUP,
        RENDER
    }
    public class Functionality
    {
        public interface IApplicationFunction
        {
            void Execute();
        }

        private static readonly Dictionary<ApplicationFunctions, IApplicationFunction> appFunctions = new Dictionary<ApplicationFunctions, IApplicationFunction>
        {
            { ApplicationFunctions.WELCOME, new ApplicationFunction(() =>
                {
                    Console.WriteLine("--- Running WELCOME ---");
                    Console.WriteLine("Welcome to the system, user!");
                    Console.WriteLine("Initialising system...");
                    Console.WriteLine("Setting up user preferences");
                    Console.WriteLine("-----------------------");
                })
            },
            { ApplicationFunctions.DATA, new ApplicationFunction(() =>
                {
                    Console.WriteLine("--- Running DATA ---");
                    Console.WriteLine("Fetching data from the database");
                    Console.WriteLine("Processing Data...");
                    Console.WriteLine("Applying business logic...");
                    Console.WriteLine("Data processing complete!");
                    Console.WriteLine("-----------------------");
                })
            },
            { ApplicationFunctions.BACKUP, new ApplicationFunction(() =>
                {
                    Console.WriteLine("--- Running BACKUP ---");
                    Console.WriteLine("Initiating Backup procedure...");
                    Console.WriteLine("Creating a backup of user data...");
                    Console.WriteLine("Ensuring data integrity...");
                    Console.WriteLine("Backup complete!");
                    Console.WriteLine("-----------------------");
                })
            },
            { ApplicationFunctions.RENDER, new ApplicationFunction(() =>
                {
                    Console.WriteLine("--- Running RENDER ---");
                    Console.WriteLine("Loading and displaying the main application screen...");
                    Console.WriteLine("Rendering interactive elements and controls...");
                    Console.WriteLine("Implementing accessibility features...");
                    Console.WriteLine("User input enabled.");
                    Console.WriteLine("-----------------------");
                })
            }
        };

        public static void ExecuteFunction(ApplicationFunctions appFunction)
        {
            if (appFunctions.ContainsKey(appFunction))
            {
                appFunctions[appFunction].Execute();
            }
        }

        private class ApplicationFunction : IApplicationFunction
        {
            private readonly Action action;

            public ApplicationFunction(Action action)
            {
                this.action = action;
            }

            public void Execute()
            {
                action();
            }
        }
    }
}



