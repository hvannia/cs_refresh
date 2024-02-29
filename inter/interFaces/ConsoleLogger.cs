using System;

namespace interFaces
{
	public class ConsoleLogger : ILogger
	{
		public ConsoleLogger()
		{
		}

        void ILogger.LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        void ILogger.LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }
}

