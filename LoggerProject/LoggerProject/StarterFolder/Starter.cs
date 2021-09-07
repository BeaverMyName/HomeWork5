using System;
using System.Reflection;
using LoggerProject.ActionsFolder;
using LoggerProject.ResultFolder;
using LoggerProject.LoggerFolder;

namespace LoggerProject.StarterFolder
{
    public class Starter
    {
        public void Run()
        {
            var methods = typeof(Actions).GetMethods(BindingFlags.Public | BindingFlags.Static | BindingFlags.InvokeMethod);

            Random rand = new Random();

            for (int i = 0; i < 100; i++)
            {
                if ((Result)methods[rand.Next(0, methods.Length - 1)].Invoke(null, null) is Result result && result.Status == false)
                {
                    var log = new Error(DateTime.Now, $"Action failed by a reason: {result.ErrorMessage}");
                    Logger.Instance.Logs.Add(log);
                    Logger.Instance.WriteOnConsole(log);

                    // Logger.Instance.WriteInFile(log);
                }
            }

            Logger.Instance.WriteInFile();
        }
    }
}
