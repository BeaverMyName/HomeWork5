using System;

namespace LoggerProject.LoggerFolder
{
    public class Info : Log
    {
        public Info(DateTime time, string message)
            : base(time, message)
        {
        }
    }
}
