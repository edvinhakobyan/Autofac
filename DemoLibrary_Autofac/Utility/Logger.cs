using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utility
{
    class Logger : ILogger
    {
        IWriter _writer;

        public Logger(IWriter writer)
        {
            _writer = writer;
        }

        public void Log(string massage)
        {
            _writer.ConsoleWrite(massage);
            _writer.FileWrite(massage);
        }
    }
}
