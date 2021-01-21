using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CompositionExample
{
    class FileLogger: Logger
    {
        private string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public override void LogError(string message)
        {
            using StreamWriter writer =
                new StreamWriter(_path, true);

            message = $"ERROR: {message}";
            writer.Write(message);
        }

        public override void LogInformation(string message)
        {
            using StreamWriter writer =
                new StreamWriter(_path, true);

            message = $"INFO: {message}";
            writer.Write(message);
        }
    }
}
