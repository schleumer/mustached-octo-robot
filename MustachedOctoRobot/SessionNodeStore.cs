using System;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace MustachedOctoRobot
{


	public class SessionColors
	{
		private List<String> _data = new List<String> (){
				
			};
		public string DefaultColor = "#000000";
			
		public String this [int index] {
			get {
				if (index < _data.Count) {
					return _data [index];
				} else {
					return this.DefaultColor;
				}
			}
			set {
					
			}
		}
	}

	public class SessionNode
	{
		private string _name;
			
		public string Name {
			get { 
				return _name;
			}
			set { 
				_name = value;
				this.OnPropertyChanged ("Name");
			}
		}
			
		private string _url;
			
		public string Url {
			get { 
				return _url;
			}
			set { 
				_url = value;
				this.OnPropertyChanged ("Url");
			}
		}
			
		private string _nickname;
			
		public string Nickname {
			get { 
				return _nickname;
			}
			set { 
				_nickname = value;
				this.OnPropertyChanged ("Nickname");
			}
		}
			
		private dynamic _color;
			
		public dynamic Color {
			get { 
				return _color;
			}
			set { 
				_color = value;
				this.OnPropertyChanged ("Color");
			}
		}
			
		private IService _service;
			
		public IService Service {
			get { 
				return _service;
			}
			set { 
				_service = value;
				this.OnPropertyChanged ("Service");
			}
		}
			
		private List<String> _messages;
			
		public List<String> Messages {
			get { 
				return _messages;
			}
			set { 
				_messages = value;
				this.OnPropertyChanged ("Messages");
			}
		}
			
		private List<String> _privateMessage;
			
		public List<String> PrivateMessages {
			get { 
				return _privateMessage;
			}
			set { 
				_privateMessage = value;
				this.OnPropertyChanged ("PrivateMessages");
			}
		}

		public string Status = "OFF";

		public void Shot(){
			
		}
			
		public event PropertyChangedEventHandler PropertyChanged;

		public void OnPropertyChanged (string propertyName)
		{
			var propertyChanged = PropertyChanged;
			if (propertyChanged != null) {
				propertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}
			
	}
		
	public class SessionNodeStore : List<SessionNode>
	{
		public SessionNodeStore ()
		{
//			foreach (var item in Settings.Sessions) {
//				var i = item.Value;
//				this.Add (item.Key ,new SessionNode (){
//						Name = (string)i["name"],
//						Url = (string)i["url"],
//						Nickname = (string)i["nickname"],
//						Color = new SessionColors()[System.Convert.ToInt32(i["cor"])]
//					});
//			}
		}
	}
}
