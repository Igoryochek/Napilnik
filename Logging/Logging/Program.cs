using System;

namespace Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            Pathfinder pathfinder1 = new Pathfinder(new FileLogWriter());
            Pathfinder pathfinder2 = new Pathfinder(new ConsoleLogWriter());
            Pathfinder pathfinder3 = new Pathfinder(new SecureConsoleLogWriter(new FileLogWriter()));
            Pathfinder pathfinder4 = new Pathfinder(new SecureConsoleLogWriter(new ConsoleLogWriter()));
            Pathfinder pathfinder5 = new Pathfinder(new ConsoleLogWriter(new SecureConsoleLogWriter(new FileLogWriter())));

            pathfinder1.Find();
            pathfinder2.Find();
            pathfinder3.Find();
            pathfinder4.Find();
            pathfinder5.Find();
        }
    }
}
