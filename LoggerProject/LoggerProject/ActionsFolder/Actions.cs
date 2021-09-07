using System;
using LoggerProject.ResultFolder;
using LoggerProject.LoggerFolder;

namespace LoggerProject.ActionsFolder
{
    public static class Actions
    {
        public static Result GetInfo()
        {
            var log = new Info(DateTime.Now, "Start method: GetInfo");
            Logger.Instance.Logs.Add(log);
            Logger.Instance.WriteOnConsole(log);

            // Logger.Instance.WriteInFile(log);
            return new Result() { Status = true };
        }

        public static Result GetWarning()
        {
            var log = new Warning(DateTime.Now, "Skipped logic in method: GetWarning");
            Logger.Instance.Logs.Add(log);
            Logger.Instance.WriteOnConsole(log);

            // Logger.Instance.WriteInFile(log);
            return new Result() { Status = true };
        }

        public static Result GetError()
        {
            return new Result() { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
