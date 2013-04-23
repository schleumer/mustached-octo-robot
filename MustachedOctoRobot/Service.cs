using System;
using System.Linq;
using ServiceStack.WebHost.Endpoints;
using ServiceStack.ServiceHost;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Funq;
using ServiceStack.ServiceInterface;
using System.Threading;
using ServiceStack.Razor;
using System.Net;
using ServiceStack.Logging;
using ServiceStack.Logging.Support.Logging;
using ServiceStack.WebHost.Endpoints.Support.Markdown;

namespace MustachedOctoRobot
{
	public class Hello {
		public string Name { get; set; }
	}
	
	public class HelloResponse {
		public HelloResponse(){
		}
		public string Result { get; set; }
	}
	
	public class HelloService : Service
	{
		public object Any(Hello request) 
		{
			return new HelloResponse();
		}
	}
	
	//Define the Web Services AppHost
	public class Service : AppHostHttpListenerBase {
		public Service() : base("StarterTemplate HttpListener", typeof(HelloService).Assembly) { }
		
		public override void Configure(Funq.Container container) {
			LogManager.LogFactory = new ConsoleLogFactory();
			Plugins.Add(new RazorFormat());
			Routes
				.Add<Hello>("/hello/{Name}");

			SetConfig(new EndpointHostConfig{
				DebugMode = true
			});
		}
	}
}

