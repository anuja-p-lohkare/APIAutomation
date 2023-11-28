using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharpAutomation.HelperClass.Request;

namespace APIAutomationProject.APIRequests
{
    public class GetRequest
    {       
        public (string, string) ExexuteGetUserRequest(string url)
        {
            RestClientHelper rch = new RestClientHelper();
            string fname = null; 
            string lname = null;                        
            var request = rch.GetRestRequest(url, null, Method.Get, null, DataFormat.Json);
            var response = rch.SendRequest(request);
            if(response.IsSuccessful)
            {
                var resDetails = JToken.Parse(response.Content);
                fname = resDetails.SelectToken("data.first_name").Value <string>();
                lname = resDetails.SelectToken("data.last_name").Value<string>();                
            }
            return (fname, lname);
        }        
    }
}
