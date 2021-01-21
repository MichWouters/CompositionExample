using System;
using System.Collections.Generic;
using System.Text;

namespace CompositionExample
{
    public class Installer
    {
        private Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            // Do magic
            _logger.LogInformation("Installing app");
            _logger.LogError("Something went wrong");
        }
    }
}
