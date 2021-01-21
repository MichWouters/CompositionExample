using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExample
{
    public class Logger
    {
        public int Id { get; set; }

        public virtual void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public virtual void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
        }
    }
}
