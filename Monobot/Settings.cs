using System;
using Newtonsoft.Json.Linq;

namespace Monobot
{
	public class Settings
	{

		public static JObject Global;
		public static JObject Sessions;

		public static void Load ()
		{
			Global = JObject.Parse (System.IO.File.ReadAllText ("configuration.json"));
				Sessions = (JObject)Global["sessions"];
		}
	}
}

