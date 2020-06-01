using System;
using Newtonsoft.Json;
using My_team.Support;

namespace My_team.Models.Base
{
    public class My_teamBase : BaseBindableObject
    {
         // Id Start
		string _id;
		[JsonProperty(PropertyName = "_id")]
		public string Id
		{
			get { return _id; }
			set { SetValue(ref _id, value); }
		}
		 // Id End 
        
        Object ojas;
        [JsonProperty(PropertyName = "Ojas")]
        public Object Ojas
        {
            get { return ojas; }
            set { SetValue(ref ojas, value); }
        }
        
    }
}