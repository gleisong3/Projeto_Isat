using System;
using System.IO;

namespace Helpers
{
    public class GenericDataHelper
    {
        public string GetDatabasePath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data");
        }
    }
}
