using System;

namespace CompositionExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Logger logger = new AlternativeLogger();
            DbMigrator dbMigrator = new DbMigrator(logger);
            Installer installer = new Installer(logger);

            dbMigrator.Migrate();
            Console.WriteLine();
            installer.Install();

            Console.ReadLine();
        }
    }
}