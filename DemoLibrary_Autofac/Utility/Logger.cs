using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utility
{
    public class Logger : ILogger
    {
        public void Log(string massage)
        {
            Console.WriteLine($"{massage}");
        }
    }
}
