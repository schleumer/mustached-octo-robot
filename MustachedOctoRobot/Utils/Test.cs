using System;
using System.IO;
using System.Net;
using System.Text;
using System.Collections.Generic;

namespace MustachedOctoRobot.Utils
{
	public class Test
	{
		public Test ()
		{

		}

		public static void Request (string url, string method = "GET", Dictionary<string,dynamic>  data = null)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create (url);
			request.Method = method;
			request.ContentType = "application/x-www-form-urlencoded";
			request.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";

			//byte[] _byteVersion = Encoding.ASCII.GetBytes (string.Concat ("content=", ""));

			//request.ContentLength = _byteVersion.Length;

			//Stream stream = request.GetRequestStream ();
			//stream.Write (_byteVersion, 0, _byteVersion.Length);
			//stream.Close ();

			HttpWebResponse response = (HttpWebResponse)request.GetResponse ();

			using (StreamReader reader = new StreamReader(response.GetResponseStream())) {
				Console.WriteLine (reader.ReadToEnd ());
			}
		}
	}
}

