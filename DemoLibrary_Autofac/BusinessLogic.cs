using DemoLibrary;
using DemoLibrary.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        IDataAccess _dataAccess;
        ILogger _logger;

        public BusinessLogic(IDataAccess dataAccess, ILogger logger)
        {
            _dataAccess = dataAccess;
            _logger = logger;
        }

        public void ProcessRun()
        {
            _logger.Log("Starting Loging");
            Console.WriteLine("Processing the data");

            _dataAccess.Load();
            _dataAccess.SaveData();

            _logger.Log("Finished processing of the data.");           
        }
    }
}
