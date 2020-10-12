using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    public interface IRegisterLog
    {
        void LogReport(string LogMessage, int LogID);
    }
}
