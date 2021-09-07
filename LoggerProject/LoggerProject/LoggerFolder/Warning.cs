using System;

namespace LoggerProject.LoggerFolder
{
    public class Warning : Log
    {
        public Warning(DateTime time, string message)
            : base(time, message)
        {
        }
    }
}
