using System;
using ServiceStack.Logging;
using ServiceStack.Text;
using System.Threading;
using ServiceStack.Logging.Support.Logging;
using System.Collections.Generic;
using Mono.Unix;
using System.Diagnostics;

namespace MustachedOctoRobot
{
	public static class StringExtensions
	{
		public static String __(this String s)
		{
			return Catalog.GetString(s);
		}
	}


	public class MainClass
	{
		public static List<String> OpenedSessions = new List<String> ();

		public static void Main (string[] args)
		{
			Templating.BaseUri = "/app/";

			LogManager.LogFactory = new ConsoleLogFactory ();

			Settings.Load ();
			
			var appHost = new MustachedOctoRobot.Service ();
			string localBinding = "http://localhost:8080/";
			appHost.Init ();
				appHost.Start (localBinding);
			("\n\nListening on "+ localBinding + "..").Print ();

			Process process = new Process();
			process.StartInfo.FileName = "firefox";
			process.StartInfo.WorkingDirectory = System.IO.Directory.GetCurrentDirectory();
			process.StartInfo.Arguments = "\"" + localBinding + "app\"";
			//process.Start();

			Console.ReadKey();

			//process.Kill ();
		}
	}
}
