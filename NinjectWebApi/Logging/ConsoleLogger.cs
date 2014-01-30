using System;

namespace NinjectWebApi.Logging
{
	public class ConsoleLogger : Logger
	{
		public void Log(string message)
		{
			Console.Out.Write(message);
		}

		public string CurrentController { get; set; }
	}
}