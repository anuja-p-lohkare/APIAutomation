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
    public class PostRequest
    {
        public (string, string) ExecuteCreateUserRequest(string url, object payload)
        {
            RestClientHelper rch = new RestClientHelper();
            string name = null;
            string role = null;                       
            var request = rch.GetRestRequest(url, null, Method.Post, payload, DataFormat.Json);
            var response = rch.SendRequest(request);            
            if (response.IsSuccessful)
            {
                var resDetails = JToken.Parse(response.Content);
                name = resDetails.SelectToken("name").Value<string>();
                role = resDetails.SelectToken("job").Value<string>();
            }
            return (name, role);
        }
    }
}
