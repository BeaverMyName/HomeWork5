using System;

namespace LoggerProject.LoggerFolder
{
    public class Error : Log
    {
        public Error(DateTime time, string message)
            : base(time, message)
        {
        }
    }
}
