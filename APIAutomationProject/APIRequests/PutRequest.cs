using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharpAutomation.HelperClass.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIAutomationProject.APIRequests
{
    public class PutRequest
    {
        public string ExecuteUpdateUserRequest(string url, object payload)
        {
            RestClientHelper rch = new RestClientHelper();
            string name = null;            
            var request = rch.GetRestRequest(url, null, Method.Put, payload, DataFormat.Json);
            var response = rch.SendRequest(request);            
            if (response.IsSuccessful)
            {
                var resDetails = JToken.Parse(response.Content);
                name = resDetails.SelectToken("name").Value<string>();                
            }
            return name;
        }
    }
}
