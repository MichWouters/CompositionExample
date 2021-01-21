using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExample
{
    public class AlternativeLogger: Logger
    {
        public override void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
        }

        public override void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}
