using System;

namespace MustachedOctoRobot
{
	public class Templating{
		public static string[] css = new string[]{
			"css/bootstrap.min.css"
		};
		public static string[] js = new string[]{
			"js/bootstrap.min.js"
		};
		
		public static string BaseUri = "/";
		
		public static string GetBaseUri(string relative){
			return BaseUri + relative;
		}
	}

	public class T : Templating
	{
	}
}

