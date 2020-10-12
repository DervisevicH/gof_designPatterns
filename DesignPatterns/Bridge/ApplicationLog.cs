using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public class ApplicationLog: Log 
    {
        public override void LogAppMessage()
        {
            _registerLog.LogReport(LogMessage, LogID);
        }
    }
}

