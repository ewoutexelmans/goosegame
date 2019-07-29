using System;
using GreenbeltGame.Core.Interfaces;

namespace GreenbeltGame.Infrastructure.Loggers
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
