using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class FileLogWriter : ILogger
    {
        private ILogger _logger;

        public FileLogWriter(ILogger logger)
        {
            _logger = logger;
        }
        public FileLogWriter()
        {
        }
        public void WriteError(string message)
        {
            File.WriteAllText("log.txt", message);
            if (_logger != null)
                _logger.WriteError(message);
        }
    }
}
