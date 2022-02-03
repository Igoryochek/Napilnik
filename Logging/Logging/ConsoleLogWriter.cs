using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class ConsoleLogWriter : ILogger
    {
        private ILogger _logger;

        public ConsoleLogWriter(ILogger logger)
        {
            _logger = logger;
        }
        public ConsoleLogWriter()
        {
        }

        public void WriteError(string message)
        {
            Console.WriteLine(message);
            if (_logger != null)
                _logger.WriteError(message);
        }
    }
}
