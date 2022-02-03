using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    class SecureConsoleLogWriter : ILogger
    {
        private ILogger _logger;

        public SecureConsoleLogWriter(ILogger logger)
        {
            _logger = logger;
        }

        public void WriteError(string message)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)            
                _logger.WriteError(message);          
        }
    }
}
