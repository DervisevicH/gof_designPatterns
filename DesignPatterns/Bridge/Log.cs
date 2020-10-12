using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public abstract class Log
    {
        public IRegisterLog _registerLog;
        public string LogMessage;
        public int LogID;
        public abstract void LogAppMessage();
    }
}
