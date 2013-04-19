using System;
using Newtonsoft.Json.Linq;

namespace MustachedOctoRobot
{
	public class Settings
	{
		public static String ApplicationName = "Mustached Octo Robot";
		public static JObject Global;
		public static JObject Sessions;

		public static void Load ()
		{
			Global = JObject.Parse (System.IO.File.ReadAllText ("configuration.json"));
				Sessions = (JObject)Global["sessions"];
		}
	}
}

