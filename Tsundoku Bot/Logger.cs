using System;

namespace Tsundoku_Bot
{
    public class Logger : ILogger
    {
        public virtual void Log(string message)
        {
            //Default Logging, can be overriden
            Console.WriteLine(message);
        }
    }
}
