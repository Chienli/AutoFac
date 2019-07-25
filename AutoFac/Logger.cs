using System;

namespace AutoFac
{
    internal class Logger : ILogger
    {
        public void ConsoleLog(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}