using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utility
{
    class Logger
    {
        public void Log(string massage)
        {
            Console.WriteLine($"{massage}");
        }
    }
}
