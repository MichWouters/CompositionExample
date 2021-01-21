using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExample
{
    public class DbMigrator
    {
        private Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            // Do migrator magic
            _logger.LogInformation("Logging started");
            _logger.LogError("Logging went wrong");
        }
    }
}
