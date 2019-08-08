﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Utility
{
    class DataAccess : IDataAccess
    {
        public void Load()
        {
            Console.WriteLine("Loading Data");
        }

        public void SaveData()
        {
            Console.WriteLine("Saving Data");
        }
    }
}
