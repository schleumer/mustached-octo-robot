using System;
using ServiceStack.Logging;
using ServiceStack.Text;
using System.Threading;
using ServiceStack.Logging.Support.Logging;
using System.Collections.Generic;

namespace MustachedOctoRobot
{
	public class MainClass
	{
		public static List<String> OpenedSessions = new List<String> ();
		public static void Main (string[] args)
		{

			LogManager.LogFactory = new ConsoleLogFactory();
			
			var appHost = new MustachedOctoRobot.Service();
			appHost.Init();
			appHost.Start("http://*:8080/");
			
			"\n\nListening on http://*:8080/..".Print();
			"Type Ctrl+C to quit..".Print();
			Thread.Sleep(Timeout.Infinite);
		}
	}
}
