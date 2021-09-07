using System;

namespace LoggerProject.LoggerFolder
{
    public abstract class Log
    {
        private DateTime _time;
        private string _message;

        public Log(DateTime time, string message)
        {
            _time = time;
            _message = message;
        }

        public DateTime Time
        {
            get
            {
                return _time;
            }
        }

        public string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
