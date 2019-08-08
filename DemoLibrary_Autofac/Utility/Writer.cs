using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utility
{
    public class Writer : IWriter
    {
        public void ConsoleWrite(string masage)
        {
            Console.WriteLine(masage);
        }

        public void FileWrite(string masage)
        {
            
        }
    }
}
