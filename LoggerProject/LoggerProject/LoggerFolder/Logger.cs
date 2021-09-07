using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace LoggerProject.LoggerFolder
{
    public sealed class Logger
    {
        // private TextWriter _writer = new StreamWriter("log.txt");
        private static readonly Logger _instance = new Logger();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public List<Log> Logs { get; set; } = new List<Log>();

        public void WriteOnConsole(Log log)
        {
            Console.WriteLine($"{DateTime.Now}: {log.GetType().Name}: {log.Message}");
        }

        /*
        public void WriteInFile(Log log)
        {
            _writer.WriteLine($"{DateTime.Now}: {log.GetType().Name}: {log.Message}");
        }
        */

        public void WriteInFile()
        {
            StringBuilder stringLog = new StringBuilder();
            foreach (Log log in Logs)
            {
                stringLog.Append($"{DateTime.Now}: {log.GetType().Name}: {log.Message}\n");
            }

            File.WriteAllText("log.txt", stringLog.ToString());
        }
    }
}
