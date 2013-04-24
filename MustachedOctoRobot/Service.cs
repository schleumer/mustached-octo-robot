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
	[Route("/AllSessions")]
	[DataContract]
	public class AllSessions : IReturn<SessionNodeStore>
	{
		public AllSessions()
		{

		}
	}
	
	public class RobotResponse {
    	public RobotResponse() {
    	}
    	public string Result { get; set; }
	}
	
	public class RobotService : Service
	{
		public object Any(AllSessions request) 
		{
			return Settings.Global.Sessions;
		}
	}
	
	//Define the Web Services AppHost
	public class HostService : AppHostHttpListenerBase {
		public HostService() : base("StarterTemplate HttpListener", typeof(HostService).Assembly) { }
		
		public override void Configure(Funq.Container container) {
			LogManager.LogFactory = new ConsoleLogFactory();
			Plugins.Add(new RazorFormat());
			

			SetConfig(new EndpointHostConfig{
				DebugMode = true
			});
		}
	}
}

