using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class BrowserLogger : IRegisterLog
    {
        public void LogReport(string LogMessage, int LogID)
        {
            Console.WriteLine("Browser Logger: \n Log Message: {0}; LogID: {1}", LogMessage, LogID);
        }
    }
}
