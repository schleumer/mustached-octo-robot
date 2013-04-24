using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using ServiceStack.Text;

namespace MustachedOctoRobot
{
	public class GlobalSettings {
		public SessionNodeStore _sessions;
		public SessionNodeStore Sessions {
			get{
				return this._sessions;
			}
			set{
				this._sessions = value;
			}
		}
	}
	public class Settings
	{
		public static String ApplicationName = "Mustached Octo Robot";
		public static GlobalSettings Global;

		public static void Load ()
		{
			var jSerializer = new JsonSerializer<GlobalSettings> ();
			Global = jSerializer.DeserializeFromString(System.IO.File.ReadAllText ("configuration.json"));
			System.IO.File.WriteAllText("configuration.json",Global.SerializeToString());
		}
	}
}

