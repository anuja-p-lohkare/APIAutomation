using APIAutomationProject.Utilities;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace APIAutomationProject.APIRequests
{
    public class GetRequest
    {       
        public (string, string) ExexuteGetUserRequest(string url)
        {
            try
            {
                string fname = null;
                string lname = null;
                APIHelper apiHelper = new APIHelper();

                var response = apiHelper.ExecuteRestRequest(url, null, Method.Get, null);

                if (response.IsSuccessful)
                {
                    var resDetails = JToken.Parse(response.Content);

                    fname = resDetails.SelectToken("data.first_name").Value<string>();
                    lname = resDetails.SelectToken("data.last_name").Value<string>();
                }

                return (fname, lname);
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }        
    }
}
