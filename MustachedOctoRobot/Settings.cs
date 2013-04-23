using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using ServiceStack.Text;

namespace MustachedOctoRobot
{
	public class GlobalSettings {
		public Dictionary<string, SessionNode> sessions;
	}
	public class Settings
	{
		public static String ApplicationName = "Mustached Octo Robot";
		public static GlobalSettings Global;

		public static void Load ()
		{
			//var jSerializer = new JsonSerializer<GlobalSettings> ();
			var json = JsonObject.Parse(System.IO.File.ReadAllText ("configuration.json"));
			Console.WriteLine (json.Object("sessions").Dump());

		}
	}
}

