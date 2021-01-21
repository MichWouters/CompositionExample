using System;

namespace CompositionExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string path = "C:/dev/foo.txt";
            Logger logger = new FileLogger(path);

            DbMigrator dbMigrator = new DbMigrator(logger);
            Installer installer = new Installer(logger);

            dbMigrator.Migrate();
            Console.WriteLine();
            installer.Install();

            Console.ReadLine();
        }
    }
}