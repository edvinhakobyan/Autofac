using DemoLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic
    {
        public void ProcessRun()
        {
            Logger loger = new Logger();
            DataAccess dataAccess = new DataAccess();

            loger.Log("Starting Loging");
            Console.WriteLine("Processing the data");

            dataAccess.Load();
            dataAccess.SaveData("==+++==");

            loger.Log("Finished processing of the data.");           

        }
    }
}
