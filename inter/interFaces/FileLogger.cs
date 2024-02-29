using System;
using System.IO;


namespace interFaces
{
	public class FileLogger:ILogger
	{

        private readonly string _path;

        private void Log(string messageType, string message)
        {
            // using 'using to automatically dispose of the stream writer 
            using (var StreamWriter = new StreamWriter(_path, true))
            {

                StreamWriter.WriteLine(DateTime.UtcNow + " "+  messageType + ":" + message);
            }

        }


        public FileLogger(string path)
		{
            _path = path;
		}

        void ILogger.LogError(string message)
        {
            Log("[E]", message);
        }

        void ILogger.LogInfo(string message)
        {

            Log("[I]", message);
        }
    }
}

